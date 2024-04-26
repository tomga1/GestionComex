namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero1 = numeroA.Text;
            double primerNumero = double.Parse(numero1);

            string numero2 = numeroB.Text;
            double segundoNumero = double.Parse(numero2);

            string numero3 = numeroC.Text;
            double tercerNumero = double.Parse(numero3);

            double promedio = (primerNumero + segundoNumero + tercerNumero) / 3;


            MessageBox.Show("El promedio es : " + promedio); 
            
        }

        private void txt1_Click(object sender, EventArgs e)
        {

        }
      

    }
}
