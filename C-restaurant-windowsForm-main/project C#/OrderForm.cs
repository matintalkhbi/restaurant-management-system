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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void submitOrder_Click(object sender, EventArgs e)
        {
            string customerName = CustomerName.Text;
            string foodName = FoodName.Text;

            string[] customers = File.ReadAllLines("Customers.txt");
            bool customerExists = customers.Any(line => line.Split(',')[0].Equals(customerName, StringComparison.OrdinalIgnoreCase));

            if (!customerExists)
            {
                MessageBox.Show("مشتری مورد نظر یافت نشد!");
                return;
            }

            string orderEntry = $"{customerName},{foodName},{DateTime.Now}";
            File.AppendAllText("Orders.txt", orderEntry + Environment.NewLine);
            MessageBox.Show("سفارش با موفقیت ثبت شد!");
        }
    }
}
