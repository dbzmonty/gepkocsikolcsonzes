namespace Gepkocsikolcsonzes
{
    public partial class Fooldal : Form
    {
        private static List<Auto> autok = new List<Auto>();
        private static List<string> markak = new List<string>();

        public Fooldal()
        {
            InitializeComponent();
        }

        private void TSMI_Kilepes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Fooldal_Load(object sender, EventArgs e)
        {
            Fajlkezeles fk = new Fajlkezeles();
            autok = fk.Beolvasas();
            
            foreach (Auto auto in autok)
            {
                string marka = auto.Marka;
                if (!markak.Contains(marka))
                    markak.Add(marka);
            }

            markak.Sort();

            GepkocsikFeltoltese(markak);
        }

        private void GepkocsikFeltoltese(List<string> markak)
        {
            ToolStripMenuItem[] items = new ToolStripMenuItem[markak.Count];

            for (int i = 0; i < items.Length; i++)
            {
                items[i] = new ToolStripMenuItem();
                items[i].Name = "dynamicItem" + i.ToString();
                items[i].Tag = markak[i];
                items[i].Text = markak[i];
                items[i].Click += new EventHandler(MenuItemClickHandler);
            }

            TSMI_Gepkocsik.DropDownItems.AddRange(items);
        }

        private void MenuItemClickHandler(object? sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            ListaFeltoltese(clickedItem.Tag.ToString());
        }

        private void ListaFeltoltese(string marka)
        {
            lblMarka.Text = String.Empty;
            listView1.Items.Clear();

            foreach (Auto auto in autok)
            {
                if (auto.Marka == marka)
                {
                    string[] sor = { auto.Rendszam, auto.Fogyasztas };
                    ListViewItem lvi = new ListViewItem(sor);
                    listView1.Items.Add(lvi);
                    lblMarka.Text = "Márka: " + auto.Marka;
                }
            }
        }

        private void rovidtavuBerlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Berles berles = new Berles(false, autok, markak);
            berles.ShowDialog();
        }

        private void hosszutavuBerlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Berles berles = new Berles(true, autok, markak);
            berles.ShowDialog();
        }
    }
}