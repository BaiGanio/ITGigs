using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _2Excel.ConsoleClient.Models
{
    public static class HashUtil
    {
        public static int ConvertCustomIdToInt(CustomId id)
        {
            MD5 md5Hasher = MD5.Create();
            var hashed = md5Hasher.ComputeHash(Encoding.UTF8.GetBytes(id.ToString()));
            int ivalue = BitConverter.ToInt32(hashed, 0);
            return Math.Abs(ivalue);
        }
    }
}
