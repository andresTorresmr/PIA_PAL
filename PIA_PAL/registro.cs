using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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

        public class register
        {
            public string nombre1 { get; set; }
            public string nombre2 { get; set; }
            public string apellidop { get; set; }
            public string apellidom { get; set; }
            public string fecha_nac { get; set; }
            public List<Resultados>
                resultados
            { get; set; }
            public int cp { get; set; }
            public int la { get; set; }
            public int lti { get; set; }
            public int lni { get; set; }
        }

        private void botonPia1_Click(object sender, EventArgs e)
        {
            //CONTEO DE REGISTRO DENTRO DEL JSON
            bool registrado = false;
            string json = File.ReadAllText(@"C:\Users\luis_\source\repos\PIA_PAL\PIA_PAL\Resources\datos - Copia.json");
            JObject jObj = JObject.Parse(json);
            int count = jObj.Count;
            JObject EVdata = JObject.Parse(json);
            MessageBox.Show(Convert.ToString(EVdata.Count));
            //CONTEO DE REGISTRO DENTRO DEL JSON

            for (int i = 1; i < count; i++)
            {
                IList<JToken> registro = EVdata[Convert.ToString(i)].Children().ToList();
                IList<register> busqueda = new List<register>();
            }

            foreach (JToken dato_registro in registro)
            {
                register Register = JsonConvert.DeserializeObject<register>(dato_registro.ToString());
            }

        }
    }
}
