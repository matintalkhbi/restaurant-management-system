namespace project_C_
{
    public partial class MainForm : Form
    {

        private List<UserManage> users = new List<UserManage>();

        public class UserManage
        {
            public string Username;
            public string Password;

        }

        public MainForm()
        {
            InitializeComponent();
            if (File.Exists("users.txt"))
            {
                using (StreamReader reader = new StreamReader("users.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 2)
                        {
                            users.Add(new UserManage { Username = parts[0], Password = parts[1] });
                        }
                    }
                }
            }
        }

        
        
        

        public List<UserManage> GetUsersList()
        {
            return users;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void loginmainform_Click(object sender, EventArgs e)
        {
            new LoginForm(users).Show();
            this.Hide();
        }

        private void signinmainform_Click(object sender, EventArgs e)
        {
            new RegisterForm(users).Show();
            this.Hide();
        }
    }
}
