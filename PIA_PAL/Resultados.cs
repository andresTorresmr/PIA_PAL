using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
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
    public partial class Resultados : Form
    {
        public Resultados()
        {
            InitializeComponent();
        }

        public void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        public void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 inicio = new Form1();
            inicio.Show();
            this.Close();
        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public class SearchResult
        {
            public string Nombre1 { get; set; }
            public string Nombre2 { get; set; }
            public string ApellidoP { get; set; }
            public string ApellidoM { get; set; }
        }

        private void Resultados_Load(object sender, EventArgs e)
        {
            Nombre_usuario.Text = Variables.ID;
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
            JObject EVdata = JObject.Parse(json);
            //get JSON result objects into a list
            IList<JToken> results = EVdata[Variables.ID].Children().ToList();

            // serialize JSON results into .NET objects
            IList<SearchResult> searchResults = new List<SearchResult>();
            foreach (JToken result in results)
            {
                SearchResult searchResult = JsonConvert.DeserializeObject<SearchResult>(result.ToString());
                searchResults.Add(searchResult);
            }

            // List the properties of the searchResults IList
            foreach (SearchResult item in searchResults)
            {
                Nombre_usuario.Text = item.Nombre1 + " " + item.ApellidoP;

                //MessageBox.Show("Bienvenido: " + item.Nombre1 + " " + item.Nombre2 + " " + item.ApellidoP + " " + item.ApellidoM + " . Existen " + count + " elementos en el archivo json.");

            }
        }
    }
}
