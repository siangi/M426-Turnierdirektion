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
    public partial class ErstellenView : Form
    {
        public int SelectedPunkteSystem { get{ return cmbPunktesystem.SelectedIndex; }  }
        public List<string> Teilnehmer {
            get
            {
                List<string> Result = new List<string>();

                for (int i = 0; i < lstTeilnehmer.Items.Count; i++)
                {
                    Result.Add(lstTeilnehmer.Items[i].Text);
                }

                return Result;
            }
        }

        public ErstellenView()
        {
            InitializeComponent();
        }

        public ErstellenView(string[] Punktesysteme)
        {
            InitializeComponent();
            cmbPunktesystem.Items.AddRange(Punktesysteme);
        }

        private void btnHinzufuegen_Click(object sender, EventArgs e)
        {
            TeilnehmerDialog Dialog = new TeilnehmerDialog();
            string NewName = Dialog.Execute();

            lstTeilnehmer.Items.Add(NewName);
        }

        private void btnEntfernen_Click(object sender, EventArgs e)
        {
            if(lstTeilnehmer.SelectedItems.Count > 0)
            {
                foreach(ListViewItem item in lstTeilnehmer.SelectedItems)
                {
                    item.Remove();
                }
            }
        }

        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTurnierErstellen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
