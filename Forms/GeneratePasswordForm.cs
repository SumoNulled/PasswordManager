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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PasswordManager.Forms
{
    public partial class GeneratePasswordForm : Form
    {
        public GeneratePasswordForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String password;
            password = "password~";
            password = Password.Encrypt(password);

            String[][] parameters = {
                new string[]{"@service", "theoldmountain.com" },
                new string[]{"@password", password }
            };

            using (SqlCeCommand cmd = SQLCe.Query("usp_Generated_Passwords_Insert", parameters))
            {
                cmd.ExecuteNonQuery();
            }
        }

        private void GeneratePasswordForm_Load(object sender, EventArgs e)
        {
            keyTextBox.Text = Password.GetKey();
            trackbar_length.Text = lengthTrackBar.Value.ToString();
        }

        private void btnPasswordCopy_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(generatedPasswordTextBox.Text);
                MessageBox.Show("Password copied to clipboard!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex)
            {
                MessageBox.Show("The generated password box is empty!");
            }
        }

        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            String gen = Password.Generate(
               lengthTrackBar.Value,
               upperCaseCheckBox.Checked,
               lowerCaseCheckBox.Checked,
               numbersCheckBox.Checked,
               symbolsCheckBox.Checked
               );
            generatedPasswordTextBox.Text = gen;

            gen = Password.Encrypt(gen);

            String[][] parameters = {
                new string[]{"@service", "theoldmountain.com" },
                new string[]{"@password", gen }
            };

            using (SqlCeCommand cmd = SQLCe.Query("usp_Generated_Passwords_Insert", parameters))
            {
                cmd.ExecuteNonQuery();
            }
        }

        private void lengthTrackBar_Scroll(object sender, EventArgs e)
        {
            //toolTip1.SetToolTip(lengthTrackBar, lengthTrackBar.Value.ToString());
            trackbar_length.Text = lengthTrackBar.Value.ToString();
        }
    }
}
