using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Teste_LG.Controller;

namespace Teste_LG
{
    public partial class FormMotAdicionais : Form
    {
        Dao ConexaoBD = new Dao();

        public FormMotAdicionais()
        {
           
            InitializeComponent();
        }

        private void buttonSalvar_Click(object sender, EventArgs e) //botao de salvar, evento para salvar motadicional
        {
            maskedTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            String Sql = null; //VARIVEL QUERY

            try//PEGAR ERRO NA EXECUÇÃO
            {
                if (textColabID.Text != "" && textIDMotAdc.Text == "") //SALVAR
                {
                    if (textNomeMotAdc.Text == "" && comboRelacMotAdc.Text == "")
                    {
                        MessageBox.Show("Campo Obrigatorio não preenchido"); //verifica se campos obrigatorios estão preenchidos
                    }
                    else
                    {   //REGRA DE NEGOCIO: É PERMITIDO CADASTRAR SOMENTE ATÉ 5 MOTORISTA ADICIONAIS
                        Sql = null; //VARIVEL QUERY
                        Sql = "Select COUNT(*) from motoristaAdicionais where id_colab = '" + int.Parse(textColabID.Text) + "'" ;
                        int QtdeMotAdicionais = (int)ConexaoBD.ConsultaValores(Sql);


                        if (QtdeMotAdicionais < 5) //SÓ SALVAR DEPOIS DE CHECAR NO BANCO SE TEM MENOS DE 5 OU 5 MOTORISTA ADICIONAL
                        {   

                            int GeradorIdMotoristaADicional = ConexaoBD.ConsultaValores("Select ISNULL(max(id_mot_adicional),0) from " +
                                "motoristaAdicionais where id_colab = '" + int.Parse(textColabID.Text) + "'"); //AQUI E GERADO O ID, GERANDO SEQUENCIAL POR COLABORADOR, FICANDO ORGANIZADO DE 1 A 5
                            GeradorIdMotoristaADicional = GeradorIdMotoristaADicional + 1;

                            Sql = null; //VARIVEL QUERY

                            Sql = "Insert into MotoristaAdicionais(id_mot_adicional ,nome, telefone, grau_parentesco, id_colab) " +
                                "values ('"+ GeradorIdMotoristaADicional + "' ,'" + textNomeMotAdc.Text + "','" + maskedTelefone.Text + "','" + comboRelacMotAdc.Text + "','" + textColabID.Text + "');";
                            ConexaoBD.Insert(Sql);

                            motoristaAdicionalGrid();
                        }
                        else
                        {
                            MessageBox.Show("Não é possivel cadastrar mais que 5 Motoristas Adicionais");
                        }
                    }
                }
                else if (textColabID.Text != "" && textIDMotAdc.Text != "") //EDITAR
                {

                    if (textNomeMotAdc.Text == "" && comboRelacMotAdc.Text == "")
                    {
                        MessageBox.Show("Campo Obrigatorio não preenchido"); //verifica se campos obrigatorios estão preenchidos
                    }
                    else
                    {
                        Sql = null; //VARIVEL QUERY
                        Sql = "update MotoristaAdicionais set nome = '" + textNomeMotAdc.Text + "', telefone = '" + maskedTelefone.Text + "', grau_parentesco = '" + comboRelacMotAdc.Text + "'" +
                            "WHERE id_mot_adicional ='" + textIDMotAdc.Text + "' AND id_colab '" + textColabID.Text + "'";
                        ConexaoBD.Update(Sql);
                    }

                }
                else if (textColabID.Text == "" && textIDMotAdc.Text == "") //PREENCHIMENTO DE MOTORISTA PRINCIPAL VAZIO
                {
                    MessageBox.Show("Obrigatorio o preenchimento do Motorista Principal");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Entrar em contato com suporte para verificar erro: \n" + ex);
            }

            

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
                    comboDepartamento.Text = colaborador.Departamento.ToString();

                    flag = colaborador.Id_Colab;
                }
               

                //BLOCO DATAGRIDVIEW --- ELES BUSCA O COLABORADORES, E CONSULTA SE EXISTE MOTORISTA JÁ ADICIONADO, CASO TENHA ELE MOSTRA TODOS NO GRID
                if(flag != 0)
                {
                    try
                    {
                        motoristaAdicionalGrid();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Erro no Grid: \n" + ex);
                    }
                }else if (flag == 0)
                {
                    //LIMPA DADOS COLABORADOR
                    textColabID.Clear();
                    textNomeColab.Clear();
                    comboDepartamento.Text = "";

                    //LIMPA DADOS MOTORISTA ADICIONAIS
                    dataGridMotAdicionais.Rows.Clear();

                    textIDMotAdc.Clear();
                    textNomeMotAdc.Clear();
                    maskedTelefone.Clear();
                    comboRelacMotAdc.Text = "";
                }

            }
            else if (textPesquisa.Text == "")
            {
                MessageBox.Show("Campo de pesquisa em branco");
                
            }

        }

        private void buttonExcluir_Click(object sender, EventArgs e) //EXCLUIR
        {
            try
            {
                if (textColabID.Text != "" && textIDMotAdc.Text != "")
                {
                    {
                        String Sql = null;
                        Sql = "delete from MOTORISTAADICIONAIS WHERE id_colab ='" + textColabID.Text + "' AND id_mot_adicional ='" + textIDMotAdc.Text + "'";

                        ConexaoBD.Delete(Sql);
                    }

                    {
                        String Sql = null;
                        int flag = 0; //utilizado para validar dados e existencia na tabela
                        Sql = "select count(*) from CARRO WHERE id_motorista_principal ='" + textColabID.Text + "' AND id_motorista_adicionais ='" + textIDMotAdc.Text + "'";
                        flag = ConexaoBD.ConsultaValores(Sql);


                        if(flag != 0)
                        {
                            Sql = null;
                            Sql = "delete from CARRO WHERE id_motorista_principal ='" + textColabID.Text + "' AND id_motorista_adicionais ='" + textIDMotAdc.Text + "'";
                            ConexaoBD.Delete(Sql);
                        }

                    }
                    motoristaAdicionalGrid();
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
                textNomeMotAdc.Clear();
                maskedTelefone.Clear();
                comboRelacMotAdc.Text = "";

                foreach (MotoristaAdicional motadicional in motAdic)
                {
                    textIDMotAdc.Text = motadicional.Id_MotAdicional.ToString();
                    textNomeMotAdc.Text = motadicional.Nome.ToString();
                    maskedTelefone.Text = motadicional.Telefone.ToString();
                    comboRelacMotAdc.Text = motadicional.Grau_Parentesco.ToString();
                }

            }
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            textIDMotAdc.Clear();
            textNomeMotAdc.Clear();
            maskedTelefone.Clear();
            comboRelacMotAdc.Text = "";
        }
    }
}
