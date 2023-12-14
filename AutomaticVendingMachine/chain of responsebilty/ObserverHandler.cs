using AutomaticVendingMachine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AutomaticVendingMachine
{
    public class ObserverHandler : AbstractHandler
    {

        private ResponsibleSubject subject;
        private TheDeliverObserver observer;
        public ObserverHandler() {
            observer = new TheDeliverObserver();
            subject = new ResponsibleSubject();
            subject.Attach(observer);
        }
        
        public override object Handle(Product product)
        {
            if (product.Quantity  < 5)
            {
              subject.Notify(product);
                //Send a message to suppliers
                return base.Handle(product);
            }
            else
            {
                return base.Handle(product);
            }


        }  
        }
    }

