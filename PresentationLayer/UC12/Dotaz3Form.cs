using BuisnessLayer.Handlers;
using BuisnessLayer.Models;
using System;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace PresentationLayer.UC12
{
    public partial class Dotaz3Form : Form
    {
        public Dotaz3Form(int idAA,DateTime od, DateTime doo)
        {
            InitializeComponent();

            Dotaz3Form_load(idAA, od, doo);

        }

        
        public int idA;
        DateTime od1, doo1;

        Collection<AutomobilModel> automobils;
        private void Dotaz3Form_load(int a,DateTime od, DateTime doo)
        {
            idA = a;
            od1 = od;
            doo1 = doo;
            dateTimePicker1.Value = od;
            dateTimePicker2.Value = doo;
            automobils = AutomobilModelHandler.SelectByID(idA);

            foreach (var row in automobils)
            {
                textBox1.Text = row.Ida.ToString();
                textBox2.Text = row.Znacka;
                textBox3.Text = row.Model;
            }

        }


        //ano
        private void button1_Click(object sender, EventArgs e)
        {
            
            AutomobilModelHandler.ExportToXml(idA.ToString(),idA);
            PojistovnaForm FormPoj = new PojistovnaForm();
            this.Hide();
            FormPoj.ShowDialog();
            this.Close();
        }

        //Ne
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zvoleny automobil nebude provozu schopny");
            NováVýpůjčkaForm FormVy = new NováVýpůjčkaForm();
            this.Hide();
            FormVy.ShowDialog();
            this.Close();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
