using AutomaticVendingMachine;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticVendingMachine
{
    public class ResponsibleSubject : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            this._observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this._observers.Remove(observer);
        }
        public void Notify(Product product)
        {
            foreach (var observer in _observers)
            {
                observer.Update(product);
            }
        }
        
    }
}
