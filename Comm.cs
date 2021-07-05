using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialTransmission
{
    public partial class Comm : Form
    {

        public Comm()
        {
            InitializeComponent();
            ComHelper.Data += AddContent;
            ComHelper.ReceiveNum += AddNums;
            ComHelper.SendNum += AddNum;
        }

        //页面启动事件
        private void Comm_Load(object sender, EventArgs e)
        {
            //读取计算机所有串口
            string[] strCom = SerialPort.GetPortNames();
            if (strCom == null)
            {
                MessageBox.Show("本机没有串口！", "Error");
                return;
            }
            //GetPortNames()方法:获取当前计算机的串行端口名的数组
            foreach (string com in System.IO.Ports.SerialPort.GetPortNames())
            {
                com_port.Items.Add(com);

            }
            //默认选中第一个
            com_port.SelectedIndex = 0;
            com_jyw.SelectedIndex = 0;
            com_data.Text = "8";
            com_stop.SelectedIndex = 0;
            com_bps.Text = "4800";
            receive_ascii.Checked = true;
            send_ascii.Checked = true;
        }

        //选中保存目录
        private void receive_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;//该值确定是否可以选择多个文件
            dialog.Title = "请选择文件夹";
            dialog.Filter = "所有文件(*.*)|*.*";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                receive_FileSrc.Text = dialog.FileName;
            }
        }

        private void AddNum(object content)
        {
            int sendnum = int.Parse(content.ToString()); ;
            num1.Text = (int.Parse(num1.Text) + sendnum).ToString();
        }
        private void AddNums(object content)
        {
            int sendnum = int.Parse(content.ToString()); ;
            num2.Text = (int.Parse(num2.Text) + sendnum).ToString();
        }
        //将接受到的内容显示出来
        private void AddContent(object content)
        {
            this.BeginInvoke(new MethodInvoker(delegate
             {

                 string str = content as string;
                 if (IsTime.Checked == true)
                 {

                     string Title = DateTime.Now.ToString();
                     bt_ReceiveData.AppendText("[" + Title + "]# RECV " + (receive_ascii.Checked == true ? "ASCII" : "HEX") + "\r\n");
                 }
                 bt_ReceiveData.AppendText(str + " ");
                 if (IsLine.Checked == true)
                 {
                     bt_ReceiveData.AppendText("\r\n");
                 }
                 bt_ReceiveData.Focus();//先获取焦点
                 bt_ReceiveData.Select(bt_ReceiveData.TextLength, 0);//选中数据末尾0个字符
                 bt_ReceiveData.ScrollToCaret();//将滚动条移动到当前位置
                 //记录收到的字符个数
                 //toolStripStatusLabel1.Text += (int.Parse(toolStripStatusLabel1.Text) + content.Length).ToString();
             }));
        }

        //清空接收区
        private void receive_clean_Click(object sender, EventArgs e)
        {
            this.bt_ReceiveData.Text = "";
        }

        //清空发送区
        private void send_clean_Click(object sender, EventArgs e)
        {
            this.bt_SendData.Text = "";
        }

        /// 打开串口
        private void com_open_Click(object sender, EventArgs e)
        {
            //实例化串口配置
            ComClass com = new ComClass()
            {
                PortName = com_port.Text,
                BaudRate = int.Parse(this.com_bps.Text),
                Databit = int.Parse(com_data.Text),
                Stopbit = float.Parse(com_stop.Text),
                Paritybit = this.com_jyw.Text
            };
            //判断端口是否打开
            if (!ComHelper.port.IsOpen)
            {
                ComHelper.SerialClass(com);
                //判断是否已经打开串口控件禁用
                if (ComHelper.OpenPart())
                {
                    this.com_state.Checked = true;
                    this.com_port.Enabled = false;
                    this.com_bps.Enabled = false;
                    this.com_data.Enabled = false;
                    this.com_stop.Enabled = false;
                    this.com_jyw.Enabled = false;
                    this.com_open.Text = "关闭串口";
                }
            }
            else
            {
                ComHelper.closePort();
                this.com_state.Checked = true;
                this.com_port.Enabled = true;
                this.com_bps.Enabled = true;
                this.com_data.Enabled = true;
                this.com_stop.Enabled = true;
                this.com_jyw.Enabled = true;
                this.com_state.Checked = false;
                this.com_open.Text = "打开串口";
            }
        }

        //发送数据
        private void bt_send_Click(object sender, EventArgs e)
        {
            string SendData = this.bt_SendData.Text.Trim();
            //判断是否是HEX发送
            if (send_hex.Checked == true)
            {
                if (!ComHelper.IsHexadecimal(SendData)) { MessageBox.Show("输入非16进制数据"); }
                ComHelper.SendData(SendData, true);
            }
            else
            {
                ComHelper.SendData(SendData, false);
            }

        }

        //选中HEX时判断输入内容是否为HEX数据，如果不是将其转换成Hex
        private void send_hex_Click(object sender, EventArgs e)
        {
            if (send_hex.Checked == true && !ComHelper.IsHexadecimal(this.bt_SendData.Text))
            {
                this.bt_SendData.Text = ComHelper.GetHexFromChs(bt_SendData.Text);
            }
        }

        //接收是否为Hex格式
        private void receive_hex_CheckedChanged(object sender, EventArgs e)
        {
            if (receive_hex.Checked == true)
            {
                ComHelper.ReceiveIsHex = true;
            }
            else
            {
                ComHelper.ReceiveIsHex = false;
            }
        }

        private void send_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;//该值确定是否可以选择多个文件
            dialog.Title = "请选择文件夹";
            dialog.Filter = "所有文件(*.*)|*.*";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.bt_SendData.Text = ComHelper.fileToString(dialog.FileName);
            }
        }
    }
}
