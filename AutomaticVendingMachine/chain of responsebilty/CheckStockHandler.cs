using AutomaticVendingMachine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticVendingMachine
{
    public class CheckStockHandler : AbstractHandler
    {
       
        public override object Handle( Product product)
        {
            if (product.Quantity >0)
            {
                product.Quantity = product.Quantity - 1;
                return base.Handle(product);
            }
            else
            {
                return $"faild";

            }


        }
    }
}
