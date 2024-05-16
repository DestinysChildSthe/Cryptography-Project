using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;


namespace Cryptography
{
    public partial class Form1 : Form
    {
        OpenFileDialog fileToOpen;
        SaveFileDialog saveF;
        StreamWriter swrite;
        Stream s;
        

        public Form1()
        {
            InitializeComponent();
            choosefbtn.Enabled = false;
            Proceedbtn.Enabled = false;
            deletecbox.Enabled = false;
           
        }

        private void Textrbtn_CheckedChanged(object sender, EventArgs e)
        {
            enableChoose();
        }

        private void folderrbtn_CheckedChanged(object sender, EventArgs e)
        {
            enableChoose();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
           
        }

        private void attachementType()
        {
            fileToOpen = new OpenFileDialog();
            fileToOpen.Title = "Select File";
            fileToOpen.InitialDirectory = @"C:\";
            fileToOpen.Filter = "All files (*.*)|*.*|Text File (*.txt)|*.txt|Images (*.png)|*.jpg|PDF Documents (.pdf)|*.pdf|ZIP|*.zip|RAR|*.rar";
            fileToOpen.FilterIndex = 2;
            fileToOpen.ShowDialog();

            if (Textrbtn.Checked)
            {
                if (openFileDialog1.FileName != "")
                {
                    selectedflbl.Text = fileToOpen.FileName;
                }
                else
                {
                    selectedflbl.Text = "You did not select the file!";
                }
            }
            else if (Photorbtn.Checked)
            {

            }
            else if (Videorbtn.Checked)
            {

            }
            else if (Rarrbtn.Checked)
            {

            }
            else if (folderrbtn.Checked)
            {
                FolderBrowserDialog folderToOpen = new FolderBrowserDialog();
                if (folderToOpen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    selectedflbl.Text = folderToOpen.SelectedPath;
                    //txtFilePathDe.Text = lblChoosenFile.Text;
                }
                else
                {
                    selectedflbl.Text = "You did not select the folder!";
                }
            }
            else
            {

            }
        
        }

        private void choosefbtn_Click(object sender, EventArgs e)
        {
            try
            {
                attachementType();
            }
            catch (FileNotFoundException ex1)
            {
                MessageBox.Show("File not found" + ex1, "failed", MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Error);
            }
            catch (Exception ex2)
            {
                MessageBox.Show("Exception found" + ex2, "failed", MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Error);
            }
        }

        private void choosefcbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            enableProceed();
        }

        private void selectedflbl_Click(object sender, EventArgs e)
        {

        }

