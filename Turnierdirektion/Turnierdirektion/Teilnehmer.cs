using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnierdirektion
{
    public class Teilnehmer
    {
        public Teilnehmer(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
        public int Punkte { get; set; }
    }
}