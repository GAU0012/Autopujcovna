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
    public class ZakaznickyUcetHandler
    {
        public static Collection<ZakaznickeUctyModel> Select()
        {
            Collection<ZakaznikUcet> zakaznickeUcty = ZakaznikUcetGateway.Select();
            Collection<ZakaznickeUctyModel> ret = new Collection<ZakaznickeUctyModel>();
            foreach (var zakaznickyUcer in zakaznickeUcty)
            {
                ret.Add(new ZakaznickeUctyModel(zakaznickyUcer));
            }
            return ret;
        }
        public static int Insert(int idzu, string login, string heslo, int idza)
        {
            return ZakaznikUcetGateway.Insert(idzu, login,heslo,idza);
        }

    }
}
