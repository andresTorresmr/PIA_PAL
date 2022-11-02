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

        public class Evaluaciones
        {
            public string LTI { get; set; }
            public string LNI { get; set; }
            public string LA { get; set; }
            public string CP { get; set; }


        }

        private void Resultados_Load(object sender, EventArgs e)
        {
            Nombre_usuario.Text = Variables.ID;
            string json = @"
                            {
                            '0':[
                                {
                                    'nombre1' : 'ANDRES',
                                    'nombre2' : '',
                                    'apellidop' : 'TORRES',
                                    'apellidom' : 'MONTEMAYOR',
                                    'fecha_nac' : '2001/07/17',
                                    'resultados' :[
                                       {
                                                 0:[{
                                                    'cp':24,
                                                    'la':60,
                                                    'lti':6,
                                                    'lni':10
                                                  }],
                                                 1:[{
                                                    'cp':50,
                                                    'lai':30,
                                                    'lti':10,
                                                    'lni':10
                                                  }]        

                                        }
                                    ]
                                }
                                ],
                            '1':[
                                {
                                    'nombre1' : 'ROMAN',
                                    'nombre2' : '',
                                    'apellidop' : 'LEYVA',
                                    'apellidom' : 'GARZA',
                                    'fecha_nac' : '2000/03/18',
                                    'resultados' : [
                                        {
                                                 0:[{
                                                    'cp':24,
                                                    'la':60,
                                                    'lti':6,
                                                    'lni':10
                                                  }],
                                                 1:[{
                                                    'cp':50,
                                                    'lai':30,
                                                    'lti':10,
                                                    'lni':10
                                                  }]        

                                        }
                                    ]
                                }
                            ],
                            '2':[
                                {
                                    'nombre1' : 'JOSE',
                                    'nombre2' : 'LUIS',
                                    'apellidop' : 'CARVAJAL',
                                    'apellidom' : 'CRUZ',
                                    'fecha_nac' : '2002/07/02',
                                    'resultados' : [
                                        {
                                                 0:[{
                                                    'cp':24,
                                                    'la':60,
                                                    'lti':6,
                                                    'lni':10
                                                  }],
                                                 1:[{
                                                    'cp':50,
                                                    'lai':30,
                                                    'lti':10,
                                                    'lni':10
                                                  }]        

                                        }
                                    ]
                                }
                            ],
                            '3':[
                                {
                                    'nombre1' : 'DANIELA',
                                    'nombre2' : 'ALEJANDRA',
                                    'apellidop' : 'VIEYRA',
                                    'apellidom' : 'CABALLERO',
                                    'fecha_nac' : '2002/11/14',
                                    'resultados' : [
                                        {
                                                 0:[{
                                                    'cp':24,
                                                    'la':60,
                                                    'lti':6,
                                                    'lni':10
                                                  }],
                                                 1:[{
                                                    'cp':50,
                                                    'lai':30,
                                                    'lti':10,
                                                    'lni':10
                                                  }]        

                                        }
                                    ]
                                }
                            ]
                        }
                            ";

            JObject jObj = (JObject)JsonConvert.DeserializeObject(json);
            JObject EVdata = JObject.Parse(json);
            //get JSON result objects into a list
            IList<JToken> results = EVdata[Variables.ID].Children().ToList();
            IList<JToken> evaluacion = EVdata[Variables.ID][0]["resultados"][0]["0"].Children().ToList();

            // serialize JSON results into .NET objects
            IList<SearchResult> searchResults = new List<SearchResult>();
            IList<Evaluaciones> Evaluaciones = new List<Evaluaciones>();
            foreach (JToken result in results)
            {
                SearchResult searchResult = JsonConvert.DeserializeObject<SearchResult>(result.ToString());
                searchResults.Add(searchResult);
            }

            foreach (JToken eval in evaluacion)
            {

                MessageBox.Show(Convert.ToString(eval));
                Evaluaciones examen = JsonConvert.DeserializeObject<Evaluaciones>(eval.ToString());
                Evaluaciones.Add(examen);
            }

            // List the properties of the searchResults IList
            foreach (SearchResult item in searchResults)
            {
                Nombre_usuario.Text = item.Nombre1 + " " + item.ApellidoP;
                
                foreach (Evaluaciones carrera in Evaluaciones)
                {
                    PBLTI.Value = Convert.ToInt16(carrera.LTI);
                    PBLNI.Value = Convert.ToInt16(carrera.LNI);
                    PBLA.Value = Convert.ToInt16(carrera.LA);
                    PBCP.Value = Convert.ToInt16(carrera.CP);


                    //MessageBox.Show("Funciona" + carrera.carrera + " " + carrera.total);
                }

            }
        }

        private void botonPia1_Click(object sender, EventArgs e)
        {

        }
    }
}

