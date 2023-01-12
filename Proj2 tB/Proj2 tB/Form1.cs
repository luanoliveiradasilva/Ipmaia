using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj2_tB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

            Chave c1 = new Chave();

            c1.SetNumeros(numeros);
            c1.SetEstrelas(estrelas);

            MessageBox.Show(c1.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            for(int indice = 1; indice <= 50; indice++ ){
                comboBox1.Items.Add(indice);
                comboBox2.Items.Add(indice);
                comboBox3.Items.Add(indice);
                comboBox4.Items.Add(indice);
                comboBox5.Items.Add(indice);
                if(indice <= 12){
                    comboBoxE1.Items.Add(indice);
                    comboBoxE2.Items.Add(indice);
                }
            }

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 1;
            comboBox3.SelectedIndex = 2;
            comboBox4.SelectedIndex = 3;
            comboBox5.SelectedIndex = 4;
            comboBoxE1.SelectedIndex = 5;
            comboBoxE2.SelectedIndex = 6;
        }

        private void buttonCP1_Click(object sender, EventArgs e)
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

            Chave c1 = new Chave(numeros, estrelas);

            MessageBox.Show(c1.ToString());
        }

        private void buttonCP2_Click(object sender, EventArgs e)
        {
            Chave c1 = new Chave(
                int.Parse(comboBox1.Text), 
                int.Parse(comboBox2.Text), 
                int.Parse(comboBox3.Text), 
                int.Parse(comboBox4.Text), 
                int.Parse(comboBox5.Text),
                int.Parse(comboBoxE1.Text), 
                int.Parse(comboBoxE1.Text));
           
            MessageBox.Show(c1.ToString());
        }
    }
}
