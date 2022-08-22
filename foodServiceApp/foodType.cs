using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foodServiceApp
{
    public class foodType
    {
        string type;
        decimal foodCost;
        

        public foodType(string type, decimal foodCost)
        {
            this.type = type;
            this.foodCost = foodCost;
            
        }

        public void updateProperties(decimal newFoodCost)
        {
            foodCost = newFoodCost;
            
        }
        public string GetType() // these "Get" methods allow me to use a variable in different files
        {
            return type;
        }
        public decimal GetCost()
        {
            return foodCost;
        }

        public List<decimal> GetSettings()  // calls my settings for that animal type
        {
            List<decimal> settings = new List<decimal>();
            settings.Add(foodCost);
            

            return settings;
        }

    }
}
