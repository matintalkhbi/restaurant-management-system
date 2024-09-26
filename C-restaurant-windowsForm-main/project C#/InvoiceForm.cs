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
    public partial class InvoiceForm : Form
    {
        public InvoiceForm()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {
            string customerName = CustomerName.Text;

            if (string.IsNullOrWhiteSpace(customerName))
            {
                MessageBox.Show("لطفاً نام مشتری را وارد کنید!");
                return;
            }

            string[] orders = File.ReadAllLines("Orders.txt");
            var customerOrders = orders
                .Where(line => line.Split(',')[0].Equals(customerName, StringComparison.OrdinalIgnoreCase))
                .Select(line => line.Split(',')[1] + " - " + line.Split(',')[2])
                .ToList();

            if (!customerOrders.Any())
            {
                MessageBox.Show("سفارشی برای این مشتری یافت نشد!");
                return;
            }

            lstOrders.Items.Clear();
            foreach (var order in customerOrders)
            {
                lstOrders.Items.Add(order);
            }

            int count_order = customerOrders.Count;
            label1.Text = "تعداد سفارش های مشتری : " + count_order;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
