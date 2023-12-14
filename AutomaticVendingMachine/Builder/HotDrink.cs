using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticVendingMachine
{
    public class HotDrink :Product
    {
        public List<string> ingredients { get; set; }
        public HotDrink() :base() 
        {
            this.ingredients = new List<string>();
            this.Price = 15;
            this.Name = "Hot Drink";
            this.Quantity = 20;
            this.Type = "drink";

        }
    }
}
