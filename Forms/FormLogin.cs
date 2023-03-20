using Microsoft.VisualBasic;
using PasswordManager.Classes.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager.Forms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            using (SqlCeCommand cmd = SQLCe.Query("usp_Users_Load"))
            {
                DataTable dtUser = new DataTable();
                SqlCeDataReader rows = cmd.ExecuteResultSet(ResultSetOptions.Scrollable);
                
                if(rows.HasRows)
                {
                    dtUser.Load(rows);
                    DataRow row = dtUser.Rows[0];
                    string input = Interaction.InputBox("Please enter your pin to continue.", "Enter Pin", "");
                   
                    while (input != row["pin"].ToString())
                    {
                        if (input == "")
                        {
                            this.Dispose();
                            Environment.Exit(1);
                        }
                        MessageBox.Show("Incorrect Pin. Please try again.");
                        input = Interaction.InputBox("Please enter your pin to continue.", "Enter Pin", "");
                    }

                    MainForm main = new MainForm();
                    main.ShowDialog();

                } else
                {
                    using (SqlCeCommand subcmd = SQLCe.Query("usp_Users_Insert"))
                    {
                        string input = Interaction.InputBox("Welcome to Password Manager. Please create a pin to continue. This will be required to login and decrypt passwords.", "Create Pin", "0000");
                        if (input == String.Empty)
                        {
                            Environment.Exit(1);
                        } else
                        {
                            subcmd.Parameters.AddWithValue("@pin", input);
                            subcmd.ExecuteNonQuery();
                            MainForm main = new MainForm();
                            main.ShowDialog();
                        }
                    }
                }
                
            }
        }
    }
}
