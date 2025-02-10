namespace EduInst.PL
{
    partial class loginForm
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
            loginTxbUsername = new TextBox();
            loginTxbPassword = new TextBox();
            loginLblUsername = new Label();
            loginLblPassword = new Label();
            loginLblLogin = new Label();
            label1 = new Label();
            loginBtnSingIn = new CustomControls.RoundButton();
            loginLblForgotPass = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // loginTxbUsername
            // 
            loginTxbUsername.Font = new Font("SF Pro Display", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginTxbUsername.Location = new Point(10, 195);
            loginTxbUsername.Name = "loginTxbUsername";
            loginTxbUsername.PlaceholderText = "Username";
            loginTxbUsername.Size = new Size(410, 23);
            loginTxbUsername.TabIndex = 1;
            // 
            // loginTxbPassword
            // 
            loginTxbPassword.Font = new Font("SF Pro Display", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginTxbPassword.Location = new Point(10, 248);
            loginTxbPassword.Name = "loginTxbPassword";
            loginTxbPassword.PlaceholderText = "Password";
            loginTxbPassword.Size = new Size(410, 23);
            loginTxbPassword.TabIndex = 2;
            // 
            // loginLblUsername
            // 
            loginLblUsername.AutoSize = true;
            loginLblUsername.BackColor = Color.Transparent;
            loginLblUsername.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginLblUsername.ForeColor = SystemColors.ControlDarkDark;
            loginLblUsername.Location = new Point(10, 173);
            loginLblUsername.Name = "loginLblUsername";
            loginLblUsername.Size = new Size(84, 19);
            loginLblUsername.TabIndex = 1;
            loginLblUsername.Text = "Username";
            // 
            // loginLblPassword
            // 
            loginLblPassword.AutoSize = true;
            loginLblPassword.BackColor = Color.Transparent;
            loginLblPassword.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginLblPassword.ForeColor = SystemColors.ControlDarkDark;
            loginLblPassword.Location = new Point(10, 226);
            loginLblPassword.Name = "loginLblPassword";
            loginLblPassword.Size = new Size(81, 19);
            loginLblPassword.TabIndex = 1;
            loginLblPassword.Text = "Password";
            // 
            // loginLblLogin
            // 
            loginLblLogin.AutoSize = true;
            loginLblLogin.Font = new Font("SF Pro Display", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginLblLogin.Location = new Point(95, 86);
            loginLblLogin.Name = "loginLblLogin";
            loginLblLogin.Size = new Size(256, 29);
            loginLblLogin.TabIndex = 2;
            loginLblLogin.Text = "Login to your Account";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Pro Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(130, 115);
            label1.Name = "label1";
            label1.Size = new Size(180, 48);
            label1.TabIndex = 3;
            label1.Text = "Get started with our app, just\r\nlogin to existing account\r\nand enjoy the experience.\r\n";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // loginBtnSingIn
            // 
            loginBtnSingIn.BackColor = Color.DodgerBlue;
            loginBtnSingIn.BorderColor = Color.FromArgb(94, 129, 244);
            loginBtnSingIn.BorderRadius = 40;
            loginBtnSingIn.BorderSize = 0;
            loginBtnSingIn.FlatAppearance.BorderSize = 0;
            loginBtnSingIn.FlatStyle = FlatStyle.Flat;
            loginBtnSingIn.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginBtnSingIn.ForeColor = Color.White;
            loginBtnSingIn.Location = new Point(10, 306);
            loginBtnSingIn.Name = "loginBtnSingIn";
            loginBtnSingIn.Size = new Size(410, 40);
            loginBtnSingIn.TabIndex = 3;
            loginBtnSingIn.Text = "Sign in";
            loginBtnSingIn.UseVisualStyleBackColor = false;
            loginBtnSingIn.Click += loginBtnSingIn_Click;
            // 
            // loginLblForgotPass
            // 
            loginLblForgotPass.AutoSize = true;
            loginLblForgotPass.Font = new Font("SF Pro Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginLblForgotPass.ForeColor = Color.DodgerBlue;
            loginLblForgotPass.Location = new Point(305, 274);
            loginLblForgotPass.Name = "loginLblForgotPass";
            loginLblForgotPass.Size = new Size(115, 16);
            loginLblForgotPass.TabIndex = 6;
            loginLblForgotPass.Text = "Forgot password?";
            loginLblForgotPass.Click += loginLblForgotPass_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(190, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 247, 251);
            ClientSize = new Size(434, 361);
            Controls.Add(pictureBox1);
            Controls.Add(loginLblForgotPass);
            Controls.Add(loginBtnSingIn);
            Controls.Add(label1);
            Controls.Add(loginLblLogin);
            Controls.Add(loginLblPassword);
            Controls.Add(loginLblUsername);
            Controls.Add(loginTxbPassword);
            Controls.Add(loginTxbUsername);
            Name = "loginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign In";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox loginTxbUsername;
        private TextBox loginTxbPassword;
        private Label loginLblUsername;
        private Label loginLblPassword;
        private Label loginLblLogin;
        private Label label1;
        private CustomControls.RoundButton loginBtnSingIn;
        private Label loginLblForgotPass;
        private PictureBox pictureBox1;
    }
}