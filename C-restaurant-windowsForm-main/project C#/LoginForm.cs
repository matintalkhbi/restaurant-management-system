using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static project_C_.MainForm;

namespace project_C_
{
    public partial class LoginForm : Form
    {
        private List<UserManage> users;
        public LoginForm(List<UserManage> users)
        {
            InitializeComponent();
            this.users = users;
        }

        private void loginLoginForm_Click(object sender, EventArgs e)
        {
            string username = usernameLoginForm.Text;
            string password = passwordLoginForm.Text;
            foreach (UserManage user in users)
            {
                if (user.Username == username)
                {
                    if (user.Password == password)
                    {
                        MessageBox.Show("ورود با موفقیت انجام شد !");
                        this.Hide();
                        new HomeForm(user.Username).Show();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("رمز شما اشتباه است !");
                        return;
                    }
                }
            }
            MessageBox.Show("username not exitst");
        }

        private void registerLoginForm_Click(object sender, EventArgs e)
        {
            new RegisterForm(users).Show();
            this.Hide();
        }

        private void clearLoginForm_Click(object sender, EventArgs e)
        {
            usernameLoginForm.Clear();
            passwordLoginForm.Clear();
            usernameLoginForm.Focus();
        }

        private void ExitLoginForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
