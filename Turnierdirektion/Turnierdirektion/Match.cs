using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnierdirektion
{
    public class Match
    {
        public Match(Teilnehmer teilnehmer1, int punkte1, Teilnehmer teilnehmer2, int punkte2, bool isVerlaengerung)
        {
            this.Teilnehmer1 = teilnehmer1;
            this.Teilnehmer2 = teilnehmer2;
            this.Punkte1 = punkte1;
            this.Punkte2 = punkte2;
            this.IsVerlaengerung = isVerlaengerung;
        }

        public Teilnehmer Teilnehmer1 { get; set; }

        public int Punkte1 { get; set; }

        public Teilnehmer Teilnehmer2 { get; set; }

        public int Punkte2 { get; set; }

        public bool IsVerlaengerung { get; set; }
    }
}
