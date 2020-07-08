using BuisnessLayer.Handlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.UC12
{
    public partial class PojistovnaForm : Form
    {
        public PojistovnaForm()
        {
            InitializeComponent();
            Form1_Load();
        }

        private void Form1_Load()
        {
            comboBox2.Items.Add("Zakladní pojíštění");
            comboBox2.Items.Add("Rozšířené pojíštění");
            comboBox2.Items.Add("Premium pojíštění");
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Jmeno neni vyplněne");
            }
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Příjmení není vyplněné");
            }
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Cena není uvedena");
            }
            else { 
            int ids = ZakaznikModelHandler.CountSluzby();
                try
                {
                    ZakaznikModelHandler.InsertSluzba(ids + 1, comboBox2.Text, Int32.Parse(textBox3.Text), dateTimePicker1.Value, dateTimePicker2.Value,
                        textBox1.Text, textBox2.Text);
                          MessageBox.Show("Objednavka byla ulozena");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Objednavka byla ulozena");
                    this.Close();
                }
                }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
