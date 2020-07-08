using System;
using System.Windows.Forms;

namespace PresentationLayer.UC12
{
    public partial class DotazPojisteniForm : Form
    {
        public DotazPojisteniForm(int idA, DateTime od, DateTime doo)
        {
            InitializeComponent();
            DotazidA = idA;
            Dotazod = od;
            Dotazdoo = doo;
           
        }

        public int DotazidA;
        DateTime Dotazod, Dotazdoo;

        
        //Ne
        private void button2_Click(object sender, EventArgs e)
        {
            DotazZaplaceniForm dot = new DotazZaplaceniForm(DotazidA, Dotazod, Dotazdoo);
            this.Hide();
            dot.ShowDialog();
            this.Close();
        }
        //Ano
        private void button1_Click(object sender, EventArgs e)
        {
            PojistovnaForm dot3 = new PojistovnaForm();
            this.Hide();
            dot3.ShowDialog();
            this.Close();
        }       
    }
}
