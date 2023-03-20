using PasswordManager.Classes.Database;
using System;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PasswordManager.Forms
{
    public partial class MainForm : Form
    {
        private Form currentForm;
        public MainForm()
        {
            InitializeComponent();
            this.Refresh();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            switch (WindowState)
            {
                case FormWindowState.Maximized:
                    WindowState = FormWindowState.Normal;
                    break;

                default:
                    WindowState = FormWindowState.Maximized;
                    break;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            switch (WindowState)
            {
                default:
                    WindowState = FormWindowState.Minimized;
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void renderForm(Form form)
        {
            if (currentForm != null)
            {
                currentForm.Close();
                currentForm = null;
            }
            currentForm = form;

            formTitle.Text = form.Text;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.BringToFront();

            panelContainer.Controls.Add(form);
            panelContainer.Tag = form;

            form.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            int[] primary = { 138, 212, 255 };
            int[] secondary = { 118, 182, 219 };
            int[] triploary = { 178, 214, 235 };

            var prim = System.Drawing.Color.FromArgb(primary[0], primary[1], primary[2]);
            var sec = System.Drawing.Color.FromArgb(secondary[0], secondary[1], secondary[2]);
            var trip = System.Drawing.Color.FromArgb(triploary[0], triploary[1], triploary[2]);

            panelLogo.BackColor = prim;
            panelLogoShadow.BackColor = sec;

            panelFormTitle.BackColor = prim;
            panelFormTitleShadow.BackColor = sec;

            panelFormLogoBridge.BackColor = prim;
            panelFormLogoBridgeShadow.BackColor = sec;

            panelFormLogoTitleBridge.BackColor = trip;
            renderForm(new DashboardForm());
        }



        private void button3_Click(object sender, EventArgs e)
        {
            renderForm(new GeneratePasswordForm());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            renderForm(new DashboardForm());
        }

        private void btnResetDatabase_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to permanently reset the database? All data is stored locally, the developer will not be able to assist in data recovery.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            switch (dialog)
            {
                case DialogResult.Yes:
                    using (SqlCeCommand cmd = SQLCe.Query("usp_Accounts_Reset"))
                    {
                        cmd.ExecuteNonQuery();
                        SQLCe.Query("usp_Generated_Passwords_Reset").ExecuteNonQuery();
                        SQLCe.Query("usp_Users_Reset").ExecuteNonQuery();
                        Application.Restart();
                        Environment.Exit(1);
                    }

                    break;
            }
        }

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            renderForm(new DashboardForm());
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            renderForm(new GeneratePasswordForm());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            renderForm(new DashboardForm());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            renderForm(new AddAccountForm());
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.Image = Properties.Resources.close_hover;
            btnClose.FlatAppearance.MouseOverBackColor = Color.IndianRed;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.Image = Properties.Resources.close;
            btnClose.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            switch (WindowState)
            {
                case FormWindowState.Maximized:
                    btnMaximize.Image = Properties.Resources.restore_down;
                    break;

                default:
                    btnMaximize.Image = Properties.Resources.maximize;
                    break;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            renderForm(new ViewAccountsForm());
        }
    }
}
