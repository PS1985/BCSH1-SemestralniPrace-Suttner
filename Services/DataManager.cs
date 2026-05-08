using BCSH1_SemestralniPrace_Suttner.Models; 
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace BCSH1_SemestralniPrace_Suttner.Services
{
    internal class DataWrapper
    {
        public List<Vozidlo> Vozidla { get; set; } = new List<Vozidlo>();
        public List<Znacka> Znacky { get; set; } = new List<Znacka>();
        public List<Prodejce> Prodejci { get; set; } = new List<Prodejce>();
    }

    public class DataManager
    {
        public List<Vozidlo> SeznamVozidel { get; set; } = new List<Vozidlo>();
        public List<Znacka> SeznamZnacek { get; set; } = new List<Znacka>();
        public List<Prodejce> SeznamProdejcu { get; set; } = new List<Prodejce>();

        public DataManager()
        {
        }

        public void UlozData()
        {
            var wrapper = new DataWrapper
            {
                Vozidla = SeznamVozidel,
                Znacky = SeznamZnacek,
                Prodejci = SeznamProdejcu
            };

            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonText = JsonSerializer.Serialize(wrapper, options);
            File.WriteAllText("data.json", jsonText);
        }

        public void NactiData()
        {
            if (File.Exists("data.json"))
            {
                try
                {
                    string jsonText = File.ReadAllText("data.json");
                    var nactenyBalicek = JsonSerializer.Deserialize<DataWrapper>(jsonText);

                    if (nactenyBalicek != null)
                    {
                        SeznamVozidel = nactenyBalicek.Vozidla ?? new List<Vozidlo>();
                        SeznamZnacek = nactenyBalicek.Znacky ?? new List<Znacka>();
                        SeznamProdejcu = nactenyBalicek.Prodejci ?? new List<Prodejce>();
                    }
                }
                catch (Exception)
                {
                    SeznamVozidel = new List<Vozidlo>();
                    SeznamZnacek = new List<Znacka>();
                    SeznamProdejcu = new List<Prodejce>();
                }
            }
        }
    }
}