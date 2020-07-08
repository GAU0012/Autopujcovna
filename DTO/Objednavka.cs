using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Objednavka
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
    }
}

