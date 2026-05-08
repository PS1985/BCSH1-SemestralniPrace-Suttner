using BCSH1_SemestralniPrace_Suttner.Models;
using BCSH1_SemestralniPrace_Suttner.Services;

namespace BCSH1_SemestralniPrace_Suttner.Forms
{
    public partial class FormInzerce : Form
    {
        private DataManager _dataManager;
        public DataManager SprávceDat => _dataManager; 


        public FormInzerce(DataManager dataManager)
        {
            InitializeComponent();
            _dataManager = dataManager;

            NaplnZnacky();
            VykresliInzeraty(_dataManager.SeznamVozidel);
        }

        private void NaplnZnacky()
        {
            var seznam = new List<Znacka>();
            seznam.Add(new Znacka { Id = -1, Nazev = "Všechny značky" });
            seznam.AddRange(_dataManager.SeznamZnacek);

            cmbZnacka.DataSource = seznam;
            cmbZnacka.DisplayMember = "Nazev";
            cmbZnacka.ValueMember = "Id";
        }

        private void VykresliInzeraty(List<Vozidlo> seznam)
        {
            flpObsah.Controls.Clear();
            foreach (var auto in seznam)
            {
                InzeratControl karticka = new InzeratControl();
                karticka.NastavUdaje(auto);
                flpObsah.Controls.Add(karticka);
            }
        }

        private void btnVyhledat_Click(object sender, EventArgs e)
        {
            string hledanyText = txtNazev.Text.Trim().ToLower();

            int vybranaZnackaId = -1;
            if (cmbZnacka.SelectedValue != null && cmbZnacka.SelectedValue is int)
            {
                vybranaZnackaId = (int)cmbZnacka.SelectedValue;
            }

            var vysledek = _dataManager.SeznamVozidel.Where(auto =>
            {
                bool odpovidaZnacka = (vybranaZnackaId == -1 || auto.ZnackaId == vybranaZnackaId);

                bool odpovidaText = string.IsNullOrWhiteSpace(hledanyText) ||
                                    (auto.Model != null && auto.Model.ToLower().Contains(hledanyText));

                return odpovidaZnacka && odpovidaText;
            }).ToList();

            VykresliInzeraty(vysledek);
        }

        private void btnZpet_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ObnovSeznam()
        {
            VykresliInzeraty(_dataManager.SeznamVozidel);
        }
    }
}