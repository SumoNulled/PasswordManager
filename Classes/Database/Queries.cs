using System;

namespace PasswordManager.Classes.Database
{
    internal class Queries
    {
        private static String usp_Accounts_Count =
            "SELECT COUNT(id) as \"count\" FROM accounts;";
        private static String usp_Accounts_Delete =
            "DELETE FROM accounts WHERE id = @id;";
        private static String usp_Accounts_Insert =
            "INSERT INTO accounts (username, password, service, active) VALUES (@username, @password, @service, @active);";
        private static String usp_Accounts_Increment =
            "ALTER TABLE accounts ALTER COLUMN id IDENTITY (1,1);";
        private static string usp_Accounts_Load =
            "SELECT id, service as \"Service\", username as \"Username\", password as \"Password\", description as \"Description\" FROM accounts WHERE id = @id;";
        private static string usp_Accounts_LoadDataIntoDataGridView =
            "SELECT id, service as \"Service\", username as \"Username\", password as \"Password\", description as \"Description\", created as \"Created\" FROM accounts;";
        private static string usp_Accounts_LoadDataIntoDataGridView_Search =
            "SELECT id, service as \"Service\", username as \"Username\", password as \"Password\", description as \"Description\", created as \"Created\" FROM accounts WHERE service LIKE @Filter OR username LIKE @Filter;";
        private static String usp_Accounts_Reset =
            "DELETE FROM accounts;";
        private static String usp_Accounts_Search =
            "SELECT * FROM accounts WHERE id = @id;";
        private static String usp_Accounts_Table_Create =
            "CREATE TABLE accounts ("
            + "id int NOT NULL IDENTITY"             + ","
            + "service nvarchar(50) NOT NULL"        + ","
            + "username nvarchar(50) DEFAULT(0)"     + ","
            + "password nvarchar(100) DEFAULT(0)"    + ","
            + "active int NOT NULL DEFAULT(0)"       + ","
            + "description nvarchar(50) DEFAULT(0)" + ","
            + "created datetime DEFAULT GETDATE()"   + ","
            + "PRIMARY KEY (id)"                     + ""
            + ");";
        private static string usp_Accounts_Update =
            "UPDATE accounts SET username = @username, password = @password, description = @description WHERE id = @id";
        private static String usp_Generated_Passwords_Count =
            "SELECT COUNT(id) as \"count\" FROM generated_passwords;";
        private static String usp_Generated_Passwords_Insert =
            "INSERT INTO generated_passwords (service, password) VALUES (@service, @password);";
        private static String usp_Generated_Passwords_Table_Create =
           "CREATE TABLE generated_passwords ("
           + "id int NOT NULL IDENTITY" + ","
           + "service nvarchar(50) NOT NULL" + ","
           + "password nvarchar(100) DEFAULT(0)" + ","
           + "created datetime DEFAULT GETDATE()" + ","
           + "PRIMARY KEY (id)" + ""
           + ");";
        private static String usp_Generated_Passwords_Reset =
            "DELETE FROM generated_passwords;";
        private static string usp_Services_Count =
            "SELECT COUNT(*) as \"Count\" FROM (SELECT DISTINCT service FROM Accounts) x;";
        private static String usp_Users_Insert =
            "INSERT INTO users (pin) VALUES (@pin);";
        private static string usp_Users_Load =
            "SELECT pin FROM users;";
        private static String usp_Users_Table_Create =
            "CREATE TABLE users ("
            + "id int NOT NULL IDENTITY" + ","
            + "pin nvarchar(4) DEFAULT(NULL)" + ","
            + "created datetime DEFAULT GETDATE()" + ","
            + "PRIMARY KEY (id)" + ""
            + ");";
        private static String usp_Users_Reset =
            "DELETE FROM users;";

        public static String[] Accounts_Count()
        {
            String[] usp = { "usp_Accounts_Count", usp_Accounts_Count };
            return usp;
        }

        public static String[] Accounts_Delete()
        {
            String[] usp = { "usp_Accounts_Delete", usp_Accounts_Delete };
            return usp;
        }
        public static String[] Accounts_Increment()
        {
            String[] usp = {"usp_Accounts_Increment", usp_Accounts_Increment };
            return usp;
        }
        public static String[] Accounts_Insert()
        {
            String[] usp = { "usp_Accounts_Insert", usp_Accounts_Insert };
            return usp;
        }

        public static String[] Accounts_Load()
        {
            String[] usp = { "usp_Accounts_Load", usp_Accounts_Load };
            return usp;
        }

        public static String[] Accounts_LoadDataIntoDataGridView()
        {
            String[] usp = { "usp_Accounts_LoadDataIntoDataGridView", usp_Accounts_LoadDataIntoDataGridView };
            return usp;
        }

        public static String[] Accounts_LoadDataIntoDataGridView_Search()
        {
            String[] usp = { "usp_Accounts_LoadDataIntoDataGridView_Search", usp_Accounts_LoadDataIntoDataGridView_Search };
            return usp;
        }

        public static String[] Accounts_Reset()
        {
            String[] usp = { "usp_Accounts_Reset", usp_Accounts_Reset };
            return usp;
        }

        public static String[] Accounts_Search()
        {
            String[] usp = {"usp_Accounts_Search", usp_Accounts_Search };
            return usp;
        }

        public static String[] Accounts_Table_Create()
        {
            String[] usp = { "usp_Accounts_Table_Create", usp_Accounts_Table_Create };
            return usp;
        }

        public static String[] Accounts_Update()
        {
            String[] usp = { "usp_Accounts_Update", usp_Accounts_Update };
            return usp;
        }

        public static String[] Generated_Passwords_Count()
        {
            String[] usp = { "usp_Generated_Passwords_Count", usp_Generated_Passwords_Count };
            return usp;
        }

        public static String[] Generated_Passwords_Insert()
        {
            String[] usp = { "usp_Generated_Passwords_Insert", usp_Generated_Passwords_Insert };
            return usp;
        }

        public static String[] Generated_Passwords_Table_Create()
        {
            String[] usp = { "usp_Generated_Passwords_Table_Create", usp_Generated_Passwords_Table_Create };
            return usp;
        }

        public static String[] Generated_Passwords_Reset()
        {
            String[] usp = { "usp_Generated_Passwords_Reset", usp_Generated_Passwords_Reset };
            return usp;
        }

        public static String[] Services_Count()
        {
            String[] usp = { "usp_Services_Count", usp_Services_Count };
            return usp;
        }

        public static String[] Users_Insert()
        {
            String[] usp = { "usp_Users_Insert", usp_Users_Insert };
            return usp;
        }

        public static String[] Users_Load()
        {
            String[] usp = { "usp_Users_Load", usp_Users_Load };
            return usp;
        }

        public static String[] Users_Table_Create()
        {
            String[] usp = { "usp_Users_Table_Create", usp_Users_Table_Create };
            return usp;
        }

        public static String[] Users_Reset()
        {
            String[] usp = { "usp_Users_Reset", usp_Users_Reset };
            return usp;
        }
    }
}
