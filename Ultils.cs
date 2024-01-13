using DevExpress.XtraBars.Docking2010.DragEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTaiSan
{
    public class Ultils
    {
        public static string AES_Encrypt(string input)
        {
            using (RijndaelManaged aes = new RijndaelManaged())
            {
                using (MD5CryptoServiceProvider hash_aes = new MD5CryptoServiceProvider())
                {
                    string enscypted = "";
                    try
                    {
                        byte[] hash = new byte[32];
                        byte[] temp = hash_aes.ComputeHash(Encoding.ASCII.GetBytes(Properties.Settings.Default.PasswordHash));
                        Array.Copy(temp, 0, hash, 0, 16);
                        Array.Copy(temp, 0, hash, 16, 16);
                        aes.Key = hash;
                        aes.Mode = CipherMode.ECB;
                        ICryptoTransform DESEnscrypter = aes.CreateEncryptor();
                        byte[] buffer = ASCIIEncoding.UTF8.GetBytes(input);
                        enscypted = Convert.ToBase64String(DESEnscrypter.TransformFinalBlock(buffer, 0, buffer.Length));
                        return enscypted;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            return null;
        }


        public static string AES_Descrypt(string input)
        {
            using (RijndaelManaged aes = new RijndaelManaged())
            {
                using (MD5CryptoServiceProvider hash_aes = new MD5CryptoServiceProvider())
                {
                    string descrypted = "";
                    try
                    {
                        byte[] hash = new byte[32];
                        byte[] temp = hash_aes.ComputeHash(Encoding.ASCII.GetBytes(Properties.Settings.Default.PasswordHash));
                        Array.Copy(temp, 0, hash, 0, 16);
                        Array.Copy(temp, 0, hash, 16, 16);
                        aes.Key = hash;
                        aes.Mode = CipherMode.ECB;
                        ICryptoTransform DESEncrypter = aes.CreateDecryptor();
                        byte[] buffer = Convert.FromBase64String(input);
                        descrypted = Encoding.UTF8.GetString(DESEncrypter.TransformFinalBlock(buffer, 0, buffer.Length));
                        return descrypted;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            return null;
        }
    }
}
