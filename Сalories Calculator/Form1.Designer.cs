
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
            this.bAdd = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listFoodListBox = new System.Windows.Forms.ListBox();
            this.bRefreshList = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CaloriesTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bAdd
            // 
            this.bAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bAdd.Location = new System.Drawing.Point(100, 137);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(87, 20);
            this.bAdd.TabIndex = 0;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(16, 33);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(171, 21);
            this.NameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // listFoodListBox
            // 
            this.listFoodListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listFoodListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listFoodListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listFoodListBox.FormattingEnabled = true;
            this.listFoodListBox.ItemHeight = 15;
            this.listFoodListBox.Location = new System.Drawing.Point(543, 12);
            this.listFoodListBox.Name = "listFoodListBox";
            this.listFoodListBox.Size = new System.Drawing.Size(378, 469);
            this.listFoodListBox.TabIndex = 3;
            // 
            // bRefreshList
            // 
            this.bRefreshList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bRefreshList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bRefreshList.Location = new System.Drawing.Point(834, 487);
            this.bRefreshList.Name = "bRefreshList";
            this.bRefreshList.Size = new System.Drawing.Size(87, 20);
            this.bRefreshList.TabIndex = 4;
            this.bRefreshList.Text = "Refresh";
            this.bRefreshList.UseVisualStyleBackColor = true;
            this.bRefreshList.Click += new System.EventHandler(this.bRefreshList_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Calories";
            // 
            // CaloriesTextBox
            // 
            this.CaloriesTextBox.Location = new System.Drawing.Point(16, 91);
            this.CaloriesTextBox.Name = "CaloriesTextBox";
            this.CaloriesTextBox.Size = new System.Drawing.Size(171, 21);
            this.CaloriesTextBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CaloriesTextBox);
            this.Controls.Add(this.bRefreshList);
            this.Controls.Add(this.listFoodListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.bAdd);
            this.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calories Calculator";
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
    }
}

