namespace project_C_
{
    partial class CustomerDefinitionForm
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
            address = new Label();
            username = new Label();
            nameCustomerForm = new TextBox();
            addressCustomerForm = new TextBox();
            saveCreateCustomer = new Button();
            phoneCustomerForm = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // address
            // 
            address.AutoSize = true;
            address.Location = new Point(98, 161);
            address.Name = "address";
            address.Size = new Size(44, 20);
            address.TabIndex = 0;
            address.Text = "ادرس";
            // 
            // username
            // 
            username.AutoSize = true;
            username.Location = new Point(115, 93);
            username.Name = "username";
            username.Size = new Size(27, 20);
            username.TabIndex = 1;
            username.Text = "نام";
            username.Click += username_Click;
            // 
            // nameCustomerForm
            // 
            nameCustomerForm.Location = new Point(219, 90);
            nameCustomerForm.Name = "nameCustomerForm";
            nameCustomerForm.Size = new Size(205, 27);
            nameCustomerForm.TabIndex = 0;
            // 
            // addressCustomerForm
            // 
            addressCustomerForm.Location = new Point(219, 158);
            addressCustomerForm.Name = "addressCustomerForm";
            addressCustomerForm.Size = new Size(205, 27);
            addressCustomerForm.TabIndex = 1;
            // 
            // saveCreateCustomer
            // 
            saveCreateCustomer.Location = new Point(505, 225);
            saveCreateCustomer.Name = "saveCreateCustomer";
            saveCreateCustomer.Size = new Size(207, 29);
            saveCreateCustomer.TabIndex = 3;
            saveCreateCustomer.Text = "ذخیره ی اطلاعات";
            saveCreateCustomer.UseVisualStyleBackColor = true;
            saveCreateCustomer.Click += saveCreateCustomer_Click;
            // 
            // phoneCustomerForm
            // 
            phoneCustomerForm.Location = new Point(219, 225);
            phoneCustomerForm.Name = "phoneCustomerForm";
            phoneCustomerForm.Size = new Size(205, 27);
            phoneCustomerForm.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 228);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 6;
            label2.Text = "شماره تلفن";
            // 
            // CustomerDefinitionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(phoneCustomerForm);
            Controls.Add(label2);
            Controls.Add(saveCreateCustomer);
            Controls.Add(addressCustomerForm);
            Controls.Add(nameCustomerForm);
            Controls.Add(username);
            Controls.Add(address);
            Name = "CustomerDefinitionForm";
            Text = "تعریف مشتری ها ";
            Load += CustomerDefinitionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label address;
        private Label username;
        private TextBox nameCustomerForm;
        private TextBox addressCustomerForm;
        private Button saveCreateCustomer;
        private TextBox phoneCustomerForm;
        private Label label2;
    }
}