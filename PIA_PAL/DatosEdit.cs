using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIA_PAL
{
    public partial class Edicion_Datos : Form
    {
        public Edicion_Datos()
        {
            InitializeComponent();
        }

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

        private void botonPia1_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            string nombre = Nombre1.Texts;
            string nombre2 = Nombre2.Texts;
            string apellido1 = ApellidoP.Texts;
            string apellido2 = ApellidoM.Texts;
            string fechaNac = nacimiento.Text;
            MySqlCommand commandUP = new MySqlCommand("UPDATE usuario SET nombre_1 = @nombre1, nombre_2 = @nombre2, apellido_P = @apellido1, apellido_M = @apellido2, fecha_Nac = @fechaNac WHERE idUsuario = @id", db.getConnection());
            commandUP.Parameters.Add("@nombre1", MySqlDbType.VarChar).Value = nombre;
            commandUP.Parameters.Add("@nombre2", MySqlDbType.VarChar).Value = nombre2;
            commandUP.Parameters.Add("@apellido1", MySqlDbType.VarChar).Value = apellido1;
            commandUP.Parameters.Add("@apellido2", MySqlDbType.VarChar).Value = apellido2;
            commandUP.Parameters.Add("@fechaNac", MySqlDbType.Date).Value = nacimiento.Value.Date;
            commandUP.Parameters.Add("@id", MySqlDbType.Int64).Value = Variables.id;

            db.openConnection();


            if (commandUP.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Se actualizaron correctamente tus datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se actualizo nada perro");
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
