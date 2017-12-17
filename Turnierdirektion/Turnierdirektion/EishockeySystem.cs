using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnierdirektion
{
    class EishockeySystem : IPunktesystem
    {
        private const int PUNKTE_SIEG = 3;
        private const int PUNKTE_SIEG_NACHSPIEL = 2;
        private const int PUNKTE_VERLOREN_NACHSPIEL = 1;
        private const int PUNKTE_VERLOREN = 0;

        private Teilnehmer Verlierer = null;
        private Teilnehmer Sieger = null;

        public void MatchPunkteVerteilen(Match Value)
        {
            SetSiegerVerlierer(Value);
            
            if (Value.IsVerlaengerung)
            {
                Sieger.Punkte += PUNKTE_SIEG_NACHSPIEL;
                Verlierer.Punkte += PUNKTE_VERLOREN_NACHSPIEL;
            }
            else
            {
                Sieger.Punkte += PUNKTE_SIEG;
                Verlierer.Punkte += PUNKTE_VERLOREN;
            }
        }

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
    }
}
