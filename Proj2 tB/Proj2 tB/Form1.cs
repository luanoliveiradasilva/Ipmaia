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
    }
}
