namespace cekNetworkID
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.GetNetIDButton = new System.Windows.Forms.Button();
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.NetIDResult = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.05419F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.94581F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel1.Controls.Add(this.GetNetIDButton, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.ipTextBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.NetIDResult, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.57066F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.42934F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(482, 200);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // GetNetIDButton
            // 
            this.GetNetIDButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GetNetIDButton.Location = new System.Drawing.Point(385, 176);
            this.GetNetIDButton.Name = "GetNetIDButton";
            this.GetNetIDButton.Size = new System.Drawing.Size(94, 21);
            this.GetNetIDButton.TabIndex = 0;
            this.GetNetIDButton.Text = "Get Network ID";
            this.GetNetIDButton.UseVisualStyleBackColor = true;
            this.GetNetIDButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ipTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.ipTextBox, 2);
            this.ipTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ipTextBox.Location = new System.Drawing.Point(3, 176);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(376, 20);
            this.ipTextBox.TabIndex = 1;
            // 
            // NetIDResult
            // 
            this.NetIDResult.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.NetIDResult, 3);
            this.NetIDResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NetIDResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetIDResult.Location = new System.Drawing.Point(3, 53);
            this.NetIDResult.Name = "NetIDResult";
            this.NetIDResult.Size = new System.Drawing.Size(476, 120);
            this.NetIDResult.TabIndex = 2;
            this.NetIDResult.Text = "Network ID";
            this.NetIDResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 3);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(476, 53);
            this.label2.TabIndex = 3;
            this.label2.Text = "By Timothy Merfry Tiwow";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 200);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button GetNetIDButton;
        private System.Windows.Forms.TextBox ipTextBox;
        private System.Windows.Forms.Label NetIDResult;
        private System.Windows.Forms.Label label2;
    }
}

