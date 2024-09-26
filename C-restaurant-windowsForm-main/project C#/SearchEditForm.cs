namespace project_C_
{
    public partial class SearchEditForm : Form
    {
        public SearchEditForm()
        {
            InitializeComponent();
        }

        private void searchFood_Click(object sender, EventArgs e)
        {
            string nameFood = nameFoodSerach.Text;
            string[] Food = File.ReadAllLines("Food.txt");
            string foundFood = Array.Find(Food, line => line.StartsWith(nameFood));
            if (foundFood != null)
            {
                string[] foodInfo = foundFood.Split(',');
                showPriceFood.Text = foodInfo[1];
            }
            else
            {
                MessageBox.Show("غذا مورد نظر یافت نشد");
            }
        }

        private void saveNew_Click(object sender, EventArgs e)
        {
            string newName = newNameFood.Text;
            string newPrice = newPriceFood.Text;
            string[] Foods = File.ReadAllLines("Food.txt");
            for (int i = 0; i < Foods.Length; i++)
            {
                if (Foods[i].StartsWith(nameFoodSerach.Text))
                {
                    Foods[i] = $"{newName},{newPrice}";
                    break;
                }
            }
            File.WriteAllLines("Food.txt", Foods);
            MessageBox.Show("اطلاعات غذا با موفقیت ویرایش شد!");
        }

        private void delFood_Click(object sender, EventArgs e)
        {
            string foodName = nameFoodSerach.Text;

            if (string.IsNullOrWhiteSpace(foodName))
            {
                MessageBox.Show("لطفاً نام غذا را وارد کنید!");
                return;
            }

            string[] foods = File.ReadAllLines("Food.txt");
            string[] updatedFoods = foods.Where(line => !line.Split(',')[0].Equals(foodName, StringComparison.OrdinalIgnoreCase)).ToArray();

            if (updatedFoods.Length == foods.Length)
            {
                MessageBox.Show("غذای مورد نظر یافت نشد!");
                return;
            }

            File.WriteAllLines("Food.txt", updatedFoods);
            MessageBox.Show("غذا با موفقیت حذف شد!");
        }
    }



}

