using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Text.RegularExpressions;

namespace SerialPortReadWinForm
{
    public partial class MainWindo : Form
    {
        public MainWindo()
        {
            InitializeComponent();
            Form.CheckForIllegalCrossThreadCalls = false;
            this.Load += new System.EventHandler(this.MainWindo_Load);
        }

        SerialPort sp1 = null;

        private void MainWindo_Load(object sender, EventArgs e)
        {
            //实例化
            sp1 = new SerialPort();
            //这里需要添加引用Microsoft.VisualBasic的引用，提供操作计算机组件（如：音频，时钟，键盘文件系统等）的属性
            Microsoft.VisualBasic.Devices.Computer pc = new Microsoft.VisualBasic.Devices.Computer();
            //循环该计算机上所有串行端口的集合
            foreach (string s in pc.Ports.SerialPortNames)
            {
                //串口名称添加到cbxPortName下拉框上
                //一般计算机上是有COM1和COM2串口的，如果没有自己在cbxPortName下拉框里写COM1 和 COM2的字符串(如：this.cbxPortName.Items.Add("COM2"))
                this.portsListCB.Items.Add(s);
           }


            //防止报错，万一计算机上没有串口，就不走这一步
            if (pc.Ports.SerialPortNames.Count > 0)
            {
                portsListCB.SelectedIndex = 0;
            }
            buadRateCB.SelectedIndex = 6;
            databitsCB.SelectedIndex = 0;
            checkbitsCB.SelectedIndex = 0;          
            stopbitsCB.SelectedIndex = 0;
        }

        private void MainTitle_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void OpenConfigFileBtn_Click(object sender, EventArgs e)
        {
            openConfigFileDialog.Title = "Open a config file.";
            openConfigFileDialog.Filter = "*.xml  | *.*";
            openConfigFileDialog.FilterIndex = 1;
            openConfigFileDialog.RestoreDirectory = false;
            openConfigFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openConfigFileDialog.Multiselect = false;
            // 

            if (openConfigFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Go to XML handling part.

                // Test code here.
                MessageBox.Show(openConfigFileDialog.FileName);
                ConfigFilePath.Text = openConfigFileDialog.FileName;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buadRateCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void saveDataToFile_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void TestConnBtn_Click(object sender, EventArgs e)
        {

        }

        private void portsListCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            //设置串口端口
            sp1.PortName = portsListCB.Text;
            //设置比特率
            sp1.BaudRate = Convert.ToInt32(buadRateCB.Text);
            //设置数据位
            sp1.DataBits = Convert.ToInt32(databitsCB.Text);
            //根据选择的数据，设置停止位
            switch (stopbitsCB.Text)            //停止位
            {
                case "1":
                    sp1.StopBits = StopBits.One;
                    break;
                case "1.5":
                    sp1.StopBits = StopBits.OnePointFive;
                    break;
                case "2":
                    sp1.StopBits = StopBits.Two;
                    break;
                default:
                    MessageBox.Show("Error：参数不正确!", "Error");
                    break;
            }

            //根据选择的数据，设置奇偶校验位
            switch (checkbitsCB.Text)             //校验位
            {
                case "None":
                    sp1.Parity = Parity.None;
                    break;
                case "Odd":
                    sp1.Parity = Parity.Odd;
                    break;
                case "Even":
                    sp1.Parity = Parity.Even;
                    break;
                default:
                    MessageBox.Show("Error：参数不正确!", "Error");
                    break;
            }

            //此委托应该是异步获取数据的触发事件，即是：当有串口有数据传过来时触发
            sp1.DataReceived += new SerialDataReceivedEventHandler(port1_DataReceived);//DataReceived事件委托
            //打开串口的方法
            try
            {
                sp1.Open();
                if (sp1.IsOpen)
                {
                    MessageBox.Show("the port is opened!");
                }
                else
                {
                    MessageBox.Show("failure to open the port!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("failure to open the port!" + ex.ToString());
            }
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            sp1.Close();
            if (!sp1.IsOpen)
            {
                Console.WriteLine("the port is already closed!");
            }
        }

        private void port1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                Byte[] receivedData = new Byte[sp1.BytesToRead];        //创建接收字节数组
                sp1.Read(receivedData, 0, 64);         //读取数据
                                                       //用于其他传感器时有必要更改64
                                                                        //string text = sp1.Read();   //Encoding.ASCII.GetString(receivedData);
                sp1.DiscardInBuffer();                                  //清空SerialPort控件的Buffer
                                                                        //这是用以显示字符串
                                                                        //    string strRcv = null;
                                                                        //    for (int i = 0; i < receivedData.Length; i++ )
                                                                        //    {
                                                                        //        strRcv += ((char)Convert.ToInt32(receivedData[i])) ;
                                                                        //    }
                                                                        //    txtReceive.Text += strRcv + "\r\n";             //显示信息
                                                                        //}
                string strRcv = null;
                //int decNum = 0;//存储十进制
                for (int i = 0; i < receivedData.Length; i++) //窗体显示
                {
                    strRcv += receivedData[i].ToString("X2");  //16进制显示
                }
                dataRTB.Text += strRcv + "\r\n";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

    }
}
