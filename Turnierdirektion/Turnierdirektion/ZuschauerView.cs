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
        public ZuschauerView()
        {
            InitializeComponent();
        }

        public void OnModelPropertyChanged(string PropertyMessage)
        {
            throw new NotImplementedException();
        }
    }
}
