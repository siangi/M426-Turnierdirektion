﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turnierdirektion
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
        //    Application.EnableVisualStyles();
        //    Application.SetCompatibleTextRenderingDefault(false);
            HauptController MainControl = new HauptController();
            MainControl.Run();
        }
    }
}
