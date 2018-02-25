using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Byter
{
    public partial class Form1 : Form
    {
        List<string> filesList;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pathTextBox1_DoubleClick(object sender, EventArgs e)
        {
            FolderBrowserDialog mFolderBrowserDialog = new FolderBrowserDialog();
            if(mFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                pathTextBox1.Text = mFolderBrowserDialog.SelectedPath;
            }


        }

        private void startButton1_Click(object sender, EventArgs e)
        {
            filesList = operations.Getfiles(pathTextBox1.Text, fileExtensionTextBox1.Text);
            operations.replacer(filesList, bytesStringrichTextBox1.Text, bytesStringrichTextBox2.Text);
        }
    }
}
