using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сalories_Calculator
{
    public class FoodModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Calories { get; set; }

        public double Proteins { get; set; }

        public double Fats { get; set; }

        public double Carbohydrates { get; set; }

        public string FoodCalories
        {
            get
            {
                return $"{ Name } \t { Calories } кал\t { Proteins } г\t { Fats } г\t { Carbohydrates } г";
            }
        }
    }
}
