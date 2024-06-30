using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using Model;
using Teste_LG.Controller;
using System.Collections.Generic;
using System.Collections;

namespace Teste_LG
{
    public partial class FormColaborador : Form
    {
        Dao ConexaoBD = new Dao();

        public FormColaborador()
        {
            InitializeComponent();
        }

        private void ButtonSalvar_Click(object sender, EventArgs e) //SALVAR
        {
            maskedTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            try
            {
                if (textColabID.Text == "") //SALVAR
                {
                    try
                    {
                        if (textNome.Text == "" && comboDepartamento.Text == "") //verifica se está os campos obrigatorio preenchidos
                        {
                            MessageBox.Show("Campo Obrigatorio não preenchidos");
                        }
                        else //verifica se está os campos obrigatorio preenchidos, caso esteja é salvo no banco
                        {
                            //sql enviado para banco de dados
                            String Sql = null;
                            Sql = "Insert into colaborador(nome, telefone, departamento) values ('" + textNome.Text + "','" + maskedTelefone.Text + "','" + comboDepartamento.Text + "');";
                            ConexaoBD.Insert(Sql);
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Entrar em contato com suporte verificar erro ao Salvar: \n" + ex);
                    }
                    
                }
                else if (textColabID.Text != "") //EDITAR
                {
                    try
                    {
                        if (textNome.Text == "" && comboDepartamento.Text == "") //verifica se está os campos obrigatorio preenchidos
                        {
                            MessageBox.Show("Campo Obrigatorio não preenchidos");
                        }
                        else //verifica se está os campos obrigatorio preenchidos, caso esteja é salvo no banco
                        {
                            //sql enviado para banco de dados
                            String Sql = null;
                            Sql = "update colaborador set nome = '" + textNome.Text + "', telefone = '" + maskedTelefone.Text + "', departamento = '" + comboDepartamento.Text + "'" +
                                "WHERE id_colab ='" + textColabID.Text + "'";
                            ConexaoBD.Update(Sql);
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Entrar em contato com suporte verificar erro ao editar: \n" + ex);
                    }

                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Entrar em contato com suporte verificar erro: "+ ex);
            }
                   
        }

        private void buttonPesquisar_Click(object sender, EventArgs e) ///PESQUISAR
        {

            try
            {

                if (textPesquisa.Text != "")
                {
                    String Sql = null; //variavel para passar ao banco, query
                    Sql = "Select * from colaborador where id_colab = '" + int.Parse(textPesquisa.Text) + "'";

                    List<Colaborador> colaboradores = ConexaoBD.SelectColaborador(Sql);

                    textColabID.Clear();
                    textNome.Clear();
                    maskedTelefone.Clear();

                    foreach (Colaborador colaborador in colaboradores)
                    {
                        textColabID.Text = colaborador.Id_Colab.ToString();
                        textNome.Text = colaborador.Nome.ToString();
                        maskedTelefone.Text = colaborador.Telefone.ToString();
                        comboDepartamento.Text = colaborador.Departamento.ToString();
                    }
                }
                else if (textPesquisa.Text == "")
                {
                    MessageBox.Show("Campo de pesquisa em branco");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Entrar em contato com suporte verificar erro pesquisar: " + ex);
            }
            
        }

        private void buttonExcluir_Click(object sender, EventArgs e) //EXCLUIR
        {

            try
            {
                if (textColabID.Text != "")
                {
                    String Sql = null;
                    Sql = "delete from colaborador WHERE id_colab ='" + textColabID.Text + "'";

                    ConexaoBD.Delete(Sql);
                }
                else if (textColabID.Text == "")
                {
                    MessageBox.Show("Nenhum cadastro selecionado para excluir");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Entrar em contato com suporte verificar erro excluir: " + ex);
            }
            

        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textColabID.Clear();
            textNome.Clear();
            maskedTelefone.Clear();
            comboDepartamento.Text = "";
        }

        private void pictureMotoristaAdicional_Click(object sender, EventArgs e)
        {
            FormMotAdicionais formMotAdicionais = new FormMotAdicionais();
            formMotAdicionais.Show();
        }
    }
}
