using FontAwesome.Sharp;
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
    public partial class preguntas_7 : Form
    {
        public preguntas_7()
        {
            InitializeComponent();
        }

        private void btn_siguiente_1_Click(object sender, EventArgs e)
        {
            if (groupBox1.Enabled == true && groupBox2.Enabled == true && groupBox3.Enabled == true && groupBox4.Enabled == true && groupBox5.Enabled == true)
            {
                string message = "¿Deseas continuar? Una vez guardadas tus preguntas no se podrán modificar más ni podrás volver a esta ventana.";
                string titutlo = "WARNING";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, titutlo, buttons);
                if (result == DialogResult.Yes)
                {
                    if (
                    rbBien_1.Checked == false && rbMal_1.Checked == false && rbMal_3.Checked == false && rbMal_4.Checked == false ||
                    rbBien_2.Checked == false && rbMal_5.Checked == false && rbMal_6.Checked == false && rbMal_7.Checked == false ||
                    rbBien_3.Checked == false && rbMal_8.Checked == false && rbMal_9.Checked == false && rbMal_10.Checked == false ||
                    rbBien_4.Checked == false && rbMal_11.Checked == false && rbMal_12.Checked == false && rbMal_13.Checked == false ||
                    rbBien_5.Checked == false && rbMal_14.Checked == false && rbMal_15.Checked == false && rbMal_16.Checked == false)
                    {
                        MessageBox.Show("Contesta todas las preguntas");
                    }
                    else
                    {
                        if (rbBien_1.Checked)
                        {
                            Variables.lti += 5;

                        }
                        groupBox1.Enabled = false;

                        if (rbBien_2.Checked)
                        {
                            Variables.lti += 5;

                        }
                        groupBox2.Enabled = false;

                        if (rbBien_3.Checked)
                        {
                            Variables.lti += 5;

                        }
                        groupBox3.Enabled = false;

                        if (rbBien_4.Checked)
                        {
                            Variables.lti += 5;

                        }
                        groupBox4.Enabled = false;

                        if (rbBien_5.Checked)
                        {
                            Variables.lti += 5;

                        }
                        groupBox5.Enabled = false;


                        //MessageBox.Show("LTI: " + Variables.lti);
                        //MessageBox.Show("LNI: " + Variables.lni);
                        // MessageBox.Show("LA: " + Variables.la);
                        //MessageBox.Show("CP: " + Variables.cp);

                        Examen_preguntas principal = Owner as Examen_preguntas;
                        principal.section_7.IconChar = IconChar.CheckCircle;
                        principal.section_7.Enabled = false;
                        principal.section_8.Visible = true;
                        principal.currentChildForm.Close();


                        //preguntas_2 Segunda_pagina = new preguntas_2();
                        //this.Hide();
                        //Segunda_pagina.Show();
                    }
                }
            }
            else
            {
                preguntas_2 Segunda_pagina = new preguntas_2();
                this.Hide();
                Segunda_pagina.Show();
            }
        }
    }
}
