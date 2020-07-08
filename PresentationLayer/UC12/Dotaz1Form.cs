using System;
using System.Windows.Forms;

namespace PresentationLayer.UC12
{
    public partial class Dotaz1Form : Form
    {
        public Dotaz1Form()
        {
            InitializeComponent();
        }

        //Ano
        private void button1_Click(object sender, EventArgs e)
        {
            NováVýpůjčkaForm novaVypujcka = new NováVýpůjčkaForm();
            this.Hide();
            novaVypujcka.ShowDialog();
            this.Close();
        }

        //Ne
        private void button2_Click(object sender, EventArgs e)
        {
            PojistovnaForm dotaz2 = new PojistovnaForm();
            this.Hide();
            dotaz2.ShowDialog();
            this.Close();
        }
    }
}
