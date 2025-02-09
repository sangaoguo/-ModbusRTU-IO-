namespace 基于ModbusRTU通信协议实现IO采集卡通信
{
    partial class FrmIocard
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_output = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel_input = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_disconnnet = new System.Windows.Forms.Button();
            this.btn_connnet = new System.Windows.Forms.Button();
            this.btn_commnityset = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_output.SuspendLayout();
            this.panel_input.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(161)))), ((int)(((byte)(208)))));
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 72);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            // 
            // btn_exit
            // 
            this.btn_exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("阿里巴巴普惠体 3.0 55 Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_exit.Location = new System.Drawing.Point(667, 16);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 45);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            this.btn_exit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.btn_exit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("阿里巴巴普惠体 3.0 55 Regular", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(160, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "基于ModBusRTU通信协议实现IO采集卡通信";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.panel_output);
            this.panel2.Controls.Add(this.panel_input);
            this.panel2.Controls.Add(this.btn_disconnnet);
            this.panel2.Controls.Add(this.btn_connnet);
            this.panel2.Controls.Add(this.btn_commnityset);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(754, 380);
            this.panel2.TabIndex = 2;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            // 
            // panel_output
            // 
            this.panel_output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_output.Controls.Add(this.label11);
            this.panel_output.Controls.Add(this.label12);
            this.panel_output.Controls.Add(this.label13);
            this.panel_output.Controls.Add(this.label14);
            this.panel_output.Controls.Add(this.label15);
            this.panel_output.Controls.Add(this.label16);
            this.panel_output.Controls.Add(this.label17);
            this.panel_output.Controls.Add(this.label18);
            this.panel_output.Controls.Add(this.label19);
            this.panel_output.Location = new System.Drawing.Point(225, 192);
            this.panel_output.Name = "panel_output";
            this.panel_output.Size = new System.Drawing.Size(442, 136);
            this.panel_output.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(365, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 27);
            this.label11.TabIndex = 1;
            this.label11.Tag = "7";
            this.label11.Click += new System.EventHandler(this.Comment_Click);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(254, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 27);
            this.label12.TabIndex = 1;
            this.label12.Tag = "6";
            this.label12.Click += new System.EventHandler(this.Comment_Click);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(365, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 27);
            this.label13.TabIndex = 1;
            this.label13.Tag = "3";
            this.label13.Click += new System.EventHandler(this.Comment_Click);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(143, 89);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 27);
            this.label14.TabIndex = 1;
            this.label14.Tag = "5";
            this.label14.Click += new System.EventHandler(this.Comment_Click);
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(254, 39);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 27);
            this.label15.TabIndex = 1;
            this.label15.Tag = "2";
            this.label15.Click += new System.EventHandler(this.Comment_Click);
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(32, 89);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 27);
            this.label16.TabIndex = 1;
            this.label16.Tag = "4";
            this.label16.Click += new System.EventHandler(this.Comment_Click);
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(143, 39);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 27);
            this.label17.TabIndex = 1;
            this.label17.Tag = "1";
            this.label17.Click += new System.EventHandler(this.Comment_Click);
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(32, 39);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 27);
            this.label18.TabIndex = 1;
            this.label18.Tag = "0";
            this.label18.Click += new System.EventHandler(this.Comment_Click);
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Lime;
            this.label19.Dock = System.Windows.Forms.DockStyle.Top;
            this.label19.Font = new System.Drawing.Font("阿里巴巴普惠体 3.0 55 Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.Location = new System.Drawing.Point(0, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(440, 27);
            this.label19.TabIndex = 0;
            this.label19.Text = "数字量输出";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_input
            // 
            this.panel_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_input.Controls.Add(this.label10);
            this.panel_input.Controls.Add(this.label9);
            this.panel_input.Controls.Add(this.label6);
            this.panel_input.Controls.Add(this.label8);
            this.panel_input.Controls.Add(this.label5);
            this.panel_input.Controls.Add(this.label7);
            this.panel_input.Controls.Add(this.label4);
            this.panel_input.Controls.Add(this.label3);
            this.panel_input.Controls.Add(this.label2);
            this.panel_input.Location = new System.Drawing.Point(225, 24);
            this.panel_input.Name = "panel_input";
            this.panel_input.Size = new System.Drawing.Size(442, 136);
            this.panel_input.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(365, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 27);
            this.label10.TabIndex = 1;
            this.label10.Tag = "7";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(254, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 27);
            this.label9.TabIndex = 1;
            this.label9.Tag = "6";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(365, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 27);
            this.label6.TabIndex = 1;
            this.label6.Tag = "3";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(143, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 27);
            this.label8.TabIndex = 1;
            this.label8.Tag = "5";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(254, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 27);
            this.label5.TabIndex = 1;
            this.label5.Tag = "2";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(32, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 27);
            this.label7.TabIndex = 1;
            this.label7.Tag = "4";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(143, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 27);
            this.label4.TabIndex = 1;
            this.label4.Tag = "1";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(32, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 27);
            this.label3.TabIndex = 1;
            this.label3.Tag = "0";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Lime;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("阿里巴巴普惠体 3.0 55 Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(440, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "数字量输入";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_disconnnet
            // 
            this.btn_disconnnet.AutoSize = true;
            this.btn_disconnnet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_disconnnet.Font = new System.Drawing.Font("阿里巴巴普惠体 3.0 55 Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_disconnnet.Location = new System.Drawing.Point(62, 294);
            this.btn_disconnnet.Name = "btn_disconnnet";
            this.btn_disconnnet.Size = new System.Drawing.Size(86, 34);
            this.btn_disconnnet.TabIndex = 0;
            this.btn_disconnnet.Text = "断开连接";
            this.btn_disconnnet.UseVisualStyleBackColor = true;
            this.btn_disconnnet.Click += new System.EventHandler(this.btn_disconnnet_Click);
            // 
            // btn_connnet
            // 
            this.btn_connnet.AutoSize = true;
            this.btn_connnet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_connnet.Font = new System.Drawing.Font("阿里巴巴普惠体 3.0 55 Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_connnet.Location = new System.Drawing.Point(62, 159);
            this.btn_connnet.Name = "btn_connnet";
            this.btn_connnet.Size = new System.Drawing.Size(86, 34);
            this.btn_connnet.TabIndex = 0;
            this.btn_connnet.Text = "建立连接";
            this.btn_connnet.UseVisualStyleBackColor = true;
            this.btn_connnet.Click += new System.EventHandler(this.btn_connnet_Click);
            // 
            // btn_commnityset
            // 
            this.btn_commnityset.AutoSize = true;
            this.btn_commnityset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_commnityset.Font = new System.Drawing.Font("阿里巴巴普惠体 3.0 55 Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_commnityset.Location = new System.Drawing.Point(62, 24);
            this.btn_commnityset.Name = "btn_commnityset";
            this.btn_commnityset.Size = new System.Drawing.Size(86, 34);
            this.btn_commnityset.TabIndex = 0;
            this.btn_commnityset.Text = "通信设置";
            this.btn_commnityset.UseVisualStyleBackColor = true;
            this.btn_commnityset.Click += new System.EventHandler(this.btn_commnityset_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmIocard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 452);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmIocard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "基于ModbusRTU协议实现IO采集卡通信";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_output.ResumeLayout(false);
            this.panel_input.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_commnityset;
        private System.Windows.Forms.Button btn_disconnnet;
        private System.Windows.Forms.Button btn_connnet;
        private System.Windows.Forms.Panel panel_input;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_output;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
    }
}

