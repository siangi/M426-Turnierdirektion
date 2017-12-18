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
    public partial class ZuschauerView : Form, IObserver
    {
        List<Teilnehmer> Rangliste = null;
        TTurnier Model = null;

        public ZuschauerView(TTurnier Model)
        {
            InitializeComponent();
            this.Model = Model;
        }

        public void OnModelPropertyChanged(string PropertyMessage)
        {
            if (PropertyMessage == "MatchSaved")
            {
                Rangliste = Model.GetTeilnehmerSortiert();
            }
            TabelleAnzeigen();
        }

        private void TabelleAnzeigen()
        {
            lstTabelle.Items.Clear();
            for (int i = 0; i < Rangliste.Count; i++)
            {
                var teilnehmer = Rangliste[i];
                var lstItem = new ListViewItem((i + 1).ToString());
                lstItem.SubItems.Add(teilnehmer.Name);
                lstItem.SubItems.Add(teilnehmer.ToreErzielt + " : " + teilnehmer.ToreErhalten);
                lstItem.SubItems.Add(teilnehmer.Punkte.ToString());

                lstTabelle.Items.Add(lstItem);
            }
        }
    }
}
