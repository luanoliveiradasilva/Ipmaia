
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestaoPersonagenLOL
{
    public partial class CampeaoForm : Form
    {

        public CampeaoForm()
        {
            InitializeComponent();
        }


        private void btnCadastrarCampeao_Click_1(object sender, EventArgs e)
        {
            Campeao campeao = acessoPersonagem();
            Habilidade habilidades = acessoHabilidade();
            Skin skins = acessoSkin();

            try
            {
                if (campeao != null || habilidades != null || skins != null)
                {
                     RegistrarCampeoes registrarCampeoes = new RegistrarCampeoes(campeao, habilidades, skins);
                     registrarCampeoes.registrarCampeoes();
                }
      
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Dados invalidos"+ex);
            }
        }

        private Skin acessoSkin()
        {
            Skin skin = new Skin(); // Criação de objeto de campeão para adição de dados

            //Tratamento de erro com exception
            try
            {
                //Settando valores dos inputs texts nas variaveis que estão em campeão.

                string nomeSkin = txtNomeSkin.Text;

                if (!(nomeSkin.Equals("") || nomeSkin.Equals(null)))
                {
                    skin.setNomeSkins(nomeSkin);

                    if (chkIndisponivel.Checked)
                    {
                        skin.setSkinsHabilitada(chkIndisponivel.Text);
                    }
                    else if (chkDisponivel.Checked)
                    {
                        skin.setSkinsHabilitada(chkDisponivel.Text);
                    }

                    return skin;
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Por favor, selecionar uma disponibilidade!" + ex);
            }

            return null;
            
        }

        private Habilidade acessoHabilidade()
        {
            Habilidade habilidade = new Habilidade(); // Criação de objeto de campeão para adição de dados

            //Tratamento de erro com exception
            string nomeHabailidade = txtNomeHabilidade.Text;
            string comandoHabilidade = cbcComandoHabilidade.Text;
            string descricaoHabilidade = txtDescricaoHabilidade.Text;

            string[] setValues = {
                nomeHabailidade,
                comandoHabilidade,
                descricaoHabilidade
            };

            try
            {

                foreach (string value in setValues)
                {
                    if(!(value.Equals("") || value.Equals(null)))
                    {
                        //Settando valores dos inputs texts nas variaveis que estão em campeão.
                        habilidade.setNomeHabilidade(nomeHabailidade);
                        habilidade.setComandoHabilidade(comandoHabilidade);
                        habilidade.setDescricaoHabilidade(descricaoHabilidade);

                        return habilidade;
                        
                    }
                    else
                    {
                        MessageBox.Show("Por favor, informe os campos " + value);
                    }
                }
               
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Por favor,informar a habilidade "+ex);
            }

            return null;
        }

        private Campeao acessoPersonagem()
        {

            Campeao campeao = new Campeao(); // Criação de objeto de campeão para adição de dados


            string nomeCampea = txtNome.Text;
            string funcaoCampeao = cbcFuncao.Text;
            string DificuldadeCampeao = cbcDificuldade.Text;
            string descricaoCampeao = txtDescricao.Text;

            string[] setValues =
            {
                nomeCampea,
                funcaoCampeao,
                DificuldadeCampeao,
                descricaoCampeao
            };

            //Tratamento de erro com exception
            try
            {

                foreach (string value in setValues)
                {
                    if(!(value.Equals("") || value.Equals(null))){

                      //Settando valores dos inputs texts nas variaveis que estão em campeão.
                        campeao.setNome(nomeCampea);
                        campeao.setFuncao(funcaoCampeao);
                        campeao.setDificuldade(DificuldadeCampeao);
                        campeao.setDescricao(descricaoCampeao);


                        return campeao;
                    }
                    else
                    {
                        MessageBox.Show("Por favor, informe o campo " + value);

                    }

                }
                
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Por favor,informar a habilidade "+ex);
            }

            return null; 
        }


        private void CampeaoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide(); // Quando clicar no botao de cadastro, ira fechar a tela do form.
            Main form1 = new Main();
            form1.Show();
        }


    }
}
