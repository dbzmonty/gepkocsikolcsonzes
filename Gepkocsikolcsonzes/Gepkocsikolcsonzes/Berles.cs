using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gepkocsikolcsonzes
{
    public partial class Berles : Form
    {
        private bool hosszutavu;
        private List<Auto> autok;
        private List<string> markak;

        public Berles(bool hosszutavu, List<Auto> autok, List<string> markak)
        {
            InitializeComponent();
            this.hosszutavu = hosszutavu;
            this.autok = autok;
            this.markak = markak;
        }

        private void Berles_Load(object sender, EventArgs e)
        {
            if (hosszutavu) this.Text = "Hosszútávú bérlés";
            else this.Text = "Rövidtávú bérlés";

            foreach (string marka in markak)
            {
                cmbMarka.Items.Add(marka);
            }

            listView.MultiSelect = false;
            dtpKezdete.Value = DateTime.Today;

            if (hosszutavu)
            {
                nudNapok.Minimum = 2;
            }
            else
            {
                nudNapok.Enabled = false;
            }
        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMarka.SelectedIndex != -1)
            {
                listView.Items.Clear();

                foreach (Auto auto in autok)
                {
                    if (auto.Marka == cmbMarka.SelectedItem.ToString())
                    {
                        string[] sor = { auto.Rendszam, auto.Fogyasztas };
                        ListViewItem lvi = new ListViewItem(sor);
                        listView.Items.Add(lvi);
                    }
                }
            }
        }

        private bool Ellenorzes()
        {
            string hibauzenet = String.Empty;

            if (cmbMarka.SelectedIndex < 0) hibauzenet += "\tVálasszon autómárkát!\n";
            if (listView.SelectedItems.Count != 1) hibauzenet += "\tVálasszon autót!\n";
            if (txtNev.Text.Trim().Length < 3) hibauzenet += "\tAdja meg a nevet!\n";
            if (hosszutavu && nudNapok.Value < 2) hibauzenet += "\tHosszú távon legalább 2 napot adjon meg!\n";
            if (!hosszutavu && 1 < nudNapok.Value) hibauzenet += "\tRövidtávon csak egy napra bérelheti!\n";

            if (hibauzenet != String.Empty)
            {
                MessageBox.Show(hibauzenet, "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Mentes()
        {
            ListViewItem lvi = listView.SelectedItems[0];

            string nev = txtNev.Text.Trim();
            string marka = cmbMarka.SelectedItem.ToString();
            string rendszam = lvi.SubItems[0].Text;
            string fogyasztas = lvi.SubItems[1].Text;
            DateTime datum = dtpKezdete.Value.Date;
            int idotartam = Convert.ToInt32(nudNapok.Value);

            Fajlkezeles fk = new Fajlkezeles();
            fk.Kiiras(nev, marka, rendszam, fogyasztas, datum, idotartam);
        }

        private void btnBerles_Click(object sender, EventArgs e)
        {
            if (Ellenorzes())
            {
                Mentes();
                MessageBox.Show("Sikeres mentés!", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnKilepes_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
