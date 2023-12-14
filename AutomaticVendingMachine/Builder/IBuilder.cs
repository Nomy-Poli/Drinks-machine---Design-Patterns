using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticVendingMachine
{
    public interface IBuilder
    {
        void AddCoffee();
        void AddShoko();
        void AddWater();
        void AddMilk();
        void AddWhippedmilk();
        void AddSugar();
        void AddChocolate();
    }
}
