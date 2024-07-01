using Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Teste_LG.Controller;

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
                int flagCarro = 0; //Sinalizado de existencia na tabela de banco de dados
                { 
                    
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
                }


                {
                    Sql = null;
                    Sql = "Select * from carro where id_motorista_principal = '" + int.Parse(textPesquisa.Text) + "'";

                    List<Carro> listcarros = ConexaoBD.SelectCarro(Sql);

                    maskedPlaca.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                    textCarroID.Clear();
                    maskedPlaca.Clear();
                    textModeloCarro.Clear();

                    foreach (Carro carro in listcarros)
                    {
                        textCarroID.Text = carro.Id_carro.ToString();
                        maskedPlaca.Text = carro.Placa.ToString();
                        textModeloCarro.Text = carro.Name.ToString();

                        flagCarro = carro.Id_carro;
                    }
                }

                //BLOCO DATAGRIDVIEW --- ELES BUSCA O COLABORADORES, E CONSULTA SE EXISTE MOTORISTA JÁ ADICIONADO, CASO TENHA ELE MOSTRA TODOS NO GRID
                if (flag != 0 && flagCarro != 0)
                {
                    try
                    {
                        motoristaAdicionalGrid();
                        CarroGrid();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Erro no Grid: \n" + ex);
                    }
                }else if (flag != 0 )
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
                    //LIMPA GRID ADICIONAIS CARRO
                    dataGridVinculoCarro.Rows.Clear(); 
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

        public void CarroGrid() //ATUALIZA GRID
        {

            //flag = 0; //Sinalizado de existencia na tabela de banco de dados  
            String Sql = null;
            Sql = "Select * from CARRO_GRID where id_carro IN ( SELECT CAR.id_carro FROM CARRO CAR, colaborador COL WHERE CAR.Id_motorista_principal = '"+ int.Parse(textColabID.Text) + "' ) ";

            List<Tuple<int, string, string, string, string>> gridCarroView = ConexaoBD.SelectCarroGrid(Sql);
            dataGridVinculoCarro.Rows.Clear();

            foreach (var gridCarro in gridCarroView)
            {

                dataGridVinculoCarro.Rows.Add(gridCarro.Item1, gridCarro.Item2, gridCarro.Item3, gridCarro.Item4, gridCarro.Item5);

            }

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
                        Sql = "Select distinct count(id_carro) from carro where Id_motorista_principal = '"+ textColabID.Text + "'";
                        flag = (int)ConexaoBD.ConsultaValores(Sql);

                        if (flag == 0)
                        {

                            Sql = null; //VARIVEL QUERY
                            Sql = "Select ISNULL(max(id_carro),0) from carro";
                            int GeradorIdCarro = (int)ConexaoBD.ConsultaValores(Sql);
                            GeradorIdCarro = GeradorIdCarro + 1;


                            Sql = "Insert into Carro(id_carro ,nome, placa, Id_motorista_principal, Id_motorista_adicionais) " +
                                    "values ('" + GeradorIdCarro + "' ,'" + textModeloCarro.Text + "','" + maskedPlaca.Text + "','" + textColabID.Text + "','');";
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

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            //CARRO
            textCarroID.Clear();
            textModeloCarro.Clear();
            maskedPlaca.Clear();

            //PESSOA
            textCarroID.Clear();
            textNomeColab.Clear();
            textPesquisa.Clear();

            //MOTORISTA ADICIONAL
            dataGridMotAdicionais.Rows.Clear();
        }

        private void buttonAdicionaMotorista_Click(object sender, EventArgs e)
        {
            String Sql = null; //VARIVEL QUERY
            int flagExistenciaCadastroCarro = 0;
            int flagQtdeCadastro = 0;
            int flagExistenciaMotAdicional = 0;


            try//PEGAR ERRO NA EXECUÇÃO
            {
                if (textColabID.Text != "" && textCarroID.Text != "" && textIDMotAdc.Text != "") //ADCIONAR MOTORISTA ADICIONAL
                {
                    if (textModeloCarro.Text == "" || maskedPlaca.Text == "" || maskedPlaca.TextLength < 7)
                    {
                        MessageBox.Show("Campo Obrigatorio não preenchido"); //verifica se campos obrigatorios estão preenchidos
                    }
                    else
                    {
                        //REALIZADO UMA VALIDAÇÃO DE REGRA DE NEGOCIO A ONDE É PERMITIDO CADASTRAR SOMENTE UM CARRO PARA CADA COLABORADOR 
                        Sql = null; //VARIVEL QUERY

                        //CONFERE NO BANCO SE EXISTE AQUELE CARRO VINCULADO PARA COLABORADOR
                        Sql = "Select distinct count(id_carro) from carro where Id_motorista_principal = '" + textColabID.Text + "'";
                        flagExistenciaCadastroCarro = (int)ConexaoBD.ConsultaValores(Sql);

                        //CONFERE NO BANCO SE ESTÁ DENTRO DO PERMITIDO VINCULAR MOTORISTA ADICIONAIS, SENDO LIMITE MAXIMO 5 MOTORISTA ADICIONAIS CADASTRADOS
                        Sql = "Select count(id_carro) from carro where Id_motorista_principal = '" + textColabID.Text + "'";
                        flagQtdeCadastro = (int)ConexaoBD.ConsultaValores(Sql);

                        //CONFERE SE NÃO EXISTE ESSE MOTORISTA ADICIONAL JÁ CADASTRADO NO BANCO
                        Sql = "Select count(Id_motorista_adicionais) from carro where Id_motorista_principal = '" + textColabID.Text + "' and Id_motorista_adicionais = '"+ textIDMotAdc.Text + "'";
                        flagExistenciaMotAdicional = (int)ConexaoBD.ConsultaValores(Sql);

                        if(flagExistenciaCadastroCarro == 0)
                        {
                            MessageBox.Show("Veiculo Não cadastro para colaborador");
                        }else if (flagQtdeCadastro == 6)
                        {
                            MessageBox.Show("Limite Maximo de Motorista Adicionados");
                        }else if (flagExistenciaMotAdicional > 0)
                        {
                            MessageBox.Show("Veiculo já vinculado a motorista Adicional");
                        }else
                        {

                            Sql = null; //VARIVEL QUERY

                            Sql = "Insert into Carro(id_carro ,nome, placa, Id_motorista_principal, Id_motorista_adicionais) " +
                                    "values ('" + textCarroID.Text + "' ,'" + textModeloCarro.Text + "','" + maskedPlaca.Text + "','" + textColabID.Text + "','" + textIDMotAdc.Text + "');";
                            ConexaoBD.Insert(Sql);

                            motoristaAdicionalGrid();

                        }

                    }
                }
                
                else if (textColabID.Text == "" && textCarroID.Text == "") //PREENCHIMENTO DE MOTORISTA PRINCIPAL VAZIO
                {
                    MessageBox.Show("Selecionar Motorista Adicional");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Entrar em contato com suporte para verificar erro: \n" + ex);
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (textColabID.Text != "" && textCarroID.Text != "")
                {
                    String Sql = null;
                    Sql = "delete from CARRO WHERE id_motorista_principal ='" + textColabID.Text + "' AND id_motorista_adicional ='" + textIDMotAdc.Text + "'";

                    ConexaoBD.Delete(Sql);

                    motoristaAdicionalGrid();
                }
                else if (textColabID.Text == "" || textCarroID.Text == "")
                {
                    MessageBox.Show("Nenhum cadastro selecionado para excluir");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Entrar em contato com suporte verificar erro excluir: " + ex);
            }
        }

        private void dataGridMotAdicionais_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String Sql = null; //variavel para passar ao banco, query

            if (e.RowIndex >= 0)
            {
                Sql = null;

                int id = (int)dataGridMotAdicionais.Rows[e.RowIndex].Cells[0].Value;

                Sql = "Select * from MOTORISTAADICIONAIS WHERE id_colab ='" + textColabID.Text + "' AND id_mot_adicional ='" + id + "'";

                List<MotoristaAdicional> motAdic = ConexaoBD.SelectMotAdicional(Sql);

                textIDMotAdc.Clear();

                foreach (MotoristaAdicional motadicional in motAdic)
                {
                    textIDMotAdc.Text = motadicional.Id_MotAdicional.ToString();
                }

            }
        }
    }
}
