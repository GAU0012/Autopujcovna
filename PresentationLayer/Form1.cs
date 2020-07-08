using BuisnessLayer.Handlers;
using BuisnessLayer.Models;
using System;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Form1_Load();
        }


        public int idOr = -1;
        Boolean hodnoceni;
        public ObjednavkaModel objednavkaHendler;
        Collection<ObjednavkaModel> objednavkamodel;

        private void Form1_Load()
        {
            objednavkamodel = ObjednavkaModelHandler.SelectPoskozene();
 
            foreach (var row in objednavkamodel)
            {
                string[] r = { row.Zakaznik_idZ.ToString(), row.datum_vypujceni.ToString(), row.datum_vraceni.ToString(),row.informace_o_vraceni,
                    row.Poskozen.ToString(), row.Cena.ToString(), row.ido.ToString()};
                listView1.Items.Add(new ListViewItem(r));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            hodnoceni = true;
            String text = listView1.SelectedItems[0].Text;

            

            foreach (var row in objednavkamodel)
            {
                string IdZ = row.Zakaznik_idZ.ToString();
                if (IdZ == text)
                {
                  
                  if ( row.informace_o_vraceni == "nema hodnoceni")
                  {
                        hodnoceni = false;
                        MessageBox.Show("Zakázka nemá hodnocení automechanik ");   
                  }
                }
            }

            
            if (hodnoceni)
            {
                FakturaForm faktura = new FakturaForm();
                this.Hide();
                faktura.idZ = int.Parse(text);
                faktura.ShowDialog();
                this.Close();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuForm main = new MenuForm();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
