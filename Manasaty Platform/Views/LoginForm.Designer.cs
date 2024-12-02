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
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Login_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.Sign_up_button = new Guna.UI2.WinForms.Guna2Button();
            this.Login_button = new Guna.UI2.WinForms.Guna2Button();
            this.forget_password_label = new System.Windows.Forms.Label();
            this.Password_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Email_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Exist_ControlBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Minmize_ControlBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.Login_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // Login_panel
            // 
            this.Login_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.Login_panel.Controls.Add(this.Sign_up_button);
            this.Login_panel.Controls.Add(this.Login_button);
            this.Login_panel.Controls.Add(this.forget_password_label);
            this.Login_panel.Controls.Add(this.Password_textbox);
            this.Login_panel.Controls.Add(this.Email_textbox);
            this.Login_panel.Location = new System.Drawing.Point(-2, -3);
            this.Login_panel.Name = "Login_panel";
            this.Login_panel.Size = new System.Drawing.Size(364, 624);
            this.Login_panel.TabIndex = 1;
            // 
            // Sign_up_button
            // 
            this.Sign_up_button.Animated = true;
            this.Sign_up_button.BackColor = System.Drawing.Color.Transparent;
            this.Sign_up_button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.Sign_up_button.BorderRadius = 10;
            this.Sign_up_button.BorderThickness = 2;
            this.Sign_up_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Sign_up_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Sign_up_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Sign_up_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Sign_up_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.Sign_up_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Sign_up_button.ForeColor = System.Drawing.Color.White;
            this.Sign_up_button.HoverState.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Sign_up_button.Location = new System.Drawing.Point(155, 407);
            this.Sign_up_button.Name = "Sign_up_button";
            this.Sign_up_button.Size = new System.Drawing.Size(108, 41);
            this.Sign_up_button.TabIndex = 4;
            this.Sign_up_button.Text = "Sign up";
            this.Sign_up_button.UseTransparentBackground = true;
            this.Sign_up_button.Click += new System.EventHandler(this.Sign_up_button_Click);
            // 
            // Login_button
            // 
            this.Login_button.Animated = true;
            this.Login_button.BackColor = System.Drawing.Color.Transparent;
            this.Login_button.BorderRadius = 10;
            this.Login_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Login_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Login_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Login_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Login_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.Login_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Login_button.ForeColor = System.Drawing.Color.White;
            this.Login_button.HoverState.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Login_button.Location = new System.Drawing.Point(41, 407);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(108, 41);
            this.Login_button.TabIndex = 3;
            this.Login_button.Text = "Login";
            this.Login_button.UseTransparentBackground = true;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // forget_password_label
            // 
            this.forget_password_label.AutoSize = true;
            this.forget_password_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forget_password_label.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forget_password_label.ForeColor = System.Drawing.Color.White;
            this.forget_password_label.Location = new System.Drawing.Point(218, 351);
            this.forget_password_label.Name = "forget_password_label";
            this.forget_password_label.Size = new System.Drawing.Size(93, 13);
            this.forget_password_label.TabIndex = 2;
            this.forget_password_label.Text = "Forget Password";
            // 
            // Password_textbox
            // 
            this.Password_textbox.Animated = true;
            this.Password_textbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.Password_textbox.BorderRadius = 6;
            this.Password_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password_textbox.DefaultText = "";
            this.Password_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Password_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Password_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password_textbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.Password_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Password_textbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Password_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Password_textbox.Location = new System.Drawing.Point(41, 283);
            this.Password_textbox.Name = "Password_textbox";
            this.Password_textbox.PasswordChar = '●';
            this.Password_textbox.PlaceholderText = "Password";
            this.Password_textbox.SelectedText = "";
            this.Password_textbox.Size = new System.Drawing.Size(270, 45);
            this.Password_textbox.TabIndex = 1;
            this.Password_textbox.UseSystemPasswordChar = true;
            // 
            // Email_textbox
            // 
            this.Email_textbox.Animated = true;
            this.Email_textbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.Email_textbox.BorderRadius = 6;
            this.Email_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Email_textbox.DefaultText = "";
            this.Email_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Email_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Email_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Email_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Email_textbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.Email_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Email_textbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Email_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Email_textbox.Location = new System.Drawing.Point(41, 197);
            this.Email_textbox.Name = "Email_textbox";
            this.Email_textbox.PasswordChar = '\0';
            this.Email_textbox.PlaceholderText = "Email";
            this.Email_textbox.SelectedText = "";
            this.Email_textbox.Size = new System.Drawing.Size(270, 45);
            this.Email_textbox.TabIndex = 0;
            // 
            // Exist_ControlBox
            // 
            this.Exist_ControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exist_ControlBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.Exist_ControlBox.HoverState.FillColor = System.Drawing.Color.Red;
            this.Exist_ControlBox.IconColor = System.Drawing.Color.White;
            this.Exist_ControlBox.Location = new System.Drawing.Point(874, 12);
            this.Exist_ControlBox.Name = "Exist_ControlBox";
            this.Exist_ControlBox.Size = new System.Drawing.Size(38, 29);
            this.Exist_ControlBox.TabIndex = 2;
            // 
            // Minmize_ControlBox
            // 
            this.Minmize_ControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minmize_ControlBox.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.Minmize_ControlBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.Minmize_ControlBox.IconColor = System.Drawing.Color.White;
            this.Minmize_ControlBox.Location = new System.Drawing.Point(830, 12);
            this.Minmize_ControlBox.Name = "Minmize_ControlBox";
            this.Minmize_ControlBox.Size = new System.Drawing.Size(38, 29);
            this.Minmize_ControlBox.TabIndex = 3;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.BorderRadius = 6;
            this.guna2ShadowForm1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 620);
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
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel Login_panel;
        private Guna.UI2.WinForms.Guna2TextBox Email_textbox;
        private Guna.UI2.WinForms.Guna2TextBox Password_textbox;
        private System.Windows.Forms.Label forget_password_label;
        private Guna.UI2.WinForms.Guna2Button Login_button;
        private Guna.UI2.WinForms.Guna2Button Sign_up_button;
        private Guna.UI2.WinForms.Guna2ControlBox Minmize_ControlBox;
        private Guna.UI2.WinForms.Guna2ControlBox Exist_ControlBox;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
    }
}