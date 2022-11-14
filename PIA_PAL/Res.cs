using FontAwesome.Sharp;
using MySqlConnector;
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

        class DB
        {
            MySqlConnection connection = new
            //MySqlConnection("server = 127.0.0.1;port=3306;username=root;password=;database=ansystec_pal; pooling = false; convert zero datetime=true");
            MySqlConnection("server = 162.241.62.140;port=3306;username=ansystec_roman;password=Roman2022..;database=ansystec_pal; pooling = false; convert zero datetime=true");
            public void openConnection()
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
            }

            public void closeConnection()
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            public MySqlConnection getConnection()
            {
                return connection;
            }
        }


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

        private void Res_Load(object sender, EventArgs e)
        {
            btnex1.Visible = false;
            btnex2.Visible = false;
            btnex3.Visible = false;
            lblNombre.Text = Variables.nombre1;
            lblApellidoP.Text = Variables.apellidop;
            lblApellidoM.Text = Variables.apellidom;
            DB db = new DB();
            db.openConnection();
            int conteo;
            MySqlCommand select1 = new MySqlCommand("SELECT COUNT(idExamen) FROM resultado WHERE idEstudiante = @id", db.getConnection());
            select1.Parameters.Add("@id", MySqlDbType.Int64).Value = Variables.id;
            var dr = select1.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                conteo = (int)dr.GetInt64(0);
                if (conteo == 1)
                {
                    btnex1.Visible=true;
                }
                if (conteo == 2)
                {
                    btnex1.Visible = true;
                    btnex2.Visible = true;
                }
                if (conteo == 3)
                {
                    btnex1.Visible = true;
                    btnex2.Visible = true;
                    btnex3.Visible = true;
                }
            }
        }


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

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            int conteo;
            MySqlCommand select1 = new MySqlCommand("SELECT COUNT(idExamen) FROM resultado WHERE idEstudiante = @id", db.getConnection());
            select1.Parameters.Add("@id", MySqlDbType.Int64).Value = Variables.id;
            var dr = select1.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                conteo = (int)dr.GetInt64(0);
                if (conteo < 3)
                {
                    MessageBox.Show("RECUERDA que solo puedes hacer 3 examenes. Llevas: " + conteo);
                    string message = "¿Quieres realizar otro examen?";
                    string titutlo = "Examen";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, titutlo, buttons, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Examen_preguntas forms = new Examen_preguntas();
                        forms.Show();
                        this.Close();
                    }
                    else
                    {

                    }

                }

                else
                {
                    MessageBox.Show("Llegaste a tu limite de 3 examenes.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DatosEdit_Click(object sender, EventArgs e)
        {
            Edicion_Datos edit = new Edicion_Datos();
            edit.Show();
            this.Close();
        }
    }
}
