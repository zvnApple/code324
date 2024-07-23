using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Just_Nom.Classes
{
    public class OrderManager
    {
        public CustomerClass customer { get; private set; }

        public void CreateOrder(Menu menu)
        {
           
           
     
            Console.WriteLine("Enter customer name: ");
            string customerName = Console.ReadLine();

            Console.Write("Is this a delivery order? [yes/no]: ");
            string deliveryOption = Console.ReadLine();
            bool isDelivery = deliveryOption.ToLower() == "yes";


            Address address = null;
            if (isDelivery)
            {
                address = GetDeliveryAddress();
            }

            var cusotomer = new CustomerClass(customerName, address);
            var order = isDelivery ? (Order)new DeliveryOrder(customer) : new PickupOrder(customer);

            var menuItems = menu.GetMenuItems();
            bool addingItems = true;

            while (addingItems)
            {
                Console.Clear();
                menu.DisplayMenu();
                Console.WriteLine("Select items to your order or type 'done' to finish.");

                string input = Console.ReadLine();
                if (input.ToLower() == "done")
                {
                    addingItems = false;
                }
                else if (int.TryParse(input, out int itemNumber) && itemNumber > 0 && itemNumber <= menuItems.Count)
                {
                    var selectedItem = menuItems[itemNumber - 1];
                    order.AddFoodItem(selectedItem);
                    Console.WriteLine($"{selectedItem} added to your order.");
                }
                else
                {
                    Console.WriteLine("YOu can not select that, please select a valid item");
                }
            }
            order.WriteToFile();
            Console.WriteLine("Order Summary:");
            Console.WriteLine(order.ToString());

        }

        private Address GetDeliveryAddress()
        {
            Console.Write("Enter your street name: ");
            string street = Console.ReadLine();

            Console.Write("Enter your city name: ");
            string city = Console.ReadLine();

            Console.Write("Enter your post code: ");
            string postCode = Console.ReadLine();

            return new Address(street, city, postCode);
        }

     

    
    }
}
