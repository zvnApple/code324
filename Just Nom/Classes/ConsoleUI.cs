using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Just_Nom.Classes
{
    public static class ConsoleUI
    {
        private static List<string> menuItems;

        private static Menu menu = new Menu();
        private static OrderManager orderManager = new OrderManager();

        static ConsoleUI()
        {
            try
            {
                initializeMenuItems();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred during static initialization: {ex.Message}");
                Console.WriteLine($"Stack Trace: {ex.StackTrace}");
                throw;
            }
        }

        public static void initializeMenuItems()
        {
            menuItems = new List<string>()
        {
            "1. Create an Order",
            "2. Add a Pizza",
            "3. Add a Burger",
            "4. Display Order",
            "5. Exit"
        };
        }

        public static void DisplayMenu()
        {
            bool exit = false;
            while (!exit)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Menu:");
                    foreach (var item in menuItems)
                    {
                        Console.WriteLine(item);
                    }

                    Console.WriteLine("\nSelect an option: ");
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out int selection))
                    {
                        switch (selection)
                        {
                            case 1:
                                CreateOrder();
                                break;
                            case 2:
                                AddPizza();
                                break;
                            case 3:
                                AddBurger();
                                break;
                            case 4:
                                DisplayOrder();
                                break;
                            case 5:
                                exit = true;
                                break;
                            default:
                                Console.WriteLine("Invalid selection. Please try again.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a number.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred while displaying the menu: {ex.Message}");
                }
                finally
                {
                    if (!exit)
                    {
                        Console.WriteLine("\nPress any key to return to the menu...");
                        Console.ReadKey();
                    }
                }
            }
        }

        private static void CreateOrder()
        {
            Console.Clear();
            orderManager.CreateOrder(menu);
            Console.WriteLine("Order created successfully! Press any key to return to the main menu.");
            Console.ReadKey();
        }

        private static void AddPizza()
        {
            Console.WriteLine("Adding a pizza...");
            
        }

        private static void AddBurger()
        {
            Console.WriteLine("Adding a burger...");
            AddBurger();
            

        }

        private static void DisplayOrder()
        {
            Console.WriteLine("Displaying the order...");
        }

        internal static int GetIntegerInRange(int min, int max)
        {
            while (true)
            {
                Console.Write($"Enter a number between {min} and {max}: ");
                if (int.TryParse(Console.ReadLine(), out int value) && value >= min && value <= max)
                {
                    return value;
                }
                Console.WriteLine("Invalid input. Please try again.");
            }
        }
    }

}
