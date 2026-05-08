using BCSH1_SemestralniPrace_Suttner.Models;
using BCSH1_SemestralniPrace_Suttner.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BCSH1_SemestralniPrace_Suttner.Forms
{
    public partial class InzeratControl : UserControl
    {
        private Vozidlo _auto;

        public InzeratControl()
        {
            InitializeComponent();
        }

        public void NastavUdaje(Vozidlo auto)
        {
            _auto = auto;

            lblModel.Text = auto.Model;
            lblRokVyroby.Text = $"{auto.RokVyroby} | {auto.Kilometry} km | {auto.Palivo}";
            lblCena.Text = $"{auto.Cena:N0} Kč";

            if (!string.IsNullOrEmpty(auto.CestaKObrazku))
            {
                string absolutniCesta = Path.Combine(Application.StartupPath, auto.CestaKObrazku);
                if (File.Exists(absolutniCesta))
                {
                    using (var stream = new FileStream(absolutniCesta, FileMode.Open, FileAccess.Read))
                    {
                        pbFotoVozidla.Image = Image.FromStream(stream);
                    }
                }
            }
        }

        private void btnDetail_Click_1(object sender, EventArgs e)
        {
            DataManager dm = null;
            Form rodicovskyForm = this.FindForm();

            if (rodicovskyForm is FormInzerce inzerce) dm = inzerce.SprávceDat;
            else if (rodicovskyForm is FormHlavni hlavni) dm = hlavni.SprávceDat;

            if (dm == null || _auto == null) return;

            var znacka = dm.SeznamZnacek.Find(z => z.Id == _auto.ZnackaId);
            var prodejce = dm.SeznamProdejcu.Find(p => p.Id == _auto.ProdejceId);

            FormDetail detail = new FormDetail(_auto, znacka, prodejce, dm);

            if (detail.ShowDialog() == DialogResult.OK)
            {
                if (rodicovskyForm is FormInzerce frmInzerce)
                {
                    frmInzerce.ObnovSeznam();
                }
                else if (rodicovskyForm is FormHlavni frmHlavni)
                {
                    frmHlavni.VykresliInzeraty();
                }
            }
        }
    }
}