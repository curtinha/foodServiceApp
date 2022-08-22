using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foodServiceApp
{
    public class food

    {
        // food Attributes

        private string species;
        private string name;
        private List<int> consumptions = new List<int>();




        // methods
        // constructor

        public food(string species, string name, List<int> consumption)
        {
            this.species = species;
            this.name = name;
            this.consumptions = consumption;


        }

        public int TotalFoodCons() // calculates total consumption for animal being inputted
        {
            int totalCons = 0;
            foreach (var dailyCons in consumptions)
            {
                totalCons += dailyCons;

            }
            return totalCons;
        }

        public decimal TotalFoodCost(decimal foodCost) // Calculates total cost for that animal
        {
            decimal totalCost = 0.0m;
            foreach (var dailyCons in consumptions)
            {
                totalCost += dailyCons * foodCost;
            }

            return totalCost;
        }

        public string GetSpecies() // gets the species variable
        {
            return species;
        }

        public string Summary(decimal foodCost) // this method prints my messagebox after the user has entered an animal's information
        {
            string totals = "Total Weekly Consumption: " + Convert.ToString(TotalFoodCons()) + "g\nTotal Weekly Cost: $" + Convert.ToString(TotalFoodCost(foodCost)) + "\n";
            string summary = "Name: " + name + "\nSpecies: " + species + "\n" + totals;

            int counter = 1;

            foreach (int consumption in consumptions)
            {

                summary += $"Day {counter}: " + consumption + "g\n";
                counter++;
            }


            return summary;
        }
    }


}
