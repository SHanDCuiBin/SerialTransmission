using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerialTransmission
{
    public class ComHelper
    {
        public delegate void ReceiveData(object str);

        public static event ReceiveData Data;
        public static event ReceiveData ReceiveNum;
        public static event ReceiveData SendNum;

        //是否Hex接收
        public static bool ReceiveIsHex = false;
        //实例化串口
        public static SerialPort port = new SerialPort();
        //读取缓存区数据
        static   StringBuilder Datas = new StringBuilder("");
        static bool rest = true;
        //打开串口配置串口
        public static void SerialClass(ComClass p)
        {
            port.PortName = p.PortName;
            port.BaudRate = p.BaudRate;
            port.DataBits = p.Databit;
            switch (p.Stopbit)
            {
                case 1:
                    port.StopBits = StopBits.One; //使用一个停止位
                    break;
                case 1.5f:
                    port.StopBits = StopBits.OnePointFive; //使用一个停止位
                    break;
                case 2:
                    port.StopBits = StopBits.Two; //使用一个停止位
                    break;
                default:

                    break;
            }
            switch (p.Paritybit)
            {
                case "NONE":
                    port.Parity = Parity.None;
                    break;
                case "ODD":
                    port.Parity = Parity.Odd;
                    break;
                case "EVEN":
                    port.Parity = Parity.Even;
                    break;
                case "MARK":
                    port.Parity = Parity.Mark;
                    break;
                case "SPACE":
                    port.Parity = Parity.Space;
                    break;
                default:

                    break;
            }
            //port.Handshake = Handshake.None;
            port.RtsEnable = true;
            port.DtrEnable = true;//获取或设置一个值，改值在串行通讯过程中启用数据终端就绪（DTR）信号。
            port.ReadTimeout = 2000;
            port.DataReceived += Sp1_DataReceived;
        }

        /// <summary>
        /// 打开串口
        /// </summary>
        /// <returns></returns>
        public static bool OpenPart()
        {
            bool ok = false;
            //如果串口是打开的，先关闭
            if (port.IsOpen) port.Close();
            try
            {
                //打开串口
                port.Open();
                ok = true;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            return ok;
        }

        /// <summary>
        /// 关闭串口
        /// </summary>
        public static void closePort()
        {
            if (port.IsOpen)
            {
                port.Close();
            }
        }

        /// <summary>
        /// 数据发送
        /// </summary>
        /// <param name="Data">数据</param>
        /// <param name="IsHEX">是否Hex发送</param>
        public static void SendData(string Data, bool IsHEX)
        {
            byte[] sendData = null;
            if (!port.IsOpen) //如果没打开
            {
                return;
            }
            String strSend = Data;
            try
            {
                if (IsHEX)
                {
                    sendData = ConvertHexStringToBytes(strSend.Trim());
                }
                else
                {
                    sendData = Encoding.Default.GetBytes(strSend.Trim());
                }
                //sp1.WriteLine(txtSendStr.Text);    //写入数据
                SendNum(sendData.Length);
                port.Write(sendData, 0, sendData.Length);
            }
            catch (Exception ex)
            {
            }

        }

      
        /// <summary>
        /// 监听返回值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void Sp1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (ComHelper.port.IsOpen)     //判断是否打开串口
            {
                string content = "";
                int Lengths = port.BaudRate/10;
                //输出当前时间
                DateTime dt = DateTime.Now;
                try
                {
                    Byte[] receivedData = new Byte[port.BytesToRead];        //创建接收字节数组
                    port.Read(receivedData, 0, receivedData.Length);         //读取数据
                    ReceiveNum(receivedData.Length);
                    //foreach (byte item in receivedData)
                    //{
                    //    Datas.Append(Convert.ToChar(item));
                    //}
                    //是否解析成16进制
                    if (ReceiveIsHex)
                    {
                        content = bytetohex(receivedData, receivedData.Length).Trim();
                    }
                    else
                    {
                        content = Encoding.Default.GetString(receivedData);
                    }
                    //委托传值
                    Data(content);
                }
                catch (Exception ex)
                {

                }
            }
        }

        /// <summary>
        /// 从汉字转换到16进制
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string GetHexFromChs(string s)
        {
            if ((s.Length % 2) != 0)
            {
                s += " ";//空格
                         //throw new ArgumentException("s is not valid chinese string!");
            }

            System.Text.Encoding chs = System.Text.Encoding.GetEncoding("gb2312");

            byte[] bytes = chs.GetBytes(s);

            string str = "";

            for (int i = 0; i < bytes.Length; i++)
            {
                str += string.Format("{0:X}", bytes[i]) + " ";
            }
            return str;
        }

        /// <summary>
        /// byte[]转HEXString
        /// </summary>
        /// <param name="byteArray">byte数组</param>
        /// <param name="lenght">长度</param>
        /// <returns></returns>
        public static string bytetohex(byte[] byteArray, int lenght)
        {
            // string str = "";
            var str = new System.Text.StringBuilder();
            int start = Environment.TickCount;//计时器
            Console.WriteLine("wait...");
            for (int i = 0; i < lenght; i++)
            {
                str.Append(String.Format("{0:X2} ", byteArray[i]));//var拼接
            }
            string s = str.ToString();
            Console.WriteLine(Math.Abs(Environment.TickCount - start));//在调试窗口可查用时
            return s;
        }

        /// 判断是否十六进制格式字符串
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsHexadecimal(string str)
        {
            str = str.Replace(" ", "");
            bool IsHex = System.Text.RegularExpressions.Regex.IsMatch(str, "^[0-9A-Fa-f]+$");
            return IsHex;
        }

        /// <summary>
        /// 16进制原码字符串转字节数组
        /// </summary>
        /// <param name="hexString">"AABBCC"或"AA BB CC"格式的字符串</param>
        /// <returns></returns>
        public static byte[] ConvertHexStringToBytes(string hexString)
        {
            hexString = hexString.Replace(" ", "");
            if (hexString.Length % 2 != 0)
            {
                throw new ArgumentException("参数长度不正确");
            }

            byte[] returnBytes = new byte[hexString.Length / 2];
            for (int i = 0; i < returnBytes.Length; i++)
            {
                returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
            }

            return returnBytes;
        }


        /// <summary>
        /// 获取文件中的数据
        /// </summary>
        /// <param name="args"></param>
        public static string fileToString(String filePath)
        {
            StringBuilder strData = new StringBuilder("");
            try
            {
                string line;
                // 创建一个 StreamReader 的实例来读取文件 ,using 语句也能关闭 StreamReader
                using (System.IO.StreamReader sr = new System.IO.StreamReader(filePath, System.Text.Encoding.GetEncoding("gb2312")))
                {
                    // 从文件读取并显示行，直到文件的末尾 
                    while ((line = sr.ReadLine()) != null)
                    {
                        //Console.WriteLine(line);
                        strData.Append( line);
                    }
                }
            }
            catch (Exception e)
            {
                // 向用户显示出错消息
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            return strData.ToString();
        }

        public static void WriteLog(string FileName)
        {

        }
    }
}
