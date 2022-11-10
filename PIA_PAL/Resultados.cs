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
            int lti;
            int lni;
            int la;
            int cp;
            MySqlCommand select1 = new MySqlCommand("SELECT lti,lni,cp,la FROM resultado WHERE idEstudiante=1 AND idExamen = 1", db.getConnection());
            var dr = select1.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                lti = (int)dr.GetInt64(0);
                lni = (int)dr.GetInt64(1);
                la = (int)dr.GetInt64(2);
                cp = (int)dr.GetInt64(3);
                MessageBox.Show("Si funca" + lti);
                MessageBox.Show("Si funca" + lni);
                MessageBox.Show("Si funca" + la);
                MessageBox.Show("Si funca" + cp);

                Variables.lti = Convert.ToInt16(lti);
                Variables.lni = Convert.ToInt16(lni);
                Variables.la = Convert.ToInt16(la);
                Variables.cp = Convert.ToInt16(cp);


                PBCP.Value = Variables.cp;
                PBLA.Value = Variables.la;
                PBLNI.Value = Variables.lni;
                PBLTI.Value = Variables.lti;
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
            int lti;
            int lni;
            int la;
            int cp;
            MySqlCommand select1 = new MySqlCommand("SELECT lti,lni,cp,la FROM resultado WHERE idEstudiante=1 AND idExamen = 2", db.getConnection());
            var dr = select1.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                lti = (int)dr.GetInt64(0);
                lni = (int)dr.GetInt64(1);
                la = (int)dr.GetInt64(2);
                cp = (int)dr.GetInt64(3);
                MessageBox.Show("Si funciona" + lti);
                MessageBox.Show("Si funciona" + lni);
                MessageBox.Show("Si funciona" + la);
                MessageBox.Show("Si funciona" + cp);


                PBCP.Value = cp;
                PBLA.Value = la;
                PBLNI.Value = lni;
                PBLTI.Value = lti;
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
            int lti;
            int lni;
            int la;
            int cp;
            MySqlCommand select1 = new MySqlCommand("SELECT lti,lni,cp,la FROM resultado WHERE idEstudiante=1 AND idExamen = 3", db.getConnection());
            var dr = select1.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                lti = (int)dr.GetInt64(0);
                lni = (int)dr.GetInt64(1);
                la = (int)dr.GetInt64(2);
                cp = (int)dr.GetInt64(3);
                MessageBox.Show("Si funciona" + lti);
                MessageBox.Show("Si funciona" + lni);
                MessageBox.Show("Si funciona" + la);
                MessageBox.Show("Si funciona" + cp);


                PBCP.Value = cp;
                PBLA.Value = la;
                PBLNI.Value = lni;
                PBLTI.Value = lti;
            }
            else
            {
                MessageBox.Show("No se encontro tu segundo examen. Intenta hacer otro.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}