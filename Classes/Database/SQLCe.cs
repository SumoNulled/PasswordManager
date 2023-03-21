using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;

namespace PasswordManager.Classes.Database
{
    internal class SQLCe
    {
        
        public static SqlCeCommand Query(String sql, String[][] parameters = null)
        {
            sql = SQLCe.StoredProcedure(sql);
            Database db = new Database();
            SqlCeConnection conn = db.connect(Config.GetDataSource(), Config.GetPass());
            conn.Open();

            SqlCeCommand cmd = new SqlCeCommand(sql, conn);

            if (parameters != null)
            {
                for (int i = 0; i < parameters.Length; i++)
                {
                    cmd.Parameters.AddWithValue(parameters[i][0], parameters[i][1]);
                }
            }

            return cmd;
        }
        public static String StoredProcedure(String usp)
        {
            return procedures[usp];
        }

        public static String[] AddParameter(String parameter, String value)
        {
            String[] param = { parameter, value };
            return param;
        }

        private static Dictionary<string, string> procedures =
            new Dictionary<string, string>
            {
                {                  Queries.Accounts_Count()[0]        , Queries.Accounts_Count()[1]                           },
                {                  Queries.Accounts_Delete()[0]       , Queries.Accounts_Delete()[1]                          },
                {                 Queries.Accounts_Insert()[0]        , Queries.Accounts_Insert()[1]                          },
                {                 Queries.Accounts_Increment()[0]     , Queries.Accounts_Increment()[1]                       },
                {                    Queries.Accounts_Load()[0]       , Queries.Accounts_Load()[1]                            },
                {Queries.Accounts_LoadDataIntoDataGridView()[0]       , Queries.Accounts_LoadDataIntoDataGridView()[1]        },
                {Queries.Accounts_LoadDataIntoDataGridView_Search()[0], Queries.Accounts_LoadDataIntoDataGridView_Search()[1] },
                {                  Queries.Accounts_Reset()[0]        , Queries.Accounts_Reset()[1]                           },
                {           Queries.Accounts_Table_Create()[0]        , Queries.Accounts_Table_Create()[1]                    },
                {                 Queries.Accounts_Update()[0]        , Queries.Accounts_Update()[1]                          },
                {       Queries.Generated_Passwords_Count()[0]        , Queries.Generated_Passwords_Count()[1]                },
                {      Queries.Generated_Passwords_Insert()[0]        , Queries.Generated_Passwords_Insert()[1]               },
                {       Queries.Generated_Passwords_Reset()[0]        , Queries.Generated_Passwords_Reset()[1]                },
                {Queries.Generated_Passwords_Table_Create()[0]        , Queries.Generated_Passwords_Table_Create()[1]         },
                {                  Queries.Services_Count()[0]        , Queries.Services_Count()[1]                           },
                {                    Queries.Users_Insert()[0]        , Queries.Users_Insert()[1]                             },
                {                      Queries.Users_Load()[0]        , Queries.Users_Load()[1]                               },
                {                      Queries.Users_Reset()[0]       , Queries.Users_Reset()[1]                              },
                {              Queries.Users_Table_Create()[0]        , Queries.Users_Table_Create()[1]                       }
            };
    }
}
