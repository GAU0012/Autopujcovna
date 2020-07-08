using BuisnessLayer.Handlers;
using BuisnessLayer.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppFinal
{
    public partial class Login : System.Web.UI.Page
    {

        Collection<ZakaznickeUctyModel> zakaznickeUctyModels;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void heslo_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            zakaznickeUctyModels = ZakaznickyUcetHandler.Select();
            foreach(var row in zakaznickeUctyModels)
            {
                if(row.login == logintxt.Text && row.heslo == heslotxt.Text)
                {
                    Session["id"] = row.idzak;
                    Response.Redirect("HomePage.aspx");
                }
                else
                {
                    Label1.ForeColor = System.Drawing.Color.Red;             
                    Label1.Text = "Vaše heslo nebo Email je špatně zadan";
                }
            }
        }

        protected void heslotxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}