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
            
            this.Close();
        }


        private void btnPrimeraVez_Click(object sender, EventArgs e)
        {

            Perfil formulario = new Perfil();
            formulario.Show();
            this.Hide();


            //preguntas_1 formulario = new preguntas_1();
            //formulario.Show();
            //this.Hide();


            //Formulario formulario = new Formulario();
            //formulario.Show();
            //this.Hide();
        }

        private void btnYa_Click(object sender, EventArgs e)
        {
            Resultados resultados = new Resultados();
            resultados.Show();
            this.Hide();
            //Datos resultados = new Datos();
            //resultados.Show();
            //this.Hide();
        }
    }
}