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
    public partial class ViewAccountsForm : Form
    {
        public ViewAccountsForm()
        {
            InitializeComponent();
            LoadDataIntoDataGridView();
        }

        private void LoadDataIntoDataGridView()
        {
            using (SqlCeCommand cmd = SQLCe.Query("usp_Accounts_LoadDataIntoDataGridView"))
            {
                DataTable dtAccounts = new DataTable();
                SqlCeDataReader rows = cmd.ExecuteReader();
                dtAccounts.Load(rows);

                accountsDataGridView.DataSource = dtAccounts;
                accountsDataGridView.Columns[0].Visible = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (SearchTextBox.Text != string.Empty)
            {
                using (SqlCeCommand cmd = SQLCe.Query("usp_Accounts_LoadDataIntoDataGridView_Search"))
                {
                    // Passing Parameter
                    cmd.Parameters.AddWithValue("@Filter", "%" + SearchTextBox.Text.Trim() + "%");

                    DataTable dtAccounts = new DataTable();
                    SqlCeDataReader rows = cmd.ExecuteResultSet(ResultSetOptions.Scrollable);
                    if (rows.HasRows)
                    {
                        dtAccounts.Load(rows);
                        accountsDataGridView.DataSource = dtAccounts;
                        rows.Close();
                    }
                    else
                    {
                        MessageBox.Show("No matching records found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a search parameter", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void accountsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (accountsDataGridView.SelectedRows != null && (accountsDataGridView.Rows.Count > 0))
            {
               using(DataGridViewRow row = accountsDataGridView.SelectedRows[0])
                {
                    int id = Convert.ToInt32(row.Cells[0].Value);
                    String username = row.Cells[2].Value.ToString();
                    String password = row.Cells[3].Value.ToString();

                    if (rdCopyPassword.Checked)
                    {
                        try
                        {
                            String password_decrypted = Password.Decrypt(password);
                            Clipboard.SetText(password_decrypted);
                            MessageBox.Show("Password copied to clipboard!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("The password is empty!");
                        }
                    } 
                    else if (rdCopyUsername.Checked)
                    {
                        try
                        {
                            Clipboard.SetText(username.ToString());
                            MessageBox.Show("Username copied to clipboard!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("The password is empty!");
                        }
                    } 
                    else if (rdEdit.Checked) {
                        EditAccountForm edit = new EditAccountForm();
                        edit.AccountId = id;
                        edit.Show();
                        edit.FormClosed += EditAccountForm_FormClosed;
                    }
                    else
                    {
                        MessageBox.Show("Please select a double click functionality.");
                    }

                }  
            }
            else
            {
                MessageBox.Show("No records found.");
            }
        }

        private void EditAccountForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadDataIntoDataGridView();
        }
    }
}
