using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersManagementApp.Database;

namespace UsersManagementApp.Users
{
    public static class Session
    {
        private static int id;

        private static bool loggedIn;

        public static int GetId() 
        { 
            return id;
        }

        private static void SetId(int id)
        {
            Session.id = id;
        }

        public static void Initialize(int id)
        {
            Session.SetId(id);
            loggedIn = true;
        }
        private static String Get(String column)
        {
            String stored_procedure = "usp_Users_Load";
            String[][] parameters = { new String[] { "@id", Session.GetId().ToString() }};
            String result = SQL.Select(stored_procedure, column, parameters);

            return result;
        }

        public static String GetUsername()
        {
            return Get("username");
        }

        public static String GetRole()
        {
            return Get("role");
        }
    }
}
