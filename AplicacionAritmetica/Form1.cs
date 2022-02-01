using System.Windows.Forms;

namespace AplicacionAritmetica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            int valor1;
            int valor2;
            int resultado;

            valor1 = int.Parse(txtValor1.Text);
            valor2 = int.Parse(txtValor2.Text);

            resultado = valor1 + valor2;

            lblResultado.Text = resultado.ToString();
        }

        private void label7_Click(object sender, System.EventArgs e)
        {

        }

        private void label13_Click(object sender, System.EventArgs e)
        {

        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            int val1 = int.Parse(txtVal1.Text);
            int val2 = int.Parse(txtVal2.Text);
            int resultado;

            resultado = val1 + val2;

            lblRes.Text = resultado.ToString();



        }

        private void button4_Click(object sender, System.EventArgs e)
        {
           
        }

        
    }
}
