using BCSH1_SemestralniPrace_Suttner.Models;
using System;
using System.Windows.Forms;
using System.IO;

namespace BCSH1_SemestralniPrace_Suttner.Forms
{
    public partial class FormPridatVozidlo : Form
    {
        public Vozidlo? NoveVozidlo { get; private set; }
        public Prodejce? NovyProdejce { get; private set; }
        private string vybranaCestaKFotce = "";
        private Vozidlo? _editovaneAuto;

        public FormPridatVozidlo()
        {
            InitializeComponent();

            cmbPalivo.Items.Clear();
            cmbPalivo.Items.AddRange(new string[] { "Benzín", "Nafta", "LPG", "Elektro", "Hybrid" });
            cmbPalivo.SelectedIndex = 0; 

            cmbMena.Items.Clear();
            cmbMena.Items.AddRange(new string[] { "Kč", "EUR", "USD" });
            cmbMena.SelectedIndex = 0; 
        }

        private void btnUlozit_Click_1(object sender, EventArgs e)
        {
            try
            {
                int prodejceId = _editovaneAuto?.ProdejceId ?? new Random().Next(100, 99999);

                NovyProdejce = new Prodejce
                {
                    Id = prodejceId,
                    Jmeno = txtProdejce.Text,
                    Kontakt = txtKontakt.Text
                };

                string relativniCesta = _editovaneAuto?.CestaKObrazku ?? "";
                if (!string.IsNullOrEmpty(vybranaCestaKFotce))
                {
                    string adresarImages = Path.Combine(Application.StartupPath, "images");
                    if (!Directory.Exists(adresarImages)) Directory.CreateDirectory(adresarImages);

                    string novyNazev = Guid.NewGuid().ToString() + Path.GetExtension(vybranaCestaKFotce);
                    string cilovaCesta = Path.Combine(adresarImages, novyNazev);

                    File.Copy(vybranaCestaKFotce, cilovaCesta);
                    relativniCesta = Path.Combine("images", novyNazev);
                }

                if (_editovaneAuto == null)
                {
                    NoveVozidlo = new Vozidlo { Id = new Random().Next(100, 99999) };
                }
                else
                {
                    NoveVozidlo = _editovaneAuto;
                }

                NoveVozidlo.Model = txtModel.Text;
                NoveVozidlo.Vin = txtVin.Text;
                NoveVozidlo.RokVyroby = int.Parse(txtRokVyroby.Text);
                NoveVozidlo.Kilometry = int.Parse(txtKilometry.Text);
                NoveVozidlo.Cena = decimal.Parse(txtCena.Text);
                NoveVozidlo.Palivo = cmbPalivo.Text;
                NoveVozidlo.CestaKObrazku = relativniCesta;
                NoveVozidlo.ZnackaId = (int)cmbZnacka.SelectedValue;
                NoveVozidlo.ProdejceId = NovyProdejce.Id;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba: " + ex.Message);
            }
        }

        private void btnNahratFoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbFotoVozidla.Image = Image.FromFile(openFileDialog1.FileName);
                pbFotoVozidla.SizeMode = PictureBoxSizeMode.Zoom;

                vybranaCestaKFotce = openFileDialog1.FileName;
            }
        }

        public void NaplnSeznamy(List<Znacka> znacky)
        {
            cmbZnacka.DataSource = null;

            cmbZnacka.DataSource = znacky;

            cmbZnacka.DisplayMember = "Nazev"; 
            cmbZnacka.ValueMember = "Id";      
        }

        public void PripravProEditaci(Vozidlo auto, List<Znacka> znacky, Prodejce prodejce)
        {
            _editovaneAuto = auto;
            NaplnSeznamy(znacky); 

            cmbZnacka.SelectedValue = auto.ZnackaId;
            txtModel.Text = auto.Model;
            txtVin.Text = auto.Vin;
            txtRokVyroby.Text = auto.RokVyroby.ToString();
            txtKilometry.Text = auto.Kilometry.ToString();
            txtCena.Text = auto.Cena.ToString();
            cmbPalivo.SelectedItem = auto.Palivo;

            if (prodejce != null)
            {
                txtProdejce.Text = prodejce.Jmeno;
                txtKontakt.Text = prodejce.Kontakt;
            }

            if (!string.IsNullOrEmpty(auto.CestaKObrazku))
            {
                string cesta = Path.Combine(Application.StartupPath, auto.CestaKObrazku);
                if (File.Exists(cesta))
                {
                    using (var fs = new FileStream(cesta, FileMode.Open, FileAccess.Read))
                    {
                        pbFotoVozidla.Image = new Bitmap(fs);
                    }
                    pbFotoVozidla.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }

            btnUlozit.Text = "Uložit změny";
        }
    }
}