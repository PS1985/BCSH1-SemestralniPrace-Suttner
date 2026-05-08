using BCSH1_SemestralniPrace_Suttner.Services;
using BCSH1_SemestralniPrace_Suttner.Models;
using System;
using System.Windows.Forms;

namespace BCSH1_SemestralniPrace_Suttner.Forms
{
    public partial class FormHlavni : Form
    {
        private DataManager _dataManager;

        public DataManager SprávceDat => _dataManager;

        public FormHlavni()
        {
            InitializeComponent();
            _dataManager = new DataManager();
            _dataManager.NactiData();

            if (_dataManager.SeznamZnacek.Count == 0)
            {
                _dataManager.SeznamZnacek.Add(new Znacka { Id = 1, Nazev = "Škoda" });
                _dataManager.SeznamZnacek.Add(new Znacka { Id = 2, Nazev = "Volkswagen" });
                _dataManager.SeznamZnacek.Add(new Znacka { Id = 3, Nazev = "BMW" });
                _dataManager.SeznamZnacek.Add(new Znacka { Id = 4, Nazev = "Mercedes-Benz" });
                _dataManager.SeznamZnacek.Add(new Znacka { Id = 5, Nazev = "Audi" });
                _dataManager.SeznamZnacek.Add(new Znacka { Id = 6, Nazev = "Hyundai" });
                _dataManager.SeznamZnacek.Add(new Znacka { Id = 7, Nazev = "Kia" });
                _dataManager.SeznamZnacek.Add(new Znacka { Id = 8, Nazev = "Toyota" });
                _dataManager.SeznamZnacek.Add(new Znacka { Id = 9, Nazev = "Ford" });
                _dataManager.SeznamZnacek.Add(new Znacka { Id = 10, Nazev = "Peugeot" });
                _dataManager.SeznamZnacek.Add(new Znacka { Id = 11, Nazev = "Renault" });
                _dataManager.SeznamZnacek.Add(new Znacka { Id = 12, Nazev = "Citroën" });
                _dataManager.SeznamZnacek.Add(new Znacka { Id = 13, Nazev = "Opel" });
                _dataManager.SeznamZnacek.Add(new Znacka { Id = 14, Nazev = "Dacia" });
                _dataManager.SeznamZnacek.Add(new Znacka { Id = 15, Nazev = "Volvo" });
                _dataManager.SeznamZnacek.Add(new Znacka { Id = 16, Nazev = "Mazda" });
                _dataManager.SeznamZnacek.Add(new Znacka { Id = 17, Nazev = "Honda" });
                _dataManager.SeznamZnacek.Add(new Znacka { Id = 18, Nazev = "Fiat" });
                _dataManager.SeznamZnacek.Add(new Znacka { Id = 19, Nazev = "Seat" });
                _dataManager.SeznamZnacek.Add(new Znacka { Id = 20, Nazev = "Suzuki" });

                _dataManager.UlozData();
            }

            VykresliInzeraty();
        }

        public void VykresliInzeraty()
        {
            panelInzeraty.Controls.Clear();

            foreach (var auto in _dataManager.SeznamVozidel)
            {
                InzeratControl karticka = new InzeratControl();
                karticka.NastavUdaje(auto);

                panelInzeraty.Controls.Add(karticka);
            }
        }

        private void pbResize_Click(object sender, EventArgs e)
        {
            if (flpanelLeft.Width == 194)
            {
                flpanelLeft.Width = 64;

                btnInzerce.Text = "";
                btnPridatVozidlo.Text = "";
            }
            else
            {
                flpanelLeft.Width = 194;

                btnInzerce.Text = "        Inzerce";
                btnPridatVozidlo.Text = "        Přidat vozidlo";
            }

        }

        private void btnInzerce_Click(object sender, EventArgs e)
        {
            FormInzerce oknoInzerce = new FormInzerce(_dataManager);

            oknoInzerce.Show();
        }

        private void btnPridatVozidlo_Click(object sender, EventArgs e)
        {
            FormPridatVozidlo okno = new FormPridatVozidlo();
            okno.NaplnSeznamy(_dataManager.SeznamZnacek);

            if (okno.ShowDialog() == DialogResult.OK)
            {
                if (okno.NovyProdejce != null)
                {
                    _dataManager.SeznamProdejcu.Add(okno.NovyProdejce);
                }

                if (okno.NoveVozidlo != null)
                {
                    _dataManager.SeznamVozidel.Add(okno.NoveVozidlo);
                }

                _dataManager.UlozData();

                VykresliInzeraty();
            }
        }
    }
}