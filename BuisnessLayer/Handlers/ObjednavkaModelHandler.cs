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
   public class ObjednavkaModelHandler
    {
        public static Collection<ObjednavkaModel> Select()
        {
            Collection<Objednavka> objednavky = ObjednavkaGateway.Select();
            Collection<ObjednavkaModel> ret = new Collection<ObjednavkaModel>();
            foreach (var objednavka in objednavky)
            {
                ret.Add(new ObjednavkaModel(objednavka));
            }
            return ret;
        }

        public static Collection<ObjednavkaModel> SelectPoskozene()
        {
            Collection<Objednavka> objednavky = ObjednavkaGateway.SelectPoskozene();
            Collection<ObjednavkaModel> ret = new Collection<ObjednavkaModel>();
            foreach (var objednavka in objednavky)
            {
                ret.Add(new ObjednavkaModel(objednavka));
            }
            return ret;
        }

        public static Collection<ObjednavkaModel> SelectByZakaznik(int idz)
        {
            Collection<Objednavka> objednavky = ObjednavkaGateway.SelectzByZakaznik(idz);
            Collection<ObjednavkaModel> ret = new Collection<ObjednavkaModel>();
            foreach (var objednavka in objednavky)
            {
                ret.Add(new ObjednavkaModel(objednavka));
            }
            return ret;
        }

        public static void ExportToXml(string filename, int idz)
        {
            ObjednavkaGateway.ExportToXML(filename,idz);
        }

    }
}
