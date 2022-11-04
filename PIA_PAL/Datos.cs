using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
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
        public class SearchResult
        {
            public string Nombre1 { get; set; }
            public string Nombre2 { get; set; }
            public string ApellidoP { get; set; }
            public string ApellidoM { get; set; }
        }

        private void botonPia1_Click(object sender, EventArgs e)
        {
            bool registrado = false;
            string json = File.ReadAllText(@"C:\Users\Román\source\repos\PIA_PAL\PIA_PAL\Resources\datos - Copia.json");

            //JObject jObj = (JObject)JsonConvert.DeserializeObject(json);
            JObject jObj = JObject.Parse(json);
            int count = jObj.Count;
            JObject EVdata = JObject.Parse(json);
            MessageBox.Show(Convert.ToString(EVdata.Count));

            for (int i = 1; i <= count; i++)
            {
                IList<JToken> datos = EVdata[Convert.ToString(i)].Children().ToList();
                IList<SearchResult> Resultados = new List<SearchResult>();

                foreach (JToken registro in datos)
                {
                    SearchResult searchResult = JsonConvert.DeserializeObject<SearchResult>(registro.ToString());
                    Resultados.Add(searchResult);
                }

                // List the properties of the searchResults IList
                foreach (SearchResult item in Resultados)
                {
                    if(item.Nombre1 == Nombre1.Texts & item.Nombre2 == Nombre2.Texts & item.ApellidoP == ApellidoP.Texts && item.ApellidoM == ApellidoM.Texts)
                    {
                        registrado = true;
                        Variables.ID = Convert.ToString(i);
                        MessageBox.Show("Bienvenido: " + item.Nombre1 + " " + item.Nombre2 + " " + item.ApellidoP + " " + item.ApellidoM + ".");
                    }
                }
            }
            if(registrado == true)
            {
                Resultados forms = new Resultados();
                forms.Show();
                this.Close();
            }
            else
            {
                string message = "No se encontró tu registro. ¿Quieres registrarte?";
                string titulo = "WARNING";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, titulo, buttons);
                if (result == DialogResult.Yes)
                {
                    registro register = new registro();
                    register.Show();
                    this.Close();
                }
                else
                {
                    Form1 inicio = new Form1();
                    inicio.Show();
                    this.Close();
                }

            }

        }

        private void piaTextBox1_Load(object sender, EventArgs e)
        {
            
        }

        private void ApellidoM_Load(object sender, EventArgs e)
        {

        }
    }
}
