using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnierdirektion
{
    class FussballSystem : IPunktesystem
    {
        private const int PUNKTE_SIEG = 3;
        private const int PUNKTE_UNENTSCHIEDEN = 1;
        private const int PUNKTE_VERLOREN = 0;

        private Teilnehmer Sieger = null;
        private Teilnehmer Verlierer = null;

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

        private void SetTordifferenz(Match value)
        {
            value.Teilnehmer1.ToreErzielt += value.Punkte1;
            value.Teilnehmer1.ToreErhalten += value.Punkte2;

            value.Teilnehmer2.ToreErzielt += value.Punkte2;
            value.Teilnehmer2.ToreErhalten += value.Punkte1;
        }
    }
}
