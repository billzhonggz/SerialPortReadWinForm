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
using System.IO;

using MySql.Data.MySqlClient;

using System.Xml;
using System.Xml.XPath;


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

            // 设置默认配置文件地址
            ConfigFilePath.Text = Directory.GetCurrentDirectory() + "\\config.ini" ;
            // dataRTB.Text = ConfigFilePath.Text;

            // 尝试加载配置文件
            {
                if (File.Exists(ConfigFilePath.Text))
                {
                    // 读取ini 
                    Ini ini = new Ini(ConfigFilePath.Text);
                    portsListCB.Text = ini.ReadValue("serial", "port");
                    buadRateCB.Text = ini.ReadValue("serial", "buadrate");
                    checkbitsCB.Text = ini.ReadValue("serial", "checkbits");
                    databitsCB.Text = ini.ReadValue("serial", "databits");
                    stopbitsCB.Text = ini.ReadValue("serial", "stopbits");

                    dbServerAddressTB.Text = ini.ReadValue("database", "sever");
                    dbPortDB.Text = ini.ReadValue("database", "port");
                    dbUsrNameTB.Text = ini.ReadValue("database", "username");
                    dbPwdTB.Text = ini.ReadValue("database", "password");
                    dbNameTB.Text = ini.ReadValue("database", "databasename");

                }
            }


        }

        // 写入数据库信息
        public void writeDB(string v1, string v2, string v3)
        {
            // 数据库连接
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "server=" + dbServerAddressTB.Text + ";user=" + dbUsrNameTB.Text + ";database=" + dbNameTB.Text + ";port=" + dbPortDB.Text + ";password=" + dbPwdTB.Text + ";";
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                // Console.WriteLine("Connecting to MySQL...");
                label10.Text = "Uploading...";
                conn.Open();
                cmd.Connection = conn;

                string sql = "INSERT INTO `esdc`.`raw_data` (`d_id`, `a_id`, `date`, `time`, `latitude`, `longitude`, `pressure`, `heading`, `poll_1`, `poll_2`, `poll_3`, `poll_4`, `poll_5`, `photo_id`) VALUES (NULL, '1', curdate(), curtime(), NULL, NULL, NULL, NULL, '"+v1+"', '"+v2+"', '"+v3+"', '0', '0', NULL);";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                label10.Text = "Success!";
            }
            catch (MySqlException ex)
            {
                // Console.WriteLine("Error " + ex.Number + " has occurred: " + ex.Message);
                label10.Text = "Error!";
            }
            conn.Close();
        }

        public void writeXML(string v1, string v2, string v3)
        {
            // if the file exists, we'll add the data into the xml
            if (File.Exists(Directory.GetCurrentDirectory() + "\\data.xml"))
            {
                //MessageBox.Show("File exist ");
                //insert new student info
                XmlDocument doc = new XmlDocument();
                doc.Load(Directory.GetCurrentDirectory() + "\\data.xml");
                XmlNode node = doc.SelectSingleNode("//data");
                XmlNode studentNode = doc.CreateElement("data");
                studentNode.Attributes.Append(CreateAttribute(node, "TIME", DateTime.Now.ToString()));
                studentNode.Attributes.Append(CreateAttribute(node, "POLL1", v1));
                studentNode.Attributes.Append(CreateAttribute(node, "POLL2", v2));
                studentNode.Attributes.Append(CreateAttribute(node, "POLL3", v3));

                node.AppendChild(studentNode);
                doc.Save(Directory.GetCurrentDirectory() + "\\data.xml");  //Save the xml


            }
            else //The file does not exist, we'll create it
            {
                XmlDocument doc = new XmlDocument();
                XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
                doc.AppendChild(dec);
                //create the root element
                XmlElement root = doc.CreateElement("ESDC");
                doc.AppendChild(root);
                //create the "Students" element
                XmlElement element = doc.CreateElement("data");
                root.AppendChild(element);

                //create the "Student" element with attributes
                XmlNode node = doc.CreateElement("data");
                node.Attributes.Append(CreateAttribute(node, "TIME", DateTime.Now.ToString()));
                node.Attributes.Append(CreateAttribute(node, "POLL1", v1));
                node.Attributes.Append(CreateAttribute(node, "POLL2", v2));
                node.Attributes.Append(CreateAttribute(node, "POLL3", v3));
                root.ChildNodes[0].AppendChild(node);

                doc.Save(Directory.GetCurrentDirectory() + "\\data.xml");
            }

        }

        public XmlAttribute CreateAttribute(XmlNode node, string attributeName, string value)
        {
            try
            {
                XmlDocument doc = node.OwnerDocument;
                XmlAttribute attr = null;
                attr = doc.CreateAttribute(attributeName);
                attr.Value = value;
                node.Attributes.SetNamedItem(attr);
                return attr;
            }
            catch (Exception err)
            {
                string desc = err.Message;
                return null;
            }
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
            openConfigFileDialog.Filter = "*.ini  | *.*";
            openConfigFileDialog.FilterIndex = 1;
            openConfigFileDialog.RestoreDirectory = false;
            openConfigFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openConfigFileDialog.Multiselect = false;
            // 

            if (openConfigFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Go to XML handling part.

                // Test code here.
                // MessageBox.Show(openConfigFileDialog.FileName);
                ConfigFilePath.Text = openConfigFileDialog.FileName;
            }

            {
                if (File.Exists(ConfigFilePath.Text))
                {
                    // 读取ini 
                    Ini ini = new Ini(ConfigFilePath.Text);
                    portsListCB.Text = ini.ReadValue("serial", "port");
                    buadRateCB.Text = ini.ReadValue("serial", "buadrate");
                    checkbitsCB.Text = ini.ReadValue("serial", "checkbits");
                    databitsCB.Text = ini.ReadValue("serial", "databits");
                    stopbitsCB.Text = ini.ReadValue("serial", "stopbits");

                    dbServerAddressTB.Text = ini.ReadValue("database", "sever");
                    dbPortDB.Text = ini.ReadValue("database", "port");
                    dbUsrNameTB.Text = ini.ReadValue("database", "username");
                    dbPwdTB.Text = ini.ReadValue("database", "password");
                    dbNameTB.Text = ini.ReadValue("database", "databasename");

                }
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
            // 测试数据库连接
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "server="+dbServerAddressTB.Text+";user="+dbUsrNameTB.Text+";database="+dbNameTB.Text+";port="+dbPortDB.Text+";password="+dbPwdTB.Text+";";
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                // Console.WriteLine("Connecting to MySQL...");
                label10.Text = "Connecting...";
                conn.Open();
                cmd.Connection = conn;
                
                string sql = "INSERT INTO `esdc`.`raw_data` (`d_id`, `a_id`, `date`, `time`, `latitude`, `longitude`, `pressure`, `heading`, `poll_1`, `poll_2`, `poll_3`, `poll_4`, `poll_5`, `photo_id`) VALUES (NULL, '1', curdate(), curtime(), NULL, NULL, NULL, NULL, '0', '0', '0', '0', '0', NULL);";
                cmd.CommandText =sql;
                cmd.ExecuteNonQuery();
                label10.Text = "Success!";
            }
            catch (MySqlException ex)
            {
                // Console.WriteLine("Error " + ex.Number + " has occurred: " + ex.Message);
                label10.Text = "Error!";
            }
            conn.Close();

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
                                                       //!!!用于其他传感器时有必要更改64
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
                for (int i = 0; i < 64; i++) //窗体显示
                                             //!!!用于其他传感器时有必要更改64
                {
                    strRcv += receivedData[i].ToString("X2");  //16进制显示
                }
                //dataRTB.Text += strRcv + "\r\n";
                string pm1pm25pm10 = strRcv;
                string pm1 = pm1pm25pm10.Substring(16, 4);
                string pm25 = pm1pm25pm10.Substring(20, 4);
                string pm10 = pm1pm25pm10.Substring(24, 4);
                int pm1_dec = Convert.ToInt32(pm1, 16);
                int pm25_dec = Convert.ToInt32(pm25, 16);
                int pm10_dec = Convert.ToInt32(pm10, 16);
                string output = "PM1: " + pm1_dec.ToString() + "    PM2.5: " + pm25_dec.ToString() + "    PM10: " + pm10_dec.ToString();
                // 写XML

                if(saveToFileCheck.Checked == true)
                {
                    writeXML(pm1_dec.ToString(), pm25_dec.ToString(), pm10_dec.ToString());
                }
                // 写数据库

                if(checkBox1.Checked == true)
                {
                    writeDB(pm1_dec.ToString(), pm25_dec.ToString(), pm10_dec.ToString());
                }

                dataRTB.Text += output + "\r\n";
                dataRTB.Focus();
                dataRTB.Select(dataRTB.TextLength, 0);
                dataRTB.ScrollToCaret();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        private void dataRTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveConfigBtn_Click(object sender, EventArgs e)
        {
            // 保存配置信息

            {
                Ini ini = new Ini(ConfigFilePath.Text);
                // 写入ini  
                ini.Writue("serial", "port", portsListCB.Text);
                ini.Writue("serial", "buadrate", buadRateCB.Text);
                ini.Writue("serial", "checkbits", checkbitsCB.Text);
                ini.Writue("serial", "databits", databitsCB.Text);
                ini.Writue("serial", "stopbits", stopbitsCB.Text);

                ini.Writue("database", "sever", dbServerAddressTB.Text);
                ini.Writue("database", "port", dbPortDB.Text);
                ini.Writue("database", "username", dbUsrNameTB.Text);
                ini.Writue("database", "password", dbPwdTB.Text);
                ini.Writue("database", "databasename", dbNameTB.Text);

                // label1.Text = "new ini file created!";
                MessageBox.Show("Your config had saved!");


            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }


    public class Ini
    {
        // 声明INI文件的写操作函数 WritePrivateProfileString()  

        [System.Runtime.InteropServices.DllImport("kernel32")]

        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        // 声明INI文件的读操作函数 GetPrivateProfileString()  

        [System.Runtime.InteropServices.DllImport("kernel32")]

        private static extern int GetPrivateProfileString(string section, string key, string def, System.Text.StringBuilder retVal, int size, string filePath);


        private string sPath = null;
        public Ini(string path)
        {
            this.sPath = path;
        }

        public void Writue(string section, string key, string value)
        {

            // section=配置节，key=键名，value=键值，path=路径  

            WritePrivateProfileString(section, key, value, sPath);

        }
        public string ReadValue(string section, string key)
        {

            // 每次从ini中读取多少字节  

            System.Text.StringBuilder temp = new System.Text.StringBuilder(255);

            // section=配置节，key=键名，temp=上面，path=路径  

            GetPrivateProfileString(section, key, "", temp, 255, sPath);

            return temp.ToString();

        }



    }
}
