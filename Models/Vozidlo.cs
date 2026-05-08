using System;
using System.Collections.Generic;
using System.Text;

namespace BCSH1_SemestralniPrace_Suttner.Models
{
    public class Vozidlo
    {
        public int Id { get; set; }
        public string Vin { get; set; }
        public string Model { get; set; }
        public int RokVyroby { get; set; }
        public int Kilometry { get; set; }
        public decimal Cena { get; set; }
        public string Palivo { get; set; }

        public int ZnackaId { get; set; }
        public int ProdejceId { get; set; }
        public string CestaKObrazku { get; set; }
    }
}
