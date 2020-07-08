using BuisnessLayer.Models;
using DataLayerHandler.DatatAcces;
using DTO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Handlers
{
    public class ZakaznikModelHandler
    {
        /*

        public static Collection<ZakaznikModel> SelectById(int idZ)
        {
            Collection<Zakaznik> zakaznici = ZakaznikGateway.Detail(idZ);
            Collection<ZakaznikModel> ret = new Collection<ZakaznikModel>();
            foreach (var zakaznik in zakaznici)
            {
                ret.Add(new ZakaznikModel(zakaznik));
            }
            return ret;
        }
        */

        public static int Insert (int idz, string jmeno, string prijmeni, DateTime datum_narozeni, int Tel_cislo, string email)
        {
            return ZakaznikGateway.Insert(idz, jmeno, prijmeni, datum_narozeni, Tel_cislo, email);
        }

        public static int InsertSluzba(int ids, string nazev, int cena, DateTime od, DateTime doo, string jmeno, string prijmeni)
        {
            return ZakaznikGateway.InsertSluzba(ids, nazev, cena, od, doo, jmeno, prijmeni);
        }

        public static int Count()
        {
            return ZakaznikGateway.Count();
         
         }
        public static int CountSluzby()
        {
            return ZakaznikGateway.CountSluzby();
        }

        public static ZakaznikModel Detail(int idZakaznika)
        {
            return new ZakaznikModel(ZakaznikGateway.Detail(idZakaznika));
        }


    }
}
