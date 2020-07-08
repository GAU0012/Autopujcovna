using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Models
{
    public class ZakaznikModel
    {

        public int idz { get; set; }
        public string jmeno { get; set; }
        public string Prijmeni { get; set; }
        public DateTime Datum_narozeni { get; set; }
        public int tel_cislo { get; set; }
        public string Email { get; set; }

        public ZakaznikModel ()
        {

        }

        public ZakaznikModel(Zakaznik zakaznik)
        {
            idz = zakaznik.idz;
            jmeno = zakaznik.jmeno;
            Prijmeni = zakaznik.Prijmeni;
            Datum_narozeni = zakaznik.Datum_narozeni;
            tel_cislo = zakaznik.tel_cislo;
            Email = zakaznik.Email;
        }

        public Zakaznik ToDTO()
        {
            Zakaznik zakaznik = new Zakaznik()
            {
                idz = idz,
                jmeno = jmeno,
                Prijmeni = Prijmeni,
                Datum_narozeni = Datum_narozeni,
                tel_cislo = tel_cislo,
                Email = Email
            };
            return zakaznik;
        }

    }
}
