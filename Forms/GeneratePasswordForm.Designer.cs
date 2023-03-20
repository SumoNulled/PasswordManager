namespace PasswordManager.Forms
{
    partial class GeneratePasswordForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.upperCaseCheckBox = new System.Windows.Forms.CheckBox();
            this.lowerCaseCheckBox = new System.Windows.Forms.CheckBox();
            this.numbersCheckBox = new System.Windows.Forms.CheckBox();
            this.symbolsCheckBox = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.generatedPasswordTextBox = new System.Windows.Forms.TextBox();
            this.lengthTrackBar = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.divider = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnPasswordCopy = new System.Windows.Forms.Button();
            this.btnGeneratePassword = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.trackbar_length = new System.Windows.Forms.Label();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lengthTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Key:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(11, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(454, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOTE: This key only controls storing your encrypted passwords in the database. Th" +
    "is does not \r\naffect the generation algorithm.";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Red;
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(13, 393);
            this.panel7.TabIndex = 6;
            this.panel7.Visible = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DarkRed;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(13, 28);
            this.panel8.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.symbolsCheckBox);
            this.panel1.Controls.Add(this.numbersCheckBox);
            this.panel1.Controls.Add(this.lowerCaseCheckBox);
            this.panel1.Controls.Add(this.upperCaseCheckBox);
            this.panel1.Location = new System.Drawing.Point(13, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 38);
            this.panel1.TabIndex = 7;
            // 
            // upperCaseCheckBox
            // 
            this.upperCaseCheckBox.AutoSize = true;
            this.upperCaseCheckBox.Checked = true;
            this.upperCaseCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.upperCaseCheckBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upperCaseCheckBox.Location = new System.Drawing.Point(0, 18);
            this.upperCaseCheckBox.Name = "upperCaseCheckBox";
            this.upperCaseCheckBox.Size = new System.Drawing.Size(143, 17);
            this.upperCaseCheckBox.TabIndex = 0;
            this.upperCaseCheckBox.Text = "Uppercase Letters (A-Z)";
            this.upperCaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // lowerCaseCheckBox
            // 
            this.lowerCaseCheckBox.AutoSize = true;
            this.lowerCaseCheckBox.Checked = true;
            this.lowerCaseCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lowerCaseCheckBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowerCaseCheckBox.Location = new System.Drawing.Point(149, 17);
            this.lowerCaseCheckBox.Name = "lowerCaseCheckBox";
            this.lowerCaseCheckBox.Size = new System.Drawing.Size(140, 17);
            this.lowerCaseCheckBox.TabIndex = 1;
            this.lowerCaseCheckBox.Text = "Lowercase Letters (a-z)";
            this.lowerCaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // numbersCheckBox
            // 
            this.numbersCheckBox.AutoSize = true;
            this.numbersCheckBox.Checked = true;
            this.numbersCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.numbersCheckBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numbersCheckBox.Location = new System.Drawing.Point(295, 17);
            this.numbersCheckBox.Name = "numbersCheckBox";
            this.numbersCheckBox.Size = new System.Drawing.Size(97, 17);
            this.numbersCheckBox.TabIndex = 2;
            this.numbersCheckBox.Text = "Numbers (0-9)";
            this.numbersCheckBox.UseVisualStyleBackColor = true;
            // 
            // symbolsCheckBox
            // 
            this.symbolsCheckBox.AutoSize = true;
            this.symbolsCheckBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symbolsCheckBox.Location = new System.Drawing.Point(398, 17);
            this.symbolsCheckBox.Name = "symbolsCheckBox";
            this.symbolsCheckBox.Size = new System.Drawing.Size(68, 17);
            this.symbolsCheckBox.TabIndex = 3;
            this.symbolsCheckBox.Text = "Symbols";
            this.symbolsCheckBox.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(476, 30);
            this.panel2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-5, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Customize Your Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // keyTextBox
            // 
            this.keyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keyTextBox.Location = new System.Drawing.Point(62, 28);
            this.keyTextBox.MaxLength = 100;
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.ReadOnly = true;
            this.keyTextBox.Size = new System.Drawing.Size(426, 20);
            this.keyTextBox.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(13, 295);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(474, 30);
            this.panel3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Generated Password";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // generatedPasswordTextBox
            // 
            this.generatedPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generatedPasswordTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.generatedPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatedPasswordTextBox.Location = new System.Drawing.Point(12, 332);
            this.generatedPasswordTextBox.Name = "generatedPasswordTextBox";
            this.generatedPasswordTextBox.ReadOnly = true;
            this.generatedPasswordTextBox.Size = new System.Drawing.Size(476, 22);
            this.generatedPasswordTextBox.TabIndex = 10;
            this.generatedPasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lengthTrackBar
            // 
            this.lengthTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lengthTrackBar.Location = new System.Drawing.Point(13, 195);
            this.lengthTrackBar.Maximum = 100;
            this.lengthTrackBar.Minimum = 8;
            this.lengthTrackBar.Name = "lengthTrackBar";
            this.lengthTrackBar.Size = new System.Drawing.Size(473, 45);
            this.lengthTrackBar.TabIndex = 11;
            this.lengthTrackBar.TickFrequency = 2;
            this.lengthTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.lengthTrackBar.Value = 15;
            this.lengthTrackBar.Scroll += new System.EventHandler(this.lengthTrackBar_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Length:";
            // 
            // divider
            // 
            this.divider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.divider.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.divider.Location = new System.Drawing.Point(13, 276);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(475, 1);
            this.divider.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel4.Location = new System.Drawing.Point(13, 91);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(475, 1);
            this.panel4.TabIndex = 14;
            // 
            // btnPasswordCopy
            // 
            this.btnPasswordCopy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPasswordCopy.Location = new System.Drawing.Point(12, 361);
            this.btnPasswordCopy.Name = "btnPasswordCopy";
            this.btnPasswordCopy.Size = new System.Drawing.Size(476, 23);
            this.btnPasswordCopy.TabIndex = 15;
            this.btnPasswordCopy.Text = "Copy to Clipboard";
            this.btnPasswordCopy.UseVisualStyleBackColor = true;
            this.btnPasswordCopy.Click += new System.EventHandler(this.btnPasswordCopy_Click);
            // 
            // btnGeneratePassword
            // 
            this.btnGeneratePassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGeneratePassword.Location = new System.Drawing.Point(12, 235);
            this.btnGeneratePassword.Name = "btnGeneratePassword";
            this.btnGeneratePassword.Size = new System.Drawing.Size(476, 23);
            this.btnGeneratePassword.TabIndex = 16;
            this.btnGeneratePassword.Text = "Generate";
            this.btnGeneratePassword.UseVisualStyleBackColor = true;
            this.btnGeneratePassword.Click += new System.EventHandler(this.btnGeneratePassword_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ShowAlways = true;
            // 
            // trackbar_length
            // 
            this.trackbar_length.AutoSize = true;
            this.trackbar_length.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackbar_length.Location = new System.Drawing.Point(55, 177);
            this.trackbar_length.Name = "trackbar_length";
            this.trackbar_length.Size = new System.Drawing.Size(81, 13);
            this.trackbar_length.TabIndex = 17;
            this.trackbar_length.Text = "trackbar_length";
            // 
            // GeneratePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 393);
            this.Controls.Add(this.trackbar_length);
            this.Controls.Add(this.btnGeneratePassword);
            this.Controls.Add(this.btnPasswordCopy);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.divider);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lengthTrackBar);
            this.Controls.Add(this.generatedPasswordTextBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GeneratePasswordForm";
            this.Text = "Generate Password";
            this.Load += new System.EventHandler(this.GeneratePasswordForm_Load);
            this.panel7.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lengthTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox lowerCaseCheckBox;
        private System.Windows.Forms.CheckBox upperCaseCheckBox;
        private System.Windows.Forms.CheckBox numbersCheckBox;
        private System.Windows.Forms.CheckBox symbolsCheckBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox generatedPasswordTextBox;
        private System.Windows.Forms.TrackBar lengthTrackBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel divider;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnPasswordCopy;
        private System.Windows.Forms.Button btnGeneratePassword;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label trackbar_length;
    }
}