using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Models
{
    public class AutomobilModel
    {
        public int Ida { get; set; }
        public string Znacka { get; set; }
        public string Model { get; set; }
        public int Rok_vyroby { get; set; }
        public string Informace_o_poskozeni { get; set; }
        public string Hladina_paliva { get; set; }
        public int Zpusobily_jizdy { get; set; }
        public int Cena_za_den { get; set; }


        public AutomobilModel()
        {

        }

       

        public AutomobilModel(Automobil automobil)
        {
            Ida = automobil.Ida;
            Znacka = automobil.Znacka;
            Model = automobil.Model;
            Rok_vyroby = automobil.Rok_vyroby;
            Informace_o_poskozeni = automobil.Informace_o_poskozeni;
            Hladina_paliva = automobil.Hladina_paliva;
            Zpusobily_jizdy = automobil.Zpusobily_jizdy;
            Cena_za_den = automobil.Cena_za_den;
        }

        public Automobil ToDTO()
        {
            Automobil automobil = new Automobil()
            {
                Ida = Ida,
                Znacka = Znacka,
                Model = Model,
                Rok_vyroby = Rok_vyroby,
                Informace_o_poskozeni = Informace_o_poskozeni,
                Hladina_paliva = Hladina_paliva,
                Zpusobily_jizdy = Zpusobily_jizdy,
                Cena_za_den = Cena_za_den
            };
            return automobil;
        }

    }
}
