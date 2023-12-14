using AutomaticVendingMachine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticVendingMachine
{
   public abstract class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;
        public IHandler SetNext(IHandler handler)
        {
            this._nextHandler = handler;
            return handler;
        }

        public virtual object Handle( Product product)
        {
            if (this._nextHandler != null)
            {
                return this._nextHandler.Handle(product);
            }
            else
            {
                return "Succeeded";
            }
        }

    }

}

