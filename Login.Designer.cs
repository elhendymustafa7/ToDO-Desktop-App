namespace ToDO_Desktop_App
{
    partial class Login
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
            LoginLabel = new Label();
            Email = new Label();
            Password = new Label();
            EmailBox = new TextBox();
            PasswordBox = new TextBox();
            submit = new Button();
            Register = new Button();
            SuspendLayout();
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Location = new Point(325, 9);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(46, 20);
            LoginLabel.TabIndex = 0;
            LoginLabel.Text = "Login";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(37, 113);
            Email.Name = "Email";
            Email.Size = new Size(46, 20);
            Email.TabIndex = 1;
            Email.Text = "Email";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(37, 159);
            Password.Name = "Password";
            Password.Size = new Size(70, 20);
            Password.TabIndex = 2;
            Password.Text = "Password";
            // 
            // EmailBox
            // 
            EmailBox.Location = new Point(126, 113);
            EmailBox.Name = "EmailBox";
            EmailBox.Size = new Size(227, 27);
            EmailBox.TabIndex = 3;
            EmailBox.TextChanged += EmailBox_TextChanged;
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(126, 159);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(227, 27);
            PasswordBox.TabIndex = 4;
            // 
            // submit
            // 
            submit.Location = new Point(126, 223);
            submit.Name = "submit";
            submit.Size = new Size(94, 29);
            submit.TabIndex = 5;
            submit.Text = "submit";
            submit.UseVisualStyleBackColor = true;
            submit.Click += submit_Click;
            // 
            // Register
            // 
            Register.Location = new Point(259, 223);
            Register.Name = "Register";
            Register.Size = new Size(94, 29);
            Register.TabIndex = 6;
            Register.Text = "Register";
            Register.UseVisualStyleBackColor = true;
            Register.Click += Register_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Register);
            Controls.Add(submit);
            Controls.Add(PasswordBox);
            Controls.Add(EmailBox);
            Controls.Add(Password);
            Controls.Add(Email);
            Controls.Add(LoginLabel);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LoginLabel;
        private Label Email;
        private Label Password;
        private TextBox EmailBox;
        private TextBox PasswordBox;
        private Button submit;
        private Button Register;
    }
}