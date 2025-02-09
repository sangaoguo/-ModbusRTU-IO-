namespace 基于ModbusRTU通信协议实现IO采集卡通信
{
    partial class Frmcommnityset
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_PortName = new System.Windows.Forms.ComboBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.cbb_Parity = new System.Windows.Forms.ComboBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.cbb_StopBits = new System.Windows.Forms.ComboBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.cbb_BaudRate = new System.Windows.Forms.ComboBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.cbb_DataBits = new System.Windows.Forms.ComboBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(161)))), ((int)(((byte)(208)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 56);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("阿里巴巴普惠体 3.0 55 Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(423, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("阿里巴巴普惠体 3.0 55 Regular", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(31, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "通信设置";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("阿里巴巴普惠体 3.0 55 Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(55, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "端口号";
            // 
            // cbb_PortName
            // 
            this.cbb_PortName.FormattingEnabled = true;
            this.cbb_PortName.Location = new System.Drawing.Point(119, 86);
            this.cbb_PortName.Name = "cbb_PortName";
            this.cbb_PortName.Size = new System.Drawing.Size(87, 20);
            this.cbb_PortName.TabIndex = 4;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("阿里巴巴普惠体 3.0 55 Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl2.Location = new System.Drawing.Point(55, 141);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(58, 22);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "校验位";
            // 
            // cbb_Parity
            // 
            this.cbb_Parity.FormattingEnabled = true;
            this.cbb_Parity.Location = new System.Drawing.Point(119, 141);
            this.cbb_Parity.Name = "cbb_Parity";
            this.cbb_Parity.Size = new System.Drawing.Size(87, 20);
            this.cbb_Parity.TabIndex = 4;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("阿里巴巴普惠体 3.0 55 Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl4.Location = new System.Drawing.Point(55, 197);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(58, 22);
            this.lbl4.TabIndex = 3;
            this.lbl4.Text = "停止位";
            // 
            // cbb_StopBits
            // 
            this.cbb_StopBits.FormattingEnabled = true;
            this.cbb_StopBits.Location = new System.Drawing.Point(119, 199);
            this.cbb_StopBits.Name = "cbb_StopBits";
            this.cbb_StopBits.Size = new System.Drawing.Size(87, 20);
            this.cbb_StopBits.TabIndex = 4;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("阿里巴巴普惠体 3.0 55 Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl1.Location = new System.Drawing.Point(299, 86);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(58, 22);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "波特率";
            // 
            // cbb_BaudRate
            // 
            this.cbb_BaudRate.FormattingEnabled = true;
            this.cbb_BaudRate.Location = new System.Drawing.Point(363, 87);
            this.cbb_BaudRate.Name = "cbb_BaudRate";
            this.cbb_BaudRate.Size = new System.Drawing.Size(87, 20);
            this.cbb_BaudRate.TabIndex = 4;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("阿里巴巴普惠体 3.0 55 Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl3.Location = new System.Drawing.Point(299, 142);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(58, 22);
            this.lbl3.TabIndex = 3;
            this.lbl3.Text = "数据位";
            // 
            // cbb_DataBits
            // 
            this.cbb_DataBits.FormattingEnabled = true;
            this.cbb_DataBits.Location = new System.Drawing.Point(363, 142);
            this.cbb_DataBits.Name = "cbb_DataBits";
            this.cbb_DataBits.Size = new System.Drawing.Size(87, 20);
            this.cbb_DataBits.TabIndex = 4;
            // 
            // btn_ok
            // 
            this.btn_ok.AutoSize = true;
            this.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ok.Font = new System.Drawing.Font("阿里巴巴普惠体 3.0 55 Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ok.Location = new System.Drawing.Point(119, 251);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(86, 34);
            this.btn_ok.TabIndex = 5;
            this.btn_ok.Text = "确认设置";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_close
            // 
            this.btn_close.AutoSize = true;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("阿里巴巴普惠体 3.0 55 Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_close.Location = new System.Drawing.Point(271, 251);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(86, 34);
            this.btn_close.TabIndex = 5;
            this.btn_close.Text = "取消设置";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Frmcommnityset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 312);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.cbb_StopBits);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.cbb_DataBits);
            this.Controls.Add(this.cbb_Parity);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.cbb_BaudRate);
            this.Controls.Add(this.cbb_PortName);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frmcommnityset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "通信设置";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_PortName;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.ComboBox cbb_Parity;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.ComboBox cbb_StopBits;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.ComboBox cbb_BaudRate;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.ComboBox cbb_DataBits;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_close;
    }
}