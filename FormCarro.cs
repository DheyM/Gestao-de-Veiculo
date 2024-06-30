using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teste_LG.Controller;
using Model;

namespace Teste_LG
{
    public partial class FormCarro : Form
    {
        Dao ConexaoBD = new Dao();

        public FormCarro()
        {
            InitializeComponent();
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            String Sql = null; //variavel para passar ao banco, query


            if (textPesquisa.Text != "")
            {
                int flag = 0; //Sinalizado de existencia na tabela de banco de dados    
                Sql = null;
                Sql = "Select * from colaborador where id_colab = '" + int.Parse(textPesquisa.Text) + "'";

                List<Colaborador> colaboradores = ConexaoBD.SelectColaborador(Sql);

                textColabID.Clear();
                textNomeColab.Clear();
                //maskedTelefone.Clear();

                foreach (Colaborador colaborador in colaboradores)
                {
                    textColabID.Text = colaborador.Id_Colab.ToString();
                    textNomeColab.Text = colaborador.Nome.ToString();
                    //maskedTelefone.Text = colaborador.Telefone.ToString();

                    flag = colaborador.Id_Colab;
                }


                //BLOCO DATAGRIDVIEW --- ELES BUSCA O COLABORADORES, E CONSULTA SE EXISTE MOTORISTA JÁ ADICIONADO, CASO TENHA ELE MOSTRA TODOS NO GRID
                if (flag != 0)
                {
                    try
                    {
                        motoristaAdicionalGrid();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Erro no Grid: \n" + ex);
                    }
                }
                else if (flag == 0)
                {
                    //LIMPA DADOS COLABORADOR
                    textColabID.Clear();
                    textNomeColab.Clear();

                    //LIMPA DADOS MOTORISTA ADICIONAIS
                    dataGridMotAdicionais.Rows.Clear();
                }

            }
            else if (textPesquisa.Text == "")
            {
                MessageBox.Show("Campo de pesquisa em branco");

            }

        }

        public void motoristaAdicionalGrid() //ATUALIZA GRID
        {

            //flag = 0; //Sinalizado de existencia na tabela de banco de dados  
            String Sql = null;
            Sql = "Select * from MOTORISTAADICIONAIS where id_colab = '" + int.Parse(textColabID.Text) + "'";

            List<MotoristaAdicional> motAdic = ConexaoBD.SelectMotAdicional(Sql);
            dataGridMotAdicionais.Rows.Clear();

            foreach (MotoristaAdicional motAdicional in motAdic)
            {

                dataGridMotAdicionais.Rows.Add(motAdicional.Id_MotAdicional, motAdicional.Nome, motAdicional.Telefone, motAdicional.Grau_Parentesco);

            }

        }

        private int dataGridMotAdicionais_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = 0; //PEGA O VALOR DO ID PARA ADICIONAR O MOTORISTA AO VEICULO

            if (e.RowIndex >= 0)
            {

                id = (int)dataGridMotAdicionais.Rows[e.RowIndex].Cells[0].Value;

            }
            return id;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            maskedPlaca.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            String Sql = null; //VARIVEL QUERY
            int flag = 0;

            try//PEGAR ERRO NA EXECUÇÃO
            {
                if (textColabID.Text != "" && textCarroID.Text == "") //SALVAR
                {
                    if (textModeloCarro.Text == "" || maskedPlaca.Text == "" ||  maskedPlaca.TextLength < 7)
                    {
                        MessageBox.Show("Campo Obrigatorio não preenchido"); //verifica se campos obrigatorios estão preenchidos
                    }
                    else
                    {
                        //REALIZADO UMA VALIDAÇÃO DE REGRA DE NEGOCIO A ONDE É PERMITIDO CADASTRAR SOMENTE UM CARRO PARA CADA COLABORADOR 
                        Sql = null; //VARIVEL QUERY
                        Sql = "Select disctinct count(id_carro) from carro where Id_motorista_principal = '"+ textColabID.Text + "'";
                        flag = (int)ConexaoBD.ConsultaValores(Sql);

                        if (flag == 0)
                        {

                            Sql = null; //VARIVEL QUERY
                            Sql = "Select max(id_carro) from carro";
                            int GeradorIdMotoristaADicional = (int)ConexaoBD.ConsultaValores(Sql);
                            GeradorIdMotoristaADicional = GeradorIdMotoristaADicional + 1;


                            Sql = "Insert into Carro(id_carro ,nome, placa, Id_motorista_principal, Id_motorista_adicionais) " +
                                    "values ('" + GeradorIdMotoristaADicional + "' ,'" + textModeloCarro.Text + "','" + maskedPlaca.Text + "','" + textColabID.Text + "','NULL');";
                            ConexaoBD.Insert(Sql);

                            motoristaAdicionalGrid();
                        }
                        else
                        {
                            MessageBox.Show("Já existe um veículo cadastrado para ele colaborador!\nLimite de 1 veículo por colaborador!");
                        }

                    }
                }
                else if (textColabID.Text != "" && textCarroID.Text != "") //EDITAR
                {

                    if (textModeloCarro.Text == "" || maskedPlaca.Text == "" || maskedPlaca.TextLength < 7)
                    {
                        MessageBox.Show("Campo Obrigatorio não preenchido"); //verifica se campos obrigatorios estão preenchidos
                    }
                    else
                    {
                        Sql = null; //VARIVEL QUERY
                        Sql = "update MotoristaAdicionais set nome = '" + textModeloCarro.Text + "WHERE id_mot_adicional ='" + textColabID.Text + "' AND id_colab '" + textCarroID.Text + "'";
                        ConexaoBD.Update(Sql);
                    }

                }
                else if (textColabID.Text == "" && textCarroID.Text == "") //PREENCHIMENTO DE MOTORISTA PRINCIPAL VAZIO
                {
                    MessageBox.Show("Preencher os dados para salvar");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Entrar em contato com suporte para verificar erro: \n" + ex);
            }
        }
    }
}
