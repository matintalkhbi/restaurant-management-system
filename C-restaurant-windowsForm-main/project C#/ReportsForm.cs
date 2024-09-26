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
    public partial class ReportsForm : Form
    {
        private List<string> orders;
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string foodName = FoodName.Text;

            GenerateReport(foodName);
        }
        private void GenerateReport(string foodName)
        {
            // خواندن غذاها از فایل
            var foods = File.ReadAllLines("Food.txt");

            // بررسی وجود غذا در فایل
            if (!foods.Any(line => line.Split(',')[0].Equals(foodName, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("همچین غذایی در لیست وجود ندارد!");
                return;
            }

            // خواندن سفارش‌ها از فایل
            orders = File.ReadAllLines("Orders.txt").ToList();

            // فیلتر کردن سفارش‌ها بر اساس غذا
            var filteredOrders = orders
                .Where(line =>
                {
                    string[] parts = line.Split(',');
                    string orderedFood = parts[1];
                    return orderedFood.Equals(foodName, StringComparison.OrdinalIgnoreCase);
                })
                .Select(line =>
                {
                    string[] parts = line.Split(',');
                    string customerName = parts[0];
                    DateTime orderDate = DateTime.Parse(parts[2]); 
                    return new { CustomerName = customerName, OrderDate = orderDate };
                })
                .ToList();

            
            listBoxReport.Items.Clear();
            foreach (var item in filteredOrders)
            {
                listBoxReport.Items.Add($"نام مشتری: {item.CustomerName} - تاریخ سفارش: {item.OrderDate}");
            }
        }
    }
}
