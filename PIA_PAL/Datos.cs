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
            string ID;
            string json = @"{
                            '1':[
                                {
                                    'nombre1' : 'ANDRES',
                                    'nombre2' : '',
                                    'apellidop' : 'TORRES',
                                    'apellidom' : 'MONTEMAYOR',
                                    'fecha_nac' : '2001/07/17',
                                    'resultados' : [
                                        {
                                            'carrera' : 'LTI',
                                            'total' : '25'
                                        },
                                        {
                                            'carrera' : 'LNI',
                                            'total' : '25'
                                        },
                                        {
                                            'carrera' : 'CP',
                                            'total' : '25'
                                        },
                                        {
                                            'carrera' : 'LA',
                                            'total' : '25'
                                        }
                                    ]
                                }
                            ],
                            '2':[
                                {
                                    'nombre1' : 'ROMAN',
                                    'nombre2' : '',
                                    'apellidop' : 'LEYVA',
                                    'apellidom' : 'GARZA',
                                    'fecha_nac' : '2000/03/18',
                                    'resultados' : [
                                        {
                                            'carrera' : 'LTI',
                                            'total' : '25'
                                        },
                                        {
                                            'carrera' : 'LNI',
                                            'total' : '25'
                                        },
                                        {
                                            'carrera' : 'CP',
                                            'total' : '25'
                                        },
                                        {
                                            'carrera' : 'LA',
                                            'total' : '25'
                                        }
                                    ]
                                }
                            ],
                            '3':[
                                {
                                    'nombre1' : 'JOSE',
                                    'nombre2' : 'LUIS',
                                    'apellidop' : 'CARVAJAL',
                                    'apellidom' : 'CRUZ',
                                    'fecha_nac' : '2002/07/02',
                                    'resultados' : [
                                        {
                                            'carrera' : 'LTI',
                                            'total' : '25'
                                        },
                                        {
                                            'carrera' : 'LNI',
                                            'total' : '25'
                                        },
                                        {
                                            'carrera' : 'CP',
                                            'total' : '25'
                                        },
                                        {
                                            'carrera' : 'LA',
                                            'total' : '25'
                                        }
                                    ]
                                }
                            ],
                            '4':[
                                {
                                    'nombre1' : 'DANIELA',
                                    'nombre2' : 'ALEJANDRA',
                                    'apellidop' : 'VIEYRA',
                                    'apellidom' : 'CABALLERO',
                                    'fecha_nac' : '2002/11/14',
                                    'resultados' : [
                                        {
                                            'carrera' : 'LTI',
                                            'total' : '25'
                                        },
                                        {
                                            'carrera' : 'LNI',
                                            'total' : '25'
                                        },
                                        {
                                            'carrera' : 'CP',
                                            'total' : '25'
                                        },
                                        {
                                            'carrera' : 'LA',
                                            'total' : '25'
                                        }
                                    ]
                                }
                            ]
                        }";

            JObject jObj = (JObject)JsonConvert.DeserializeObject(json);
            int count = jObj.Count;
            JObject EVdata = JObject.Parse(json);
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
            for(int i = 1; i < count; i++)
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
                        ID = Convert.ToString(i);
                        MessageBox.Show("Bienvenido: " + item.Nombre1 + " " + item.Nombre2 + " " + item.ApellidoP + " " + item.ApellidoM + ".");
                    }

                }
            }
            if(registrado == true)
            {
                // get JSON result objects into a list
                IList<JToken> results = EVdata["2"].Children().ToList();

                //// serialize JSON results into .NET objects
                IList<SearchResult> searchResults = new List<SearchResult>();
                foreach (JToken result in results)
                {
                    SearchResult searchResult = JsonConvert.DeserializeObject<SearchResult>(result.ToString());
                    searchResults.Add(searchResult);
                }

                //// List the properties of the searchResults IList
                foreach (SearchResult item in searchResults)
                {

                    MessageBox.Show("Bienvenido: " + item.Nombre1 + " " + item.Nombre2 + " " + item.ApellidoP + " " + item.ApellidoM + " . Existen " + count + " elementos en el archivo json." + ID);

                }

                Resultados FHPP = new Resultados();
                AddOwnedForm(FHPP);
                FHPP.DatoRecibido.Text = ID;


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
    }
}
