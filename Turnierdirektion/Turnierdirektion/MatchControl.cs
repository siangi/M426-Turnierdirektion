using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turnierdirektion
{
    public partial class MatchControl : UserControl
    {
        private SaveMatchMethod m_OnSavematch = null;
        public delegate void SaveMatchMethod(Teilnehmer HeimTeilnehmer, Teilnehmer GastTeilnehmer, int Heimtore, int Gasttore, bool IsVerlaengerung);
        public event SaveMatchMethod OnSaveMatch { add { m_OnSavematch = value; } remove { m_OnSavematch = null; } }

        private List<Teilnehmer> m_TeilnehmerListe;
        

        public MatchControl(List<Teilnehmer> teilnehmerListe)
        {
            InitializeComponent();
            m_TeilnehmerListe = teilnehmerListe;

            foreach (Teilnehmer teil in teilnehmerListe)
            {
                cmbHeim.Items.Add(teil.Name);
                cmbGast.Items.Add(teil.Name);
            }
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            var heimTeilnehmer = m_TeilnehmerListe.FirstOrDefault(tn => tn.Name == cmbHeim.Text);
            var gastTeilnehmer = m_TeilnehmerListe.FirstOrDefault(tn => tn.Name == cmbGast.Text);
            var heimtore = int.Parse(txtHeimtore.Text);
            var gasttore = int.Parse(txtGasttore.Text);

            if (m_OnSavematch != null && cmbHeim.SelectedItem != cmbGast.SelectedItem)
                m_OnSavematch(heimTeilnehmer, gastTeilnehmer, heimtore, gasttore, chkVerlaengerung.Checked);
        }
    }
}
