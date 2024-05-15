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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.decryptbtn = new System.Windows.Forms.Button();
            this.choosefcbox = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.Proceedbtn = new System.Windows.Forms.Button();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Textrbtn = new System.Windows.Forms.RadioButton();
            this.Photorbtn = new System.Windows.Forms.RadioButton();
            this.folderrbtn = new System.Windows.Forms.RadioButton();
            this.Videorbtn = new System.Windows.Forms.RadioButton();
            this.Rarrbtn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.selectedflbl = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.deletecbox = new System.Windows.Forms.CheckBox();
            this.encryptbtn = new System.Windows.Forms.Button();
            this.keytxtbox = new System.Windows.Forms.TextBox();
            this.repeatktxtbox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
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
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.choosefcbox);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 392);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Choose file";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
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
            // tabPage3
            // 
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
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(19, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 340);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Decryption";
            // 
            // decryptbtn
            // 
            this.decryptbtn.Location = new System.Drawing.Point(43, 159);
            this.decryptbtn.Name = "decryptbtn";
            this.decryptbtn.Size = new System.Drawing.Size(145, 34);
            this.decryptbtn.TabIndex = 1;
            this.decryptbtn.Text = "Decrypt";
            this.decryptbtn.UseVisualStyleBackColor = true;
            // 
            // choosefcbox
            // 
            this.choosefcbox.FormattingEnabled = true;
            this.choosefcbox.Location = new System.Drawing.Point(123, 302);
            this.choosefcbox.Name = "choosefcbox";
            this.choosefcbox.Size = new System.Drawing.Size(133, 28);
            this.choosefcbox.TabIndex = 0;
            this.choosefcbox.Text = "Choose File";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(123, 272);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Proceedbtn
            // 
            this.Proceedbtn.Location = new System.Drawing.Point(452, 295);
            this.Proceedbtn.Name = "Proceedbtn";
            this.Proceedbtn.Size = new System.Drawing.Size(110, 41);
            this.Proceedbtn.TabIndex = 2;
            this.Proceedbtn.Text = "Proceed";
            this.Proceedbtn.UseVisualStyleBackColor = true;
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Location = new System.Drawing.Point(592, 295);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(109, 41);
            this.Cancelbtn.TabIndex = 3;
            this.Cancelbtn.Text = "Cancel";
            this.Cancelbtn.UseVisualStyleBackColor = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select file(s) from computer";
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
            // selectedflbl
            // 
            this.selectedflbl.AutoSize = true;
            this.selectedflbl.Location = new System.Drawing.Point(225, 273);
            this.selectedflbl.Name = "selectedflbl";
            this.selectedflbl.Size = new System.Drawing.Size(122, 20);
            this.selectedflbl.TabIndex = 7;
            this.selectedflbl.Text = "No File selected";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(24, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(330, 336);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Encryption";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.repeatktxtbox);
            this.groupBox4.Controls.Add(this.keytxtbox);
            this.groupBox4.Controls.Add(this.encryptbtn);
            this.groupBox4.Controls.Add(this.deletecbox);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(400, 32);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(346, 336);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Encryption Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Key:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Repeat Key:";
            // 
            // deletecbox
            // 
            this.deletecbox.AutoSize = true;
            this.deletecbox.Location = new System.Drawing.Point(43, 223);
            this.deletecbox.Name = "deletecbox";
            this.deletecbox.Size = new System.Drawing.Size(274, 24);
            this.deletecbox.TabIndex = 2;
            this.deletecbox.Text = "Delete original file after encryption";
            this.deletecbox.UseVisualStyleBackColor = true;
            // 
            // encryptbtn
            // 
            this.encryptbtn.Location = new System.Drawing.Point(165, 284);
            this.encryptbtn.Name = "encryptbtn";
            this.encryptbtn.Size = new System.Drawing.Size(122, 30);
            this.encryptbtn.TabIndex = 3;
            this.encryptbtn.Text = "Encrypt";
            this.encryptbtn.UseVisualStyleBackColor = true;
            // 
            // keytxtbox
            // 
            this.keytxtbox.Location = new System.Drawing.Point(43, 82);
            this.keytxtbox.Name = "keytxtbox";
            this.keytxtbox.Size = new System.Drawing.Size(282, 26);
            this.keytxtbox.TabIndex = 4;
            // 
            // repeatktxtbox
            // 
            this.repeatktxtbox.Location = new System.Drawing.Point(42, 172);
            this.repeatktxtbox.Name = "repeatktxtbox";
            this.repeatktxtbox.Size = new System.Drawing.Size(283, 26);
            this.repeatktxtbox.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 26);
            this.textBox1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Enter key:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Controls.Add(this.decryptbtn);
            this.groupBox5.Location = new System.Drawing.Point(426, 34);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(316, 327);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Decryption Key";
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
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
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
        private System.Windows.Forms.Button button4;
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
    }
}

