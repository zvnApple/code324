using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Just_Nom.Classes
{
    public abstract class Order
    {
        private List<FoodItem> foodItems = new List<FoodItem>();
        private CustomerClass customer;
        private FoodItem foodItem;
        private Order orders;

        private decimal TotalPrice { get; set; }
        private Address Address { get; set; }
        public Order(CustomerClass customer)
        {
            this.customer = customer;
        }
        public Order(Address address)
        {
            this.Address = address;
        }
        public CustomerClass Customer
        {
            get { return customer; }

        }

        public List<FoodItem> FoodItems
        {
            get { return new List<FoodItem>(foodItems); }
        }
       
        public void AddFoodItem(FoodItem item)
        {
            foodItems.Add(foodItem);
            TotalPrice = item.CalculatedPrice();
        }

        public void RemoveFoodItem(FoodItem item)
        {
            foodItems.Remove(item);
            TotalPrice -= item.CalculatedPrice();
        }

        public decimal GetTotalPrice()
        {
            return TotalPrice;
        }
  
        public abstract decimal CalculateTotalPrice();

        

        public string WriteToFile()
        {
            string orderDetails = $"Your order {customer.Name}\n";
            if (customer != null)
            {
                orderDetails += $"This order will be delivered to: {customer.Address.Street}, {customer.Address.City},{customer.Address.PostCode}\n";
            }
            orderDetails += "items: \n";
            string fileName = $"{Customer.Name}'s Order.txt";
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine("Just Nom");
                writer.WriteLine($"{foodItems}");
                writer.WriteLine($"Customer: {customer.Name}");
                writer.WriteLine("Order Details:");
                foreach (var item in FoodItems)
                {
                    writer.WriteLine($"{item.Name}: {item.CalculatedPrice:C}");
                }

                writer.WriteLine($"Total Price: {TotalPrice}");
            }
            foreach (var item in foodItems)
            {
                orderDetails += $"- {item.Name}: {item.CalculatedPrice():C}\n";
            }
            orderDetails += $"Totl: {CalculateTotalPrice():C}\n";
            return orderDetails;

        }
    }

}
