using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Just_Nom.Classes
{
    public class Pizza : FoodItem
    {
        private PizzaRecipe recipe;
        private List<Topping> toppings = new List<Topping>();

        public Pizza() { }

        public Pizza(PizzaRecipe recipe)
        {
            this.recipe = recipe;
            this.BasePrice = recipe.BasePrice;
            this.toppings.AddRange(recipe.Toppings);
        }

        public List<Topping> Toppings
        {
            get { return new List<Topping>(toppings); }
        }

        public void AddTopping(Topping topping)
        {
            toppings.Add(topping);
        }

        public void RemoveTopping(Topping topping)
        {
            toppings.Remove(topping);
        }

        public override decimal CalculatedPrice()
        {
            decimal price = BasePrice;
            foreach (var topping in toppings)
            {
                price += topping.AdditionalCharge;
            }
            return price;
        }
    }

}