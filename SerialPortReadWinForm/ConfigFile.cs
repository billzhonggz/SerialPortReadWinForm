using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace SerialPortReadWinForm
{
    class ConfigFile
    {
        public void CreateConfigFile(string port, string buadRate, string checkbits, string databits, string stopbits,
            string filePath, string dbAddr, string dbPort, string dbUsrName, string dbPwd, string dbName)
        {
            // Define path.
            string path = "D:\\config.xml";
            // Creating XML file.

        }
    }
}
