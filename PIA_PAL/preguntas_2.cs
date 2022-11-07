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
    public partial class preguntas_2 : Form
    {
        public preguntas_2()
        {
            InitializeComponent();
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            preguntas_1 Primer_pagina = new preguntas_1();
            this.Hide();
            Primer_pagina.Show();
        }
    }
}
