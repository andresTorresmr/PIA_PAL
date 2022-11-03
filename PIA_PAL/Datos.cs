using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            string json = File.ReadAllText(@"C:\Users\Román\source\repos\PIA_PAL\PIA_PAL\Resources\prueba2.json");

            //JObject jObj = (JObject)JsonConvert.DeserializeObject(json);
            JObject jObj = JObject.Parse(File.ReadAllText(@"C:\Users\Román\source\repos\PIA_PAL\PIA_PAL\Resources\prueba2.json"));
            int count = jObj.Count;
            JObject EVdata = JObject.Parse(File.ReadAllText(@"C:\Users\Román\source\repos\PIA_PAL\PIA_PAL\Resources\prueba2.json"));
            // get JSON result objects into a list
            //IList<JToken> results = EVdata["2"].Children().ToList();

            //// serialize JSON results into .NET objects
            //IList<SearchResult> searchResults = new List<SearchResult>();
            //foreach (JToken result in results)
            //{
            //    SearchResult searchResult = JsonConvert.DeserializeObject<SearchResult>(result.ToString());
            //    searchResults.Add(searchResult);
            //}

            //// List the properties of the searchResults IList
            //foreach (SearchResult item in searchResults)
            //{

            //    MessageBox.Show("Bienvenido: " + item.Nombre1 + " " + item.Nombre2 + " " + item.ApellidoP + " " + item.ApellidoM + " . Existen " + count + " elementos en el archivo json.");
                
            //}
            //PRUEBAS A VER SI JALA
            for(int i = 1; i <= count; i++)
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
                        Variables.ID = Convert.ToString(i - 1);
                        MessageBox.Show("Bienvenido: " + item.Nombre1 + " " + item.Nombre2 + " " + item.ApellidoP + " " + item.ApellidoM + ".");
                    }

                }
            }
            if(registrado == true)
            {
                // get JSON result objects into a list
                //IList<JToken> results = EVdata["2"].Children().ToList();

                ////// serialize JSON results into .NET objects
                //IList<SearchResult> searchResults = new List<SearchResult>();
                //foreach (JToken result in results)
                //{
                //    SearchResult searchResult = JsonConvert.DeserializeObject<SearchResult>(result.ToString());
                //    searchResults.Add(searchResult);
                //}

                //// List the properties of the searchResults IList
                //foreach (SearchResult item in searchResults)
                //{

                //    MessageBox.Show("Bienvenido: " + item.Nombre1 + " " + item.Nombre2 + " " + item.ApellidoP + " " + item.ApellidoM + " . Existen " + count + " elementos en el archivo json.");

                //}

                //Resultados FHPP = new Resultados();
                //AddOwnedForm(FHPP);
                //FHPP.DatoRecibido.Text = ID;


                Resultados forms = new Resultados();
                forms.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("No se encontró tu registro");
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
