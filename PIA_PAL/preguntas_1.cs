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
    public partial class preguntas_1 : Form
    {
        public preguntas_1()
        {
            InitializeComponent();
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            string message = "¿Deseas continuar? una vez guardadas tus preguntas no se podrán modificar más.";
            string titutlo = "WARNING";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, titutlo, buttons);
            if (result == DialogResult.Yes)
            {
                //PREGUNTA 1
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
                }

                

            }
            
        }
    }
}
