using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CipherLab.Services;

namespace CipherLab.Views.Controls
{
    public partial class UcTextCrypto : UserControl
    {
        public UcTextCrypto()
        {
            InitializeComponent();
        }

        private void btnCOPY_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtOutput.Text) && !string.IsNullOrWhiteSpace(txtOutput.Text))
            {
                Clipboard.SetText(txtOutput.Text);
                MessageBox.Show("Result copied to clipboard!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("There is no text to copy!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string plainText = txtInput.Text;
            string key = txtKey.Text;

            if (string.IsNullOrEmpty(plainText) || string.IsNullOrEmpty(key))
            {
                MessageBox.Show("Please enter both text and secret key!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string encryptedResult = EncryptionService.Encrypt(plainText, key);
            txtOutput.Text = encryptedResult;

            JsonLogService.SaveLog("Encrypt", plainText, encryptedResult);

        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string cipherText = txtInput.Text;
            string key = txtKey.Text;

            // Boşluk kontrolü
            if (string.IsNullOrEmpty(cipherText) || string.IsNullOrEmpty(key))
            {
                MessageBox.Show("Please enter both encrypted text and secret key!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // EncryptionService kullanarak şifreyi çözüyoruz
            string decryptedResult = EncryptionService.Decrypt(cipherText, key);
            txtOutput.Text = decryptedResult;

            JsonLogService.SaveLog("Decrypt", cipherText, decryptedResult);
        }
    }
}
