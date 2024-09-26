namespace project_C_
{
    partial class ReportsForm
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
            listBoxReport = new ListBox();
            label1 = new Label();
            button1 = new Button();
            FoodName = new TextBox();
            SuspendLayout();
            // 
            // listBoxReport
            // 
            listBoxReport.FormattingEnabled = true;
            listBoxReport.Location = new Point(21, 150);
            listBoxReport.Name = "listBoxReport";
            listBoxReport.Size = new Size(749, 284);
            listBoxReport.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 60);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 1;
            label1.Text = "اسم غذا";
            // 
            // button1
            // 
            button1.Location = new Point(634, 51);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "گزارش";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FoodName
            // 
            FoodName.Location = new Point(183, 57);
            FoodName.Name = "FoodName";
            FoodName.Size = new Size(125, 27);
            FoodName.TabIndex = 0;
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(FoodName);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(listBoxReport);
            Name = "ReportsForm";
            Text = "گزارش";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxReport;
        private Label label1;
        private Button button1;
        private TextBox FoodName;
    }
}