using AutomaticVendingMachine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticVendingMachine
{
    
        class Client
        {
            public static object ClientCode(AbstractHandler handler,Product product)
            {
              return handler.Handle( product);    
            }
        }
}

