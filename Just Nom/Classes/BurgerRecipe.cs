using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Just_Nom.Classes
{
    public class BurgerRecipe
{
    public string Name { get; private set; }
    public List<Garnish> Garnishes { get; private set; }
    public decimal BasePrice { get; private set; }

    public BurgerRecipe(string name, List<Garnish> garnishes, decimal basePrice)
    {
        Name = name;
        Garnishes = garnishes;
        BasePrice = basePrice;
    }
}

}
