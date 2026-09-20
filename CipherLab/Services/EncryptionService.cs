using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace CipherLab.Services
{
    public static class EncryptionService
    {

        public static string Encrypt(string plainText, string secretKey)
        {
            if (string.IsNullOrEmpty(plainText) || string.IsNullOrEmpty(secretKey))
                return "Text or key cannot be empty!";

            byte[] keyBytes = GetKeyBytes(secretKey);

            using (Aes aes = Aes.Create())
            {
                aes.Key = keyBytes;
                aes.GenerateIV(); 
                byte[] iv = aes.IV;

                using (MemoryStream ms = new MemoryStream())
                {
                    ms.Write(iv, 0, iv.Length);

                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        using (StreamWriter sw = new StreamWriter(cs))
                        {
                            sw.Write(plainText);
                        }
                    }

                    return Convert.ToBase64String(ms.ToArray());
                }
            }
        }

        
        public static string Decrypt(string cipherText, string secretKey)
        {
            try
            {
                if (string.IsNullOrEmpty(cipherText) || string.IsNullOrEmpty(secretKey))
                    return "Ciphertext or key cannot be empty!";

                byte[] fullCipher = Convert.FromBase64String(cipherText);
                byte[] keyBytes = GetKeyBytes(secretKey);

                using (Aes aes = Aes.Create())
                {
                    aes.Key = keyBytes;

                    byte[] iv = new byte[16];
                    Array.Copy(fullCipher, 0, iv, 0, iv.Length);
                    aes.IV = iv;

                    using (MemoryStream ms = new MemoryStream(fullCipher, iv.Length, fullCipher.Length - iv.Length))
                    {
                        using (CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(aes.Key, aes.IV), CryptoStreamMode.Read))
                        {
                            using (StreamReader sr = new StreamReader(cs))
                            {
                                return sr.ReadToEnd();
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                return "Error: Decryption failed! Invalid key or corrupted text.";
            }
        }

        
        private static byte[] GetKeyBytes(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }
    }
}