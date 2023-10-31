namespace ToDO_Desktop_App
{
    partial class Home
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
            Register = new Button();
            Login = new Button();
            Welcome = new Label();
            SuspendLayout();
            // 
            // Register
            // 
            Register.Location = new Point(706, 3);
            Register.Name = "Register";
            Register.Size = new Size(94, 29);
            Register.TabIndex = 0;
            Register.Text = "Register";
            Register.UseVisualStyleBackColor = true;
            Register.Click += Register_Click;
            // 
            // Login
            // 
            Login.Location = new Point(606, 3);
            Login.Name = "Login";
            Login.Size = new Size(94, 29);
            Login.TabIndex = 1;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = true;
            Login.Click += Login_Click;
            // 
            // Welcome
            // 
            Welcome.AutoSize = true;
            Welcome.Location = new Point(279, 203);
            Welcome.Name = "Welcome";
            Welcome.Size = new Size(131, 20);
            Welcome.TabIndex = 2;
            Welcome.Text = "Welcome to ToDO";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Welcome);
            Controls.Add(Login);
            Controls.Add(Register);
            Name = "Home";
            Text = "Home";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Register;
        private Button Login;
        private Label Welcome;
    }
}