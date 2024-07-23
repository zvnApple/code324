using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Just_Nom.Classes
{
    public class Garnish
    {
        public string Name { get; private set; }
        public decimal AdditionalCharge { get; private set; }

        public Garnish() { }

        public Garnish(string name, decimal additionalCharge)
        {
            Name = name;
            AdditionalCharge = additionalCharge;
        }
    }

}
