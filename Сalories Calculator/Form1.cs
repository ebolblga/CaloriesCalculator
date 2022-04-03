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
using System.Windows.Forms.DataVisualization.Charting;

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
            ChartRender();
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

            //dataGridView.AutoGenerateColumns = false;
            //dataGridView.DataSource = null;
            //dataGridView.DataSource = food;
        }

        private void bRefreshList_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            LoadFoodList();
            ChartRender();
            this.Cursor = Cursors.Default;
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
            ChartRender();
        }

        private void ChartRender()
        {
            chart1.Series[0].Points.Clear();
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();

            int sizeOfList = food.Count;
            double[] array = new double[sizeOfList];
            string[] dateArray = new string[sizeOfList];

            int day;
            int month;
            int year;

            for (int i = 0; i < sizeOfList; ++i)
            {
                array[i] = food[i].Amount / 100 * food[i].Calories;
                int date = food[i].Date;
                day = date % 100;
                date /= 100;
                month = date % 100;
                date /= 100;
                year = date;
                dateArray[i] = day.ToString("00") + "." + month.ToString("00") + "." + date.ToString("0000");
            }

            ChartArea area = new ChartArea();
            chart1.ChartAreas.Add(area);

            Series series = new Series();
            series.ChartType = SeriesChartType.Line;
            series.Name = "series";
            series.ChartArea = area.Name;
            chart1.Series.Add(series);

            for (int i = 0; i < sizeOfList; ++i)
            {
                chart1.Series["series"].Points.AddXY(dateArray[i], array[i]);
            }

            double minimum = array[0];
            double maximum = array[0];
            for (int i = 1; i < sizeOfList; ++i)
            {
                if (array[i] < minimum)
                    minimum = array[i];
                if (array[i] > maximum)
                    maximum = array[i];
            }

            area.RecalculateAxesScale();
            area.AxisY.Minimum = Convert.ToInt32(minimum - 10);
            area.AxisY.Maximum = Convert.ToInt32(maximum + 10);
            area.AxisX.Minimum = 1;
            area.AxisX.Maximum = sizeOfList;

            area.Position.X = 0;
            area.Position.Width = 100;
            area.Position.Height = 100;
            area.Position.Y = 0;

            series.Color = Color.FromArgb(165, 0, 13);
            series.BorderWidth = 2;
            area.BackColor = Color.Transparent;
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
