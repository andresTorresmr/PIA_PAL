using MySqlConnector;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PIA_PAL;
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
    public partial class registro : Form
    {
        public registro()
        {
            InitializeComponent();
        }

        class DB
        {
            MySqlConnection connection = new
            MySqlConnection("server = 127.0.0.1;port=3306;username=root;password=;database=ansystec_pal; pooling = false; convert zero datetime=true");

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
            MySqlCommand command = new MySqlCommand("INSERT INTO usuario(nombre_1, nombre_2, apellido_P, apellido_M, fecha_Nac) VALUES (@nombre1, @nombre2, @apellido1, @apellido2, @fechaNac)", db.getConnection());


            command.Parameters.Add("@nombre1", MySqlDbType.VarChar).Value = Nombre1.Texts;
            command.Parameters.Add("@nombre2", MySqlDbType.VarChar).Value = Nombre2.Texts;
            command.Parameters.Add("@apellido1", MySqlDbType.VarChar).Value = ApellidoP.Texts;
            command.Parameters.Add("@apellido2", MySqlDbType.VarChar).Value = ApellidoM.Texts;
            command.Parameters.Add("@fechaNac", MySqlDbType.Date).Value = nacimiento.Value;

            db.openConnection();

            if (!checkTextBoxesValues())
            {

                if (checkUsername())
                {
                    MessageBox.Show("Este estudiante ya esta registrado", "Estudiante duplicado", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    MySqlCommand commandSe = new MySqlCommand("SELECT * FROM usuario", db.getConnection());
                    //Aquí se asigna un select a una variable
                    string nombre;
                    MySqlCommand select1 = new MySqlCommand("SELECT nombre_1 FROM usuario WHERE idUsuario=1", db.getConnection());
                    var dr = select1.ExecuteReader();
                    if (dr.HasRows)
                    {
                        dr.Read();
                        nombre = dr.GetString(0);
                        MessageBox.Show("Si funciona" + nombre);
                    }
                    //Aquí se asigna un select a una variable
                }
                else
                {
                    if(command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Tus datos han sido registrados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
 

                    }
                    else
                    {
                        MessageBox.Show("ERROR");
                    }
                }
            }

        }

        public bool checkUsername()
        {
            DB db = new DB();
            string nombre = Nombre1.Texts;
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM usuario WHERE nombre_1 = @nombre1", db.getConnection());
            command.Parameters.Add("@nombre1", MySqlDbType.VarChar).Value = nombre;
            adapter.SelectCommand = command;

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool checkTextBoxesValues()
        {
            string fnombre = Nombre1.Texts;
            string fnombre2 = Nombre2.Texts;
            string apellidom = ApellidoM.Texts;
            string apellidop = ApellidoP.Texts;

            if (fnombre.Equals("nombre_1") || fnombre2.Equals("nombre_2") || apellidop.Equals("apellido_p") || apellidom.Equals("apellido_m"))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    
        private void Nombre1_Load(object sender, EventArgs e)
        {

        }
    }
}

