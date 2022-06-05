
namespace Simple_XOR_Encryption
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Plaintext = new System.Windows.Forms.TextBox();
            this.Encrypted = new System.Windows.Forms.TextBox();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.Key = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GenerateKeyButton = new System.Windows.Forms.Button();
            this.EncryptFilePath = new System.Windows.Forms.TextBox();
            this.SelectFileButton = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Plaintext
            // 
            this.Plaintext.Location = new System.Drawing.Point(12, 102);
            this.Plaintext.Multiline = true;
            this.Plaintext.Name = "Plaintext";
            this.Plaintext.Size = new System.Drawing.Size(360, 80);
            this.Plaintext.TabIndex = 0;
            // 
            // Encrypted
            // 
            this.Encrypted.Location = new System.Drawing.Point(12, 293);
            this.Encrypted.Multiline = true;
            this.Encrypted.Name = "Encrypted";
            this.Encrypted.Size = new System.Drawing.Size(360, 80);
            this.Encrypted.TabIndex = 1;
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(12, 241);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(125, 25);
            this.EncryptButton.TabIndex = 2;
            this.EncryptButton.Text = "Encrypt/Decrypt";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // Key
            // 
            this.Key.Location = new System.Drawing.Point(12, 203);
            this.Key.Name = "Key";
            this.Key.Size = new System.Drawing.Size(360, 23);
            this.Key.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Key:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Output:";
            // 
            // GenerateKeyButton
            // 
            this.GenerateKeyButton.Location = new System.Drawing.Point(272, 243);
            this.GenerateKeyButton.Name = "GenerateKeyButton";
            this.GenerateKeyButton.Size = new System.Drawing.Size(100, 23);
            this.GenerateKeyButton.TabIndex = 7;
            this.GenerateKeyButton.Text = "Generate key";
            this.GenerateKeyButton.UseVisualStyleBackColor = true;
            this.GenerateKeyButton.Click += new System.EventHandler(this.GenerateKeyButton_Click);
            // 
            // EncryptFilePath
            // 
            this.EncryptFilePath.Enabled = false;
            this.EncryptFilePath.Location = new System.Drawing.Point(12, 28);
            this.EncryptFilePath.Name = "EncryptFilePath";
            this.EncryptFilePath.Size = new System.Drawing.Size(303, 23);
            this.EncryptFilePath.TabIndex = 9;
            // 
            // SelectFileButton
            // 
            this.SelectFileButton.Enabled = false;
            this.SelectFileButton.Location = new System.Drawing.Point(322, 28);
            this.SelectFileButton.Name = "SelectFileButton";
            this.SelectFileButton.Size = new System.Drawing.Size(50, 23);
            this.SelectFileButton.TabIndex = 10;
            this.SelectFileButton.Text = "...";
            this.SelectFileButton.UseVisualStyleBackColor = true;
            this.SelectFileButton.Click += new System.EventHandler(this.SelectFileButton_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(87, 19);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.Text = "Encrypt file:";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(12, 77);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(91, 19);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Encrypt text:";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.SelectFileButton);
            this.Controls.Add(this.EncryptFilePath);
            this.Controls.Add(this.GenerateKeyButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Key);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.Encrypted);
            this.Controls.Add(this.Plaintext);
            this.Name = "MainWindow";
            this.Text = "Simple XOR Encryption";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Plaintext;
        private System.Windows.Forms.TextBox Encrypted;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.TextBox Key;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GenerateKeyButton;
        private System.Windows.Forms.TextBox EncryptFilePath;
        private System.Windows.Forms.Button SelectFileButton;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}

