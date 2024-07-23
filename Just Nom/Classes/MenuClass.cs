using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Just_Nom.Classes
{
    public class Menu
    {
        private List<FoodItem> foodItems;

        public Menu()
        {
            foodItems = new List<FoodItem>()


            {
                new Pizza(new PizzaRecipe("Margherita",
                new List<Topping> { new Topping("Tomato Sauce", 0), new Topping("Cheese", 0) }, 8)),
                new Burger (new BurgerRecipe("Cheese Burger",
                new List<Garnish> { new Garnish("Cheese", 0) }, 5))
            };
        }

        public Menu(List<FoodItem> foodItems)
        {
            this.foodItems = foodItems;
            
        }

        public void DisplayMenu()
        {
            Console.WriteLine("Menu:");
            foreach (var item in foodItems)
            {
                Console.WriteLine($"{GetMenuItems} - {item.BasePrice:C}");
            }
            string customerResponse = Console.ReadLine();
            Console.WriteLine($"Are you sure you want{customerResponse}");
        }

        public List<FoodItem> GetMenuItems()
        {
            return new List<FoodItem>(foodItems);
        }
    }

}
