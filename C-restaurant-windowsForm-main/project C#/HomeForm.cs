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
    public partial class HomeForm : Form
    {
        private NotifyIcon trayIcon;
        private bool isMinimizedToTray = false;
        public HomeForm(string username)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        private void MainForm_Resize(object sender, EventArgs e)
        {
            
            if (this.WindowState == FormWindowState.Minimized)
            {
                
                this.Hide();
                notifyIcon.Visible = true; 
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Maximized;
            notifyIcon.Visible = false; 
        }


        private void مدیریتمشتریانToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void مشتریانToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void تعریفمشتریToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CustomerDefinitionForm().Show();
        }

        private void ویرایشوجستجویمشتریToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CustomerSearchForm().Show();
        }

        private void userwelcome_Click(object sender, EventArgs e)
        {

        }

        private void تعریفغذاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FoodDefinitionForm().Show();
        }

        private void منویرستورانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FoodMenuForm().Show();
        }

        private void جستجوویرایشوحذفغذاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SearchEditForm().Show();
        }

        private void ثبتسفارشمشتریToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new OrderForm().Show();
        }

        private void تهیهیصورتحسابمشتریToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InvoiceForm().Show();
        }

        private void تهیهیگزارشبراساسفراوانیسفارشهابافیلترغذاوباقیمتیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ReportsForm().Show();
        }


    }
}
