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
    public partial class DirektionView : Form, IObserver
    {
        public DirektionView()
        {
            InitializeComponent();
        }

        public void OnModelPropertyChanged(string PropertyMessage)
        {
            throw new NotImplementedException();
        }
    }
}
