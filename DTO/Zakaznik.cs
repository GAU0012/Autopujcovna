using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Zakaznik
    {
        public int idz { get; set; }
        public string jmeno { get; set; }
        public string Prijmeni { get; set; }
        public DateTime Datum_narozeni { get; set; }
        public int tel_cislo { get; set; }
        public string Email { get; set; }
    }
}
