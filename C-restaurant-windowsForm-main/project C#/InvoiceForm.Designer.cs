namespace project_C_
{
    partial class InvoiceForm
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
            lstOrders = new ListBox();
            CustomerName = new TextBox();
            lbcustomerName = new Label();
            search = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lstOrders
            // 
            lstOrders.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lstOrders.FormattingEnabled = true;
            lstOrders.Location = new Point(12, 154);
            lstOrders.Name = "lstOrders";
            lstOrders.Size = new Size(776, 224);
            lstOrders.TabIndex = 0;
            // 
            // CustomerName
            // 
            CustomerName.Location = new Point(222, 65);
            CustomerName.Name = "CustomerName";
            CustomerName.Size = new Size(125, 27);
            CustomerName.TabIndex = 0;
            // 
            // lbcustomerName
            // 
            lbcustomerName.AutoSize = true;
            lbcustomerName.Location = new Point(59, 65);
            lbcustomerName.Name = "lbcustomerName";
            lbcustomerName.Size = new Size(82, 20);
            lbcustomerName.TabIndex = 2;
            lbcustomerName.Text = "اسم مشتری";
            // 
            // search
            // 
            search.Location = new Point(400, 64);
            search.Name = "search";
            search.Size = new Size(94, 29);
            search.TabIndex = 1;
            search.Text = "جستجو";
            search.UseVisualStyleBackColor = true;
            search.Click += search_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(652, 68);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 3;
            label1.Text = "تعداد سفارش ها ";
            label1.Click += label1_Click;
            // 
            // InvoiceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(search);
            Controls.Add(lbcustomerName);
            Controls.Add(CustomerName);
            Controls.Add(lstOrders);
            Name = "InvoiceForm";
            Text = "گزارش مشتری";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstOrders;
        private TextBox CustomerName;
        private Label lbcustomerName;
        private Button search;
        private Label label1;
    }
}