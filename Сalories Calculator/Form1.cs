using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            DoubleBuffered = true;

            LoadFoodList();
            dateTimePicker1.MaxDate = DateTime.Today;
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


            if (NameTextBox.Text != "")
                f.Name = NameTextBox.Text;
            else
            {
                MessageBox.Show("Name is needed", "Error");
                return;
            }

            try
            {
                //f.Amount = Convert.ToInt32(AmountTextBox.Text);
                //f.Calories = Convert.ToInt32(CaloriesTextBox.Text);
                //f.Proteins = Convert.ToDouble(ProteinsTextBox.Text);
                //f.Fats = Convert.ToDouble(FatsTextBox.Text);
                //f.Carbohydrates = Convert.ToDouble(CarbohydratesTextBox.Text);
                f.Date = Convert.ToInt32(dateTimePicker1.Value.Year.ToString("0000") + dateTimePicker1.Value.Month.ToString("00") + dateTimePicker1.Value.Day.ToString("00"));
            }
            catch
            {
                MessageBox.Show("Parameters are incorrect", "Error");
                return;
            }

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

        #region cosmetics
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.FromArgb(236, 55, 110), Color.FromArgb(245, 177, 97), 135F))
            //using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.FromArgb(255, 185, 162), Color.FromArgb(255, 237, 212), 45F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        #endregion
    }
}
