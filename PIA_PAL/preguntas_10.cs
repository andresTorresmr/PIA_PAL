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
    public partial class preguntas_10 : Form
    {


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
        public preguntas_10()
        {
            InitializeComponent();
        }

        private void btn_siguiente_1_Click(object sender, EventArgs e)
        {
            if (groupBox1.Enabled == true && groupBox2.Enabled == true && groupBox3.Enabled == true && groupBox4.Enabled == true && groupBox5.Enabled == true)
            {
                string message = "¿Deseas continuar? Una vez guardadas tus preguntas no se podrán modificar más ni podrás volver a esta ventana.";
                string titutlo = "WARNING";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, titutlo, buttons);
                if (result == DialogResult.Yes)
                {
                    if (
                    rbBien_1.Checked == false && rbMal_1.Checked == false && rbMal_3.Checked == false && rbMal_4.Checked == false ||
                    rbBien_2.Checked == false && rbMal_5.Checked == false && rbMal_6.Checked == false && rbMal_7.Checked == false ||
                    rbBien_3.Checked == false && rbMal_8.Checked == false && rbMal_9.Checked == false && rbMal_10.Checked == false ||
                    rbBien_4.Checked == false && rbMal_11.Checked == false && rbMal_12.Checked == false && rbMal_13.Checked == false ||
                    rbBien_5.Checked == false && rbMal_14.Checked == false && rbMal_15.Checked == false && rbMal_16.Checked == false)
                    {
                        MessageBox.Show("Contesta todas las preguntas");
                    }
                    else
                    {
                        if (rbBien_1.Checked)
                        {
                            Variables.cp += 5;

                        }
                        groupBox1.Enabled = false;

                        if (rbBien_2.Checked)
                        {
                            Variables.cp += 5;

                        }
                        groupBox2.Enabled = false;

                        if (rbBien_3.Checked)
                        {
                            Variables.cp += 5;

                        }
                        groupBox3.Enabled = false;

                        if (rbBien_4.Checked)
                        {
                            Variables.cp += 5;

                        }
                        groupBox4.Enabled = false;

                        if (rbBien_5.Checked)
                        {
                            Variables.cp += 5;

                        }
                        groupBox5.Enabled = false;


                        //MessageBox.Show("LTI: " + Variables.lti);
                        //MessageBox.Show("LNI: " + Variables.lni);
                        //MessageBox.Show("LA: " + Variables.la);
                        //MessageBox.Show("CP: " + Variables.cp);

                        Examen_preguntas principal = Owner as Examen_preguntas;
                        principal.section_10.IconChar = IconChar.CheckCircle;
                        principal.section_10.Enabled = false;

                        DB dbconteo = new DB();
                        dbconteo.openConnection();
                        int conteo = 0;
                        MySqlCommand select1 = new MySqlCommand("SELECT COUNT(idExamen) FROM resultado WHERE idEstudiante = @id", dbconteo.getConnection());
                        select1.Parameters.Add("@id", MySqlDbType.Int64).Value = Variables.id;
                        var dr = select1.ExecuteReader();
                        if (dr.HasRows)
                        {
                            dr.Read();
                            conteo = (int)dr.GetInt64(0);


                        }
                        conteo = conteo + 1;
                        DB db = new DB();
                        db.openConnection();
                        MySqlCommand commandExamen = new MySqlCommand("INSERT INTO resultado (idEstudiante, num_Examen, lti, lni, la, cp) VALUES ( @id, @nExamen, @lti,@lni,@la,@cp) ", db.getConnection());
                        commandExamen.Parameters.Add("@id", MySqlDbType.Int16).Value = Convert.ToInt16(Variables.id);
                        commandExamen.Parameters.Add("@nExamen", MySqlDbType.Int16).Value = Convert.ToInt16(conteo);
                        commandExamen.Parameters.Add("@lti", MySqlDbType.Int16).Value = Convert.ToInt16(Variables.lti);
                        commandExamen.Parameters.Add("@lni", MySqlDbType.Int16).Value = Convert.ToInt16(Variables.lni);
                        commandExamen.Parameters.Add("@la", MySqlDbType.Int16).Value = Convert.ToInt16(Variables.la);
                        commandExamen.Parameters.Add("@cp", MySqlDbType.Int16).Value = Convert.ToInt16(Variables.cp);

                        if (commandExamen.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Finalizaste tu examen, te llevaremos a tu perfil para que veas el resultado.");
                            Res resultados = new Res();
                            resultados.Show();
                            principal.Close();
                        }
                        else
                        {
                            MessageBox.Show("ERROR");
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("Finalizaste tu examen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
