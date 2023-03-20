using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersManagementApp.Database;

namespace UsersManagementApp.Rights
{
    public class Permissions
    {
        private int id;
        public Permissions() { }
        public Permissions(int id)
        {
            this.id = id;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public int GetId() 
        { 
            return this.id;
        }

        public bool HasPermission(String permission)
        {
            String stored_procedure = "usp_Permissions_Check";
            String[][] parameters = {
                new String[] { "@id", Convert.ToString(this.GetId()) },
                new String[] { "@permission", permission } 
            };
            int result = Convert.ToInt32(SQL.Select(stored_procedure, "check", parameters));

            return Convert.ToBoolean(result);
        }

        public static string GetAdmin()
        {
            return "is_admin";
        }
    }
}
