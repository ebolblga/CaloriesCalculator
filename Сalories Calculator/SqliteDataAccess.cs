using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сalories_Calculator
{
    public class SqliteDataAccess
    {
        public static List<FoodModel> LoadFood()
        {
            using(IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<FoodModel>("select * from Food", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveFood(FoodModel food)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Food (Name, Amount, Calories, Proteins, Fats, Carbohydrates, Date) values(@Name, @Amount, @Calories, @Proteins, @Fats, @Carbohydrates, @Date)", food);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static void DeleteFood(int id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"delete from Food where Id = { id }");
            }
        }
    }
}
