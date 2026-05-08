using BCSH1_SemestralniPrace_Suttner.Models;
using BCSH1_SemestralniPrace_Suttner.Services;
using System.IO;

namespace BCSH1_SemestralniPrace_Suttner.Forms
{
    public partial class FormDetail : Form
    {
        private Vozidlo _auto;
        private DataManager _dataManager;
        public FormDetail(Vozidlo auto, Znacka znacka, Prodejce prodejce, DataManager dataManager)
        {
            InitializeComponent();
            _auto = auto;
            _dataManager = dataManager;

            string nazevZnacky = znacka != null ? znacka.Nazev : "Neznámá značka";
            lblNazev.Text = $"{nazevZnacky} {auto.Model}";

            lblVin.Text = $"VIN: {auto.Vin}";
            lblRokVyroby.Text = $"Rok výroby: {auto.RokVyroby}";
            lblKilometry.Text = $"Najeto: {auto.Kilometry:N0} km";
            lblPalivo.Text = $"Palivo: {auto.Palivo}";
            lblCena.Text = $"Cena: {auto.Cena:N0} Kč";

            if (prodejce != null)
            {
                lblProdejceJmeno.Text = $"Prodejce: {prodejce.Jmeno}";
                lblProdejceKontakt.Text = $"Kontakt: {prodejce.Kontakt}";
            }

            if (!string.IsNullOrEmpty(auto.CestaKObrazku))
            {
                string cesta = Path.Combine(Application.StartupPath, auto.CestaKObrazku);
                if (File.Exists(cesta))
                {
                    using (FileStream fs = new FileStream(cesta, FileMode.Open, FileAccess.Read))
                    {
                        pbVelkaFotka.Image = Image.FromStream(fs);
                    }
                    pbVelkaFotka.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }

        private void btnSmazat_Click(object sender, EventArgs e)
        {
            var vysledek = MessageBox.Show(
                "Opravdu chcete tento inzerát smazat?",
                "Potvrdit smazání",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (vysledek == DialogResult.Yes)
            {
                if (!string.IsNullOrEmpty(_auto.CestaKObrazku))
                {
                    string cestaKObrazku = Path.Combine(Application.StartupPath, _auto.CestaKObrazku);
                    if (pbVelkaFotka.Image != null)
                    {
                        pbVelkaFotka.Image.Dispose();
                        pbVelkaFotka.Image = null;
                    }
                    if (File.Exists(cestaKObrazku))
                    {
                        try { File.Delete(cestaKObrazku); } catch { }
                    }
                }

                var prodejce = _dataManager.SeznamProdejcu.Find(p => p.Id == _auto.ProdejceId);

                _dataManager.SeznamVozidel.Remove(_auto);

                if (prodejce != null)
                {
                    bool maDalsiInzeraty = _dataManager.SeznamVozidel.Any(v => v.ProdejceId == prodejce.Id);

                    if (!maDalsiInzeraty)
                    {
                        _dataManager.SeznamProdejcu.Remove(prodejce);
                    }
                }

                _dataManager.UlozData();

                MessageBox.Show("Inzerát i s prodejcem byli úspěšně smazáni.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnZpet_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpravit_Click(object sender, EventArgs e)
        {
            FormPridatVozidlo oknoUprav = new FormPridatVozidlo();

            var znacka = _dataManager.SeznamZnacek.Find(z => z.Id == _auto.ZnackaId);
            var prodejce = _dataManager.SeznamProdejcu.Find(p => p.Id == _auto.ProdejceId);

            oknoUprav.PripravProEditaci(_auto, _dataManager.SeznamZnacek, prodejce);

            if (oknoUprav.ShowDialog() == DialogResult.OK)
            {
                if (prodejce != null)
                {
                    prodejce.Jmeno = oknoUprav.NovyProdejce.Jmeno;
                    prodejce.Kontakt = oknoUprav.NovyProdejce.Kontakt;
                }

                _dataManager.UlozData();
                MessageBox.Show("Změny byly uloženy.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}