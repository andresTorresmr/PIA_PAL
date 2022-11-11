using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using MySqlConnector;

namespace PIA_PAL
{
    public partial class Resultados : Form
    {

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

        public Resultados()
        {
            InitializeComponent();
        }

        public void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        public void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 inicio = new Form1();
            inicio.Show();
            this.Close();
        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Resultados_Load(object sender, EventArgs e)
        {
           
        }
        private void botonPia1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            int conteo;
            MySqlCommand select1 = new MySqlCommand("SELECT COUNT(idExamen) FROM resultado WHERE idEstudiante = 1", db.getConnection());
            var dr = select1.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                conteo = (int)dr.GetInt64(0);
                MessageBox.Show("Si funciona" + conteo);

                if (conteo < 3)
                {
                    MessageBox.Show("RECUERDA que solo puedes hacer 3 examenes. Llevas: " +  conteo);
                    Examen_preguntas forms = new Examen_preguntas();
                    forms.Show();
                    this.Close();
                }

                else
                {
                    MessageBox.Show("Llegaste a tu limite de 3 examenes. Elimina uno");
                }
            }
        }

        private void btnex1_MouseHover(object sender, EventArgs e)
        {
            btnCerrarEx1.Visible = true;
            
        }

        private void btnCerrarEx1_MouseLeave(object sender, EventArgs e)
        {
            btnCerrarEx1.Visible = false;
        }

        private void btnCerrarEx2_MouseHover(object sender, EventArgs e)
        {
            btnCerrarEx2.Visible = true;
        }

        private void btnCerrarEx2_MouseLeave(object sender, EventArgs e)
        {
            btnCerrarEx2.Visible = false;
        }

        private void btnCerrarEx3_MouseHover(object sender, EventArgs e)
        {
            btnCerrarEx3.Visible = true;
        }

        private void btnCerrarEx3_MouseLeave(object sender, EventArgs e)
        {
            btnCerrarEx3.Visible = false;
        }

        private void btnCerrarEx1_Click(object sender, EventArgs e)
        {
            string message = "¿Seguro que quieres borrar el examen?";
            string titutlo = "WARNING";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, titutlo, buttons);
            if (result == DialogResult.Yes)
            {
                btnex1.Visible = false;
            }
        }

        private void btnex2_MouseHover(object sender, EventArgs e)
        {
            btnCerrarEx2.Visible = true;
        }

        private void btnex3_MouseHover(object sender, EventArgs e)
        {
            btnCerrarEx3.Visible = true;
        }

        private void btnCerrarEx2_Click(object sender, EventArgs e)
        {
            string message = "¿Seguro que quieres borrar el examen?";
            string titutlo = "WARNING";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, titutlo, buttons);
            if (result == DialogResult.Yes)
            {
                btnex2.Visible = false;
            }
        }

        private void btnCerrarEx3_Click(object sender, EventArgs e)
        {
            string message = "¿Seguro que quieres borrar el examen?";
            string titutlo = "WARNING";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, titutlo, buttons);
            if (result == DialogResult.Yes)
            {
                btnex3.Visible = false;
            }
        }

        private void btnex1_Click(object sender, EventArgs e)
        {
            //Aquí selecciona los resultado del examen correspondiente en este caso = 1
            DB db = new DB();
            db.openConnection();
            int lti1;
            int lni1;
            int la1;
            int cp1;
            MySqlCommand select1 = new MySqlCommand("SELECT lti,lni,cp,la FROM resultado WHERE idEstudiante=1 AND idExamen = 1", db.getConnection());
            var dr = select1.ExecuteReader();

            if (PBCP.Value <= 100)
            {
                PBCP.Value = 0;
            }

            if (PBLA.Value <= 100)
            {
                PBLA.Value = 0;
            }

            if (PBLNI.Value <= 100)
            {
                PBLNI.Value = 0;
            }

            if (PBLTI.Value <= 100)
            {
                PBLTI.Value = 0;
            }

            if (dr.HasRows)
            {
                dr.Read();
                lti1 = (int)dr.GetInt64(0);
                lni1 = (int)dr.GetInt64(1);
                la1 = (int)dr.GetInt64(2);
                cp1 = (int)dr.GetInt64(3);
                MessageBox.Show("Si funca" + lti1);
                MessageBox.Show("Si funca" + lni1);
                MessageBox.Show("Si funca" + la1);
                MessageBox.Show("Si funca" + cp1);

                PBCP.Value = cp1;
                PBLA.Value = la1;
                PBLNI.Value = lni1;
                PBLTI.Value = lti1;
            }
            else
            {
                MessageBox.Show("No se encontro examen alguno", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DB dbEx1 = new DB();
                dbEx1.openConnection();
                int conteo;
                MySqlCommand selectEx1 = new MySqlCommand("SELECT COUNT(idExamen) FROM resultado WHERE idEstudiante = 1", db.getConnection());
                var drEx1 = selectEx1.ExecuteReader();
                if (drEx1.HasRows)
                {
                    drEx1.Read();
                    conteo = (int)drEx1.GetInt64(0);
                    MessageBox.Show("Si funciona" + conteo);

                    if (conteo < 3)
                    {
                        MessageBox.Show("RECUERDA que solo puedes hacer 3 examenes. Llevas: " + conteo);
                        string message = "¿Quieres hacer otro examen?";
                        string titutlo = "Examen";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, titutlo, buttons, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            Examen_preguntas forms = new Examen_preguntas();
                            forms.Show();
                            this.Close();
                        }
                    }

                    else
                    {
                        MessageBox.Show("Llegaste a tu limite de 3 examenes. Elimina uno");
                    }
                }
            }
        }
        private void btnex2_Click(object sender, EventArgs e)
        {
            //Aquí selecciona los resultado del examen correspondiente en este caso = 2
            DB db = new DB();
            db.openConnection();
            int lti2;
            int lni2;
            int la2;
            int cp2;

            if (PBCP.Value <= 100)
            {
                PBCP.Value = 0;
            }

            if (PBLA.Value <= 100)
            {
                PBLA.Value = 0;
            }

            if (PBLNI.Value <= 100)
            {
                PBLNI.Value = 0;
            }

            if (PBLTI.Value <= 100)
            {
                PBLTI.Value = 0;
            }

            MySqlCommand select1 = new MySqlCommand("SELECT lti,lni,cp,la FROM resultado WHERE idEstudiante=1 AND idExamen = 2", db.getConnection());
            var dr = select1.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                lti2 = (int)dr.GetInt64(0);
                lni2 = (int)dr.GetInt64(1);
                la2 = (int)dr.GetInt64(2);
                cp2 = (int)dr.GetInt64(3);
                MessageBox.Show("Si funciona" + lti2);
                MessageBox.Show("Si funciona" + lni2);
                MessageBox.Show("Si funciona" + la2);
                MessageBox.Show("Si funciona" + cp2);


                PBCP.Value = cp2;
                PBLA.Value = la2;
                PBLNI.Value = lni2;
                PBLTI.Value = lti2;
            }
            else
            {
                MessageBox.Show("No se encontro tu segundo examen. Intenta hacer otro.", "Warning", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnex3_Click(object sender, EventArgs e)
        {
            //Aquí selecciona los resultado del examen correspondiente en este caso = 3
            DB db = new DB();
            db.openConnection();
            int lti3;
            int lni3;
            int la3;
            int cp3;

            if (PBCP.Value <= 100)
            {
                PBCP.Value = 0;
            }

            if (PBLA.Value <= 100)
            {
                PBLA.Value = 0;
            }

            if (PBLNI.Value <= 100)
            {
                PBLNI.Value = 0;
            }

            if (PBLTI.Value <= 100)
            {
                PBLTI.Value = 0;
            }

            MySqlCommand select1 = new MySqlCommand("SELECT lti,lni,cp,la FROM resultado WHERE idEstudiante=1 AND idExamen = 3", db.getConnection());
            var dr = select1.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                lti3 = (int)dr.GetInt64(0);
                lni3 = (int)dr.GetInt64(1);
                la3 = (int)dr.GetInt64(2);
                cp3 = (int)dr.GetInt64(3);
                MessageBox.Show("Si funciona" + lti3);
                MessageBox.Show("Si funciona" + lni3);
                MessageBox.Show("Si funciona" + la3);
                MessageBox.Show("Si funciona" + cp3);


                PBCP.Value = cp3;
                PBLA.Value = la3;
                PBLNI.Value = lni3;
                PBLTI.Value = lti3;
            }
            else
            {
                MessageBox.Show("No se encontro tu segundo examen. Intenta hacer otro.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}