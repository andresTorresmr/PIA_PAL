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
using System.Xml.Linq;
using MySqlConnector;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PIA_PAL.herramientas;

namespace PIA_PAL
{
    public partial class Datos : Form
    {
        public Datos()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 inicio = new Form1();
            inicio.Show();
            this.Close();
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

        public void botonPia1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Nombre1.Texts) || !string.IsNullOrEmpty(ApellidoP.Texts) || !string.IsNullOrEmpty(ApellidoM.Texts) || nacimiento.Value.Date <= DateTime.Now.Date)
            {
                DB db = new DB();
                string nombre = Nombre1.Texts;
                string nombre2 = Nombre2.Texts;
                string apellido1 = ApellidoP.Texts;
                string apellido2 = ApellidoM.Texts;
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT * FROM usuario WHERE nombre_1 = @nombre1 AND nombre_2 = @nombre2 AND apellido_P = @apellido1 AND apellido_M = @apellido2 AND fecha_Nac = @fechaNac", db.getConnection());
                MySqlCommand commandId = new MySqlCommand("SELECT idUsuario FROM usuario WHERE nombre_1 = @nombre1 AND nombre_2 = @nombre2 AND apellido_P = @apellido1 AND apellido_M = @apellido2 AND fecha_Nac = @fechaNac", db.getConnection());
                command.Parameters.Add("@nombre1", MySqlDbType.VarChar).Value = nombre;
                command.Parameters.Add("@nombre2", MySqlDbType.VarChar).Value = nombre2;
                command.Parameters.Add("@apellido1", MySqlDbType.VarChar).Value = apellido1;
                command.Parameters.Add("@apellido2", MySqlDbType.VarChar).Value = apellido2;
                command.Parameters.Add("@fechaNac", MySqlDbType.Date).Value = nacimiento.Value.Date;
                //id
                commandId.Parameters.Add("@nombre1", MySqlDbType.VarChar).Value = nombre;
                commandId.Parameters.Add("@nombre2", MySqlDbType.VarChar).Value = nombre2;
                commandId.Parameters.Add("@apellido1", MySqlDbType.VarChar).Value = apellido1;
                commandId.Parameters.Add("@apellido2", MySqlDbType.VarChar).Value = apellido2;
                commandId.Parameters.Add("@fechaNac", MySqlDbType.Date).Value = nacimiento.Value.Date;
                adapter.SelectCommand = command;

                adapter.Fill(table);

                //Aquí se asigna un select a una variable

                if (table.Rows.Count == 0)
                {
                    int count1 = table.Rows.Count;
                    //MessageBox.Show("Hola" + count1);
                    MessageBox.Show("Tus datos no se encuentran en nuestra base de datos", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    string message = "¿Quieres registrarte?";
                    string titutlo = "Registro";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, titutlo, buttons, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        registro registro = new registro();
                        registro.Show();
                        this.Hide();
                    }

                }
                db.openConnection();
                if (!checkTextBoxesValues())
                {
                    if (checkUsername())
                    {
                        string message = "¿Quieres ver tu resultados?";
                        string titutlo = "Resultados";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, titutlo, buttons);
                        if (result == DialogResult.Yes)
                        {
                            Int64 id;
                            var dr = commandId.ExecuteReader();
                            if (dr.HasRows)
                            {
                                dr.Read();
                                id = dr.GetInt64(0);
                                Variables.id = (int)id;
                            }
                            Variables.nombre1 = Nombre1.Texts;
                            Variables.apellidop = ApellidoP.Texts;
                            Variables.apellidom = ApellidoM.Texts;
                            //Resultados registro = new Resultados();
                            //registro.Show();
                            //this.Hide();
                            Res resultados = new Res();
                            resultados.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                    }
                }
            } else
            {
                MessageBox.Show("Los campos de primer nombre, apellido paterno y apellido materno deben contener información y  no puedes escoger la fecha de hoy.");
            }
        }

        public bool checkUsername()
        {
            DB db = new DB();
            string nombre = Nombre1.Texts;
            string nombre2 = Nombre2.Texts;
            string apellido1 = ApellidoP.Texts;
            string apellido2 = ApellidoM.Texts;
            string fechaNac = nacimiento.Text;
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM usuario WHERE nombre_1 = @nombre1 AND nombre_2 = @nombre2 AND apellido_P = @apellido1 AND apellido_M = @apellido2 AND fecha_Nac = @fechaNac", db.getConnection());
            command.Parameters.Add("@nombre1", MySqlDbType.VarChar).Value = nombre;
            command.Parameters.Add("@nombre2", MySqlDbType.VarChar).Value = nombre2;
            command.Parameters.Add("@apellido1", MySqlDbType.VarChar).Value = apellido1;
            command.Parameters.Add("@apellido2", MySqlDbType.VarChar).Value = apellido2;
            command.Parameters.Add("@fechaNac", MySqlDbType.Date).Value = nacimiento.Value.Date;
            adapter.SelectCommand = command;

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                //int count1 = table.Rows.Count;
                //MessageBox.Show("Hola" + count1);
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


        private void piaTextBox1_Load(object sender, EventArgs e)
        {
            
        }

        private void ApellidoM_Load(object sender, EventArgs e)
        {

        }

        private void Nombre1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void Nombre2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void ApellidoP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void ApellidoM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
