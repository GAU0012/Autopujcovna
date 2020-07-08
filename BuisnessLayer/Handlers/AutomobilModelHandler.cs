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
    public class AutomobilModelHandler
    {
        public static Collection<AutomobilModel> Select()
        {
            Collection<Automobil> automobily = AutomobilGateway.Select();
            Collection<AutomobilModel> ret = new Collection<AutomobilModel>();
            foreach (var automobil in automobily)
            {
                ret.Add(new AutomobilModel(automobil));
            }
            return ret;
        }



        public static Collection<AutomobilModel> SelectByID(int idA)
        {
            Collection<Automobil> automobily = AutomobilGateway.SelectByID(idA);
            Collection<AutomobilModel> ret = new Collection<AutomobilModel>();
            foreach (var automobil in automobily)
            {
                ret.Add(new AutomobilModel(automobil));
            }
            return ret;
        }

        public static AutomobilModel Detail(String Znacka, String Model)
        {
            return new AutomobilModel(AutomobilGateway.Detail(Znacka,Model));
        }

        public static void ExportToXml(string filename, int Id)
        {
            AutomobilGateway.ExportToXML(filename,Id);
        }


        public static Collection<AutomobilModel> SelectByZnackaModel (String Znacka,String Model)
        {
            Collection<Automobil> automobily = AutomobilGateway.SelectByZnackaModel(Znacka, Model);
            Collection<AutomobilModel> ret = new Collection<AutomobilModel>();
            foreach (var automobil in automobily)
            {
                ret.Add(new AutomobilModel(automobil));
            }
            return ret;
        }


        public static Collection<AutomobilModel> SelectByZnacka(String Znacka)
        {
            Collection<Automobil> automobily = AutomobilGateway.SelectByZnacka(Znacka);
            Collection<AutomobilModel> ret = new Collection<AutomobilModel>();
            foreach (var automobil in automobily)
            {
                ret.Add(new AutomobilModel(automobil));
            }
            return ret;
        }
        

    }
}
