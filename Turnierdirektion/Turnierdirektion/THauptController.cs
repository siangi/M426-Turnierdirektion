using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnierdirektion
{
    public class THauptController
    {
        private TTurnier Turnier = new TTurnier();
        private ErstellenView m_erstellenView = null;
        private DirektionView m_direktionView = null;
        private ZuschauerView m_zuschauerView = null;

        public static readonly string[] Punktesysteme = { "Fussball (Sieg 3 P. Unentschieden 1 P.)", "Eishockey (Sieg 3P. Sieg nach Nachspielzeit 2 P.)" };

        public void Run()
        {
            m_erstellenView = new ErstellenView(Punktesysteme);
            m_erstellenView.ShowDialog();

            int selectedIndex = m_erstellenView.SelectedPunkteSystem;
            List<string> Teilnehmer = m_erstellenView.Teilnehmer;

            Turnier.Teilnehmer = TeilnehmerFromStringList(Teilnehmer);
            Turnier.Punktesystem = CreatePunkteSystem(selectedIndex);

            m_direktionView = new DirektionView(Turnier, Turnier.Teilnehmer);
            m_zuschauerView = new ZuschauerView(Turnier);

            Turnier.Register(m_direktionView);
            Turnier.Register(m_zuschauerView);

            m_zuschauerView.Show();            
            m_direktionView.ShowDialog();
        }

        private List<Teilnehmer> TeilnehmerFromStringList(List<string> StringList)
        {
            List<Teilnehmer> TeilnehmerList = new List<Teilnehmer>();

            for (int i = 0; i < StringList.Count; i++)
                TeilnehmerList.Add(new Teilnehmer(StringList[i]));

            return TeilnehmerList;
        }

        private IPunktesystem CreatePunkteSystem(int ArrayIndex)
        {
            IPunktesystem punktesystem = null;

            switch (ArrayIndex)
            {
                case 0:
                    punktesystem = new FussballSystem();
                    break;

                case 1:
                    punktesystem = new EishockeySystem();
                    break;
            }
            return punktesystem;
        }
    }
}
