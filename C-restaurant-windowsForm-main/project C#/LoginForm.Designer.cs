namespace project_C_
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
            loginLoginForm = new Button();
            registerLoginForm = new Button();
            usernameLoginForm = new TextBox();
            passwordLoginForm = new TextBox();
            username = new Label();
            passwordtext = new Label();
            clearLoginForm = new Button();
            ExitLoginForm = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // loginLoginForm
            // 
            loginLoginForm.Location = new Point(513, 269);
            loginLoginForm.Name = "loginLoginForm";
            loginLoginForm.Size = new Size(94, 29);
            loginLoginForm.TabIndex = 2;
            loginLoginForm.Text = "login";
            loginLoginForm.UseVisualStyleBackColor = true;
            loginLoginForm.Click += loginLoginForm_Click;
            // 
            // registerLoginForm
            // 
            registerLoginForm.Location = new Point(377, 269);
            registerLoginForm.Name = "registerLoginForm";
            registerLoginForm.Size = new Size(94, 29);
            registerLoginForm.TabIndex = 3;
            registerLoginForm.Text = "register";
            registerLoginForm.UseVisualStyleBackColor = true;
            registerLoginForm.Click += registerLoginForm_Click;
            // 
            // usernameLoginForm
            // 
            usernameLoginForm.Location = new Point(240, 99);
            usernameLoginForm.Name = "usernameLoginForm";
            usernameLoginForm.Size = new Size(367, 27);
            usernameLoginForm.TabIndex = 0;
            // 
            // passwordLoginForm
            // 
            passwordLoginForm.Location = new Point(240, 164);
            passwordLoginForm.Name = "passwordLoginForm";
            passwordLoginForm.PasswordChar = '*';
            passwordLoginForm.Size = new Size(367, 27);
            passwordLoginForm.TabIndex = 1;
            // 
            // username
            // 
            username.AutoSize = true;
            username.Location = new Point(114, 99);
            username.Name = "username";
            username.Size = new Size(73, 20);
            username.TabIndex = 4;
            username.Text = "username";
            // 
            // passwordtext
            // 
            passwordtext.AutoSize = true;
            passwordtext.Location = new Point(114, 164);
            passwordtext.Name = "passwordtext";
            passwordtext.Size = new Size(72, 20);
            passwordtext.TabIndex = 5;
            passwordtext.Text = "password";
            // 
            // clearLoginForm
            // 
            clearLoginForm.Location = new Point(240, 269);
            clearLoginForm.Name = "clearLoginForm";
            clearLoginForm.Size = new Size(94, 29);
            clearLoginForm.TabIndex = 4;
            clearLoginForm.Text = "clear";
            clearLoginForm.UseVisualStyleBackColor = true;
            clearLoginForm.Click += clearLoginForm_Click;
            // 
            // ExitLoginForm
            // 
            ExitLoginForm.Location = new Point(114, 269);
            ExitLoginForm.Name = "ExitLoginForm";
            ExitLoginForm.Size = new Size(94, 29);
            ExitLoginForm.TabIndex = 5;
            ExitLoginForm.Text = "Exit";
            ExitLoginForm.UseVisualStyleBackColor = true;
            ExitLoginForm.Click += ExitLoginForm_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(346, 36);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 8;
            label3.Text = "Login Form";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(ExitLoginForm);
            Controls.Add(clearLoginForm);
            Controls.Add(passwordtext);
            Controls.Add(username);
            Controls.Add(passwordLoginForm);
            Controls.Add(usernameLoginForm);
            Controls.Add(registerLoginForm);
            Controls.Add(loginLoginForm);
            Name = "LoginForm";
            Text = "Login Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginLoginForm;
        private Button registerLoginForm;
        private TextBox usernameLoginForm;
        private TextBox passwordLoginForm;
        private Label username;
        private Label passwordtext;
        private Button clearLoginForm;
        private Button ExitLoginForm;
        private Label label3;
    }
}