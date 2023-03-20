using PasswordManager.Classes.Database;
using PasswordManager.Classes.Passwords;
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
    public partial class AddAccountForm : Form
    {
        public AddAccountForm()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void generatePasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            switch(generatePasswordCheckBox.Checked)
            {
                case true:
                    passwordTextBox.ReadOnly = true;
                    passwordTextBox.Text = Password.Generate(15);
                    break;

                default:
                    passwordTextBox.ReadOnly = false;
                    passwordTextBox.Text = String.Empty;
                    break;
            }
        }

        private void ResetForm()
        {
            usernameTextBox.Clear();
            passwordTextBox.Clear();
            serviceTextBox.Clear();
            generatePasswordCheckBox.Checked = false;

            usernameTextBox.Focus();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Password cannot be empty.");
                passwordTextBox.Focus();
            }
            else
            {
                String password = Password.Encrypt(passwordTextBox.Text.ToString());
            


                String[][] parameters = {
                    new string[]{"@username", usernameTextBox.Text.ToString() },
                    new string[]{"@service", serviceTextBox.Text.ToString() },
                    new string[]{"@password", password },
                    new string[]{"@active", "1" }
                };

                using (SqlCeCommand cmd = SQLCe.Query("usp_Accounts_Insert", parameters))
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Account successfully added to the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ResetForm();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("0x0001", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void AddAccountForm_Load(object sender, EventArgs e)
        {
            usernameTextBox.Focus();
        }
    }
}
