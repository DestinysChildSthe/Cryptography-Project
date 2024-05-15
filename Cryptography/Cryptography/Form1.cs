using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptography
{
    public partial class Form1 : Form
    {
        OpenFileDialog fileToOpen;
        SaveFileDialog saveF;
        StreamWriter swrite;
        Stream s;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapt;
        DataSet ds;

        public Form1()
        {
            InitializeComponent();
            btnChooseFile.Enabled = false;
            btnProceed.Enabled = false;
            cboxDeleteEn.Enabled = false;
            cboxDeleteDe.Enabled = false;
            lblUserCount.Text = "0";
            tControl.TabPages.Remove(Admin);
        }

        private void Textrbtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void folderrbtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            fileToOpen = new OpenFileDialog();
            fileToOpen.Title = "Select File";
            fileToOpen.InitialDirectory = @"C:\";
            fileToOpen.Filter = "All files (*.*)|*.*|Text File (*.txt)|*.txt|Images (*.png)|*.jpg|PDF Documents (.pdf)|*.pdf|ZIP|*.zip|RAR|*.rar";
            fileToOpen.FilterIndex = 2;
            fileToOpen.ShowDialog();

            if (rbFile.Checked)
            {
                if (openFileDialog1.FileName != "")
                {
                    lblChoosenFile.Text = fileToOpen.FileName;
                }
                else
                {
                    lblChoosenFile.Text = "You did not select the file!";
                }
            }
            else if (rbPhoto.Checked)
            {

            }
            else if (rbRar.Checked)
            {

            }
            else if (rbFolder.Checked)
            {
                FolderBrowserDialog folderToOpen = new FolderBrowserDialog();
                if (folderToOpen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    lblChoosenFile.Text = folderToOpen.SelectedPath;
                    //txtFilePathDe.Text = lblChoosenFile.Text;
                }
                else
                {
                    lblChoosenFile.Text = "You did not select the folder!";
                }
            }
            else
            {

            }
        }
    }
}
