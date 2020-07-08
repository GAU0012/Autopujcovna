using PresentationLayer.UC12;
using System;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        //Vypujceni vozila na pobocce
        private void button2_Click(object sender, EventArgs e)
        {
            Dotaz1Form dotaz1 = new Dotaz1Form();
            this.Hide();
            dotaz1.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }
    }
}
