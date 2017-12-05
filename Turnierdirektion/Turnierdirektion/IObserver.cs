using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnierdirektion
{
    public interface IObserver
    {
        void OnModelPropertyChanged(string PropertyMessage);
    }
}
