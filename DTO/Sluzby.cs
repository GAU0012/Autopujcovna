using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class Sluzby
    {
        public int Ids { get; set; }
        public string Nazev { get; set; }
        public int Cena { get; set; }
        public DateTime Datum_od { get; set; }
        public DateTime Datum_do { get; set; }
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
    }
}
