using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticVendingMachine
{
   
      class Cream : AbstractColdDrinkDecorator
    {
        public Cream(ColdDrink coldDrink) : base(coldDrink)
        {
        }
        public override int GetCost()
        {
            return coldDrink.GetCost() + 2;
        }
    }
}
