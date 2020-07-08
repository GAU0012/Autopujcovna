using BuisnessLayer.Handlers;
using BuisnessLayer.Models;
using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;


namespace PresentationLayer
{
    public partial class FakturaForm : Form
    {

        public FakturaForm()
        {
            InitializeComponent();
        }
       
        public int idZ;
       // public int idO = 1;
       
        //List<string> PosFaktur = new List<string>();

        public ZakaznikModel zakaznikModel;

        private void Faktura_Load(object sender, EventArgs e)
        {

            zakaznikModel = ZakaznikModelHandler.Detail(idZ);
            textBox1.Text = zakaznikModel.jmeno;
            textBox3.Text = zakaznikModel.Prijmeni;
            dateTimePicker1.Value = zakaznikModel.Datum_narozeni;
            textBox5.Text = zakaznikModel.tel_cislo.ToString();
            textBox6.Text = zakaznikModel.Email;

        }

        //zpet
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

     

        //poslat
        private void button2_Click(object sender, EventArgs e)
        {
            if(numericUpDown1.Value == 0)
            {
                MessageBox.Show("Neni stanovená cena");
            }

            var client = new SmtpClient("smtp.gmail.com", 587); // udaje na server
            {

                
                    client.Credentials = new NetworkCredential("vistest2020@gmail.com", "Test2020Vis"); // prihlasovaci udaje na smtp gmailu
                    client.EnableSsl = true;

            };

            try
            {
                     //Od, do, predmet, soubor
                    client.Send("vistest2020@gmail.com", "adammg@seznam.cz", "Faktura za pojsiteni", " Jméno a příjmení :" + zakaznikModel.jmeno  + zakaznikModel.Prijmeni 
                        + "\r" + " Email: " +zakaznikModel.Email + " Tel. :" + zakaznikModel.tel_cislo +"\r" +" Cena :" + numericUpDown1.Value.ToString()); // odeslani
                    MessageBox.Show("Email byl úspěšně odeslan");
            }
            catch (Exception ex)
            {
                    MessageBox.Show("Error:" + ex.ToString());
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {

           
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
