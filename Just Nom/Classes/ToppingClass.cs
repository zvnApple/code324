using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Just_Nom.Classes
{
    public class Topping
    {
        public string Name { get; private set; }
        public decimal AdditionalCharge { get; private set; }

        public Topping() { }

        public Topping(string name, decimal additionalCharge)
        {
            Name = name;
            AdditionalCharge = additionalCharge;
        }
    }

}
