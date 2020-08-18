using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cekNetworkID
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ip = ipTextBox.Text;

            byte[] ip_split = new byte[4];
            int cidr = new int();
            StringBuilder temp = new StringBuilder();

            {
                int j = 0;

                for (int i = 0; i < ip.Length; i++)
                {
                    if (ip[i] == '.')
                    {
                        Console.WriteLine(temp.ToString());
                        ip_split[j] = Byte.Parse(temp.ToString());
                        j++;
                        temp.Clear();
                    }
                    else if (ip[i] == '/')
                    {
                        Console.WriteLine(temp.ToString());
                        ip_split[j] = Byte.Parse(temp.ToString());
                        j++;
                        temp.Clear();
                    }
                    else
                    {
                        temp.Append(ip[i]);
                    }
                }

                cidr = Byte.Parse(temp.ToString());
            }

            byte[] cidr_split = new byte[4];
            {
                int j = 0;
                int blok = 0;
                byte b = 0;

                while (cidr > 0)
                {
                    if(j == 8)
                    {
                        cidr_split[blok] = b;
                        blok++;
                        j = 0;
                        b = 0;
                    }
                    else
                    {
                        b = (byte)(b >> 1);
                        b = (byte)(b ^ 0b_1000_0000);
                        j++;
                        cidr--;
                    }
                }

                if(b != 0)
                {
                    cidr_split[blok] = b;
                    blok++;
                    b = 0;
                }

                while(blok < 4)
                {
                    b = 0;
                    cidr_split[blok] = b;
                    blok++;
                }
            }

            for(int i=0; i<ip_split.Length; i++)
            {
                ip_split[i] &= cidr_split[i];
            }

            temp.Clear();
            for(int i=0; i<ip_split.Length; i++)
            {
                if(i == ip_split.Length-1)
                {
                    temp.Append(ip_split[i]);
                }
                else
                {
                    temp.Append(ip_split[i]);
                    temp.Append('.');
                }
            }

            NetIDResult.Text = temp.ToString();
        }
    }
}
