namespace project_C_
{
    partial class RegisterForm
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
            label2 = new Label();
            label3 = new Label();
            LoginRegisterForm = new Button();
            RegisterRegisterForm = new Button();
            ExitRegisterForm = new Button();
            usernameRegisterForm = new TextBox();
            passwordRegisterForm = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(319, 66);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 0;
            label1.Text = "RegisterForm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 132);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 7;
            label2.Text = "username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(108, 199);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 8;
            label3.Text = "password";
            // 
            // LoginRegisterForm
            // 
            LoginRegisterForm.Location = new Point(522, 282);
            LoginRegisterForm.Name = "LoginRegisterForm";
            LoginRegisterForm.Size = new Size(94, 29);
            LoginRegisterForm.TabIndex = 3;
            LoginRegisterForm.Text = "Login";
            LoginRegisterForm.UseVisualStyleBackColor = true;
            LoginRegisterForm.Click += LoginRegisterForm_Click;
            // 
            // RegisterRegisterForm
            // 
            RegisterRegisterForm.Location = new Point(380, 282);
            RegisterRegisterForm.Name = "RegisterRegisterForm";
            RegisterRegisterForm.Size = new Size(94, 29);
            RegisterRegisterForm.TabIndex = 4;
            RegisterRegisterForm.Text = "Register";
            RegisterRegisterForm.UseVisualStyleBackColor = true;
            RegisterRegisterForm.Click += RegisterRegisterForm_Click;
            // 
            // ExitRegisterForm
            // 
            ExitRegisterForm.Location = new Point(108, 282);
            ExitRegisterForm.Name = "ExitRegisterForm";
            ExitRegisterForm.Size = new Size(94, 29);
            ExitRegisterForm.TabIndex = 6;
            ExitRegisterForm.Text = "Exit";
            ExitRegisterForm.UseVisualStyleBackColor = true;
            ExitRegisterForm.Click += ExitRegisterForm_Click;
            // 
            // usernameRegisterForm
            // 
            usernameRegisterForm.Location = new Point(245, 132);
            usernameRegisterForm.Name = "usernameRegisterForm";
            usernameRegisterForm.Size = new Size(371, 27);
            usernameRegisterForm.TabIndex = 1;
            // 
            // passwordRegisterForm
            // 
            passwordRegisterForm.Location = new Point(245, 199);
            passwordRegisterForm.Name = "passwordRegisterForm";
            passwordRegisterForm.Size = new Size(371, 27);
            passwordRegisterForm.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(245, 282);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(passwordRegisterForm);
            Controls.Add(usernameRegisterForm);
            Controls.Add(ExitRegisterForm);
            Controls.Add(RegisterRegisterForm);
            Controls.Add(LoginRegisterForm);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button LoginRegisterForm;
        private Button RegisterRegisterForm;
        private Button ExitRegisterForm;
        private TextBox usernameRegisterForm;
        private TextBox passwordRegisterForm;
        private Button button1;
    }
}