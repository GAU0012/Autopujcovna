using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Models
{
   public class ZakaznickeUctyModel
    {
        public int idzu { get; set; }
        public string login { get; set; }
        public string heslo { get; set; }
        public int idzak { get; set; }

        public ZakaznickeUctyModel()
        {

        }

        public ZakaznickeUctyModel(ZakaznikUcet zakaznik)
        {
            idzu = zakaznik.idzu;
            login = zakaznik.login;
            heslo = zakaznik.heslo;
            idzak = zakaznik.idzak;
        }

        public ZakaznikUcet ToDTO()
        {
            ZakaznikUcet zakaznikUcet = new ZakaznikUcet()
            {
                idzu = idzu,
                login = login,
                heslo = heslo,
                idzak = idzak,
  
            };
            return zakaznikUcet;
        }
    }
}
