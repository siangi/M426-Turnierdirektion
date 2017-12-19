using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnierdirektion
{
    /// <summary>
    /// Controller für das erstellte Turnier.
    /// Beobachtetes Objekt
    /// </summary>
    public class TTurnier : IObservable
    {
        private List<IObserver> m_Observers = new List<IObserver>();
        public List<Teilnehmer> Teilnehmer { get; set; }
        public IPunktesystem Punktesystem { get; set; }
        public List<Match> Matches { get; set; }

        /// <summary>
        /// Siehe Interface IObservable
        /// </summary>
        /// <param name="Message"></param>
        public void InvokePropertyChanged(string Message)
        {
            for (int i = 0; i < m_Observers.Count; i++)
            {
                m_Observers[i].OnModelPropertyChanged(Message);
            }
        }

        /// <summary>
        /// Siehe Interface IObservable
        /// </summary>
        /// <param name="Value"></param>
        public void Register(IObserver Value)
        {
            if (Value == null)
                return;

            m_Observers.Add(Value);
        }
        
        /// <summary>
        /// Erstellt das Match und gibt es an das Punktesystem weiter.
        /// </summary>
        /// <param name="HeimTeilnehmer"></param>
        /// <param name="GastTeilnehmer"></param>
        /// <param name="Heimtore"></param>
        /// <param name="Gasttore"></param>
        /// <param name="IsVerlaengerung"></param>
        public void OnMatchSave(Teilnehmer HeimTeilnehmer, Teilnehmer GastTeilnehmer, int Heimtore, int Gasttore, bool IsVerlaengerung)
        {
            Match Match = new Match(HeimTeilnehmer, Heimtore, GastTeilnehmer, Gasttore, IsVerlaengerung);
            Punktesystem.MatchPunkteVerteilen(Match);
            InvokePropertyChanged("MatchSaved");
        }

        /// <summary>
        /// Sortiert die Liste im Teilnehmerproperty nach Punkten absteigend, für die Zuschauerübersicht.
        /// </summary>
        /// <returns>Sortierte Liste</returns>
        public List<Teilnehmer> GetTeilnehmerSortiert()
        {
            List<Teilnehmer> SortedList = Teilnehmer.OrderByDescending(o => o.Punkte).ThenByDescending(o => o.ToreErzielt - o.ToreErhalten).ThenByDescending(o => o.ToreErzielt).ToList();

            return SortedList;
        }
    }
}
