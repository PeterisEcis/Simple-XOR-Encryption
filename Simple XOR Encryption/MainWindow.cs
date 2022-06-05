using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Simple_XOR_Encryption
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //TODO
        // File input/output ?

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            if(Key.Text.Length == 0)
            {
                MessageBox.Show("No key provided!");
                return;
            }

            if (radioButton1.Checked) // Encrypt selected file
            {
                var path = EncryptFilePath.Text;
                if (File.Exists(path))
                {
                    var text = File.ReadAllText(path);
                    if(text.Length == 0)
                    {
                        MessageBox.Show("File is empty!");
                    }
                    else
                    {
                        Encrypted.Text = EncryptDecrypt(text, Key.Text);
                    }
                }
                else
                {
                    MessageBox.Show("File does not exist");
                }
            }

            else   //Encrypt provided text
            {
                if (Plaintext.Text.Length == 0)
                {
                    MessageBox.Show("No message to encrypt/decrypt!");
                }
                else
                {
                    Encrypted.Text = EncryptDecrypt(Plaintext.Text, Key.Text);
                }
            }
        }

        private string EncryptDecrypt(string plaintext, string key) // Main encryption function
        {
            StringBuilder encryptedOutput = new StringBuilder();
            for (int i = 0; i < plaintext.Length; i++)
            {
                char currentChar = (char)(plaintext[i] ^ key[i % (key.Length - 1)]); // Ja plaintext ir garāks par key, tad key tiek atkārtots
                encryptedOutput.Append(currentChar);
            }
            return encryptedOutput.ToString();
        }

        private void GenerateKeyButton_Click(object sender, EventArgs e)
        {
            int length = Plaintext.Text.Length;
            if(length != 0)
            {
                Key.Text = GenerateRandomKey(Plaintext.Text.Length);
            }
        }

        // Generates random key using capital letters and numbers
        private string GenerateRandomKey(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            EncryptFilePath.Enabled = radioButton1.Checked;
            SelectFileButton.Enabled = radioButton1.Checked;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Plaintext.Enabled = radioButton2.Checked;
        }

        private void SelectFileButton_Click(object sender, EventArgs e)
        {
            var fileDialog = new OpenFileDialog
            {
                InitialDirectory = File.Exists(EncryptFilePath.Text) ? EncryptFilePath.Text : @"C:\" ,
                Title = "Select File",
                Filter = "txt files (*.txt)|*.txt|all files|*.*"
            };
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                EncryptFilePath.Text = fileDialog.FileName;
            }

        }
    }
}
