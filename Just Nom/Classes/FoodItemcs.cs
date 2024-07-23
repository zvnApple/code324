using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Just_Nom.Classes
{
    public abstract class FoodItem
    {
        public string Name { get; protected set; }
        public decimal BasePrice { get; protected set; }

        public abstract decimal CalculatedPrice();
    }

}
