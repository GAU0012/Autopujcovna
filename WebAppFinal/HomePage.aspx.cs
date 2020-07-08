using BuisnessLayer.Handlers;
using BuisnessLayer.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppFinal
{
    public partial class HomePage : System.Web.UI.Page
    {

        Collection<ObjednavkaModel> objednavkamodel;
        protected void Page_Load(object sender, EventArgs e)
        {
            Label2.Text =  Session["id"].ToString();

            int idz = Int32.Parse(Session["id"].ToString());



            objednavkamodel = ObjednavkaModelHandler.SelectByZakaznik(idz);


          
            
            foreach (var row in objednavkamodel)
            {
                ListBox1.Items.Add("Datum od:  " + row.datum_vypujceni.ToString() + "  Datum do:  " + row.datum_vraceni.ToString() + "  Informace o vraceni:  "+ row.informace_o_vraceni + "  Poskozen:  "
                    + row.Poskozen.ToString() + "  Cena:  " + row.Cena.ToString() + "  Stav automobilu:  " + row.Stav_automobilu  );
            }
            
            
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //save
        protected void Button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}