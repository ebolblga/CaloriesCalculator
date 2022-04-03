
namespace Сalories_Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bAdd = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listFoodListBox = new System.Windows.Forms.ListBox();
            this.bRefreshList = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CaloriesTextBox = new System.Windows.Forms.TextBox();
            this.ProteinsTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FatsTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CarbohydratesTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // bAdd
            // 
            this.bAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(0)))), ((int)(((byte)(13)))));
            this.bAdd.Location = new System.Drawing.Point(17, 248);
            this.bAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(196, 23);
            this.bAdd.TabIndex = 0;
            this.bAdd.Text = "Добавить";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(18, 40);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(195, 23);
            this.NameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название продукта";
            // 
            // listFoodListBox
            // 
            this.listFoodListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listFoodListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(160)))));
            this.listFoodListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listFoodListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(0)))), ((int)(((byte)(13)))));
            this.listFoodListBox.FormattingEnabled = true;
            this.listFoodListBox.ItemHeight = 18;
            this.listFoodListBox.Location = new System.Drawing.Point(455, 14);
            this.listFoodListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listFoodListBox.Name = "listFoodListBox";
            this.listFoodListBox.Size = new System.Drawing.Size(597, 360);
            this.listFoodListBox.TabIndex = 3;
            // 
            // bRefreshList
            // 
            this.bRefreshList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bRefreshList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(0)))), ((int)(((byte)(13)))));
            this.bRefreshList.Location = new System.Drawing.Point(955, 382);
            this.bRefreshList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bRefreshList.Name = "bRefreshList";
            this.bRefreshList.Size = new System.Drawing.Size(99, 24);
            this.bRefreshList.TabIndex = 4;
            this.bRefreshList.Text = "Обновить";
            this.bRefreshList.UseVisualStyleBackColor = true;
            this.bRefreshList.Click += new System.EventHandler(this.bRefreshList_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(0)))), ((int)(((byte)(13)))));
            this.label2.Location = new System.Drawing.Point(234, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Калорийность, ккал";
            // 
            // CaloriesTextBox
            // 
            this.CaloriesTextBox.Location = new System.Drawing.Point(238, 40);
            this.CaloriesTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CaloriesTextBox.Name = "CaloriesTextBox";
            this.CaloriesTextBox.Size = new System.Drawing.Size(195, 23);
            this.CaloriesTextBox.TabIndex = 5;
            // 
            // ProteinsTextBox
            // 
            this.ProteinsTextBox.Location = new System.Drawing.Point(238, 109);
            this.ProteinsTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProteinsTextBox.Name = "ProteinsTextBox";
            this.ProteinsTextBox.Size = new System.Drawing.Size(195, 23);
            this.ProteinsTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(234, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Белки, г";
            // 
            // FatsTextBox
            // 
            this.FatsTextBox.Location = new System.Drawing.Point(238, 179);
            this.FatsTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FatsTextBox.Name = "FatsTextBox";
            this.FatsTextBox.Size = new System.Drawing.Size(195, 23);
            this.FatsTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(234, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Жиры, г";
            // 
            // CarbohydratesTextBox
            // 
            this.CarbohydratesTextBox.Location = new System.Drawing.Point(238, 248);
            this.CarbohydratesTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CarbohydratesTextBox.Name = "CarbohydratesTextBox";
            this.CarbohydratesTextBox.Size = new System.Drawing.Size(195, 23);
            this.CarbohydratesTextBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(234, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Углеводы, г";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(15, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Сколько, г";
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Location = new System.Drawing.Point(18, 109);
            this.AmountTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(195, 23);
            this.AmountTextBox.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(0)))), ((int)(((byte)(13)))));
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dateTimePicker1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(18, 179);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(195, 23);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.Value = new System.DateTime(2022, 4, 3, 0, 0, 0, 0);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(18, 413);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsValueShownAsLabel = true;
            series1.IsVisibleInLegend = false;
            series1.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(0)))), ((int)(((byte)(13)))));
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1036, 198);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(15, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Дата";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1066, 623);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AmountTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CarbohydratesTextBox);
            this.Controls.Add(this.FatsTextBox);
            this.Controls.Add(this.ProteinsTextBox);
            this.Controls.Add(this.CaloriesTextBox);
            this.Controls.Add(this.bRefreshList);
            this.Controls.Add(this.listFoodListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.bAdd);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(0)))), ((int)(((byte)(13)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calories Calculator";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listFoodListBox;
        private System.Windows.Forms.Button bRefreshList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CaloriesTextBox;
        private System.Windows.Forms.TextBox ProteinsTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FatsTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CarbohydratesTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label7;
    }
}

