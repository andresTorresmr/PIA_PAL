using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Printing;
using System.Runtime.InteropServices;
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
        private Form currentChildForm;

        //constructor
        public Perfil()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
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

        private void OpenChildForm(Form childForm)
        {
            if(iconPestanaActual != null)
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

        private void btn_test_1_Click(object sender, EventArgs e)
        {
            //Color del texto cuando se selecciona
            ActivateButton(sender, Color.FromArgb(246, 202, 204));

            //openchildform();
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
    }
}
