using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modbus.Device;


namespace 基于ModbusRTU通信协议实现IO采集卡通信
{
    public partial class FrmIocard : Form
    {
        ModbusSerialMaster  master=null;//创建一个modbus通信对象
        SerialPort SerialPort = null;//成员变量。
        SerialParam serialParam =null;
        private string path = Application.StartupPath + "\\SerialParam.txt";
        //"C:\\Users\\Administrator\\source\\repos\\swjshizhan\\基于ModbusRTU通信协议实现IO采集卡通信\\bin\\Debug\\SerialParam.txt"
        //原理就是Application.StartupPath可以获得地址，然后后面+//+文件名就可以好获得即将要写入的。


        public FrmIocard()
        {
            InitializeComponent();
            this.serialParam=BinaryHleper.Deseralizeobject<SerialParam>(path);
            //this.FormClosing += FrmIocard_FormClosing;
        }

        //private void FrmIocard_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    DialogResult result = MessageBox.Show("是否确认退出系统", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //    if (result==DialogResult.Yes)
        //    {
        //        this.timer1.Enabled = false;
        //        this.SerialPort.Close();
        //        this.master= null;
        //    }
        //}
        #region 无边框拖动 

        private Point mPoint;
        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);
        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
            }
        }
        #endregion

        private void btn_connnet_Click(object sender, EventArgs e)
        {
            SerialPort = new SerialPort()
            {
                PortName = this.serialParam.PortName,
                BaudRate = this.serialParam.BaudRate,
                Parity = this.serialParam.Parity,
                DataBits = this.serialParam.DataBits,
            };//实例化一个串口对象，并初始化。

            try
            {
                SerialPort.Open();
                master = ModbusSerialMaster.CreateRtu(SerialPort);//除了可以new一个对象，还可以使用工厂方法创建一个对象。要不自己做，要不别人给
                timer1.Enabled = true;

            }
            catch (Exception ex)
            {
               MessageBox.Show("串口打开失败"+ex.Message);
            }      
        }

        private void btn_disconnnet_Click(object sender, EventArgs e)
        {
            if (SerialPort != null)
            {
                this.timer1.Enabled = false;
            SerialPort.Close();
                foreach (Label item in panel_input.Controls.OfType<Label>())
                {if (item.Tag != null&&item.Tag.ToString().Length>0)
                    item.BackColor = Color.Red;
                }
                foreach (Label item in panel_output.Controls.OfType<Label>())
                {
                    if (item.Tag != null && item.Tag.ToString().Length > 0)
                        item.BackColor = Color.Red;
                }



                }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            bool[] input=this.master.ReadInputs(1, 0, 8);//表示站地址，起始地址，读取的个数
            if (input.Length == 8)
            {
                foreach (Label item in panel_input.Controls.OfType<Label>())
                {
                    if (item.Tag != null && item.Tag.ToString().Length > 0)//为了防止tag为空，所以加了一个判断,tag写入后删除也是空字符串，所以要判断长度。
                    {
                        int index = Convert.ToInt16(item.Tag.ToString());
                        item.BackColor = input[index] ? Color.Green : Color.Red;//如果为true就是绿色，否则就是红色。
                    }
                }
            }

            bool[] output = this.master.ReadCoils(1, 0, 8);//表示站地址，起始地址，读取的个数
            if (output.Length == 8)
            {
                foreach (Label item in panel_output.Controls.OfType<Label>())
                {
                    if (item.Tag != null && item.Tag.ToString().Length > 0)//为了防止tag为空，所以加了一个判断,tag写入后删除也是空字符串，所以要判断长度。
                    {
                        int index = Convert.ToInt16(item.Tag.ToString());
                        item.BackColor = output[index] ? Color.Green : Color.Red;
                    }
                }
            }

        }

        private void Comment_Click(object sender, EventArgs e)
        {
            if (sender is Label label)
            {
                if (label.Tag != null && label.Tag.ToString().Length > 0)
                { 
                int index = Convert.ToInt16(label.Tag.ToString());

                    bool writeValue = label.BackColor ==Color.Red? true : false;
                    this.master.WriteSingleCoil(1, (ushort)index, writeValue);
                }
            
            }
        }

        private void btn_commnityset_Click(object sender, EventArgs e)
        {
            Frmcommnityset frmcommnityset = new Frmcommnityset(serialParam,path);
            frmcommnityset.ShowDialog();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
       
      

    }
}
