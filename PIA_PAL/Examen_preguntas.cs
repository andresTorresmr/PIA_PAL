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

        //Sección 1
        private void section_1_Click(object sender, EventArgs e)
        {
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
            lblPestanaActual.Text = preg_1.Text;
            //Color del texto cuando se selecciona
            ActivateButton(sender, Color.FromArgb(246, 202, 204));
            //OpenChildForm(new preguntas_1());
            
        }

        //Sección 2
        private void section_2_Click(object sender, EventArgs e)
        {
            preguntas_2 preg_2 = new preguntas_2();
            AddOwnedForm(preg_2);
            currentChildForm = preg_2;
            preg_2.TopLevel = false;
            preg_2.FormBorderStyle = FormBorderStyle.None;
            preg_2.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(preg_2);
            panelDesktop.Tag = preg_2;
            preg_2.BringToFront();
            preg_2.Show();
            lblPestanaActual.Text = preg_2.Text;
            //Color del texto cuando se selecciona
            ActivateButton(sender, Color.FromArgb(246, 202, 204));
        }

        //Sección 3
        private void section_3_Click(object sender, EventArgs e)
        {
            preguntas_3 preg_3 = new preguntas_3();
            AddOwnedForm(preg_3);
            currentChildForm = preg_3;
            preg_3.TopLevel = false;
            preg_3.FormBorderStyle = FormBorderStyle.None;
            preg_3.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(preg_3);
            panelDesktop.Tag = preg_3;
            preg_3.BringToFront();
            preg_3.Show();
            lblPestanaActual.Text = preg_3.Text;
            //Color del texto cuando se selecciona
            ActivateButton(sender, Color.FromArgb(246, 202, 204));
        }

        //Sección 4
        private void section_4_Click(object sender, EventArgs e)
        {
            preguntas_4 preg_4 = new preguntas_4();
            AddOwnedForm(preg_4);
            currentChildForm = preg_4;
            preg_4.TopLevel = false;
            preg_4.FormBorderStyle = FormBorderStyle.None;
            preg_4.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(preg_4);
            panelDesktop.Tag = preg_4;
            preg_4.BringToFront();
            preg_4.Show();
            lblPestanaActual.Text = preg_4.Text;
            //Color del texto cuando se selecciona
            ActivateButton(sender, Color.FromArgb(246, 202, 204));
        }

        //Sección 5
        private void section_5_Click(object sender, EventArgs e)
        {
            preguntas_5 preg_5 = new preguntas_5();
            AddOwnedForm(preg_5);
            currentChildForm = preg_5;
            preg_5.TopLevel = false;
            preg_5.FormBorderStyle = FormBorderStyle.None;
            preg_5.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(preg_5);
            panelDesktop.Tag = preg_5;
            preg_5.BringToFront();
            preg_5.Show();
            lblPestanaActual.Text = preg_5.Text;
            //Color del texto cuando se selecciona
            ActivateButton(sender, Color.FromArgb(246, 202, 204));
        }

        //Sección 6
        private void section_6_Click(object sender, EventArgs e)
        {
            preguntas_6 preg_6 = new preguntas_6();
            AddOwnedForm(preg_6);
            currentChildForm = preg_6;
            preg_6.TopLevel = false;
            preg_6.FormBorderStyle = FormBorderStyle.None;
            preg_6.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(preg_6);
            panelDesktop.Tag = preg_6;
            preg_6.BringToFront();
            preg_6.Show();
            lblPestanaActual.Text = preg_6.Text;
            //Color del texto cuando se selecciona
            ActivateButton(sender, Color.FromArgb(246, 202, 204));
        }

        //Sección 7
        private void section_7_Click(object sender, EventArgs e)
        {
            preguntas_7 preg_7 = new preguntas_7();
            AddOwnedForm(preg_7);
            currentChildForm = preg_7;
            preg_7.TopLevel = false;
            preg_7.FormBorderStyle = FormBorderStyle.None;
            preg_7.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(preg_7);
            panelDesktop.Tag = preg_7;
            preg_7.BringToFront();
            preg_7.Show();
            lblPestanaActual.Text = preg_7.Text;
            //Color del texto cuando se selecciona
            ActivateButton(sender, Color.FromArgb(246, 202, 204));
        }

        //Sección 8
        private void section_8_Click(object sender, EventArgs e)
        {
            preguntas_8 preg_8 = new preguntas_8();
            AddOwnedForm(preg_8);
            currentChildForm = preg_8;
            preg_8.TopLevel = false;
            preg_8.FormBorderStyle = FormBorderStyle.None;
            preg_8.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(preg_8);
            panelDesktop.Tag = preg_8;
            preg_8.BringToFront();
            preg_8.Show();
            lblPestanaActual.Text = preg_8.Text;
            //Color del texto cuando se selecciona
            ActivateButton(sender, Color.FromArgb(246, 202, 204));
        }

        //Sección 9
        private void section_9_Click(object sender, EventArgs e)
        {
            preguntas_9 preg_9 = new preguntas_9();
            AddOwnedForm(preg_9);
            currentChildForm = preg_9;
            preg_9.TopLevel = false;
            preg_9.FormBorderStyle = FormBorderStyle.None;
            preg_9.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(preg_9);
            panelDesktop.Tag = preg_9;
            preg_9.BringToFront();
            preg_9.Show();
            lblPestanaActual.Text = preg_9.Text;
            //Color del texto cuando se selecciona
            ActivateButton(sender, Color.FromArgb(246, 202, 204));
        }

        //Sección 10
        private void section_10_Click(object sender, EventArgs e)
        {
            preguntas_10 preg_10 = new preguntas_10();
            AddOwnedForm(preg_10);
            currentChildForm = preg_10;
            preg_10.TopLevel = false;
            preg_10.FormBorderStyle = FormBorderStyle.None;
            preg_10.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(preg_10);
            panelDesktop.Tag = preg_10;
            preg_10.BringToFront();
            preg_10.Show();
            lblPestanaActual.Text = preg_10.Text;
            //Color del texto cuando se selecciona
            ActivateButton(sender, Color.FromArgb(246, 202, 204));
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

        private void iconPictureBox1_Click_1(object sender, EventArgs e)
        {
            string message = "¿Seguro que deseas salir de la aplicación? Al no terminar el exámen se borrarán tus respuestas.";
            string titutlo = "WARNING";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, titutlo, buttons);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
                
        }

        private void Examen_preguntas_Load(object sender, EventArgs e)
        {
            
            section_2.Visible = false;
            section_3.Visible = false;
            section_4.Visible = false;
            section_5.Visible = false;
            section_6.Visible = false;
            section_7.Visible = false;
            section_8.Visible = false;
            section_9.Visible = false;
            section_10.Visible = false;
            lblNombre.Text = Variables.nombre1;
            lblApellidoP.Text = Variables.apellidop;
            lblApellidoM.Text = Variables.apellidom;

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconPestanaActual_Click(object sender, EventArgs e)
        {

        }

        private void lblPestanaActual_Click(object sender, EventArgs e)
        {

        }
    }
}
