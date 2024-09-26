namespace project_C_
{
    partial class SearchEditForm
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
            showPriceFood = new Label();
            label4 = new Label();
            nameFoodSerach = new TextBox();
            searchFood = new Button();
            saveNew = new Button();
            newNameFood = new TextBox();
            label3 = new Label();
            newPriceFood = new TextBox();
            label5 = new Label();
            delFood = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(340, 38);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "جستجو غذا";
            // 
            // showPriceFood
            // 
            showPriceFood.AutoSize = true;
            showPriceFood.Location = new Point(578, 107);
            showPriceFood.Name = "showPriceFood";
            showPriceFood.Size = new Size(70, 20);
            showPriceFood.TabIndex = 1;
            showPriceFood.Text = "قیمت غذا";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 107);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 3;
            label4.Text = "اسم غذا";
            // 
            // nameFoodSerach
            // 
            nameFoodSerach.Location = new Point(183, 104);
            nameFoodSerach.Name = "nameFoodSerach";
            nameFoodSerach.Size = new Size(125, 27);
            nameFoodSerach.TabIndex = 0;
            // 
            // searchFood
            // 
            searchFood.Location = new Point(567, 170);
            searchFood.Name = "searchFood";
            searchFood.Size = new Size(94, 29);
            searchFood.TabIndex = 1;
            searchFood.Text = "جستجو";
            searchFood.UseVisualStyleBackColor = true;
            searchFood.Click += searchFood_Click;
            // 
            // saveNew
            // 
            saveNew.Location = new Point(567, 354);
            saveNew.Name = "saveNew";
            saveNew.Size = new Size(94, 29);
            saveNew.TabIndex = 5;
            saveNew.Text = "ذخیره";
            saveNew.UseVisualStyleBackColor = true;
            saveNew.Click += saveNew_Click;
            // 
            // newNameFood
            // 
            newNameFood.Location = new Point(183, 288);
            newNameFood.Name = "newNameFood";
            newNameFood.Size = new Size(125, 27);
            newNameFood.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 291);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 7;
            label3.Text = "اسم غذا";
            // 
            // newPriceFood
            // 
            newPriceFood.Location = new Point(183, 355);
            newPriceFood.Name = "newPriceFood";
            newPriceFood.Size = new Size(125, 27);
            newPriceFood.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(65, 358);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 10;
            label5.Text = "قیمت غذا";
            // 
            // delFood
            // 
            delFood.Location = new Point(388, 170);
            delFood.Name = "delFood";
            delFood.Size = new Size(94, 29);
            delFood.TabIndex = 2;
            delFood.Text = "حذف غذا";
            delFood.UseVisualStyleBackColor = true;
            delFood.Click += delFood_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(338, 234);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 11;
            label2.Text = "ویرایش غذا";
            // 
            // SearchEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(delFood);
            Controls.Add(newPriceFood);
            Controls.Add(label5);
            Controls.Add(saveNew);
            Controls.Add(newNameFood);
            Controls.Add(label3);
            Controls.Add(searchFood);
            Controls.Add(nameFoodSerach);
            Controls.Add(label4);
            Controls.Add(showPriceFood);
            Controls.Add(label1);
            Name = "SearchEditForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label showPriceFood;
        private Label label4;
        private TextBox nameFoodSerach;
        private Button searchFood;
        private Button saveNew;
        private TextBox newNameFood;
        private Label label3;
        private TextBox newPriceFood;
        private Label label5;
        private Button delFood;
        private Label label2;
    }
}