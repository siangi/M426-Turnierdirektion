using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnierdirektion
{
    public class THauptController
    {
        TTurnier m_Model = new TTurnier();
        ErstellenView m_erstellenView = null;
        public static readonly string[] Punktesysteme = { "Fussball (Sieg 3 P. Unentschieden 1 P.)", "Eishockey (Sieg 3P. Sieg nach Nachspielzeit 2 P.)" };

        public void Run()
        {
            m_erstellenView = new ErstellenView(Punktesysteme);
            m_erstellenView.ShowDialog();          
        }
    }
}
