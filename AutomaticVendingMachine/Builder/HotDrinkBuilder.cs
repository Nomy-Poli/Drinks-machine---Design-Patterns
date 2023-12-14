using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticVendingMachine
{
    public class HotDrinkBuilder : IBuilder
    {
        private HotDrink hotDrink = new HotDrink();

        public HotDrinkBuilder()
        {
            this.Reset();
        }    
        public void Reset()
        { 
            this.hotDrink = new HotDrink();
        }
        public void AddChocolate()
        {
            this.hotDrink.ingredients.Add("chocolate");
        }

        public void AddCoffee()
        {
            this.hotDrink.ingredients.Add("coffe");
        }

        public void AddMilk()
        {
            this.hotDrink.ingredients.Add("milk");
        }

        public void AddShoko()
        {
            this.hotDrink.ingredients.Add("shoko");
        }

        public void AddSugar()
        {
            this.hotDrink.ingredients.Add("sugar");
        }

        public void AddWater()
        {
            this.hotDrink.ingredients.Add("water");
        }

        public void AddWhippedmilk()
        {
            this.hotDrink.ingredients.Add("whipped milk");
        }
        public HotDrink GetDrink() 
        {
            HotDrink finished_product = this.hotDrink;
            this.Reset();
            return finished_product;
        }    
    }
}
