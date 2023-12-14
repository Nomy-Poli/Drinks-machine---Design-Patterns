using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticVendingMachine
{
     class IceCofee : ColdDrink
    {
        
        public override int GetCost()
        {
            return 7;
        }
    }
}
