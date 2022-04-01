using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сalories_Calculator
{
    public partial class Form1 : Form
    {
        List<FoodModel> food = new List<FoodModel>();
        public Form1()
        {
            InitializeComponent();

            LoadFoodList();
        }

        private void LoadFoodList()
        {
            //food.Add(new FoodModel { Name = "Балтика 7 Классическая", Calories = 45, Proteins = 0, Fats = 0, Carbohydrates = 3.5 });
            //food.Add(new FoodModel { Name = "Балтика Авторское", Calories = 45, Proteins = 0, Fats = 0, Carbohydrates = 3.5 });
            //food.Add(new FoodModel { Name = "Балтика 9 Крепкое", Calories = 60, Proteins = 0, Fats = 0, Carbohydrates = 4.5 });

            food = SqliteDataAccess.LoadFood();

            WireUpFoodList();
        }

        private void WireUpFoodList()
        {
            listFoodListBox.DataSource = null;
            listFoodListBox.DataSource = food;
            listFoodListBox.DisplayMember = "FoodCalories";
        }

        private void bRefreshList_Click(object sender, EventArgs e)
        {
            LoadFoodList();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            FoodModel f = new FoodModel();

            f.Name = NameTextBox.Text;
            f.Calories = Convert.ToInt32(CaloriesTextBox.Text);
            f.Proteins = Convert.ToDouble(ProteinsTextBox.Text);
            f.Fats = Convert.ToDouble(FatsTextBox.Text);
            f.Carbohydrates = Convert.ToDouble(CarbohydratesTextBox.Text);

            //food.Add(f);
            //WireUpFoodList();
            SqliteDataAccess.SaveFood(f);

            NameTextBox.Text = "";
            CaloriesTextBox.Text = "";
            ProteinsTextBox.Text = "";
            FatsTextBox.Text = "";
            CarbohydratesTextBox.Text = "";
            LoadFoodList();
        }
    }
}
