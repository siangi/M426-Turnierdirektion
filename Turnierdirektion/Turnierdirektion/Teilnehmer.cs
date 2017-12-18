using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnierdirektion
{
    public class Teilnehmer
    {
        public string Name { get; set; }
        public int Punkte { get; set; }
        public int ToreErzielt { get; set; }
        public int ToreErhalten { get; set; }

        public Teilnehmer(string name)
        {
            this.Name = name;
        }
    }
}