        private void encryptbtn_Click(object sender, EventArgs e)
        {
            //call the Encryption method/function
            /*Register validateKey = new Register();
            bool isKeySame = Register.validatePassword(keytxtbox.Text, repeatktxtbox.Text);
            try
            {
                if (keytxtbox.Text != "" && repeatktxtbox.Text != "" && (isKeySame == true))
                {
                    saveFile();
                    deletecbox.Enabled = true;
                }
            }
            catch (IOException ioEx)
            {
                MessageBox.Show("Enter encryption key", "Enter key", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/

          
            try
            {
                if (keytxtbox.Text != "" && repeatktxtbox.Text != "" )
                {
                    string encryptedText = "";
                    List<string> algorithms = new List<string>();
                    List<object> keys = new List<object>();

                    if (vignererbtn.Checked)
                    {
                        algorithms.Add("Vigenère Cipher");
                        keys.Add(keytxtbox.Text);
                    }
                    if (vernamrbtn.Checked)
                    {
                        algorithms.Add("Vernam Cipher");
                        keys.Add(keytxtbox.Text);
                    }
                    if (transrbtn.Checked)
                    {
                        algorithms.Add("Transposition Cipher");
                        keys.Add(Convert.ToInt32(keytxtbox.Text));
                    }
                    /* if (ownrbtn.Checked)
                     {
                         algorithms.Add("Own Algorithm");
                         keys.Add(Convert.ToInt32(keytxtbox.Text));
                     }*/

                    if (algorithms.Count > 0)
                    {
                        encryptedText = EncryptWithMultipleAlgorithms(enfileptxtbox.Text, algorithms, keys);
                        saveFile();
                        deletecbox.Enabled = true;
                    }
                }
            }
            catch (IOException ioEx)
            {

                MessageBox.Show("Enter encryption key", "Enter key", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void deletecbox_CheckedChanged(object sender, EventArgs e)
        {
          

        }

        private void decryptbtn_Click(object sender, EventArgs e)
        {
            //call the decryption method/function
            saveFile();
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void keytxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void repeatktxtbox_TextChanged(object sender, EventArgs e)
        {

        }
        private void enableChoose()
        {

            if (Textrbtn.Checked == true || folderrbtn.Checked == true || Photorbtn.Checked == true ||Videorbtn.Checked == true || Rarrbtn.Checked == true)
            {
                choosefbtn.Enabled = true;
            }
        }

        private void enableProceed()
        {
            if (choosefcbox.SelectedIndex == 0 || choosefcbox.SelectedIndex == 1)
            {
                Proceedbtn.Enabled = true;
            }
        }

        public void deleteAfter(string fileToDelete)
        {
            try
            {
                // Check if file exists with its full path    
                if (System.IO.File.Exists(fileToDelete))
                {
                    // If file found, delete it    
                    System.IO.File.Delete(fileToDelete);
                    MessageBox.Show("Original file deleted ", "File deleted", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("File not found", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (IOException ioExp)
            {
                Console.WriteLine(ioExp.Message);
            }
        }


        public void saveFile()
        {
             saveF = new SaveFileDialog();
             saveF.Title = "Save File";
             saveF.InitialDirectory = @"C:\";//--"C:\\";
             saveF.Filter = "All files (*.*)|*.*|Text File (*.txt)|*.txt";

             if (saveF.ShowDialog() == DialogResult.OK)
             {
                 string encText = keytxtbox.Text;
                 string decText = textBox1.Text;
                 s = System.IO.File.Open(saveF.FileName, FileMode.CreateNew);
                 using (swrite = new StreamWriter(s))
                 {
                     if (tabControl1.SelectedIndex == 1) //encrypt
                     {
                         swrite.Write(encText); // updated text encryption
                         //encryptFile(encText);
                         Encryptlbl.Text = saveF.FileName; // filePath
                     }
                     else if (tabControl1.SelectedIndex == 2) // decrypt
                     {
                         swrite.Write(decText); // updated text decryption
                         //decyptFile(decText);
                         Decryptlbl.Text = saveF.FileName; // filepath
                     }
                     MessageBox.Show("New File saved at " + saveF.FileName, "Saved File", MessageBoxButtons.OK,
                     MessageBoxIcon.Information);

                 }

             }

        }

        /*public void saveFile(string text)
        {
            saveF = new SaveFileDialog();
            saveF.Title = "Save File";
            saveF.InitialDirectory = @"C:\";
            saveF.Filter = "All files (*.*)|*.*|Text File (*.txt)|*.txt";

            if (saveF.ShowDialog() == DialogResult.OK)
            {
                s = File.Open(saveF.FileName, FileMode.CreateNew);
                using (swrite = new StreamWriter(s))
                {
                    swrite.Write(text);
                    MessageBox.Show("New File saved at " + saveF.FileName, "Saved File", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }*/

        private void Encryptlbl_Click(object sender, EventArgs e)
        {

        }

        private void Decryptlbl_Click(object sender, EventArgs e)
        {

        }

        private void Proceedbtn_Click(object sender, EventArgs e)
        {
            if (Textrbtn.Checked || folderrbtn.Checked)
            {
                if (choosefcbox.SelectedIndex == 0)
                {
                    enfileptxtbox.Text = selectedflbl.Text;
                    if (Textrbtn.Checked == true)
                    {
                        keytxtbox.Text = System.IO.File.ReadAllText(fileToOpen.FileName);
                    }
                    else if (Photorbtn.Checked == true)
                    {
                        // disable the txtFileEn textbox
                        //show a picturebox with the image
                    }
                    else if (Videorbtn.Checked == true)
                    {
                        // txtfileEn.text == "video";
                    }
                    else if (Rarrbtn.Checked == true)
                    {
                        // txtfileEn.text == "Rar file";
                    }

                    /*tabControl1.SelectedTab = Encrypt;
                    Encrypt.Show();*/

                    tabControl1.SelectedTab = tabControl1.TabPages["Encrypt"];

                }
                else if (choosefcbox.SelectedIndex == 1)
                {
                    defileptxtbox.Text = selectedflbl.Text;
                    /*textBox1.Text = File.ReadAllText(fileToOpen.FileName);
                    tabControl1.SelectedTab = Decrypt;
                    Decrypt.Show();*/

                    if (!string.IsNullOrEmpty(fileToOpen.FileName))
                    {
                        textBox1.Text = System.IO.File.ReadAllText(fileToOpen.FileName);
                    }

                    tabControl1.SelectedTab = tabControl1.TabPages["Decrypt"];
                }
            }
        }

        private void donebtn_Click(object sender, EventArgs e)
        {
            string fPath = enfileptxtbox.Text.ToString();
            if (deletecbox.Checked == true)
            {
                deleteAfter(fPath);

            }
        }

        private void cnlbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fPath = defileptxtbox.Text.ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //----------------------Cryptography algorithm--------------


        //----------------------Vignere---------------------------

        private string VigenereEncrypt(string plainText, string key)
        {
            string cipherText = "";
            int j = 0;

            for (int i = 0; i < plainText.Length; i++)
            {
                if (Char.IsLetter(plainText[i]))
                {
                    cipherText += (char)(((plainText[i] + key[j]) % 26) + 'A');
                    j = ++j % key.Length;
                }
                else
                {
                    cipherText += plainText[i];
                }
            }

            return cipherText;
        }

        private string VigenereDecrypt(string cipherText, string key)
        {
            string plainText = "";
            int j = 0;

            for (int i = 0; i < cipherText.Length; i++)
            {
                if (Char.IsLetter(cipherText[i]))
                {
                    plainText += (char)(((cipherText[i] - key[j] + 26) % 26) + 'A');
                    j = ++j % key.Length;
                }
                else
                {
                    plainText += cipherText[i];
                }
            }

            return plainText;
        }


        //----------------------Vernam-----------------------------

        private string VernamEncrypt(string plainText, string key)
        {
            string cipherText = "";
            int j = 0;

            for (int i = 0; i < plainText.Length; i++)
            {
                cipherText += (char)(plainText[i] ^ key[j]);
                j = ++j % key.Length;
            }

            return cipherText;
        }

        private string VernamDecrypt(string cipherText, string key)
        {
            string plainText = "";
            int j = 0;

            for (int i = 0; i < cipherText.Length; i++)
            {
                plainText += (char)(cipherText[i] ^ key[j]);
                j = ++j % key.Length;
            }

            return plainText;
        }

        //----------------------Transposition-----------------------------

        private string TranspositionEncrypt(string plainText, int keyLength)
        {
            string cipherText = "";
            int rows = plainText.Length / keyLength;
            if (plainText.Length % keyLength != 0)
                rows++;

            char[,] rail = new char[rows, keyLength];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < keyLength; j++)
                {
                    if (plainText.Length == (i * keyLength) + j)
                        break;
                    rail[i, j] = plainText[(i * keyLength) + j];
                }
            }

            for (int j = 0; j < keyLength; j++)
            {
                for (int i = 0; i < rows; i++)
                {
                    if (rail[i, j] != '\0')
                        cipherText += rail[i, j];
                }
            }

            return cipherText;
        }

        private string TranspositionDecrypt(string cipherText, int keyLength)
        {
            string plainText = "";
            int rows = cipherText.Length / keyLength;
            if (cipherText.Length % keyLength != 0)
                rows++;

            char[,] rail = new char[rows, keyLength];

            for (int j = 0; j < keyLength; j++)
            {
                int k = 0;
                for (int i = 0; i < rows; i++)
                {
                    if (cipherText.Length == (i * keyLength) + j)
                        break;
                    rail[i, j] = cipherText[(i * keyLength) + j];
                    k++;
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < keyLength; j++)
                {
                    if (rail[i, j] != '\0')
                        plainText += rail[i, j];
                }
            }

            return plainText;
        }

        private string EncryptWithMultipleAlgorithms(string plainText, List<string> algorithms, List<object> keys)
        {
            string cipherText = plainText;
            for (int i = 0; i < algorithms.Count; i++)
            {
                switch (algorithms[i])
                {
                    case "Vigenère Cipher":
                        cipherText = VigenereEncrypt(cipherText, keys[i].ToString());
                        break;
                    case "Vernam Cipher":
                        cipherText = VernamEncrypt(cipherText, keys[i].ToString());
                        break;
                    case "Transposition Cipher":
                        cipherText = TranspositionEncrypt(cipherText, (int)keys[i]);
                        break;
                   /* case "Own Algorithm":
                        cipherText = OwnEncrypt(cipherText, (int)keys[i]);
                        break;*/
                        // Add more cases for other ciphers if needed
                }
            }
            return cipherText;
        }

        private string DecryptWithMultipleAlgorithms(string cipherText, List<string> algorithms, List<object> keys)
        {
            string plainText = cipherText;
            for (int i = algorithms.Count - 1; i >= 0; i--)
            {
                switch (algorithms[i])
                {
                    case "Vigenère Cipher":
                        plainText = VigenereDecrypt(plainText, keys[i].ToString());
                        break;
                    case "Vernam Cipher":
                        plainText = VernamDecrypt(plainText, keys[i].ToString());
                        break;
                    case "Transposition Cipher":
                        plainText = TranspositionDecrypt(plainText, (int)keys[i]);
                        break;
                    /*case "Own Algorithm":
                        plainText = OwnDecrypt(plainText, (int)keys[i]);
                        break;*/
                        // Add more cases for other ciphers if needed
                }
            }
            return plainText;
        }

        private void vignererbtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void transrbtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void vernamrbtn_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
