using System;

namespace PasswordManager.Classes.Database
{
    internal class Config
    {
        static private String dataSource = "PasswordManager.sdf";
        static private String password = "";

        public static String GetDataSource()
        {
            return Config.dataSource;
        }

        public static String GetPass()
        {
            return Config.password;
        }
    }
}
