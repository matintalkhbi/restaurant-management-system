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
    public partial class FoodDefinitionForm : Form
    {
        public FoodDefinitionForm()
        {
            InitializeComponent();
        }

        private void foodSave_Click(object sender, EventArgs e)
        {
            string name = nameFood.Text;
            string price = priceFood.Text;

            string foodInfo = $"{name},{price}";

            File.AppendAllText("Food.txt",foodInfo + Environment.NewLine);
            MessageBox.Show("غذا با موفقیت به منو اضافه شد");
            nameFood.Clear();
            priceFood.Clear();
        }
    }
}
