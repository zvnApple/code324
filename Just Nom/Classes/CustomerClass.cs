using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Just_Nom.Classes
{
    public class CustomerClass
    {
        public string Name { get; private set; }
        public Address Address { get; private set; }

        public CustomerClass(string name, Address address = null)
        {
            Name = name;
            Address = address;
        }
    }
}
