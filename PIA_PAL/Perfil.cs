using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using FontAwesome.Sharp;
using Color = System.Drawing.Color;

namespace PIA_PAL
{
    public partial class Perfil : Form
    {
        //campos
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        public Perfil()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
        }



        //Métodos
        private void ActivateButton(object senderBtn, Color color)
        {
            if(senderBtn != null)
            {
                DisableButton();    
                //Botón
                currentBtn = (IconButton)senderBtn;
                //fondo cuando está seleccionado
                currentBtn.BackColor = Color.FromArgb(156, 25, 27);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //Borde izquierdo del botón cuando se selecciona
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0,currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icono de la pestaña actual
                iconPestanaActual.IconChar = currentBtn.IconChar;
                iconPestanaActual.IconColor = color;


            }
        }


        private void DisableButton()
        {
             if(currentBtn != null)
            {
                //Botón
                //fondo cuando no está seleccionado
                currentBtn.BackColor = Color.FromArgb(189, 31, 33);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }

        private void btn_test_1_Click(object sender, EventArgs e)
        {
            //Color del texto cuando se selecciona
            ActivateButton(sender, Color.FromArgb(246, 202, 204));
        }

        private void btn_test_2_Click(object sender, EventArgs e)
        {
            //Color del texto cuando se selecciona
            ActivateButton(sender, Color.FromArgb(246, 202, 204));
        }

        private void btn_test_3_Click(object sender, EventArgs e)
        {
            //Color del texto cuando se selecciona
            ActivateButton(sender, Color.FromArgb(246, 202, 204));
        }

        private void img_perfil_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconPestanaActual.IconChar = IconChar.Home;
            iconPestanaActual.IconColor = Color.Gainsboro;
            lblPestanaActual.Text = "Inicio";
        }
    }
}
