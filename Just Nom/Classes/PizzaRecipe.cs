using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Just_Nom.Classes
{
    public class PizzaRecipe
    {
        public string Name { get; private set; }
        public List<Topping> Toppings { get; private set; }
        public decimal BasePrice { get; private set; }

        public PizzaRecipe(string name, List<Topping> toppings, decimal basePrice)
        {
            Name = name;
            Toppings = toppings;
            BasePrice = basePrice;
        }
    }

}
