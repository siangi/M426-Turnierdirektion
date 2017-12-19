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
    /// <summary>
    /// Ansicht für die Zuschauer, zeigt die momentane Rangliste
    /// </summary>
    public partial class ZuschauerView : Form, IObserver
    {
        List<Teilnehmer> Rangliste = null;
        Turnier Model = null;

        public ZuschauerView(Turnier Model)
        {
            InitializeComponent();
            this.Model = Model;
        }

        /// <summary>
        /// Siehe Interface IObserver
        /// </summary>
        /// <param name="PropertyMessage"></param>
        public void OnModelPropertyChanged(string PropertyMessage)
        {
            if (PropertyMessage == "MatchSaved")
            {
                Rangliste = Model.GetTeilnehmerSortiert();
            }
            TabelleAnzeigen();
        }

        /// <summary>
        /// Esrstellt die Rangliste anhand einer vom Controller erhaltenen Liste.
        /// </summary>
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
