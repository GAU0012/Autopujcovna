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
    public partial class DotazZaplaceniForm : Form
    {
        public DotazZaplaceniForm(int idA, DateTime od, DateTime doo)
        {
            InitializeComponent();
            DotazIdA = idA;
            DotazOd = od;
            DotazDoo = doo;
        }

        int DotazIdA;
        DateTime DotazOd, DotazDoo;

        public void DotazLoad()
        {
            //textBox1.Text = DotazIdA.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
