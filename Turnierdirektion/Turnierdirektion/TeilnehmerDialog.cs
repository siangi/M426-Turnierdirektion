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
    /// <summary>
    /// Dialog zum erstellen eines Teilnehmers.
    /// </summary>
    public partial class TeilnehmerDialog : Form
    {
        public TeilnehmerDialog()
        {
            InitializeComponent();
        }

        public string Execute()
        {
            this.ShowDialog();

            return txtName.Text;
        }

        private void btnHinzufuegen_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtName.Text))
                this.Close();
        }
    }
}
