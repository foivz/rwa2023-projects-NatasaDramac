namespace Teretana
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblKorisnickoime = new Label();
            lblLozinka = new Label();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(260, 92);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(303, 27);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(261, 168);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(306, 27);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += textBox2_TextChanged;
            // 
            // lblKorisnickoime
            // 
            lblKorisnickoime.AutoSize = true;
            lblKorisnickoime.Location = new Point(87, 92);
            lblKorisnickoime.Name = "lblKorisnickoime";
            lblKorisnickoime.Size = new Size(109, 20);
            lblKorisnickoime.TabIndex = 0;
            lblKorisnickoime.Text = "Korisničko ime:";
            // 
            // lblLozinka
            // 
            lblLozinka.AutoSize = true;
            lblLozinka.Location = new Point(87, 175);
            lblLozinka.Name = "lblLozinka";
            lblLozinka.Size = new Size(62, 20);
            lblLozinka.TabIndex = 1;
            lblLozinka.Text = "Lozinka:";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(417, 270);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(149, 48);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Prijavi se";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += button1_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 364);
            Controls.Add(btnLogin);
            Controls.Add(lblLozinka);
            Controls.Add(lblKorisnickoime);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Prijava u sustav teretane Strong Man";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblKorisnickoime;
        private Label lblLozinka;
        private Button btnLogin;
    }
}