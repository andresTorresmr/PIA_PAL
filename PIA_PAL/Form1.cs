namespace PIA_PAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnPrimeraVez_Click(object sender, EventArgs e)
        {

            registro registro = new registro();
            registro.Show();
            this.Hide();



            //Examen_preguntas formulario = new Examen_preguntas();
            //formulario.Show();
            //this.Hide();


            //Formulario formulario = new Formulario();
            //formulario.Show();
            //this.Hide();
        }

        private void btnYa_Click(object sender, EventArgs e)
        {
            //Resultados resultados = new Resultados();
            //resultados.Show();
            //this.Hide();
            //Datos resultados = new Datos();
            //resultados.Show();
            //this.Hide();

            Datos datos = new Datos();
            datos.Show();
            this.Hide();
        }
    }
}