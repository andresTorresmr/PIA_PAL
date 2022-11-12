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
    public partial class Res : Form
    {
        //campos
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        public Form currentChildForm;
        public Res()
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
        public void ActivateButton(object senderBtn, Color color)
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
        private void section_10_Click(object sender, EventArgs e)
        {
            Examen1 ex1 = new Examen1();
            AddOwnedForm(ex1);
            currentChildForm = ex1;
            ex1.TopLevel = false;
            ex1.FormBorderStyle = FormBorderStyle.None;
            ex1.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(ex1);
            panelDesktop.Tag = ex1;
            ex1.BringToFront();
            ex1.Show();
            lblPestanaActual.Text = ex1.Text;
            //Color del texto cuando se selecciona
            ActivateButton(sender, Color.FromArgb(246, 202, 204));
            //OpenChildForm(new preguntas_1());
        }

        private void btnex1_Click(object sender, EventArgs e)
        {
            Examen1 ex1 = new Examen1();
            AddOwnedForm(ex1);
            currentChildForm = ex1;
            ex1.TopLevel = false;
            ex1.FormBorderStyle = FormBorderStyle.None;
            ex1.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(ex1);
            panelDesktop.Tag = ex1;
            ex1.BringToFront();
            ex1.Show();
            lblPestanaActual.Text = ex1.Text;
            //Color del texto cuando se selecciona
            ActivateButton(sender, Color.FromArgb(246, 202, 204));
            //OpenChildForm(new preguntas_1());
        }

        private void btnex2_Click(object sender, EventArgs e)
        {
            Examen2 ex2 = new Examen2();
            AddOwnedForm(ex2);
            currentChildForm = ex2;
            ex2.TopLevel = false;
            ex2.FormBorderStyle = FormBorderStyle.None;
            ex2.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(ex2);
            panelDesktop.Tag = ex2;
            ex2.BringToFront();
            ex2.Show();
            lblPestanaActual.Text = ex2.Text;
            //Color del texto cuando se selecciona
            ActivateButton(sender, Color.FromArgb(246, 202, 204));
            //OpenChildForm(new preguntas_1());
        }

        private void btnex3_Click(object sender, EventArgs e)
        {
            Examen3 ex3 = new Examen3();
            AddOwnedForm(ex3);
            currentChildForm = ex3;
            ex3.TopLevel = false;
            ex3.FormBorderStyle = FormBorderStyle.None;
            ex3.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(ex3);
            panelDesktop.Tag = ex3;
            ex3.BringToFront();
            ex3.Show();
            lblPestanaActual.Text = ex3.Text;
            //Color del texto cuando se selecciona
            ActivateButton(sender, Color.FromArgb(246, 202, 204));
            //OpenChildForm(new preguntas_1());
        }
    }
}
