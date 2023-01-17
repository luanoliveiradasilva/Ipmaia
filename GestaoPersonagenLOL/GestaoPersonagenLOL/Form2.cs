using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoPersonagenLOL
{
    public partial class Form2 : Form
    {

        private List<string> valoresDosGrids;

        public Form2(List<string> valoresDosGrids)
        {
            InitializeComponent();
            this.valoresDosGrids = valoresDosGrids;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            ArrayList list = new ArrayList();

            foreach (string value in valoresDosGrids)
            {
                list.Add(value);
            }

            label1.Text = list[0].ToString();
            label2.Text = list[1].ToString();
            label3.Text = list[2].ToString();
            label4.Text = list[3].ToString();
            label5.Text = list[4].ToString();
            label6.Text = list[5].ToString();
            label7.Text = list[6].ToString();
            label8.Text = list[7].ToString();
            label9.Text = list[8].ToString();

        }
    }
}
