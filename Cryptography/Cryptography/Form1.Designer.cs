namespace Cryptography
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.selectedflbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Rarrbtn = new System.Windows.Forms.RadioButton();
            this.Videorbtn = new System.Windows.Forms.RadioButton();
            this.folderrbtn = new System.Windows.Forms.RadioButton();
            this.Photorbtn = new System.Windows.Forms.RadioButton();
            this.Textrbtn = new System.Windows.Forms.RadioButton();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.Proceedbtn = new System.Windows.Forms.Button();
            this.choosefbtn = new System.Windows.Forms.Button();
            this.choosefcbox = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cnlbtn = new System.Windows.Forms.Button();
            this.donebtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Encryptlbl = new System.Windows.Forms.Label();
            this.repeatktxtbox = new System.Windows.Forms.TextBox();
            this.keytxtbox = new System.Windows.Forms.TextBox();
            this.encryptbtn = new System.Windows.Forms.Button();
            this.deletecbox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.enfileptxtbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Decryptlbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.decryptbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.defileptxtbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.vignererbtn = new System.Windows.Forms.RadioButton();
            this.transrbtn = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.vernamrbtn = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.selectedflbl);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.Cancelbtn);
            this.tabPage1.Controls.Add(this.Proceedbtn);
            this.tabPage1.Controls.Add(this.choosefbtn);
            this.tabPage1.Controls.Add(this.choosefcbox);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 392);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Choose file";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // selectedflbl
            // 
            this.selectedflbl.AutoSize = true;
            this.selectedflbl.Location = new System.Drawing.Point(271, 278);
            this.selectedflbl.Name = "selectedflbl";
            this.selectedflbl.Size = new System.Drawing.Size(122, 20);
            this.selectedflbl.TabIndex = 7;
            this.selectedflbl.Text = "No File selected";
            this.selectedflbl.Click += new System.EventHandler(this.selectedflbl_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cryptography App";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select file(s) from computer";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Rarrbtn);
            this.groupBox2.Controls.Add(this.Videorbtn);
            this.groupBox2.Controls.Add(this.folderrbtn);
            this.groupBox2.Controls.Add(this.Photorbtn);
            this.groupBox2.Controls.Add(this.Textrbtn);
            this.groupBox2.Location = new System.Drawing.Point(118, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(506, 160);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Attachment Type";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Rarrbtn
            // 
            this.Rarrbtn.AutoSize = true;
            this.Rarrbtn.Location = new System.Drawing.Point(334, 71);
            this.Rarrbtn.Name = "Rarrbtn";
            this.Rarrbtn.Size = new System.Drawing.Size(84, 24);
            this.Rarrbtn.TabIndex = 4;
            this.Rarrbtn.TabStop = true;
            this.Rarrbtn.Text = "Rar file";
            this.Rarrbtn.UseVisualStyleBackColor = true;
            // 
            // Videorbtn
            // 
            this.Videorbtn.AutoSize = true;
            this.Videorbtn.Location = new System.Drawing.Point(200, 94);
            this.Videorbtn.Name = "Videorbtn";
            this.Videorbtn.Size = new System.Drawing.Size(75, 24);
            this.Videorbtn.TabIndex = 3;
            this.Videorbtn.TabStop = true;
            this.Videorbtn.Text = "Video";
            this.Videorbtn.UseVisualStyleBackColor = true;
            // 
            // folderrbtn
            // 
            this.folderrbtn.AutoSize = true;
            this.folderrbtn.Location = new System.Drawing.Point(200, 47);
            this.folderrbtn.Name = "folderrbtn";
            this.folderrbtn.Size = new System.Drawing.Size(79, 24);
            this.folderrbtn.TabIndex = 2;
            this.folderrbtn.TabStop = true;
            this.folderrbtn.Text = "Folder";
            this.folderrbtn.UseVisualStyleBackColor = true;
            this.folderrbtn.CheckedChanged += new System.EventHandler(this.folderrbtn_CheckedChanged);
            // 
            // Photorbtn
            // 
            this.Photorbtn.AutoSize = true;
            this.Photorbtn.Location = new System.Drawing.Point(50, 94);
            this.Photorbtn.Name = "Photorbtn";
            this.Photorbtn.Size = new System.Drawing.Size(76, 24);
            this.Photorbtn.TabIndex = 1;
            this.Photorbtn.TabStop = true;
            this.Photorbtn.Text = "Photo";
            this.Photorbtn.UseVisualStyleBackColor = true;
            // 
            // Textrbtn
            // 
            this.Textrbtn.AutoSize = true;
            this.Textrbtn.Location = new System.Drawing.Point(50, 48);
            this.Textrbtn.Name = "Textrbtn";
            this.Textrbtn.Size = new System.Drawing.Size(88, 24);
            this.Textrbtn.TabIndex = 0;
            this.Textrbtn.TabStop = true;
            this.Textrbtn.Text = "Text file";
            this.Textrbtn.UseVisualStyleBackColor = true;
            this.Textrbtn.CheckedChanged += new System.EventHandler(this.Textrbtn_CheckedChanged);
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Location = new System.Drawing.Point(594, 316);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(109, 41);
            this.Cancelbtn.TabIndex = 3;
            this.Cancelbtn.Text = "Cancel";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // Proceedbtn
            // 
            this.Proceedbtn.Location = new System.Drawing.Point(452, 316);
            this.Proceedbtn.Name = "Proceedbtn";
            this.Proceedbtn.Size = new System.Drawing.Size(110, 41);
            this.Proceedbtn.TabIndex = 2;
            this.Proceedbtn.Text = "Proceed";
            this.Proceedbtn.UseVisualStyleBackColor = true;
            this.Proceedbtn.Click += new System.EventHandler(this.Proceedbtn_Click);
            // 
            // choosefbtn
            // 
            this.choosefbtn.Location = new System.Drawing.Point(123, 272);
            this.choosefbtn.Name = "choosefbtn";
            this.choosefbtn.Size = new System.Drawing.Size(121, 32);
            this.choosefbtn.TabIndex = 1;
            this.choosefbtn.Text = "Choose File";
            this.choosefbtn.UseVisualStyleBackColor = true;
            this.choosefbtn.Click += new System.EventHandler(this.choosefbtn_Click);
            // 
            // choosefcbox
            // 
            this.choosefcbox.FormattingEnabled = true;
            this.choosefcbox.Location = new System.Drawing.Point(122, 341);
            this.choosefcbox.Name = "choosefcbox";
            this.choosefcbox.Size = new System.Drawing.Size(133, 28);
            this.choosefcbox.TabIndex = 0;
            this.choosefcbox.Text = "Choose File";
            this.choosefcbox.SelectedIndexChanged += new System.EventHandler(this.choosefcbox_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cnlbtn);
            this.tabPage2.Controls.Add(this.donebtn);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 392);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Encrypt";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cnlbtn
            // 
            this.cnlbtn.Location = new System.Drawing.Point(576, 328);
            this.cnlbtn.Name = "cnlbtn";
            this.cnlbtn.Size = new System.Drawing.Size(100, 39);
            this.cnlbtn.TabIndex = 3;
            this.cnlbtn.Text = "Cancel";
            this.cnlbtn.UseVisualStyleBackColor = true;
            this.cnlbtn.Click += new System.EventHandler(this.cnlbtn_Click);
            // 
            // donebtn
            // 
            this.donebtn.Location = new System.Drawing.Point(428, 328);
            this.donebtn.Name = "donebtn";
            this.donebtn.Size = new System.Drawing.Size(92, 39);
            this.donebtn.TabIndex = 2;
            this.donebtn.Text = "Done";
            this.donebtn.UseVisualStyleBackColor = true;
            this.donebtn.Click += new System.EventHandler(this.donebtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Encryptlbl);
            this.groupBox4.Controls.Add(this.repeatktxtbox);
            this.groupBox4.Controls.Add(this.keytxtbox);
            this.groupBox4.Controls.Add(this.encryptbtn);
            this.groupBox4.Controls.Add(this.deletecbox);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(400, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(346, 300);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Encryption Key";
            // 
            // Encryptlbl
            // 
            this.Encryptlbl.AutoSize = true;
            this.Encryptlbl.Location = new System.Drawing.Point(205, 231);
            this.Encryptlbl.Name = "Encryptlbl";
            this.Encryptlbl.Size = new System.Drawing.Size(21, 20);
            this.Encryptlbl.TabIndex = 6;
            this.Encryptlbl.Text = "...";
            this.Encryptlbl.Click += new System.EventHandler(this.Encryptlbl_Click);
            // 
            // repeatktxtbox
            // 
            this.repeatktxtbox.Location = new System.Drawing.Point(27, 129);
            this.repeatktxtbox.Name = "repeatktxtbox";
            this.repeatktxtbox.Size = new System.Drawing.Size(283, 26);
            this.repeatktxtbox.TabIndex = 5;
            this.repeatktxtbox.TextChanged += new System.EventHandler(this.repeatktxtbox_TextChanged);
            // 
            // keytxtbox
            // 
            this.keytxtbox.Location = new System.Drawing.Point(28, 56);
            this.keytxtbox.Name = "keytxtbox";
            this.keytxtbox.Size = new System.Drawing.Size(282, 26);
            this.keytxtbox.TabIndex = 4;
            this.keytxtbox.TextChanged += new System.EventHandler(this.keytxtbox_TextChanged);
            // 
            // encryptbtn
            // 
            this.encryptbtn.Location = new System.Drawing.Point(28, 226);
            this.encryptbtn.Name = "encryptbtn";
            this.encryptbtn.Size = new System.Drawing.Size(122, 30);
            this.encryptbtn.TabIndex = 3;
            this.encryptbtn.Text = "Encrypt";
            this.encryptbtn.UseVisualStyleBackColor = true;
            this.encryptbtn.Click += new System.EventHandler(this.encryptbtn_Click);
            // 
            // deletecbox
            // 
            this.deletecbox.AutoSize = true;
            this.deletecbox.Location = new System.Drawing.Point(28, 172);
            this.deletecbox.Name = "deletecbox";
            this.deletecbox.Size = new System.Drawing.Size(274, 24);
            this.deletecbox.TabIndex = 2;
            this.deletecbox.Text = "Delete original file after encryption";
            this.deletecbox.UseVisualStyleBackColor = true;
            this.deletecbox.CheckedChanged += new System.EventHandler(this.deletecbox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Repeat Key:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Key:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.vernamrbtn);
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Controls.Add(this.transrbtn);
            this.groupBox3.Controls.Add(this.vignererbtn);
            this.groupBox3.Controls.Add(this.enfileptxtbox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(28, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(330, 347);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // enfileptxtbox
            // 
            this.enfileptxtbox.Location = new System.Drawing.Point(23, 55);
            this.enfileptxtbox.Name = "enfileptxtbox";
            this.enfileptxtbox.Size = new System.Drawing.Size(287, 26);
            this.enfileptxtbox.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "File Path:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(767, 392);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Decrypt";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(619, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 44);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(454, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 44);
            this.button1.TabIndex = 7;
            this.button1.Text = "Done";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Decryptlbl);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Controls.Add(this.decryptbtn);
            this.groupBox5.Location = new System.Drawing.Point(426, 34);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(316, 246);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Decryption Key";
            // 
            // Decryptlbl
            // 
            this.Decryptlbl.AutoSize = true;
            this.Decryptlbl.Location = new System.Drawing.Point(52, 183);
            this.Decryptlbl.Name = "Decryptlbl";
            this.Decryptlbl.Size = new System.Drawing.Size(21, 20);
            this.Decryptlbl.TabIndex = 2;
            this.Decryptlbl.Text = "...";
            this.Decryptlbl.Click += new System.EventHandler(this.Decryptlbl_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Enter key:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // decryptbtn
            // 
            this.decryptbtn.Location = new System.Drawing.Point(43, 116);
            this.decryptbtn.Name = "decryptbtn";
            this.decryptbtn.Size = new System.Drawing.Size(145, 34);
            this.decryptbtn.TabIndex = 1;
            this.decryptbtn.Text = "Decrypt";
            this.decryptbtn.UseVisualStyleBackColor = true;
            this.decryptbtn.Click += new System.EventHandler(this.decryptbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.defileptxtbox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(19, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 340);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Decryption";
            // 
            // defileptxtbox
            // 
            this.defileptxtbox.Location = new System.Drawing.Point(24, 62);
            this.defileptxtbox.Name = "defileptxtbox";
            this.defileptxtbox.Size = new System.Drawing.Size(312, 26);
            this.defileptxtbox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "File:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // vignererbtn
            // 
            this.vignererbtn.AutoSize = true;
            this.vignererbtn.Location = new System.Drawing.Point(23, 190);
            this.vignererbtn.Name = "vignererbtn";
            this.vignererbtn.Size = new System.Drawing.Size(89, 24);
            this.vignererbtn.TabIndex = 3;
            this.vignererbtn.TabStop = true;
            this.vignererbtn.Text = "Vignere";
            this.vignererbtn.UseVisualStyleBackColor = true;
            this.vignererbtn.CheckedChanged += new System.EventHandler(this.vignererbtn_CheckedChanged);
            // 
            // transrbtn
            // 
            this.transrbtn.AutoSize = true;
            this.transrbtn.Location = new System.Drawing.Point(23, 246);
            this.transrbtn.Name = "transrbtn";
            this.transrbtn.Size = new System.Drawing.Size(129, 24);
            this.transrbtn.TabIndex = 4;
            this.transrbtn.TabStop = true;
            this.transrbtn.Text = "Transposition";
            this.transrbtn.UseVisualStyleBackColor = true;
            this.transrbtn.CheckedChanged += new System.EventHandler(this.transrbtn_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(175, 246);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(126, 24);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // vernamrbtn
            // 
            this.vernamrbtn.AutoSize = true;
            this.vernamrbtn.Location = new System.Drawing.Point(175, 190);
            this.vernamrbtn.Name = "vernamrbtn";
            this.vernamrbtn.Size = new System.Drawing.Size(90, 24);
            this.vernamrbtn.TabIndex = 6;
            this.vernamrbtn.TabStop = true;
            this.vernamrbtn.Text = "Vernam";
            this.vernamrbtn.UseVisualStyleBackColor = true;
            this.vernamrbtn.CheckedChanged += new System.EventHandler(this.vernamrbtn_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button decryptbtn;
        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.Button Proceedbtn;
        private System.Windows.Forms.Button choosefbtn;
        private System.Windows.Forms.ComboBox choosefcbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Rarrbtn;
        private System.Windows.Forms.RadioButton Videorbtn;
        private System.Windows.Forms.RadioButton folderrbtn;
        private System.Windows.Forms.RadioButton Photorbtn;
        private System.Windows.Forms.RadioButton Textrbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label selectedflbl;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox repeatktxtbox;
        private System.Windows.Forms.TextBox keytxtbox;
        private System.Windows.Forms.Button encryptbtn;
        private System.Windows.Forms.CheckBox deletecbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Encryptlbl;
        private System.Windows.Forms.Label Decryptlbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button cnlbtn;
        private System.Windows.Forms.Button donebtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox enfileptxtbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox defileptxtbox;
        private System.Windows.Forms.RadioButton vernamrbtn;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton transrbtn;
        private System.Windows.Forms.RadioButton vignererbtn;
    }
}

