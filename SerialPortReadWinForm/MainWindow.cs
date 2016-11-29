using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialPortReadWinForm
{
    public partial class MainWindo : Form
    {
        public MainWindo()
        {
            InitializeComponent();
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
    }
}
