using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Printing;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using FontAwesome.Sharp;
using static System.Windows.Forms.DataFormats;
using Color = System.Drawing.Color;

namespace PIA_PAL
{
    
    public partial class Examen_preguntas : Form
    {
        //campos
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        public Form currentChildForm;
  

    //constructor
    public Examen_preguntas()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 40);
            panelMenu.Controls.Add(leftBorderBtn);
            //formulario
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //Métodos
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
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
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icono de la pestaña actual
                iconPestanaActual.IconChar = currentBtn.IconChar;
                iconPestanaActual.IconColor = color;


            }
        }


        private void DisableButton()
        {
            if (currentBtn != null)
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

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();

            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblPestanaActual.Text = childForm.Text;
        }

        //Sección 1
        private void section_1_Click(object sender, EventArgs e)
        {
            //pruebas
            preguntas_1 preg_1 = new preguntas_1();
            AddOwnedForm(preg_1);
            currentChildForm = preg_1;
            preg_1.TopLevel = false;
            preg_1.FormBorderStyle = FormBorderStyle.None;
            preg_1.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(preg_1);
            panelDesktop.Tag = preg_1;
            preg_1.BringToFront();
            preg_1.Show();
            //Color del texto cuando se selecciona
            ActivateButton(sender, Color.FromArgb(246, 202, 204));
            //OpenChildForm(new preguntas_1());
            
        }

        //Sección 2
        private void section_2_Click(object sender, EventArgs e)
        {
            //Color del texto cuando se selecciona
            ActivateButton(sender, Color.FromArgb(246, 202, 204));
            OpenChildForm(new preguntas_2());
        }

        //Sección 3
        private void section_3_Click(object sender, EventArgs e)
        {
            //Color del texto cuando se selecciona
            ActivateButton(sender, Color.FromArgb(246, 202, 204));
            OpenChildForm(new preguntas_3());
        }

        //Sección 4
        private void section_4_Click(object sender, EventArgs e)
        {
            //Color del texto cuando se selecciona
            ActivateButton(sender, Color.FromArgb(246, 202, 204));
            OpenChildForm(new preguntas_4());
        }

        //Sección 5
        private void section_5_Click(object sender, EventArgs e)
        {
            //Color del texto cuando se selecciona
            ActivateButton(sender, Color.FromArgb(246, 202, 204));
            OpenChildForm(new preguntas_5());
        }

        //Sección 6
        private void section_6_Click(object sender, EventArgs e)
        {
            //Color del texto cuando se selecciona
            ActivateButton(sender, Color.FromArgb(246, 202, 204));
            OpenChildForm(new preguntas_6());
        }

        //Sección 7
        private void section_7_Click(object sender, EventArgs e)
        {
            //Color del texto cuando se selecciona
            ActivateButton(sender, Color.FromArgb(246, 202, 204));
            OpenChildForm(new preguntas_7());
        }

        //Sección 8
        private void section_8_Click(object sender, EventArgs e)
        {
            //Color del texto cuando se selecciona
            ActivateButton(sender, Color.FromArgb(246, 202, 204));
            OpenChildForm(new preguntas_8());
        }

        //Sección 9
        private void section_9_Click(object sender, EventArgs e)
        {
            //Color del texto cuando se selecciona
            ActivateButton(sender, Color.FromArgb(246, 202, 204));
            OpenChildForm(new preguntas_9());
        }

        //Sección 10
        private void section_10_Click(object sender, EventArgs e)
        {
            //Color del texto cuando se selecciona
            ActivateButton(sender, Color.FromArgb(246, 202, 204));
            OpenChildForm(new preguntas_10());
        }

        private void img_perfil_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
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

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
