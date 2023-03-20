using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace UsersManagementApp.General
{
    public class SecureData
    {
        public static String Encrypt(String str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] passwordHash = Encoding.UTF8.GetBytes(str);

            return Encoding.UTF8.GetString(md5.ComputeHash(passwordHash));
        }
    }
}
