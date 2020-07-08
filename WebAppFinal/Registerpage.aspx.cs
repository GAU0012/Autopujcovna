using BuisnessLayer.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppFinal
{
    

    public partial class Registerpage : System.Web.UI.Page
    {
        int PocetZakazniku = ZakaznikModelHandler.Count();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Register
        protected void Button1_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(TextBox1.Text))
            {
                Label1.ForeColor = System.Drawing.Color.Red;
                Label1.Text = "Jmeno není napsane";
            }
            else if (String.IsNullOrEmpty(TextBox2.Text))
            {
                Label2.ForeColor = System.Drawing.Color.Red;
                Label2.Text = "Přijmení není napsane";
            }
            else if (String.IsNullOrEmpty(TextBox4.Text))
            {
                Label3.ForeColor = System.Drawing.Color.Red;
                Label3.Text = "Tel. číslo není napsane";
            }
            else if (String.IsNullOrEmpty(TextBox5.Text))
            {
                Label4.ForeColor = System.Drawing.Color.Red;
                Label4.Text = "Email není napsane";
            }
            else if (String.IsNullOrEmpty(d.Value))
            {
                Label5.ForeColor = System.Drawing.Color.Red;
                Label5.Text = "Datum narozeni není napsan";
            }
            else if (String.IsNullOrEmpty(TextBox6.Text))
            {
                Label6.ForeColor = System.Drawing.Color.Red;
                Label6.Text = "Login není napsane";
            }
            else if (String.IsNullOrEmpty(TextBox7.Text))
            {
                Label7.ForeColor = System.Drawing.Color.Red;
                Label7.Text = "Heslo není napsane";
            }
            else
            {
                try
                {
                    Label8.ForeColor = System.Drawing.Color.Green;
                    Label8.Text = "Uživatel byl registrovan";

                    //ZakaznikModelHandler.Insert(PocetZakazniku + 1, TextBox1.Text, TextBox2.Text, Convert.ToDateTime(d.Value), int.Parse(TextBox4.Text), TextBox5.Text);
                    ZakaznickyUcetHandler.Insert(5, TextBox6.Text, TextBox7.Text, 6);
                }
                catch
                { }
                
            }     
        }
    }
}