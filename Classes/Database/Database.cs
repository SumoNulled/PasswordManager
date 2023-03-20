using System;
using System.Data.SqlServerCe;
using System.IO;

namespace PasswordManager.Classes.Database
{
    internal class Database
    {
        private static String ds = "Data Source=";
        private static String pw = "Password=";

        public static void Initialize(String dataSource, String password = null)
        {
            // Configure the connection to the embedded database.
            String connectionString = String.Format("{0}{1}; {2}{3};", ds, dataSource, pw, password);
            
            SqlCeEngine engine = new SqlCeEngine();
            engine.LocalConnectionString = connectionString;
            engine.CreateDatabase();
            
            // Configure tables for creation. Stored procedures found in Queries.cs and SQLCe.cs
            String[] tables = { 
                "usp_Accounts_Table_Create", 
                "usp_Generated_Passwords_Table_Create" ,
                "usp_Users_Table_Create"
            };

            foreach(String table in tables)
            {
                SqlCeCommand cmd = SQLCe.Query(table);
                cmd.ExecuteNonQuery();
            }
        }

        public SqlCeConnection connect(String dataSource, String password = null)
        {
            // In the unexpected case that the database isn't included in the file, create it.
            switch(File.Exists(dataSource))
            {
                case false:
                    Initialize(dataSource, password);
                    break;
            }

            String connectionString = String.Format("{0}{1}; {2}{3};", ds, dataSource, pw, password);

            SqlCeConnection conn = new SqlCeConnection();
            conn.ConnectionString = connectionString;

            return conn;
        }

    }
}
