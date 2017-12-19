using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnierdirektion
{
    /// <summary>
    /// Punktesystem wie es in den Fussballligen eingesetzt wird.
    /// </summary>
    class FussballSystem : IPunktesystem
    {
        private const int PUNKTE_SIEG = 3;
        private const int PUNKTE_UNENTSCHIEDEN = 1;
        private const int PUNKTE_VERLOREN = 0;

        private Teilnehmer Sieger = null;
        private Teilnehmer Verlierer = null;

        /// <summary>
        /// Master Funktion, welche die Punkte verteilt.
        /// </summary>
        /// <param name="Value">Match, welches ausgewertet werden muss.</param>
        public void MatchPunkteVerteilen(Match Value)
        {
            SetSiegerVerlierer(Value);
            SetTordifferenz(Value);

            // Bei unentschieden werden die Variabeln nicht abgefüllt 
            if (Sieger == null && Verlierer == null)
            {
                Value.Teilnehmer1.Punkte += PUNKTE_UNENTSCHIEDEN;
                Value.Teilnehmer2.Punkte += PUNKTE_UNENTSCHIEDEN;
            }
            else
            {
                Sieger.Punkte += PUNKTE_SIEG;
                Verlierer.Punkte += PUNKTE_VERLOREN;
            }
        }

        /// <summary>
        /// Ermittelt den Sieger & Verlierer des Spiels, setzt die Properties.
        /// </summary>
        /// <param name="Value">Das Match das ausgewertet wird.</param>
        private void SetSiegerVerlierer(Match Value)
        {
            Sieger = null;
            Verlierer = null;
            
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
        /// Setzt die Tordiffernz bei den Teilnehmern.
        /// </summary>
        /// <param name="value">Das Match, weleches ausgewertet wird.</param>
        private void SetTordifferenz(Match value)
        {
            value.Teilnehmer1.ToreErzielt += value.Punkte1;
            value.Teilnehmer1.ToreErhalten += value.Punkte2;

            value.Teilnehmer2.ToreErzielt += value.Punkte2;
            value.Teilnehmer2.ToreErhalten += value.Punkte1;
        }
    }
}
