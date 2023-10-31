namespace ToDO_Desktop_App
{
    partial class Register
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
            label1 = new Label();
            UserName = new Label();
            Email = new Label();
            Password = new Label();
            userNameBox = new TextBox();
            PasswordBox = new TextBox();
            EmailBox = new TextBox();
            submit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(347, 9);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "Register";
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.Location = new Point(10, 96);
            UserName.Name = "UserName";
            UserName.Size = new Size(82, 20);
            UserName.TabIndex = 1;
            UserName.Text = "User Name";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(12, 133);
            Email.Name = "Email";
            Email.Size = new Size(46, 20);
            Email.TabIndex = 2;
            Email.Text = "Email";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(12, 168);
            Password.Name = "Password";
            Password.Size = new Size(70, 20);
            Password.TabIndex = 3;
            Password.Text = "Password";
            // 
            // userNameBox
            // 
            userNameBox.Location = new Point(98, 96);
            userNameBox.Name = "userNameBox";
            userNameBox.Size = new Size(276, 27);
            userNameBox.TabIndex = 4;
            userNameBox.TextChanged += userNameBox_TextChanged;
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(98, 168);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(276, 27);
            PasswordBox.TabIndex = 5;
            // 
            // EmailBox
            // 
            EmailBox.Location = new Point(98, 133);
            EmailBox.Name = "EmailBox";
            EmailBox.Size = new Size(276, 27);
            EmailBox.TabIndex = 6;
            // 
            // submit
            // 
            submit.Location = new Point(120, 226);
            submit.Name = "submit";
            submit.Size = new Size(94, 29);
            submit.TabIndex = 7;
            submit.Text = "submit";
            submit.UseVisualStyleBackColor = true;
            submit.Click += submit_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(submit);
            Controls.Add(EmailBox);
            Controls.Add(PasswordBox);
            Controls.Add(userNameBox);
            Controls.Add(Password);
            Controls.Add(Email);
            Controls.Add(UserName);
            Controls.Add(label1);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label UserName;
        private Label Email;
        private Label Password;
        private TextBox userNameBox;
        private TextBox PasswordBox;
        private TextBox EmailBox;
        private Button submit;
    }
}