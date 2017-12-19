using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnierdirektion
{
    /// <summary>
    /// Interface für den Beobachter im Observer Muster
    /// </summary>
    public interface IObserver
    {
        /// <summary>
        /// Hier werden auf alle Nachrichten reagiert.
        /// </summary>
        /// <param name="PropertyMessage">Die Nachricht.</param>
        void OnModelPropertyChanged(string PropertyMessage);
    }
}
