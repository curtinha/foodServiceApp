using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace foodServiceApp

{
    public class windowManager
    {
        // the below lists store my initialize values for the cost of the animals foood, they are stored in a list 
       
        
        public List<food> animals = new List<food>();
        public List<foodType> species = new List<foodType>() { new foodType("Small Dog", 0.0425m), new foodType("Medium Dog", 0.0425m), new foodType("Large Dog", 0.0425m), new foodType("Cat", 0.0065m), new foodType("Horse", 0.125m), new foodType("Budgie", 0.0033m) };



        public windowManager()
        {

        }



        

        public void AddAnimal(string s, string n, List<int> c) // adds a new animal to the manager
        {
            animals.Add(new food(s, n, c));

        }

        public string RecentlyAddedAnimalSummary() // fetches the information about the most recently added animal, to be displayed in the summary box
        {
            try
            {
                string type = animals[animals.Count - 1].GetSpecies();
                int speciesIndex = SearchSpecies(type);

                decimal foodCost = species[speciesIndex].GetCost();
                return animals[animals.Count - 1].Summary(foodCost);
            }

            catch
            {
                string errorMessage = "Please Select an Animal Species"; // catches when the user clicks submit without adding an animal
                return errorMessage;
            }
        }


        public void SetSpeciesParameters(string type, decimal newCost) // updates the animals cost via the settings page
        {
            try
            {
                int speciesIndex = SearchSpecies(type);
                species[speciesIndex].updateProperties(newCost);
            }
            catch
            {
                string errorMessage = "Please Select an Animal Species, returning you to home page";
                MessageBox.Show(errorMessage);

            }
        }

        public decimal GetRecentlyAddedAnimalCost() // Calculates the cost of the most recently added animal
        {
            string type = animals[animals.Count - 1].GetSpecies();
            int speciesIndex = SearchSpecies(type);

            decimal foodCost = species[speciesIndex].GetCost();

            return animals[animals.Count - 1].TotalFoodCost(foodCost);

        }

        public int SearchSpecies(string species) // looks for the species of the animal, returns the type that matches the index
        {
            bool flag = false;
            int speciesIndex = 0;
            while (flag == false && speciesIndex < this.species.Count)
            {

                if (species.Equals(this.species[speciesIndex].GetType()))
                {
                    flag = true;
                    return speciesIndex;
                }
                else
                {
                    speciesIndex += 1;
                }

            }
            return -1;


        }

        public decimal GetTotalCost() // Calculates the total cost for the SPCA for the week
        {

            decimal totalCost = 0;
            foreach (var animal in animals)
                try
                {


                    {
                        int speciesIndex = SearchSpecies(animal.GetSpecies());
                        totalCost += animal.TotalFoodCost(species[speciesIndex].GetCost());

                    }
                }
                catch (System.ArgumentOutOfRangeException e)
                {
                    string errorMessage = "No Animals have been entered yet";
                    MessageBox.Show(errorMessage);
                }




            return totalCost;
        }






    }




}



