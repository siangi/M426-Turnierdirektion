using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnierdirektion
{
    /// <summary>
    /// Interface für die verschiedenen Punktesystemen
    /// </summary>
    public interface IPunktesystem
    {
        /// <summary>
        /// Hauptfunktion, soll die Punkte verteilen
        /// </summary>
        /// <param name="Value">Das auszuwertende Match</param>
        void MatchPunkteVerteilen(Match Value);
    }
}
