using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turnierdirektion
{
    public partial class DirektionView : Form, IObserver
    {
        List<Teilnehmer> Teilnehmerliste;
        IPunktesystem Punktesystem = null;
        public DirektionView(IPunktesystem punktesystem, List<Teilnehmer> teilnehmerliste)
        {
            InitializeComponent();
            Punktesystem = punktesystem;
            Teilnehmerliste = teilnehmerliste;
        }

        public void OnModelPropertyChanged(string PropertyMessage)
        {

        }

        public void SendMatchToModel(Teilnehmer HeimTeilnehmer, Teilnehmer GastTeilnehmer, int Heimtore, int Gasttore)
        {
            Match Match = new Match(HeimTeilnehmer, Heimtore, GastTeilnehmer, Gasttore);
            Punktesystem.MatchPunkteVerteilen(Match);
        }

        private void btnHinzufuegen_Click(object sender, EventArgs e)
        {
            pnlMatches.Controls.Add(new MatchControl(Teilnehmerliste));
        }
    }
}
