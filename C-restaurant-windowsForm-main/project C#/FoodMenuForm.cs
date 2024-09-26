using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_C_
{
    public partial class FoodMenuForm : Form
    {
        public FoodMenuForm()
        {
            InitializeComponent();
            LoadFoodMenu();
        }
        private void LoadFoodMenu()
        {

            foodMenu.Columns.Add("Price", 100, HorizontalAlignment.Right);
            foodMenu.Columns.Add("Name", 150, HorizontalAlignment.Left);


            string[] lines = File.ReadAllLines("Food.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length == 2)
                {
                    ListViewItem item = new ListViewItem(parts[0]);
                    item.SubItems.Add(parts[1]);
                    foodMenu.Items.Add(item);
                }
            }

            int count_food = lines.Length;
            label2.Text = "تعداد غذا های رستوران :"+count_food.ToString();

            // تنظیم حالت نمایش ListView
            foodMenu.View = View.Details;
            foodMenu.FullRowSelect = true;
        }



        private void foodMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
