using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnierdirektion
{
    public class TTurnier : IObservable
    {
        private List<IObserver> m_Observers = new List<IObserver>();
        public List<Teilnehmer> Teilnehmer { get; set; }
        public IPunktesystem Punktesystem { get; set; }
        public List<Match> Matches { get; set; }
        public void InvokePropertyChanged(string Message)
        {
            for (int i = 0; i < m_Observers.Count; i++)
            {
                m_Observers[i].OnModelPropertyChanged(Message);
            }
        }

        public void Register(IObserver Value)
        {
            if (Value == null)
                return;

            m_Observers.Add(Value);
        }

        public void OnMatchSave(Teilnehmer HeimTeilnehmer, Teilnehmer GastTeilnehmer, int Heimtore, int Gasttore, bool IsVerlaengerung)
        {
            Match Match = new Match(HeimTeilnehmer, Heimtore, GastTeilnehmer, Gasttore);
            Punktesystem.MatchPunkteVerteilen(Match);
            InvokePropertyChanged("MatchSaved");
        }

        public List<Teilnehmer> GetTeilnehemrSortiert()
        {
            List<Teilnehmer> SortedList = Teilnehmer.OrderByDescending(o => o.Punkte).ToList();

            return SortedList;
        }
    }
}
