
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

namespace GestaoPersonagenLOL
{
    public partial class CampeaoForm : Form
    {
        private string campeoesData;

        public CampeaoForm()
        {
            InitializeComponent();
        }

        private void btnCadastrarCampeao_Click(object sender, EventArgs e)
        {
            Campeao campeao = acessoController();

            CampeaoController campeaoController = new CampeaoController(campeao);

            campeaoController.cadastrarCampeao();
        }


        private Campeao acessoController()
        {

            Campeao campeao = new Campeao(); // Criação de objeto de campeão para adição de dados
            
            //Tratamento de erro com exception
            try
            {           
                   //Settando valores dos inputs texts nas variaveis que estão em campeão.
                campeao.setNome(txtNome.Text);
                campeao.setFuncao(txtFuncao.Text);
                campeao.setDificuldade(cbcDificuldade.Text);
                campeao.setDescricao(txtDescricao.Text);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return campeao;
        }

        private void CampeaoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide(); // Quando clicar no botao de cadastro, ira fechar a tela do form.
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
