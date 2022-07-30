using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace WindowsFormsApp1
{
    class Encryption
    {
        public static string GetHash(string type, string input)
        {
            byte[] data;
            if (type == "md5")
            {
                MD5 md5Hash = MD5.Create();
                data = md5Hash.ComputeHash(Encoding.ASCII.GetBytes(input));
            }
            else
            {
                SHA1 shaHash = SHA1.Create();
                data = shaHash.ComputeHash(Encoding.Unicode.GetBytes(input));
            }
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; ++i)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
        public static bool VerifyHash(string type, string input, string hash)
        {
            string hashOfInput;
            if (type == "md5")
            {
                hashOfInput = GetHash("md5", input);
            }
            else
            {
                hashOfInput = GetHash("sha1", input);
            }

            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
                return false;
        }
    }
}
