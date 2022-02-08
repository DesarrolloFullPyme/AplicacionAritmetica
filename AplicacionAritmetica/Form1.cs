namespace AplicacionAritmetica
{
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="Form1" />.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The button1_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="System.EventArgs"/>.</param>
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

        /// <summary>
        /// The label7_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="System.EventArgs"/>.</param>
        private void label7_Click(object sender, System.EventArgs e)
        {
        }

        /// <summary>
        /// The label13_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="System.EventArgs"/>.</param>
        private void label13_Click(object sender, System.EventArgs e)
        {
        }

        /// <summary>
        /// The condicion.
        /// </summary>
        public void condicion()
        {
            //jonAH
            string val1 = txtValor1.Text;
            string val2 = txtValor2.Text;
            if (val1 == "" && val2 == "")
            {
                MessageBox.Show("Ingrese un campo");
            }
        }

        /// <summary>
        /// The button3_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="System.EventArgs"/>.</param>
        private void button3_Click(object sender, System.EventArgs e)
        {

            //JONAH

            condicion();
            int val1 = int.Parse(txtVal1.Text);
            int val2 = int.Parse(txtVal2.Text);
            int resultado;

            resultado = val1 + val2;

            lblRes.Text = resultado.ToString();
        }

        /// <summary>
        /// The button4_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="System.EventArgs"/>.</param>
        private void button4_Click(object sender, System.EventArgs e)
        {
        }

        /// <summary>
        /// The button2_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="System.EventArgs"/>.</param>
        private void button2_Click(object sender, System.EventArgs e)
        {
            int valorvale1;
            int valorvale2;
            int resultadovale;

            valorvale1 = int.Parse(txtvalorv1.Text);
            valorvale2 = int.Parse(txtvalorv2.Text);

            resultadovale = valorvale1 + valorvale2;

            lblresultadov.Text = resultadovale.ToString();
        }

        /// <summary>
        /// The button6_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="System.EventArgs"/>.</param>
        private void button6_Click(object sender, System.EventArgs e)
        {
            int valorvale1;
            int valorvale2;
            int resultadovale;

            valorvale1 = int.Parse(txtvalorv1.Text);
            valorvale2 = int.Parse(txtvalorv2.Text);

            resultadovale = valorvale1 - valorvale2;

            lblresultadov.Text = resultadovale.ToString();
        }

        /// <summary>
        /// The button7_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="System.EventArgs"/>.</param>
        private void button7_Click(object sender, System.EventArgs e)
        {
            int valorvale1;
            int valorvale2;
            int resultadovale;

            valorvale1 = int.Parse(txtvalorv1.Text);
            valorvale2 = int.Parse(txtvalorv2.Text);

            resultadovale = valorvale1 * valorvale2;

            lblresultadov.Text = resultadovale.ToString();
        }

        /// <summary>
        /// The button5_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="System.EventArgs"/>.</param>
        private void button5_Click(object sender, System.EventArgs e)
        {
            int valorvale1;
            int valorvale2;
            int resultadovale;

            valorvale1 = int.Parse(txtvalorv1.Text);
            valorvale2 = int.Parse(txtvalorv2.Text);

            resultadovale = valorvale1 / valorvale2;

            lblresultadov.Text = resultadovale.ToString();
        }

        /// <summary>
        /// The button8_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="System.EventArgs"/>.</param>
        private void button8_Click(object sender, System.EventArgs e)
        {
            //JONAH
            int val1;
            int val2;
            int resultado;
            string var1 = txtVal1.Text;
            string var2 = txtVal2.Text;
            val1 = int.Parse(var1);
            val2 = int.Parse(var2);
            resultado = val1 - val2;
            // lblSig.Text = resultado.ToString("-");
            lblRes.Text = resultado.ToString();


            if (var1 == "" || var2 == "")
            {
                MessageBox.Show("Faltan campos");
            }
        }

        /// <summary>
        /// The button9_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="System.EventArgs"/>.</param>
        private void button9_Click(object sender, System.EventArgs e)
        {
            int valorceci1;
            int valorceci2;
            int resultadovale;

            valorceci1 = int.Parse(txtvalorc1.Text);
            valorceci2 = int.Parse(txtvalorc2.Text);

            resultadovale = valorceci1 - valorceci2;

            lblresultadoceci.Text = resultadovale.ToString();
        }

        /// <summary>
        /// The button10_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="System.EventArgs"/>.</param>
        private void button10_Click(object sender, System.EventArgs e)
        {
            int valorceci1;
            int valorceci2;
            int resultadovale;

            valorceci1 = int.Parse(txtvalorc1.Text);
            valorceci2 = int.Parse(txtvalorc2.Text);

            resultadovale = valorceci1 * valorceci2;

            lblresultadoceci.Text = resultadovale.ToString();
        }

        /// <summary>
        /// The button11_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="System.EventArgs"/>.</param>
        private void button11_Click(object sender, System.EventArgs e)
        {
            int valorceci1;
            int valorceci2;
            int resultadovale;

            valorceci1 = int.Parse(txtvalorc1.Text);
            valorceci2 = int.Parse(txtvalorc2.Text);

            resultadovale = valorceci1 / valorceci2;

            lblresultadoceci.Text = resultadovale.ToString();
        }

        private void BTNRestar_Click(object sender, System.EventArgs e)
        {
            //JONAH
            condicion();
            int val1 = int.Parse(txtVal1.Text);
            int val2 = int.Parse(txtVal2.Text);
            int resultado;


            resultado = val1 - val2;
            lblSig.Text = resultado.ToString("-");
            lblRes.Text = resultado.ToString();
        }

        private void BTNMultiplicar_Click(object sender, System.EventArgs e)
        {
            condicion();
            //JONAH
            int val1 = int.Parse(txtVal1.Text);
            int val2 = int.Parse(txtVal2.Text);
            int resultado;

            resultado = val1 * val2;
            lblSig.Text = resultado.ToString("*");
            lblRes.Text = resultado.ToString();
        }

        private void BTNDividir_Click(object sender, System.EventArgs e)
        {
            condicion();
            //JONAH
            int val1 = int.Parse(txtVal1.Text);
            int val2 = int.Parse(txtVal2.Text);
            int resultado;

            resultado = val1 / val2;
            lblSig.Text = resultado.ToString("/");
            lblRes.Text = resultado.ToString();
            
        }
    }
}
