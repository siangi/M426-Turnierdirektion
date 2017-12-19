using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnierdirektion
{
    /// <summary>
    /// Hauptcontroller der gesamten Applikation, handelt das Erstellen und die Kommunikation 
    /// zwischen den Views, dem Turnier Controller und dem Model.
    /// </summary>
    public class HauptController
    {
        private Turnier Turnier = new Turnier();
        private ErstellenView m_erstellenView = null;
        private DirektionView m_direktionView = null;
        private ZuschauerView m_zuschauerView = null;

        public static readonly string[] Punktesysteme = { "Fussball (Sieg 3 P. Unentschieden 1 P.)", "Eishockey (Sieg 3P. Sieg nach Nachspielzeit 2 P.)" };

        /// <summary>
        /// Initiiert das Programm, erstellt und initiiert alle Views, Models und Controller.
        /// Dabei werden alle Beobachter beim Turnier Controller registriert und dann die Hauptformular angezeigt.
        /// </summary>
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

        /// <summary>
        /// Parst die Stringliste vom ErstellenDialog zu einer Teilnehmerliste.
        /// </summary>
        /// <param name="StringList"></param>
        /// <returns></returns>
        private List<Teilnehmer> TeilnehmerFromStringList(List<string> StringList)
        {
            List<Teilnehmer> TeilnehmerList = new List<Teilnehmer>();

            for (int i = 0; i < StringList.Count; i++)
                TeilnehmerList.Add(new Teilnehmer(StringList[i]));

            return TeilnehmerList;
        }

        /// <summary>
        /// Erstellt das entsprrechende Punktesystem nach Userangabe.
        /// Abhängig vom Array Punktesysteme
        /// </summary>
        /// <param name="ArrayIndex">Index des ausgewählten Punktesystemes im Array</param>
        /// <returns>Das Punktesystem-Objekt</returns>
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
