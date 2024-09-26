using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using project_C_;
using static project_C_.MainForm;
namespace project_C_
{
    public partial class RegisterForm : Form
    {
        private List<UserManage> users;
        public RegisterForm(List<UserManage> users)
        {
            InitializeComponent();
            this.users = users;
        }

        private bool IsValidUsername(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                return false;
            }
            foreach (char c in username)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }

        private bool IsValidPassword(string password)
        {
            if (string.IsNullOrEmpty(password) || password.Length < 6 || password.Length > 10)
            {
                return false;
            }
            foreach (char c in password)
            {
                if (!char.IsAsciiLetterOrDigit(c) && !char.IsControl(c))
                {
                    return false;
                }
            }
            return true;
        }

        private void RegisterRegisterForm_Click(object sender, EventArgs e)
        {
            string username = usernameRegisterForm.Text;
            string password = passwordRegisterForm.Text;
            if (!IsValidPassword(username))
            {
                MessageBox.Show("نام کاربری فقط باید شامل حروف البفا باشد");
                return;
            }
            if (!IsValidPassword(password))
            {
                MessageBox.Show("پسورد باید بین 6 و 10 حرف باشد و شامل حروف القبا و کاراکتر های کنترلی باشد");
                return;
            }
            foreach (UserManage user in users)
            {
                if (user.Username == username)
                {
                    MessageBox.Show("نام کاربری تکراری است");
                    return;
                }
            }
            UserManage newUser = new UserManage { Username = username, Password = password };
            users.Add(newUser);
            SaveUsersToFile();
            MessageBox.Show("ثبت نام با موفقیت انجام شد");
            new HomeForm(newUser.Username).Show();
            this.Hide();
            
        }
        private void SaveUsersToFile()
        {
            using (StreamWriter writer = new StreamWriter("users.txt"))
            {
                foreach (var user in users)
                {
                    writer.WriteLine($"{user.Username},{user.Password}");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usernameRegisterForm.Clear();
            passwordRegisterForm.Clear();
            usernameRegisterForm.Focus();
        }

        private void ExitRegisterForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginRegisterForm_Click(object sender, EventArgs e)
        {
            new LoginForm(users).Show();
            this.Close();
        }
    }
}
