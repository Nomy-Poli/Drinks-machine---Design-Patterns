using AutomaticVendingMachine;
using AutomaticVendingMachine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace AutomaticVendingmechin
{
    public class Machine
    {
        public Dictionary<string, Product> Products { get; set; }
        public CheckStockHandler checkStockHandler { get; set; }
        public ObserverHandler observerHandler { get; set; }
        public PaymentHandler paymentHandler { get; set; }

        public Machine()
        {
            Products = new Dictionary<string, Product>();
            checkStockHandler = new CheckStockHandler();
            observerHandler = new ObserverHandler();
            paymentHandler = new PaymentHandler();
            checkStockHandler
                .SetNext(observerHandler)
                .SetNext(paymentHandler);
        }

        public void AddProduct(string name, int quantity, double price,string type)
        {
            Product product = new Product
            {
                Name = name,
                Quantity = quantity,
                Price = price,
                Type=type
            };

            Products[name] = product;
        }
  

        public object Execute(string name)
        {

            try
            {
                if (Products[name].Type == "product")
                {
                    return Client.ClientCode(checkStockHandler, Products[name]);
                }
                if (Products[name].Type == "drink")
                {
                    return Client.ClientCode(paymentHandler, Products[name]);
                }
                return "worng.";
            }

            catch
            {
                return "worng.";
            }
        }

     
    }
}
