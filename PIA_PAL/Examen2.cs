using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MySqlConnector;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIA_PAL
{
    public partial class Examen2 : Form
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

        public Examen2()
        {
            InitializeComponent();
        }

        private void Examen2_Load(object sender, EventArgs e)
        {
            //Aquí selecciona los resultado del examen correspondiente en este caso = 2
            DB db = new DB();
            db.openConnection();
            int lti1;
            int lni1;
            int la1;
            int cp1;
            int id;
            MySqlCommand select1 = new MySqlCommand("SELECT lti,lni,cp,la FROM resultado WHERE idEstudiante = @id AND num_Examen = 2", db.getConnection());
            select1.Parameters.Add("@id", MySqlDbType.Int64).Value = Variables.id;
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

                PBCP.Value = cp1;
                PBLA.Value = la1;
                PBLNI.Value = lni1;
                PBLTI.Value = lti1;
                lblCpRes.Text = Convert.ToString(cp1);
                lblLaRes.Text = Convert.ToString(la1);
                lblLniRes.Text = Convert.ToString(lni1);
                lblLtiRes.Text = Convert.ToString(lti1);
            }
            else
            {
                MessageBox.Show("No se encontro tu primer examen. Intenta hacer otro.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
