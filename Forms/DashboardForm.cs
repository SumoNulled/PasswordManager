using PasswordManager.Classes.Database;
using System;
using System.Data.SqlServerCe;
using System.Windows.Forms;

namespace PasswordManager.Forms
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            SqlCeCommand cmd = SQLCe.Query("usp_Accounts_Count");
            SqlCeDataReader row = cmd.ExecuteReader();
            String value = "";
            while (row.Read())
            {
                value = row["count"].ToString();
            }
            stored_passwords.Text = value;

            cmd = SQLCe.Query("usp_Services_Count");
            row = cmd.ExecuteReader();
            value = "";
            while (row.Read())
            {
                value = row["count"].ToString();
            }
            services.Text = value;

            cmd = SQLCe.Query("usp_Generated_Passwords_Count");
            row = cmd.ExecuteReader();
            value = "";
            while (row.Read())
            {
                value = row["count"].ToString();
            }
            generated_passwords.Text = value;

        }
    }
}
