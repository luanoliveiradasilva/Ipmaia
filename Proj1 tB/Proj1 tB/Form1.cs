using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Proj1_tB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonExe1_Click(object sender, EventArgs e)
        {
            string texto = textBoxExe1.Text;

            label1.Text = texto;
        }

        private void buttonSoma_Click(object sender, EventArgs e)
        {
            string tNumUm = textValorUm.Text;
            string tNumDois = textValorDois.Text;

            int numeroUm = int.Parse(tNumUm);
            int numeroDois = int.Parse(tNumDois);

            int resultado = numeroUm + numeroDois;

            labelResultado.Text = resultado.ToString();
        }

        private void buttonSubtracao_Click(object sender, EventArgs e)
        {
            string tNumUm = textValorUm.Text;
            string tNumDois = textValorDois.Text;

            int numeroUm = int.Parse(tNumUm);
            int numeroDois = int.Parse(tNumDois);

            int resultado = numeroUm - numeroDois;

            labelResultado.Text = resultado.ToString();
        }

        private void buttonMultiplicacao_Click(object sender, EventArgs e)
        {
            string tNumUm = textValorUm.Text;
            string tNumDois = textValorDois.Text;

            int numeroUm = int.Parse(tNumUm);
            int numeroDois = int.Parse(tNumDois);

            int resultado = numeroUm * numeroDois;

            labelResultado.Text = resultado.ToString();
        }

        private void buttonDivisao_Click(object sender, EventArgs e)
        {
            string tNumUm = textValorUm.Text;
            string tNumDois = textValorDois.Text;

            double numeroUm = double.Parse(tNumUm);
            double numeroDois = double.Parse(tNumDois);

            if (numeroDois != 0) {

                double resultado = numeroUm / numeroDois;

                labelResultado.Text = resultado.ToString();
            }
            else
            {
                labelResultado.Text = "-";
                MessageBox.Show("Impossivel dividir por 0", "Error!");
            }
           

            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnNumeroMaior_Click(object sender, EventArgs e)
        {
            string numeroUm = txtNumeroUm.Text;
            string numeroDois = txtNumeroDois.Text;

            int numeroInteiroUm = int.Parse(numeroUm);
            int numeroInteiroDois = int.Parse(numeroDois);
            

            if(numeroInteiroUm > numeroInteiroDois)
            {
                MessageBox.Show("O valor 1° é \nmaior: " + numeroInteiroUm);

            }else if(numeroInteiroUm < numeroInteiroDois)
            {
                MessageBox.Show("O valor 2° é \nmaior: " + numeroInteiroDois);
            }
            else
            {
                MessageBox.Show("Os valores são iguais.");
            }
        }

        private void btnParOuImpar_Click(object sender, EventArgs e)
        {
          
            int numeroValorResultado = int.Parse(txtNumero.Text);

            if(numeroValorResultado % 2 == 0) {
                MessageBox.Show($"Seu valor {numeroValorResultado} é par.");
            }
            else
            {
                MessageBox.Show($"Seu valor {numeroValorResultado} é impar.");
            }
        }

        private bool ePrimo(int n)
        {
            int count = 0;
            if(n <=1)
            {
                return false;
            }
            for (int indice = 2; indice <= n/2; indice++)
            {
                count++;
                if (n % indice == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private void btnPrimo_Click(object sender, EventArgs e)
        {
            int valorPrimo = int.Parse(txtNumero.Text);

            if(ePrimo(valorPrimo))
            {
                MessageBox.Show("O Número é primo");  
            }
            else
            {
                MessageBox.Show("O Número não é primo");
            }
        }

        private void btnPrimoValue_Click(object sender, EventArgs e)
        {
            int valorPrimo = int.Parse(txtPrimoValue.Text);
            int count = 0;
            int valor = 2;
            string resultado = "";


            while (count < valorPrimo)
            {
                if (ePrimo(valor))
                {
                    count++;
                    resultado += valor+"\t";

                }

                valor++;
            }
            this.txtResultado.Text = resultado;
        }
    }
}
