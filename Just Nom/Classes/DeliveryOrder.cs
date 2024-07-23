using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Just_Nom.Classes
{
    public class DeliveryOrder : Order
    {
        private const decimal DeliveryCharge = 2.00m;

        public DeliveryOrder(CustomerClass customer) : base(customer) { }

        public override decimal CalculateTotalPrice()
        {
            decimal total = 0;
            foreach (var item in FoodItems)
            {
                total += item.CalculatedPrice();
            }
            if (total <= 20)
            {
                total += DeliveryCharge;
            }
            return total;
        }
    }
}
