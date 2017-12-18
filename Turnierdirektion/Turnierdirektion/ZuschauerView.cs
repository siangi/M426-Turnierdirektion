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
                Rangliste = Model.GetTeilnehemrSortiert();
            }
        }
    }
}
