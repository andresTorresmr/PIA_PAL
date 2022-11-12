using FontAwesome.Sharp;
using MySqlConnector;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PIA_PAL;
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
    public partial class registro : Form
    {

        public registro()
        {
            InitializeComponent();
            
        }
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
            byte[] images = null;
            FileStream Streem = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(Streem);
            images = brs.ReadBytes((int)Streem.Length);

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO usuario(nombre_1, nombre_2, apellido_P, apellido_M, fecha_Nac, foto) VALUES (@nombre1, @nombre2, @apellido1, @apellido2, @fechaNac, @images)", db.getConnection());


            command.Parameters.Add("@nombre1", MySqlDbType.VarChar).Value = Nombre1.Texts;
            command.Parameters.Add("@nombre2", MySqlDbType.VarChar).Value = Nombre2.Texts;
            command.Parameters.Add("@apellido1", MySqlDbType.VarChar).Value = ApellidoP.Texts;
            command.Parameters.Add("@apellido2", MySqlDbType.VarChar).Value = ApellidoM.Texts;
            command.Parameters.Add("@fechaNac", MySqlDbType.Date).Value = nacimiento.Value.Date;
            command.Parameters.Add("@images", MySqlDbType.VarChar).Value = images;

            //ID
            string nombre = Nombre1.Texts;
            string nombre2 = Nombre2.Texts;
            string apellido1 = ApellidoP.Texts;
            string apellido2 = ApellidoM.Texts;
            MySqlCommand commandId = new MySqlCommand("SELECT idUsuario FROM usuario WHERE nombre_1 = @nombre1 AND nombre_2 = @nombre2 AND apellido_P = @apellido1 AND apellido_M = @apellido2 AND fecha_Nac = @fechaNac", db.getConnection());
            commandId.Parameters.Add("@nombre1", MySqlDbType.VarChar).Value = nombre;
            commandId.Parameters.Add("@nombre2", MySqlDbType.VarChar).Value = nombre2;
            commandId.Parameters.Add("@apellido1", MySqlDbType.VarChar).Value = apellido1;
            commandId.Parameters.Add("@apellido2", MySqlDbType.VarChar).Value = apellido2;
            commandId.Parameters.Add("@fechaNac", MySqlDbType.Date).Value = nacimiento.Value.Date;

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
                        Int64 id;
                        var dr = commandId.ExecuteReader();
                        if (dr.HasRows)
                        {
                            dr.Read();
                            id = dr.GetInt64(0);
                            MessageBox.Show("ID: " + id);
                        }
                        Resultados registro = new Resultados();
                        registro.Show();
                        this.Hide();
                    }

                }
                else
                {
                    if (command.ExecuteNonQuery() == 1)
                    {
                        Int64 id;
                        var dr = commandId.ExecuteReader();
                        if (dr.HasRows)
                        {
                            dr.Read();
                            id = dr.GetInt64(0);
                            //MessageBox.Show("ID: " + id);
                        }
                        MessageBox.Show("Tus datos han sido registrados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Examen_preguntas vocacion = new Examen_preguntas();
                        vocacion.Show();
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

        string imgLocation = "";
        private void Browsebtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd2 = new OpenFileDialog();
            fd2.Filter = "image files |*.jpg;*.png;*.gif;*.icon;.*;";
            DialogResult dres1 = fd2.ShowDialog();
            if (dres1 == DialogResult.OK)
            {
                imgLocation = fd2.FileName.ToString();
                ImgPf.ImageLocation = imgLocation;
            }
        }
    }
}

