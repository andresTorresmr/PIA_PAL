using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIA_PAL
{
    public partial class Datos : Form
    {
        public Datos()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 inicio = new Form1();
            inicio.Show();
            this.Close();
        }

        private void botonPia1_Click(object sender, EventArgs e)
        {
            Resultados forms = new Resultados();
            forms.Show();
            this.Close();
        }

        private void piaTextBox1_Load(object sender, EventArgs e)
        {

        }
    }
}
