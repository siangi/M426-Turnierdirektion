using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnierdirektion
{
    /// <summary>
    /// Punktesystem wie es in den Eishockeyligen eingesetzt werden.
    /// </summary>
    class EishockeySystem : IPunktesystem
    {
        private const int PUNKTE_SIEG = 3;
        private const int PUNKTE_SIEG_NACHSPIEL = 2;
        private const int PUNKTE_VERLOREN_NACHSPIEL = 1;
        private const int PUNKTE_VERLOREN = 0;

        private Teilnehmer Verlierer = null;
        private Teilnehmer Sieger = null;

        /// <summary>
        /// Masterfunktion, welche die Punkte an die Teams des Matches verteilt.
        /// </summary>
        /// <param name="Value">Match, welches auszuwerten ist.</param>
        public void MatchPunkteVerteilen(Match Value)
        {
            Sieger = null;
            Verlierer = null;

            SetSiegerVerlierer(Value);
            SetTordifferenz(Value);

            if (Value.IsVerlaengerung)
            {
                Sieger.Punkte += PUNKTE_SIEG_NACHSPIEL;
                Verlierer.Punkte += PUNKTE_VERLOREN_NACHSPIEL;
            }
            else
            if (Sieger == null || Verlierer == null)
                return;
            else
            {
                Sieger.Punkte += PUNKTE_SIEG;
                Verlierer.Punkte += PUNKTE_VERLOREN;
            }
        }

        /// <summary>
        /// Ermittelt den Sieger und Verlierer für die Masterfunktion
        /// </summary>
        /// <param name="Value">Match, welches ausgewertet wird.</param>
        private void SetSiegerVerlierer(Match Value)
        {
            if (Value.Punkte1 == Value.Punkte2)
                return;
            else
            if (Value.Punkte1 > Value.Punkte2)
            {
                Sieger = Value.Teilnehmer1;
                Verlierer = Value.Teilnehmer2;
            }
            else
            {
                Sieger = Value.Teilnehmer2;
                Verlierer = Value.Teilnehmer1;
            }
        }

        /// <summary>
        /// Aktualisiert die Tordifferenz für die beiden Teilnehmer.
        /// </summary>
        /// <param name="value">Match, welches ausgewertet wrid.</param>
        private void SetTordifferenz(Match value)
        {
            value.Teilnehmer1.ToreErzielt += value.Punkte1;
            value.Teilnehmer1.ToreErhalten += value.Punkte2;

            value.Teilnehmer2.ToreErzielt += value.Punkte2;
            value.Teilnehmer2.ToreErhalten += value.Punkte2;
        }
    }
}
