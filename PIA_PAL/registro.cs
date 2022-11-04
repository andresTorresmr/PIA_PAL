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

        public class SearchRegister
        {
            public string nombre1 { get; set; }
            public string nombre2 { get; set; }
            public string apellidop { get; set; }
            public string apellidom { get; set; }
            public string fecha_nac { get; set; }
            public string lti { get; set; }
            public string lni { get; set; }
            public string cp { get; set; }
            public string la { get; set; }
        }

        public class ResultadosEx
        {
            public int cp { get; set; }
            public int la { get; set; }
            public int lti { get; set; }
            public int lni { get; set; }
        }

        public class Registro
        {
            public string nombre1 { get; set; }
            public string nombre2 { get; set; }
            public string apellidop { get; set; }
            public string apellidom { get; set; }
            public string fecha_nac { get; set; }
            public List<Resultado> resultados { get; set; }
            public int cp { get; set; }
            public int la { get; set; }
            public int lti { get; set; }
            public int lni { get; set; }
            }

        public class Resultado
        {
            public List<ResultadosEx> _0 { get; set; }
            public List<Registro> _1 { get; set; }
        }

        public class Root
        {
            public List<Registro> _1 { get; set; }
        }

private void botonPia1_Click(object sender, EventArgs e)
        {
            //CONTEO DE REGISTRO DENTRO DEL JSON
            bool registrado = false;
            string json = File.ReadAllText(@"C:\Users\Román\source\repos\PIA_PAL\PIA_PAL\Resources\datos - Copia.json");
            JObject jObj = JObject.Parse(json);
            int count = jObj.Count;
            JObject EVdata = JObject.Parse(json);
            MessageBox.Show(Convert.ToString(EVdata.Count));
            //CONTEO DE REGISTRO DENTRO DEL JSON

            for (int i = 1; i < count; i++)
            {
                IList<JToken> registro = EVdata[Convert.ToString(i)].Children().ToList();
                IList<SearchRegister> Busqueda = new List<SearchRegister>();

                foreach (JToken dato_registro in registro)
                {
                    SearchRegister Register = JsonConvert.DeserializeObject<SearchRegister>(dato_registro.ToString());
                    Busqueda.Add(Register);
                }

                foreach (SearchRegister item in Busqueda)
                {
                    if (item.nombre1 == Nombre1.Texts & item.nombre2 == Nombre2.Texts & item.apellidop == ApellidoP.Texts && item.apellidom == ApellidoM.Texts)
                    {
                        registrado = true;
                        Variables.ID = Convert.ToString(i);
                    }
                }
            }
            if (registrado == true)
            {
                string message = "Ya te encuentras registrado ¿Deseas consultar tus resultados?";
                string title = "WARNING";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    Resultados forms = new Resultados();
                    forms.Show();
                    this.Close();
                }
                else
                {
                    string messageElse = "¿Quieres realizar el examen de nuevo?";
                    string titleElse = "WARNING";
                    MessageBoxButtons buttonsElse = MessageBoxButtons.YesNo;
                    DialogResult resultElse = MessageBox.Show(messageElse, titleElse, buttonsElse);
                    if (resultElse == DialogResult.Yes)
                    {
                        Formulario form1Button = new Formulario();
                        form1Button.Show();
                        this.Close();
                    }
                    else
                    {
                        Form1 form1ButtonNo = new Form1();
                        form1ButtonNo.Show();
                        this.Close();
                    }
                }
            }
            else
            {

                Registro registrobtn = new Registro();
                registrobtn.nombre1 = Nombre1.Texts;
                registrobtn.nombre2 = Nombre2.Texts;
                registrobtn.apellidop = ApellidoP.Texts;
                registrobtn.apellidom = ApellidoM.Texts;
                registrobtn.fecha_nac = nacimiento.Text;




                var jsonToWrite = JsonConvert.SerializeObject(registrobtn, Formatting.Indented);
                var _path = @"C:\Users\Román\source\repos\PIA_PAL\PIA_PAL\Resources\datos - Copia.json";

                using (StreamWriter file = File.AppendText(@"C:\Users\Román\source\repos\PIA_PAL\PIA_PAL\Resources\datos - Copia.json"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(file, registrobtn);
                }
            }
        }
    }
}

