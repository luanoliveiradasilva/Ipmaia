using System;
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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void campeãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CampeaoForm campeaoForShow = new CampeaoForm();
            campeaoForShow.Show();
        }
    }
}
