using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnierdirektion
{
    /// <summary>
    /// Interface für den Überwachbaren des Observer Musters
    /// </summary>
    public interface IObservable
    {
        /// <summary>
        /// Registriert den Beobachter
        /// </summary>
        /// <param name="Value">Beobachter</param>
        void Register(IObserver Value);

        /// <summary>
        /// Aufrufen, um die Beobachter zu benachrichtigen
        /// </summary>
        /// <param name="Message">nachricht</param>
        void InvokePropertyChanged(string Message);
    }
}
