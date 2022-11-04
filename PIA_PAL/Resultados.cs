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
using System.Reflection;

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
            string json = File.ReadAllText(@"C:\Users\Román\source\repos\PIA_PAL\PIA_PAL\Resources\datos - Copia.json");

            JObject jObj = JObject.Parse(File.ReadAllText(@"C:\Users\Román\source\repos\PIA_PAL\PIA_PAL\Resources\datos - Copia.json"));
            JObject EVdata = JObject.Parse(json);
            //get JSON result objects into a list
            IList<JToken> results = EVdata[Variables.ID].Children().ToList();            
            IList<JToken> evaluacion = EVdata[Variables.ID][0]["resultados"][0]["0"].Children().ToList();
            IList<JToken> histexamen = EVdata[Variables.ID][0]["resultados"][0].Children().ToList();
            Variables.counteval = histexamen.Count;

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

            if(Variables.counteval < 5)
            {
                MessageBox.Show("RECUERDA que solo puedes hacer 3 examenes. Llevas: " + Variables.counteval);
                Formulario forms = new Formulario();
                forms.Show();
                this.Close();
            }

            else
            {
                MessageBox.Show("Llegaste a tu limite de 3 examenes. Elimina uno" );
            }
        }

        private void btnex1_MouseHover(object sender, EventArgs e)
        {
            btnCerrarEx1.Visible = true;
            
        }

        private void btnCerrarEx1_MouseLeave(object sender, EventArgs e)
        {
            btnCerrarEx1.Visible = false;
        }

        private void btnCerrarEx2_MouseHover(object sender, EventArgs e)
        {
            btnCerrarEx2.Visible = true;
        }

        private void btnCerrarEx2_MouseLeave(object sender, EventArgs e)
        {
            btnCerrarEx2.Visible = false;
        }

        private void btnCerrarEx3_MouseHover(object sender, EventArgs e)
        {
            btnCerrarEx3.Visible = true;
        }

        private void btnCerrarEx3_MouseLeave(object sender, EventArgs e)
        {
            btnCerrarEx3.Visible = false;
        }

        private void btnCerrarEx1_Click(object sender, EventArgs e)
        {
            string message = "¿Seguro que quieres borrar el examen?";
            string titutlo = "WARNING";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, titutlo, buttons);
            if (result == DialogResult.Yes)
            {
                btnex1.Visible = false;
            }
        }

        private void btnex2_MouseHover(object sender, EventArgs e)
        {
            btnCerrarEx2.Visible = true;
        }

        private void btnex3_MouseHover(object sender, EventArgs e)
        {
            btnCerrarEx3.Visible = true;
        }

        private void btnCerrarEx2_Click(object sender, EventArgs e)
        {
            string message = "¿Seguro que quieres borrar el examen?";
            string titutlo = "WARNING";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, titutlo, buttons);
            if (result == DialogResult.Yes)
            {
                btnex2.Visible = false;
            }
        }

        private void btnCerrarEx3_Click(object sender, EventArgs e)
        {
            string message = "¿Seguro que quieres borrar el examen?";
            string titutlo = "WARNING";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, titutlo, buttons);
            if (result == DialogResult.Yes)
            {
                btnex3.Visible = false;
            }
        }

        private void btnex1_Click(object sender, EventArgs e)
        {

        }
    }
}