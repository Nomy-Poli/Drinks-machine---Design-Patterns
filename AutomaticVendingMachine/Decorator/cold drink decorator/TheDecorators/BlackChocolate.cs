using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticVendingMachine
{  
      class BlackChocolate : AbstractColdDrinkDecorator
    {
        public BlackChocolate(ColdDrink coldDrink) : base(coldDrink)
        {
        }
        public override int GetCost()
        {
            return coldDrink.GetCost() + 2;
        }
    }
}
