using BuisnessLayer.Handlers;
using BuisnessLayer.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.UC12
{
    public partial class NováVýpůjčkaForm : Form
    {
        public NováVýpůjčkaForm()
        {
            InitializeComponent();
            NováVýpůjčkaForm_load();
            
        }



        public int VybraneId;
        string znacka;
        string model;
  
        AutomobilModel VybraneAuto;
        Collection<AutomobilModel> automobils;
        Collection<ObjednavkaModel> objednavky;

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            

            comboBox2.Items.Clear();
            comboBox2.ResetText();

            //SqlConnection connection = DBConnector.GetInstance().GetConnection();

            string text = comboBox1.SelectedItem.ToString();
            // MessageBox.Show("zmena"+text);


            // automobils2 = AutomobilModelHandler.SelectByZnacka(comboBox1.SelectedItem.ToString());

            foreach (var row in automobils)
            {
                if (row.Znacka == text)
                {
                    comboBox2.Items.Add(row.Model);
                }
            }
            comboBox2.SelectedIndex = 0;
        }

        Boolean Uspech = true;

        private void NováVýpůjčkaForm_load()
        {

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";

            automobils = AutomobilModelHandler.Select();

            foreach (var row in automobils)
            {
                if (!comboBox1.Items.Contains(row.Znacka))
                {
                    comboBox1.Items.Add(row.Znacka);
                }
            }
            comboBox1.SelectedIndex = 0;

        }


        //hledej
        public void button1_Click(object sender, EventArgs e)
        {
            //SqlConnection connection = DBConnector.GetInstance().GetConnection();
            // znacka = (string)automobil2. [comboBox1.SelectedIndex]["znacka"];
            znacka = comboBox1.SelectedItem.ToString();
            model = comboBox2.SelectedItem.ToString();
            DateTime od = dateTimePicker1.Value;
            DateTime doo = dateTimePicker2.Value;

            //model = (string)automobil.Rows[comboBox2.SelectedIndex]["model"];

            MessageBox.Show(model + "  " + znacka );

            //SelectAutomobil = AutomobilModelHandler.SelectByZnackaModel(znacka, model);

            VybraneAuto = AutomobilModelHandler.Detail(znacka, model);

            

            if (od > doo)
            {
                Uspech = false;
                MessageBox.Show("Datum je špatně vyplněno");
            }
            objednavky = ObjednavkaModelHandler.Select();
            foreach (var row in objednavky)
            {
                if (row.Automobil_idA == VybraneId && row.datum_vypujceni <= od && doo <= row.datum_vraceni)
                {
                    Uspech = false;
                    MessageBox.Show("V danem Termínu nejde vypůjči automobil");
                }

            }

            if (VybraneAuto.Zpusobily_jizdy == 0 )
            {
                MessageBox.Show("Auto není provozu schopne, posílám zprávu automechanikovi");
                Dotaz3Form dot3 = new Dotaz3Form(VybraneAuto.Ida,od, doo);
                dot3.idA = VybraneId;
                this.Hide();
                dot3.ShowDialog();
                this.Close();
            }

            

           



           


            
            if (Uspech)
            {

                MessageBox.Show("Automobil je dostupny" + VybraneId.ToString() + od.ToString());
                DotazPojisteniForm dot2 = new DotazPojisteniForm(VybraneId, od, doo);
                this.Hide();
                dot2.ShowDialog();
                this.Close();
            }

           

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            cmd = new SqlCommand("Select distinct Model from automobil where znacka =" + comboBox1.SelectedText);
            connection.Open();
            cmd.ExecuteNonQuery();
            SqlCeDataReader 
                */


          

            comboBox2.Items.Clear();
            comboBox2.ResetText();
           
            //SqlConnection connection = DBConnector.GetInstance().GetConnection();

            string text = comboBox1.SelectedItem.ToString();
           // MessageBox.Show("zmena"+text);
            

            // automobils2 = AutomobilModelHandler.SelectByZnacka(comboBox1.SelectedItem.ToString());

            foreach (var row in automobils)
            {
                if (row.Znacka == text)
                {
                    comboBox2.Items.Add(row.Model);
                }
            }
            comboBox2.SelectedIndex = 0;
            /*
            automobil = AutoTableGateway.najdimodel(connection, comboBox1.SelectedText);
                BindingSource bSource = new BindingSource
                {
                    DataSource = automobil
                     
                };
                comboBox2.DataSource = bSource;
                comboBox2.DisplayMember = "model";
            */


            //comboBox2.Refresh();
            //NováVýpůjčkaForm dot2 = new NováVýpůjčkaForm();
            //this.Hide();
            // dot2.ShowDialog();
            // this.Close();







        }
        
    }
}
