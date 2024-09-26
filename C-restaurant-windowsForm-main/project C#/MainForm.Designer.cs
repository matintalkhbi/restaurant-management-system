namespace project_C_
{
    partial class MainForm
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
            label1 = new Label();
            loginmainform = new Button();
            signinmainform = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(307, 101);
            label1.Name = "label1";
            label1.Size = new Size(162, 20);
            label1.TabIndex = 2;
            label1.Text = "welcome to my project";
            // 
            // loginmainform
            // 
            loginmainform.Location = new Point(333, 207);
            loginmainform.Name = "loginmainform";
            loginmainform.Size = new Size(94, 29);
            loginmainform.TabIndex = 0;
            loginmainform.Text = "login";
            loginmainform.UseVisualStyleBackColor = true;
            loginmainform.Click += loginmainform_Click;
            // 
            // signinmainform
            // 
            signinmainform.Location = new Point(333, 273);
            signinmainform.Name = "signinmainform";
            signinmainform.Size = new Size(94, 29);
            signinmainform.TabIndex = 1;
            signinmainform.Text = "signin";
            signinmainform.TextImageRelation = TextImageRelation.ImageBeforeText;
            signinmainform.UseVisualStyleBackColor = true;
            signinmainform.Click += signinmainform_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(signinmainform);
            Controls.Add(loginmainform);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "Main Form";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button loginmainform;
        private Button signinmainform;
    }
}
