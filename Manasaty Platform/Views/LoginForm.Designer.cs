namespace Manasaty_Platform.Views
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.Login_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.signUpButton = new Guna.UI2.WinForms.Guna2Button();
            this.loginButton = new Guna.UI2.WinForms.Guna2Button();
            this.forgetPasswordLabel = new System.Windows.Forms.Label();
            this.passwordTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.emailTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Minmize_ControlBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Exist_ControlBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Login_panel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Login_panel
            // 
            this.Login_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(14)))), ((int)(((byte)(44)))));
            this.Login_panel.Controls.Add(this.signUpButton);
            this.Login_panel.Controls.Add(this.loginButton);
            this.Login_panel.Controls.Add(this.forgetPasswordLabel);
            this.Login_panel.Controls.Add(this.passwordTextbox);
            this.Login_panel.Controls.Add(this.emailTextbox);
            this.Login_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.Login_panel.Location = new System.Drawing.Point(679, 0);
            this.Login_panel.Name = "Login_panel";
            this.Login_panel.Size = new System.Drawing.Size(374, 620);
            this.Login_panel.TabIndex = 1;
            // 
            // signUpButton
            // 
            this.signUpButton.Animated = true;
            this.signUpButton.BackColor = System.Drawing.Color.Transparent;
            this.signUpButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.signUpButton.BorderRadius = 10;
            this.signUpButton.BorderThickness = 2;
            this.signUpButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.signUpButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.signUpButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signUpButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.signUpButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.signUpButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.signUpButton.ForeColor = System.Drawing.Color.White;
            this.signUpButton.HoverState.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.signUpButton.Location = new System.Drawing.Point(47, 452);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(270, 41);
            this.signUpButton.TabIndex = 4;
            this.signUpButton.Text = "Sign up";
            this.signUpButton.UseTransparentBackground = true;
            this.signUpButton.Click += new System.EventHandler(this.Sign_up_button_Click);
            // 
            // loginButton
            // 
            this.loginButton.Animated = true;
            this.loginButton.BackColor = System.Drawing.Color.Transparent;
            this.loginButton.BorderRadius = 10;
            this.loginButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.loginButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.loginButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loginButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.loginButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.HoverState.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.loginButton.Location = new System.Drawing.Point(47, 390);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(270, 41);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.UseTransparentBackground = true;
            this.loginButton.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // forgetPasswordLabel
            // 
            this.forgetPasswordLabel.AutoSize = true;
            this.forgetPasswordLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forgetPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgetPasswordLabel.ForeColor = System.Drawing.Color.White;
            this.forgetPasswordLabel.Location = new System.Drawing.Point(226, 283);
            this.forgetPasswordLabel.Name = "forgetPasswordLabel";
            this.forgetPasswordLabel.Size = new System.Drawing.Size(93, 13);
            this.forgetPasswordLabel.TabIndex = 2;
            this.forgetPasswordLabel.Text = "Forget Password";
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Animated = true;
            this.passwordTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.passwordTextbox.BorderRadius = 6;
            this.passwordTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTextbox.DefaultText = "";
            this.passwordTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTextbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.passwordTextbox.FocusedState.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.passwordTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwordTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTextbox.Location = new System.Drawing.Point(49, 215);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '●';
            this.passwordTextbox.PlaceholderText = "Password";
            this.passwordTextbox.SelectedText = "";
            this.passwordTextbox.Size = new System.Drawing.Size(270, 45);
            this.passwordTextbox.TabIndex = 1;
            this.passwordTextbox.UseSystemPasswordChar = true;
            // 
            // emailTextbox
            // 
            this.emailTextbox.Animated = true;
            this.emailTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.emailTextbox.BorderRadius = 6;
            this.emailTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTextbox.DefaultText = "";
            this.emailTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTextbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.emailTextbox.FocusedState.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.emailTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emailTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTextbox.Location = new System.Drawing.Point(49, 129);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.PasswordChar = '\0';
            this.emailTextbox.PlaceholderText = "Email";
            this.emailTextbox.SelectedText = "";
            this.emailTextbox.Size = new System.Drawing.Size(270, 45);
            this.emailTextbox.TabIndex = 0;
            // 
            // Minmize_ControlBox
            // 
            this.Minmize_ControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minmize_ControlBox.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.Minmize_ControlBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.Minmize_ControlBox.HoverState.FillColor = System.Drawing.Color.Silver;
            this.Minmize_ControlBox.IconColor = System.Drawing.Color.White;
            this.Minmize_ControlBox.Location = new System.Drawing.Point(976, 0);
            this.Minmize_ControlBox.Name = "Minmize_ControlBox";
            this.Minmize_ControlBox.Size = new System.Drawing.Size(38, 29);
            this.Minmize_ControlBox.TabIndex = 6;
            // 
            // Exist_ControlBox
            // 
            this.Exist_ControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exist_ControlBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.Exist_ControlBox.HoverState.FillColor = System.Drawing.Color.Red;
            this.Exist_ControlBox.IconColor = System.Drawing.Color.White;
            this.Exist_ControlBox.Location = new System.Drawing.Point(1014, 0);
            this.Exist_ControlBox.Name = "Exist_ControlBox";
            this.Exist_ControlBox.Size = new System.Drawing.Size(38, 29);
            this.Exist_ControlBox.TabIndex = 5;
            this.Exist_ControlBox.Click += new System.EventHandler(this.Exist_ControlBox_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(679, 620);
            this.guna2Panel1.TabIndex = 7;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Black;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(679, 620);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 620);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.Minmize_ControlBox);
            this.Controls.Add(this.Exist_ControlBox);
            this.Controls.Add(this.Login_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.Login_panel.ResumeLayout(false);
            this.Login_panel.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel Login_panel;
        private Guna.UI2.WinForms.Guna2TextBox emailTextbox;
        private Guna.UI2.WinForms.Guna2TextBox passwordTextbox;
        private System.Windows.Forms.Label forgetPasswordLabel;
        private Guna.UI2.WinForms.Guna2Button loginButton;
        private Guna.UI2.WinForms.Guna2Button signUpButton;
        private Guna.UI2.WinForms.Guna2ControlBox Minmize_ControlBox;
        private Guna.UI2.WinForms.Guna2ControlBox Exist_ControlBox;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}