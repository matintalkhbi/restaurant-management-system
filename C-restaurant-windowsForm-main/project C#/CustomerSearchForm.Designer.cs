namespace project_C_
{
    partial class CustomerSearchForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            addressCustomerSearchForm = new Label();
            phoneCustomerSearchForm = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            userSearchSearchForm = new TextBox();
            newnameSearchForm = new TextBox();
            newaddressSearchForm = new TextBox();
            newphoneSearchForm = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            saveCustomerCusromerForm = new Button();
            button2 = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 88);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 0;
            label1.Text = "شماره تلفن مشتری";
            // 
            // addressCustomerSearchForm
            // 
            addressCustomerSearchForm.AutoSize = true;
            addressCustomerSearchForm.Location = new Point(557, 48);
            addressCustomerSearchForm.Name = "addressCustomerSearchForm";
            addressCustomerSearchForm.Size = new Size(74, 20);
            addressCustomerSearchForm.TabIndex = 1;
            addressCustomerSearchForm.Text = "نام مشتری";
            // 
            // phoneCustomerSearchForm
            // 
            phoneCustomerSearchForm.AutoSize = true;
            phoneCustomerSearchForm.Location = new Point(557, 95);
            phoneCustomerSearchForm.Name = "phoneCustomerSearchForm";
            phoneCustomerSearchForm.Size = new Size(91, 20);
            phoneCustomerSearchForm.TabIndex = 2;
            phoneCustomerSearchForm.Text = "ادرس مشتری";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // userSearchSearchForm
            // 
            userSearchSearchForm.Location = new Point(226, 88);
            userSearchSearchForm.Name = "userSearchSearchForm";
            userSearchSearchForm.Size = new Size(125, 27);
            userSearchSearchForm.TabIndex = 0;
            // 
            // newnameSearchForm
            // 
            newnameSearchForm.Location = new Point(226, 229);
            newnameSearchForm.Name = "newnameSearchForm";
            newnameSearchForm.Size = new Size(125, 27);
            newnameSearchForm.TabIndex = 3;
            // 
            // newaddressSearchForm
            // 
            newaddressSearchForm.Location = new Point(226, 293);
            newaddressSearchForm.Name = "newaddressSearchForm";
            newaddressSearchForm.Size = new Size(125, 27);
            newaddressSearchForm.TabIndex = 4;
            newaddressSearchForm.TextChanged += textBox2_TextChanged;
            // 
            // newphoneSearchForm
            // 
            newphoneSearchForm.Location = new Point(226, 356);
            newphoneSearchForm.Name = "newphoneSearchForm";
            newphoneSearchForm.Size = new Size(125, 27);
            newphoneSearchForm.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 236);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 8;
            label2.Text = "اسم جدید";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 359);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 9;
            label3.Text = "شماره تلفن جدید";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 300);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 10;
            label4.Text = "ادرس جدید";
            // 
            // button1
            // 
            button1.Location = new Point(537, 144);
            button1.Name = "button1";
            button1.Size = new Size(170, 29);
            button1.TabIndex = 1;
            button1.Text = "سرچ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // saveCustomerCusromerForm
            // 
            saveCustomerCusromerForm.Location = new Point(535, 350);
            saveCustomerCusromerForm.Name = "saveCustomerCusromerForm";
            saveCustomerCusromerForm.Size = new Size(170, 29);
            saveCustomerCusromerForm.TabIndex = 6;
            saveCustomerCusromerForm.Text = "ذخیره ی اطلاعات";
            saveCustomerCusromerForm.UseVisualStyleBackColor = true;
            saveCustomerCusromerForm.Click += saveCustomerCusromerForm_Click;
            // 
            // button2
            // 
            button2.Location = new Point(537, 203);
            button2.Name = "button2";
            button2.Size = new Size(171, 27);
            button2.TabIndex = 2;
            button2.Text = "حذف";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(294, 9);
            label5.Name = "label5";
            label5.Size = new Size(148, 20);
            label5.TabIndex = 14;
            label5.Text = "جستجو و حذف مشتری";
            // 
            // CustomerSearchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(saveCustomerCusromerForm);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(newphoneSearchForm);
            Controls.Add(newaddressSearchForm);
            Controls.Add(newnameSearchForm);
            Controls.Add(userSearchSearchForm);
            Controls.Add(phoneCustomerSearchForm);
            Controls.Add(addressCustomerSearchForm);
            Controls.Add(label1);
            Name = "CustomerSearchForm";
            Text = "search and delete customers";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label addressCustomerSearchForm;
        private Label phoneCustomerSearchForm;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox userSearchSearchForm;
        private TextBox newnameSearchForm;
        private TextBox newaddressSearchForm;
        private TextBox newphoneSearchForm;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button saveCustomerCusromerForm;
        private Button deleteFood;
        private Button button2;
        private Label label5;
    }
}