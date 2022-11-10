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
                    if (rbLti.Checked == false && rbLni.Checked == false && rbLa.Checked == false && rbCp.Checked == false ||
                    rbLti_1.Checked == false && rbLni_1.Checked == false && rbLa_1.Checked == false && rbCp_1.Checked == false ||
                    rbLti_2.Checked == false && rbLni_2.Checked == false && rbLa_2.Checked == false && rbCp_2.Checked == false ||
                    rbLti_3.Checked == false && rbLni_3.Checked == false && rbLa_3.Checked == false && rbCp_3.Checked == false ||
                    rbLti_4.Checked == false && rbLni_4.Checked == false && rbLa_4.Checked == false && rbCp_4.Checked == false)
                    {
                        MessageBox.Show("Contesta todas las preguntas");
                    }
                    else
                    {
                        if (rbLti.Checked)
                        {
                            Variables.lti += 5;

                        }
                        if (rbLni.Checked)
                        {
                            Variables.lni += 5;

                        }
                        if (rbLa.Checked)
                        {
                            Variables.la += 5;

                        }
                        if (rbCp.Checked)
                        {
                            Variables.cp += 5;

                        }
                        groupBox1.Enabled = false;

                        if (rbLti_1.Checked)
                        {
                            Variables.lti += 5;

                        }
                        if (rbLni_1.Checked)
                        {
                            Variables.lni += 5;

                        }
                        if (rbLa_1.Checked)
                        {
                            Variables.la += 5;

                        }
                        if (rbCp_1.Checked)
                        {
                            Variables.cp += 5;

                        }
                        groupBox2.Enabled = false;

                        if (rbLti_2.Checked)
                        {
                            Variables.lti += 5;

                        }
                        if (rbLni_2.Checked)
                        {
                            Variables.lni += 5;

                        }
                        if (rbLa_2.Checked)
                        {
                            Variables.la += 5;

                        }
                        if (rbCp_2.Checked)
                        {
                            Variables.cp += 5;

                        }

                        groupBox3.Enabled = false;

                        if (rbLti_3.Checked)
                        {
                            Variables.lti += 5;

                        }
                        if (rbLni_3.Checked)
                        {
                            Variables.lni += 5;

                        }
                        if (rbLa_3.Checked)
                        {
                            Variables.la += 5;

                        }
                        if (rbCp_3.Checked)
                        {
                            Variables.cp += 5;

                        }

                        groupBox4.Enabled = false;

                        if (rbLti_4.Checked)
                        {
                            Variables.lti += 5;

                        }
                        if (rbLni_4.Checked)
                        {
                            Variables.lni += 5;

                        }
                        if (rbLa_4.Checked)
                        {
                            Variables.la += 5;

                        }
                        if (rbCp_4.Checked)
                        {
                            Variables.cp += 5;

                        }

                        groupBox5.Enabled = false;

                        MessageBox.Show("LTI: " + Variables.lti);
                        MessageBox.Show("LNI: " + Variables.lni);
                        MessageBox.Show("LA: " + Variables.la);
                        MessageBox.Show("CP: " + Variables.cp);

                        Examen_preguntas principal = Owner as Examen_preguntas;
                        principal.section_2.Enabled = false;
                        principal.section_3.Visible = true;
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
