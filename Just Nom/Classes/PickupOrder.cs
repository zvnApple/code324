using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Just_Nom.Classes
{
    public class PickupOrder : Order
    {
        public PickupOrder(CustomerClass customer) : base(customer) { }

        public override decimal CalculateTotalPrice()
        {
            decimal total = 0;
            foreach (var item in FoodItems)
            {
                total += item.CalculatedPrice();
            }
             return total;
        }
    }
}
