using AutomaticVendingMachine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomaticVendingMachine
{
   public  class PaymentHandler : AbstractHandler
    {
        string filePath ;
        string text;

        public override object Handle( Product product)
        {   DateTime currentTime = DateTime.Now;
            filePath= "..\\..\\..\\..\\"+ currentTime.ToString("dd-MM-yyyy")+".txt";
            text = "in: " + currentTime.ToString("dd-MM-yyyy HH:mm:ss") + " someone bought: " + product.Name;

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(text);
            }
            return base.Handle(product);
        }

    }
}
