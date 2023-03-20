using PasswordManager.Classes.Database;
using PasswordManager.Classes.Passwords;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager.Forms
{
    public partial class EditAccountForm : Form
    {
        public EditAccountForm()
        {
            InitializeComponent();
        }

        public int AccountId { get; set; }

        private void EditAccountForm_Load(object sender, EventArgs e)
        {
            lblAccountId.Text = this.AccountId.ToString();
            using (SqlCeCommand cmd = SQLCe.Query("usp_Accounts_Load"))
            {
                cmd.Parameters.AddWithValue("@id", this.AccountId.ToString());

                DataTable dtUser = new DataTable();
                SqlCeDataReader rows = cmd.ExecuteReader();

                dtUser.Load(rows);

                DataRow row = dtUser.Rows[0];

                tbUsername.Text = row["username"].ToString();
                tbPassword.Text = Password.Decrypt(row["password"].ToString());
                tbDescription.Text = row["description"].ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlCeCommand cmd = SQLCe.Query("usp_Accounts_Update"))
            {
                cmd.Parameters.AddWithValue("@id", this.AccountId.ToString());
                cmd.Parameters.AddWithValue("@username", tbUsername.Text.ToString());
                cmd.Parameters.AddWithValue("@password", Password.Encrypt(tbPassword.Text.ToString()));
                cmd.Parameters.AddWithValue("@description", tbDescription.Text.ToString());
                
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update account successfully.");
                this.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (SqlCeCommand cmd = SQLCe.Query("usp_Accounts_Delete"))
            {
                cmd.Parameters.AddWithValue("@id", this.AccountId.ToString());
                DialogResult result = MessageBox.Show("Are you sure you want to delete this account?", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
                switch(result)
                {
                    case DialogResult.Yes:
                        cmd.ExecuteNonQuery();
                        this.Close();
                        break;

                    default:

                        break;
                }
            }
        }
    }
}
