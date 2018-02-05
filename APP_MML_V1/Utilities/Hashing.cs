using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace APP_MML_V1.Utilities
{
    public class Hashing : IPasswordHasher
    {
        public static string toAscii(string va)
        {
            string s = va.ToLower();

            byte[] by = Encoding.ASCII.GetBytes(s);
            string[] salida = new string[by.Length];
            for (int i = 0; i < by.Length; i++)
            {
                int d = by[i] - 20;
                //char ca = (char)d;
                string tex = d.ToString();
                salida[i] = tex;
            }
            string result = string.Concat(salida);
            return result;
        }
        public static string toAsciiFromInter(string va)
        {
            string s = va.ToString();//.ToLower();

            byte[] by = Encoding.ASCII.GetBytes(s);
            string[] salida = new string[by.Length];
            for (int i = 0; i < by.Length; i++)
            {
                int d = by[i];
                //d = replaceToInt(d);
                string ca = d.ToString();
                //if (ca.Equals("9"))
                //{
                //    ca = " ";
                //}
                //string tex = ca.ToString();
                salida[i] = ca;//tex;
            }
            string result = string.Concat(salida);
            return result;
        }

        public static Boolean compararPassword(string externo, string interno)
        {
            externo = toAscii(externo);
            byte[] externoByte = Encoding.ASCII.GetBytes(externo);
            //externo = string.Join("", externoByte);
            byte[] internoByte = Encoding.ASCII.GetBytes(interno);
            externo = string.Join("", externoByte);
            interno = string.Join("", internoByte);
            if (externo.Equals(interno))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public string HashPassword(string password)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(password);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
        public PasswordVerificationResult VerifyHashedPassword
                 (string hashedPassword, string providedPassword)
        {
            if (hashedPassword == HashPassword(providedPassword))
                return PasswordVerificationResult.Success;
            else
                return PasswordVerificationResult.Failed;
        }
    }
}