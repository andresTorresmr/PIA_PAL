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
            MySqlCommand command = new MySqlCommand("INSERT INTO usuario(nombre_1, nombre_2, apellido_P, apellido_M, fecha_Nac) VALUES (@nombre1, @nombre2, @apellido1, @apellido2)", db.getConnection());


            command.Parameters.Add("@nombre1", MySqlDbType.VarChar).Value = Nombre1.Texts;
            command.Parameters.Add("@nombre2", MySqlDbType.VarChar).Value = Nombre2.Texts;
            command.Parameters.Add("@apellido1", MySqlDbType.VarChar).Value = ApellidoP.Texts;
            command.Parameters.Add("@apellido2", MySqlDbType.VarChar).Value = ApellidoM.Texts;

            db.openConnection();

            if (!checkTextBoxesValues())
            {
                if (checkUsername())
                {
                    MessageBox.Show("Tus datos ya están registrados", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    string message = "¿Quieres ver tus resultados?";
                    string titutlo = "Resultados";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, titutlo, buttons, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        Resultados registro = new Resultados();
                        registro.Show();
                        this.Hide();
                    }

                }
                else
                {
                    if(command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Tus datos han sido registrados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Examen_preguntas vocación = new Examen_preguntas();
                        vocación.Show();
                        this.Close();
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
            string nombre2 = Nombre2.Texts;
            string apellido1 = ApellidoP.Texts;
            string apellido2 = ApellidoM.Texts;
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            //creo que aqui está el error pero estoy muy cansado así que solo quiero acabar las preguntas y ya pls, mañana veo esto en clases :D
            MySqlCommand command = new MySqlCommand("SELECT * FROM usuario WHERE nombre_1 = @nombre1 AND apellido_P = @apellido1 AND apellido_M = @apellido2", db.getConnection());
            command.Parameters.Add("@nombre1", MySqlDbType.VarChar).Value = nombre;
            command.Parameters.Add("@nombre2", MySqlDbType.VarChar).Value = nombre2;
            command.Parameters.Add("@apellido1", MySqlDbType.VarChar).Value = apellido1;
            command.Parameters.Add("@apellido2", MySqlDbType.VarChar).Value = apellido2;
            adapter.SelectCommand = command;

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                int count1 = table.Rows.Count;
                MessageBox.Show("Hola" + count1);
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
            string fechaNac = nacimiento.Text;

           

            if (fnombre.Equals("nombre_1") && fnombre2.Equals("nombre_2") && apellidop.Equals("apellido_p") && apellidom.Equals("apellido_m"))
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

