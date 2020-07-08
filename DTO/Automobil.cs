using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Automobil
    {
        public int Ida { get; set; }
        public string Znacka { get; set; }
        public string Model { get; set; }
        public int Rok_vyroby { get; set; }
        public string Informace_o_poskozeni { get; set; }
        public string Hladina_paliva { get; set; }
        public int Zpusobily_jizdy { get; set; }
        public int Cena_za_den { get; set; }

    }
}
