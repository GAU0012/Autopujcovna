using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Models
{
    public class ObjednavkaModel
    {
        public int ido { get; set; }
        public DateTime datum_vypujceni { get; set; }
        public DateTime datum_vraceni { get; set; }
        public string informace_o_vraceni { get; set; }
        public string Poskozen { get; set; }
        public int Cena { get; set; }
        public string Stav_automobilu { get; set; }
        public int Sluzby_idS { get; set; }
        public int Automobil_idA { get; set; }
        public int Zakaznik_idZ { get; set; }

        public ObjednavkaModel()
        {

        }

        public ObjednavkaModel (Objednavka objednavka)
        {
            ido = objednavka.ido;
            datum_vypujceni = objednavka.datum_vypujceni;
            datum_vraceni = objednavka.datum_vraceni;
            informace_o_vraceni = objednavka.informace_o_vraceni;
            Poskozen = objednavka.Poskozen;
            Cena = objednavka.Cena;
            Stav_automobilu = objednavka.Stav_automobilu;
            Sluzby_idS = objednavka.Sluzby_idS;
            Automobil_idA = objednavka.Automobil_idA;
            Zakaznik_idZ = objednavka.Zakaznik_idZ;
        }

        public Objednavka ToDTO()//uvsech presvest ba DTOcka pak
        {
            Objednavka objednavka = new Objednavka()
            {
                ido = ido,
                datum_vypujceni = datum_vypujceni,
                datum_vraceni = datum_vraceni,
                informace_o_vraceni = informace_o_vraceni,
                Poskozen = Poskozen,
                Cena = Cena,
                Stav_automobilu = Stav_automobilu,
                Sluzby_idS = Sluzby_idS,
                Automobil_idA = Automobil_idA,
                Zakaznik_idZ = Zakaznik_idZ

            };
            return objednavka;
        }


    }
}
