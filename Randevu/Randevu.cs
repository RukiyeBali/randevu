using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp13
{
    internal class Randevu
    {
        int id;
        string adSoyad;
        string telefon;
        string poliklinik;
        DateTime tarih;
        bool sigorta;

        public int Id { get => id; set => id = value; }
        public string AdSoyad { get => adSoyad; set => adSoyad = value; }
        public string Telefon { get => telefon; set => telefon = value; }
        public string Poliklinik { get => poliklinik; set => poliklinik = value; }
        public DateTime Tarih { get => tarih; set => tarih = value; }
        public bool Sigorta { get => sigorta; set => sigorta = value; }

        public Randevu(int id, string adSoyad, string telefon, string poliklinik, DateTime tarih, bool sigorta)
        {
            this.id = id;
            this.adSoyad = adSoyad;
            this.telefon = telefon;
            this.poliklinik = poliklinik;
            this.tarih = tarih;
            this.sigorta = sigorta;
        }
    }
}
