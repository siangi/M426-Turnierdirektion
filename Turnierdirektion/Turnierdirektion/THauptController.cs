using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnierdirektion
{
    public class THauptController
    {
        TTurnier Turnier = new TTurnier();
        ErstellenView m_erstellenView = null;
        public static readonly string[] Punktesysteme = { "Fussball (Sieg 3 P. Unentschieden 1 P.)", "Eishockey (Sieg 3P. Sieg nach Nachspielzeit 2 P.)" };

        public void Run()
        {
            m_erstellenView = new ErstellenView(Punktesysteme);
            m_erstellenView.ShowDialog();

            int selectedIndex = m_erstellenView.SelectedPunkteSystem;
            List<string> Teilnehmer = m_erstellenView.Teilnehmer;

            Turnier.Teilnehmer = TeilnehmerFromStringList(Teilnehmer);
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
