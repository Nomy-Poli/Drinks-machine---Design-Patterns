using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticVendingMachine
{
    abstract class AbstractColdDrinkDecorator : ColdDrink

    {
        protected ColdDrink coldDrink;
        public AbstractColdDrinkDecorator(ColdDrink coldDrink)
        {
            this.coldDrink = coldDrink;
        }
        
    }
}
