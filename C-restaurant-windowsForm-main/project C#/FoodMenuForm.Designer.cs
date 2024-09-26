namespace project_C_
{
    partial class FoodMenuForm
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
            foodMenu = new ListView();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // foodMenu
            // 
            foodMenu.Location = new Point(168, 75);
            foodMenu.Name = "foodMenu";
            foodMenu.Size = new Size(411, 359);
            foodMenu.TabIndex = 0;
            foodMenu.UseCompatibleStateImageBehavior = false;
            foodMenu.SelectedIndexChanged += foodMenu_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(483, 21);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 1;
            label1.Text = "منوی رستوران";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 21);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 2;
            label2.Text = "تعداد غذا ها";
            label2.Click += label2_Click;
            // 
            // FoodMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(foodMenu);
            Name = "FoodMenuForm";
            Text = "منوی رستوران";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView foodMenu;
        private Label label1;
        private Label label2;
    }
}