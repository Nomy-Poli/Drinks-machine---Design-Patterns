using AutomaticVendingMachine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticVendingMachine
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        object Handle( Product product);

    }
}
