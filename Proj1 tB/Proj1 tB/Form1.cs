using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string tNum1 = textBoxExe2Num1.Text;
            string tNum2 = textBoxExe2Num2.Text;

            int num1 = int.Parse(tNum1);
            int num2 = int.Parse(tNum2);

            int resultado = num1 + num2;

            labelExe2Res.Text = resultado.ToString();
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            string tNum1 = textBoxExe2Num1.Text;
            string tNum2 = textBoxExe2Num2.Text;

            int num1 = int.Parse(tNum1);
            int num2 = int.Parse(tNum2);

            int resultado = num1 - num2;

            labelExe2Res.Text = resultado.ToString();
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            string tNum1 = textBoxExe2Num1.Text;
            string tNum2 = textBoxExe2Num2.Text;

            int num1 = int.Parse(tNum1);
            int num2 = int.Parse(tNum2);

            int resultado = num1 * num2;

            labelExe2Res.Text = resultado.ToString();
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            string tNum1 = textBoxExe2Num1.Text;
            string tNum2 = textBoxExe2Num2.Text;

            double num1 = double.Parse(tNum1);
            double num2 = double.Parse(tNum2);

            if(num2 != 0)
            {
                double resultado = num1 / num2;

                labelExe2Res.Text = resultado.ToString();
            }
            else
            {
                labelExe2Res.Text = "-";
                MessageBox.Show("Impossível dividir por 0","ERRO!!!");
            }            
        }

        private void buttonMaior_Click(object sender, EventArgs e)
        {
            string tnum1 = textBoxExe3Num1.Text;
            string tnum2 = textBoxExe3Num2.Text;

            int num1 = int.Parse(tnum1);
            int num2 = int.Parse(tnum2);

            if(num1 > num2)
            {
                MessageBox.Show("O número maior é o número 1\nvalor = " + num1);
            }
            else if(num1 < num2)
            {
                MessageBox.Show("O número maior é o número 2\nvalor = " + num2);
            }
            else
            {
                MessageBox.Show("O números são iguais\nvalor = " + num1);
            }
        }

        private void buttonParImpar_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBoxExe4.Text);

            if(num % 2 == 0)
            {
                MessageBox.Show("O número " + num + " é PAR");
            }
            else
            {
                MessageBox.Show("O número " + num + " é ÍMPAR");
            }
        }

        private bool ePrimo(int n)
        {
            if(n <= 1)
            {
                return false;
            }
            for(int i = 2; i <= n/2; i++)
            {
                if(n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private void buttonPrimos_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBoxExe4.Text);

            if(ePrimo(num))
            {
                MessageBox.Show("O número " + num + " é primo");
            }
            else
            {
                MessageBox.Show("O número " + num + " NÃO é primo");
            }
        }

        private void buttonExe5_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBoxExe5.Text);
            int contador = 0, valor = 2;
            string resultado = "";

            while(contador < num)
            {
                if(ePrimo(valor))
                {
                    contador++;
                    resultado += valor + "\t";

                }
                valor++;
            }

            textBoxPrimos.Text = resultado;


        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 1; i <= 50; i++)
            {
                comboBox1.Items.Add(i);
                comboBox2.Items.Add(i);
                comboBox3.Items.Add(i);
                comboBox4.Items.Add(i);
                comboBox5.Items.Add(i);
            }

            for(int i = 1; i <= 12; i++)
            {
                comboBoxE1.Items.Add(i);
                comboBoxE2.Items.Add(i);
            }
        }

        private void buttonVP_Click(object sender, EventArgs e)
        {
            int[] numeros = new int[5];
            int[] estrelas = new int[2];

            numeros[0] = int.Parse(comboBox1.Text);
            numeros[1] = int.Parse(comboBox2.Text);
            numeros[2] = int.Parse(comboBox3.Text);
            numeros[3] = int.Parse(comboBox4.Text);
            numeros[4] = int.Parse(comboBox5.Text);

            estrelas[0] = int.Parse(comboBoxE1.Text);
            estrelas[1] = int.Parse(comboBoxE2.Text);

            MessageBox.Show(ChaveToString(numeros, estrelas));

            GerarChavePremiada();

            MessageBox.Show(ChaveToString(numerosP, estrelasP));

            MessageBox.Show(VerificarPremio(numeros, estrelas));

            int[] resultados = new int[14];
            
            for(int i = 0; i < 1000; i++)
            {
                int pos = VerificarPremioINT(numeros, estrelas);
                resultados[pos]++;
                System.Threading.Thread.Sleep(13);
                GerarChavePremiada();
            }

            string sorte = "";

            for(int i = 0; i < resultados.Length; i++)
            {
                if(i == 0)
                {
                    sorte += "Sem Prémio: " + resultados[i] + "\n";
                }
                else
                {
                    sorte += i + "º Prémio: " + resultados[i] + "\n";
                }
            }
            MessageBox.Show(sorte);

        }

        private string ChaveToString(int[] num, int[] est)
        {
            string chave = "";

            for (int i = 0; i < num.Length; i++)
            {
                chave += num[i] + " ";
            }
            chave += "+ ";
            for (int i = 0; i < est.Length; i++)
            {
                chave += est[i] + " ";
            }

            return chave;
        }

        int[] numerosP = new int[5];
        int[] estrelasP = new int[2];
        private void GerarChavePremiada()
        {
            Random r = new Random();

            for (int i = 0; i < numerosP.Length; i++)
            {
                int num = r.Next(1, 51);
                while(Existe(num, numerosP))
                {
                    num = r.Next(1, 51);
                }
                numerosP[i] = num;

            }
            for (int i = 0; i < estrelasP.Length; i++)
            {
                int est = r.Next(1, 13);
                while (Existe(est, estrelasP))
                {
                    est = r.Next(1, 13);
                }
                estrelasP[i] = est;
            }
        }

        private bool Existe(int val, int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                if(val == array[i])
                {
                    return true;
                }
            }
            return false;
        }

        private string VerificarPremio(int[] num, int[] est)
        {
            int numIguais = 0, estIguais = 0;
            string res = "";

            //CICLO PARA CORRER O VETOR NUM
            for(int i = 0; i < num.Length; i++)
            {
                //CICLO PARA CORRER O VETOR NUMEROSP
                for(int j = 0; j < numerosP.Length; j++)
                {
                    //VERIFICAR SE NUM[I] E NUMEROSP[J] SÃO IGUAIS
                    if(num[i] == numerosP[j])
                    {
                        //SE SÃO IGUAIS NUMIGUAIS++
                        numIguais++;
                    }
                }
            }
            //FAZER O MESMO PARA AS ESTRELAS
            for (int i = 0; i < est.Length; i++)
            {
                for (int j = 0; j < estrelasP.Length; j++)
                {
                    if (est[i] == estrelasP[j])
                    {
                        estIguais++;
                    }
                }
            }

            if(numIguais == 5 && estIguais == 2)
            {
                res = "1º Prémio";
            }
            else if (numIguais == 5 && estIguais == 1)
            {
                res = "2º Prémio";
            }
            else if (numIguais == 5 && estIguais == 0)
            {
                res = "3º Prémio";
            }
            else if (numIguais == 4 && estIguais == 2)
            {
                res = "4º Prémio";
            }
            else if (numIguais == 4 && estIguais == 1)
            {
                res = "5º Prémio";
            }
            else if (numIguais == 3 && estIguais == 2)
            {
                res = "6º Prémio";
            }
            else if (numIguais == 4 && estIguais == 0)
            {
                res = "7º Prémio";
            }
            else if (numIguais == 2 && estIguais == 2)
            {
                res = "8º Prémio";
            }
            else if (numIguais == 3 && estIguais == 1)
            {
                res = "9º Prémio";
            }
            else if (numIguais == 3 && estIguais == 0)
            {
                res = "10º Prémio";
            }
            else if (numIguais == 1 && estIguais == 2)
            {
                res = "11º Prémio";
            }
            else if (numIguais == 2 && estIguais == 1)
            {
                res = "12º Prémio";
            }
            else if (numIguais == 2 && estIguais == 0)
            {
                res = "13º Prémio";
            }
            else
            {
                res = "Sem Prémio";
            }

            return res;
        }

        private int VerificarPremioINT(int[] num, int[] est)
        {
            int numIguais = 0, estIguais = 0;
            int res = 0;

            //CICLO PARA CORRER O VETOR NUM
            for (int i = 0; i < num.Length; i++)
            {
                //CICLO PARA CORRER O VETOR NUMEROSP
                for (int j = 0; j < numerosP.Length; j++)
                {
                    //VERIFICAR SE NUM[I] E NUMEROSP[J] SÃO IGUAIS
                    if (num[i] == numerosP[j])
                    {
                        //SE SÃO IGUAIS NUMIGUAIS++
                        numIguais++;
                    }
                }
            }
            //FAZER O MESMO PARA AS ESTRELAS
            for (int i = 0; i < est.Length; i++)
            {
                for (int j = 0; j < estrelasP.Length; j++)
                {
                    if (est[i] == estrelasP[j])
                    {
                        estIguais++;
                    }
                }
            }

            if (numIguais == 5 && estIguais == 2)
            {
                res = 1;
            }
            else if (numIguais == 5 && estIguais == 1)
            {
                res = 2;
            }
            else if (numIguais == 5 && estIguais == 0)
            {
                res = 3;
            }
            else if (numIguais == 4 && estIguais == 2)
            {
                res = 4;
            }
            else if (numIguais == 4 && estIguais == 1)
            {
                res = 5;
            }
            else if (numIguais == 3 && estIguais == 2)
            {
                res = 6;
            }
            else if (numIguais == 4 && estIguais == 0)
            {
                res = 7;
            }
            else if (numIguais == 2 && estIguais == 2)
            {
                res = 8;
            }
            else if (numIguais == 3 && estIguais == 1)
            {
                res = 9;
            }
            else if (numIguais == 3 && estIguais == 0)
            {
                res = 10;
            }
            else if (numIguais == 1 && estIguais == 2)
            {
                res = 11;
            }
            else if (numIguais == 2 && estIguais == 1)
            {
                res = 12;
            }
            else if (numIguais == 2 && estIguais == 0)
            {
                res = 13;
            }
            else
            {
                res = 0;
            }

            return res;
        }

    }
}

/*
1.º Prémio  5 Números + 2 Estrelas
2.º Prémio  5 Números + 1 Estrela
3.º Prémio  5 Números + 0 Estrelas
4.º Prémio  4 Números + 2 Estrelas
5.º Prémio  4 Números + 1 Estrela
6.º Prémio  3 Números + 2 Estrelas
7.º Prémio  4 Números + 0 Estrelas
8.º Prémio  2 Números + 2 Estrelas
9.º Prémio  3 Números + 1 Estrela
10.º Prémio 3 Números + 0 Estrelas
11.º Prémio 1 Número + 2 Estrelas
12.º Prémio 2 Números + 1 Estrela
13.º Prémio 2 Números + 0 Estrelas
*/