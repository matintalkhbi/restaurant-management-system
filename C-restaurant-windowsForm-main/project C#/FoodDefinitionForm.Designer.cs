namespace project_C_
{
    partial class FoodDefinitionForm
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
            foodSave = new Button();
            label3 = new Label();
            nameFood = new TextBox();
            priceFood = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 112);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 0;
            label1.Text = "اسم غذا";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(135, 165);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "قیمت غذا";
            // 
            // foodSave
            // 
            foodSave.Location = new Point(359, 283);
            foodSave.Name = "foodSave";
            foodSave.Size = new Size(170, 29);
            foodSave.TabIndex = 2;
            foodSave.Text = "دخیره ی اطلاعات";
            foodSave.UseVisualStyleBackColor = true;
            foodSave.Click += foodSave_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(290, 20);
            label3.Name = "label3";
            label3.Size = new Size(151, 20);
            label3.TabIndex = 3;
            label3.Text = "اضافه کردن غذا به منو";
            // 
            // nameFood
            // 
            nameFood.Location = new Point(275, 105);
            nameFood.Name = "nameFood";
            nameFood.Size = new Size(254, 27);
            nameFood.TabIndex = 0;
            // 
            // priceFood
            // 
            priceFood.Location = new Point(275, 162);
            priceFood.Name = "priceFood";
            priceFood.Size = new Size(254, 27);
            priceFood.TabIndex = 1;
            // 
            // FoodDefinitionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(priceFood);
            Controls.Add(nameFood);
            Controls.Add(label3);
            Controls.Add(foodSave);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FoodDefinitionForm";
            Text = "غذا به منو ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button foodSave;
        private Label label3;
        private TextBox nameFood;
        private TextBox priceFood;
    }
}