using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 基于ModbusRTU通信协议实现IO采集卡通信
{
    public partial class Frmcommnityset : Form
    {
        private string path = string.Empty;
        private SerialParam serialParam = null;
        public Frmcommnityset(SerialParam serialParam,string path)
        {
            InitializeComponent();
            this.path = path;
            this.serialParam = serialParam;


            this.cbb_PortName.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            this.cbb_BaudRate.Items.AddRange(new string[] { "9600", "19200", "38400"});
            this.cbb_DataBits.Items.AddRange(new string[] {  "7", "8" });
            this.cbb_Parity.DataSource = Enum.GetNames(typeof(Parity));
            this.cbb_StopBits.DataSource = Enum.GetNames(typeof(StopBits));//添加可选项
           
            this.cbb_PortName.Text = serialParam.PortName;
            this.cbb_BaudRate.Text = serialParam.BaudRate.ToString();
            this.cbb_DataBits.Text = serialParam.DataBits.ToString();
            this.cbb_Parity.Text = serialParam.Parity.ToString();
            this.cbb_StopBits.Text = serialParam.StopBits.ToString();

        } 
        #region 无边框拖动 

        private Point mPoint;
        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);
        }

        #endregion

        private void btn_ok_Click(object sender, EventArgs e)
        {
            //重新赋值，因为下拉框可能修改了
            serialParam.PortName = this.cbb_PortName.Text.Trim();
            serialParam.BaudRate = Convert.ToInt32(this.cbb_BaudRate.Text.Trim());
            serialParam.DataBits = Convert.ToInt32(this.cbb_DataBits.Text.Trim());
            serialParam.Parity = (Parity)Enum.Parse(typeof(Parity), this.cbb_Parity.Text.Trim());//先将字符串转换为object类型，再转换为Parity类型
            serialParam.StopBits = (StopBits)Enum.Parse(typeof(StopBits), this.cbb_StopBits.Text.Trim());

            BinaryHleper.Serializeobject(this.path, this.serialParam);
            this.DialogResult = DialogResult.OK;//关闭窗体，前面用了showdialog，所以这里用ok


        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;//关闭窗体，前面用了showdialog，所以这里用cancel 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
