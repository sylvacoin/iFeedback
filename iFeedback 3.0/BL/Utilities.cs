using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace iFeedback.BL
{
    public class Utilities
    {
        public string md5(string text)
        {
            using (MD5 md5 = MD5.Create())
            {
                Byte[] hash = md5.ComputeHash(Encoding.UTF8.GetBytes(text)) ;
                return BitConverter.ToString(hash).Replace("-", "").ToLower();
            }
        }
    }
}
