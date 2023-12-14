using AutomaticVendingMachine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AutomaticVendingMachine
{
    public class TheDeliverObserver : IObserver
    {
        //Here I enter the product that is missing from the supplier
        //and he makes sure to fill the same product to the amount of 100.
        //And also writes for the daily report that he made sure to update the quantity of a certain product

        string filePath;
        string text;
        public void Update( Product product)
        {
            product.Quantity = 100;
            DateTime currentTime = DateTime.Now;
            text = "in: " + currentTime.ToString("dd-MM-yyyy HH:mm:ss") + " the deliver add update the qty server to the : " + product.Name +"product";
            filePath = "..\\..\\..\\..\\" + currentTime.ToString("dd-MM-yyyy") + ".txt";
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(text);
            }
        }
    }
}
