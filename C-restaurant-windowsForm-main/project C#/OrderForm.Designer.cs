namespace project_C_
{
    partial class OrderForm
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
            submitOrder = new Button();
            CustomerName = new TextBox();
            FoodName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 141);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "اسم مشتری";
            // 
            // submitOrder
            // 
            submitOrder.Location = new Point(503, 199);
            submitOrder.Name = "submitOrder";
            submitOrder.Size = new Size(94, 29);
            submitOrder.TabIndex = 2;
            submitOrder.Text = "ثبت سفارش";
            submitOrder.UseVisualStyleBackColor = true;
            submitOrder.Click += submitOrder_Click;
            // 
            // CustomerName
            // 
            CustomerName.Location = new Point(211, 141);
            CustomerName.Name = "CustomerName";
            CustomerName.Size = new Size(125, 27);
            CustomerName.TabIndex = 0;
            // 
            // FoodName
            // 
            FoodName.Location = new Point(211, 200);
            FoodName.Name = "FoodName";
            FoodName.Size = new Size(125, 27);
            FoodName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 203);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 3;
            label2.Text = "اسم غذا";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(342, 30);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 4;
            label3.Text = "ثبت سفارش";
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(FoodName);
            Controls.Add(label2);
            Controls.Add(CustomerName);
            Controls.Add(submitOrder);
            Controls.Add(label1);
            Name = "OrderForm";
            Text = "ثبت سفارش";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button submitOrder;
        private TextBox CustomerName;
        private TextBox FoodName;
        private Label label2;
        private Label label3;
    }
}