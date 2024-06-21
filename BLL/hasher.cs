using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Hobook_Software.BLL
{
    public static class hasher
    {
        public static string Encode(string plainText)
        {
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            string encodedText = Convert.ToBase64String(plainTextBytes);
            return encodedText;
        }

        public static string Decode(string encodedText)
        {
            byte[] encodedBytes = Convert.FromBase64String(encodedText);
            string plainText = Encoding.UTF8.GetString(encodedBytes);
            return plainText;
        }
    }
}
