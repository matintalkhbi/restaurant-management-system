using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace project_C_
{
    public partial class RegisterForm : Form
    {
        private string conString = "server=localhost;user id=root;password=yourpassword;database=users";

        public RegisterForm()
        {
            InitializeComponent();
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
                if (!char.IsLetterOrDigit(c) && !char.IsControl(c))
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

            if (!IsValidUsername(username))
            {
                MessageBox.Show("نام کاربری فقط باید شامل حروف الفبا باشد");
                return;
            }

            if (!IsValidPassword(password))
            {
                MessageBox.Show("پسورد باید بین 6 و 10 حرف باشد و شامل حروف الفبا و اعداد باشد");
                return;
            }

            using (MySqlConnection con = new MySqlConnection(conString))
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO users (username, password) VALUES (@username, @password)";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("ثبت نام با موفقیت انجام شد !");
                        this.Hide();
                        new HomeForm(username).Show();
                    }
                    else
                    {
                        MessageBox.Show("خطا در ثبت نام، لطفاً مجدداً تلاش کنید.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطا در اتصال به دیتابیس: " + ex.Message);
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
            new LoginForm().Show();
            this.Close();
        }
    }
}
