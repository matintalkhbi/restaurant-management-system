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
    public partial class CustomerDefinitionForm : Form
    {
        public CustomerDefinitionForm()
        {
            InitializeComponent();
        }
        private void CustomerDefinitionForm_Load(object sender, EventArgs e)
        {
            
        }

        private void username_Click(object sender, EventArgs e)
        {

        }

        private void saveCreateCustomer_Click(object sender, EventArgs e)
        {
            string name = nameCustomerForm.Text;
            string address = addressCustomerForm.Text;
            string phone = phoneCustomerForm.Text;

            if (File.Exists("Customers.txt"))
            {
                var lines = File.ReadAllLines("Customers.txt");
                var phones = lines.Select(line => line.Split(',')[2]).ToList();

                if (phones.Contains(phone))
                {
                    MessageBox.Show("شماره تلفن وارد شده یکتا نیست. لطفاً شماره تلفن دیگری وارد کنید.");
                    return;
                }
            }

            // افزودن کاربر جدید به فایل
            string customerInfo = $"{name},{address},{phone}";
            File.AppendAllText("Customers.txt", customerInfo + Environment.NewLine);
            MessageBox.Show("کاربر با موفقیت ثبت شد");

            // پاک کردن فیلدها
            nameCustomerForm.Clear();
            addressCustomerForm.Clear();
            phoneCustomerForm.Clear();
            this.Hide();
        }
    }
}
