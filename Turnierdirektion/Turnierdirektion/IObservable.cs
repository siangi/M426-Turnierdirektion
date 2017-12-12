using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnierdirektion
{
    public interface IObservable
    {
        void Register(IObserver Value);

        void InvokePropertyChanged(string Message);
    }
}
