using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Teste_LG.Controller;


namespace Model
{
    public class Dao
    {


        String conexao =
                          "Data Source=LG003591\\MSSQLSERVER01;" +
                          "Initial Catalog=Gestao;" +
                          "Integrated Security=SSPI;";

        public void Insert(String sqlText)
        {
            // variavel de conexão e instanciando
            SqlConnection con = new SqlConnection();
            //passa conexão com base de dados
            con.ConnectionString = conexao;
            //instancia variavel para executar comados no banco

            try
            {

                //variavel de executar query e instanciando
                SqlCommand cm = new SqlCommand(sqlText, con);
                //recebe os sql query passado pela tela
                cm.CommandText = sqlText;
                //abre a conexao
                con.Open();
                //executa a query
                cm.ExecuteNonQuery();

                MessageBox.Show("Cadastrado com sucesso!");

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);

            }
            finally
            {
                con.Close();
            }

        }

        public void Update(String sqlText)
        {
            // variavel de conexão e instanciando
            SqlConnection con = new SqlConnection();
            //passa conexão com base de dados
            con.ConnectionString = conexao;
            //instancia variavel para executar comados no banco

            try
            {
                //variavel de executar query e instanciando
                SqlCommand cm = new SqlCommand(sqlText, con);
                //recebe os sql query passado pela tela
                cm.CommandText = sqlText;
                //abre a conexao
                con.Open();
                //executa a query
                cm.ExecuteNonQuery();

                MessageBox.Show("Alterado com sucesso!");

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);

            }
            finally
            {
                con.Close();
            }
        }

        public void Delete(String sqlText)
        {
            // variavel de conexão e instanciando
            SqlConnection con = new SqlConnection();
            //passa conexão com base de dados
            con.ConnectionString = conexao;
            //instancia variavel para executar comados no banco

            try
            {
                //variavel de executar query e instanciando
                SqlCommand cm = new SqlCommand(sqlText, con);
                //recebe os sql query passado pela tela
                cm.CommandText = sqlText;
                //abre a conexao
                con.Open();
                //executa a query
                cm.ExecuteNonQuery();

                MessageBox.Show("Cadastro Excluido com sucesso!");

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);

            }
            finally
            {
                con.Close();
            }
        }


        /*
        //SELECT FAZ UM COUNT NO BANCO PARA SABER QUANTIDADE DE REGISTRO EXISTENTE. LIMITANDO A 5 CADASTRO DE MOTORISTA ADICIONAL
        public int Contador(String sqlText)
        {
            int contador = 0;
            // variavel de conexão e instanciando
            SqlConnection con = new SqlConnection();
            //passa conexão com base de dados
            con.ConnectionString = conexao;
            //instancia variavel para executar comados no banco
            try
            {
                //variavel de executar query e instanciando
                SqlCommand cm = new SqlCommand(sqlText, con);
                //recebe os sql query passado pela tela
                cm.CommandText = sqlText;
                //abre a conexao
                con.Open();
                //executa a query
                SqlDataReader reader = cm.ExecuteReader();
                while (reader.Read())
                {
                    contador = (int)reader.GetInt32(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro a executar bloco de Qtd: \n" +ex);
            }
            finally
            {
                con.Close();
            }
            return contador;
        }*/

        public int ConsultaValores(String sqlText) //UTILIZADO PARA PEGAR O NUMERO DE SEQUENCIA ID, UTILIZADO EM MOTADICIONAIS
        {
            int numeroSeq = 0;
            // variavel de conexão e instanciando
            SqlConnection con = new SqlConnection();
            //passa conexão com base de dados
            con.ConnectionString = conexao;
            //instancia variavel para executar comados no banco
            try
            {
                //variavel de executar query e instanciando
                SqlCommand cm = new SqlCommand(sqlText, con);
                //recebe os sql query passado pela tela
                cm.CommandText = sqlText;
                //abre a conexao
                con.Open();
                //executa a query
                SqlDataReader reader = cm.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        numeroSeq = (int)reader[0];
                    }
                } 
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro a executar bloco de Qtd: \n" + ex);
            }
            finally
            {
                con.Close();
            }
            return numeroSeq;
        }

        //CLASSE QUE FAZ ACESSO NO BANCO PARA OBTER REGISTRO EXISTENTES COLABORADOR

        public List<Colaborador> SelectColaborador(String sqlText)
        {
            //variavel de conexão e instanciando
            SqlConnection con = new SqlConnection();
            //passa conexão com base de dados
            con.ConnectionString = conexao;
            //instancia variavel para executar comados no banco

            List<Colaborador> listColaborador = new List<Colaborador>();

            try
            { 
                //variavel de executar query e instanciando
                SqlCommand cm = new SqlCommand(sqlText, con);
                //recebe os sql query passado pela tela
                cm.CommandText = sqlText;
                //abre a conexao
                con.Open();
                //executa a query
                SqlDataReader reader = cm.ExecuteReader();

                if (reader.HasRows) 
                {

                    while (reader.Read())
                    {
                        Colaborador colaborador = new Colaborador();

                        colaborador.Id_Colab = ((int)reader["id_colab"]);
                        colaborador.Nome = (string)reader["nome"];
                        colaborador.Telefone = (string)reader["telefone"];
                        colaborador.Departamento = (string)reader["departamento"];

                        listColaborador.Add(colaborador);
                    }
                    

                }
                else
                {
                    MessageBox.Show("Colaborador inexistente!");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro, verifique com administrador: "+ex.Message);
            }
            finally
            {
                con.Close();
            }

            return listColaborador;
        }


        //CLASSE QUE FAZ ACESSO NO BANCO PARA OBTER REGISTRO EXISTENTES MOTORISTA ADICIONAIS, VINCULADO AO MOTORISTA PRINCIPAL

        public List<MotoristaAdicional> SelectMotAdicional(String sqlText)
        {
            // variavel de conexão e instanciando
            SqlConnection con = new SqlConnection();
            //passa conexão com base de dados
            con.ConnectionString = conexao;
            //instancia variavel para executar comados no banco

            List<MotoristaAdicional> listMotoristaAdicional = new List<MotoristaAdicional>();
            //MotoristaAdicional motAdic = new MotoristaAdicional();

            try
            {
                //variavel de executar query e instanciando
                SqlCommand cm = new SqlCommand(sqlText, con);
                //recebe os sql query passado pela tela
                cm.CommandText = sqlText;
                //abre a conexao
                con.Open();
                //executa a query
                SqlDataReader reader = cm.ExecuteReader();

                if (reader.HasRows)
                {
                    //foreach (MotoristaAdicional motorista in listMotoristaAdicional) ^{ 
                    //}

                    

                    while (reader.Read())
                    {
                            //INSTANCIA DA CLASSE DE MOTORISTA OCORRE DENTRO DO WHILE DE LEITURA
                            MotoristaAdicional motAdic = new MotoristaAdicional();

                            //PASSANDO PARAMENTROS PARA CLASSE
                            motAdic.Id_MotAdicional = ((int)reader["id_mot_adicional"]);
                            motAdic.Nome = (string)reader["nome"];
                            motAdic.Telefone = (string)reader["telefone"];
                            motAdic.Grau_Parentesco = (string)reader["grau_parentesco"];

                            //USADO PARA ADICIONAR A UM LIST OS VALORES
                            listMotoristaAdicional.Add(motAdic);

                    }

                }
                else
                {
                    MessageBox.Show("Não existe Motorista Adicional!");
                }

                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }
            return listMotoristaAdicional;
        }


        //CLASSE QUE FAZ ACESSO NO BANCO PARA OBTER REGISTRO EXISTENTES CARRO, VINCULADO A COLABORADOR E MOTORISTA ADICIONAIS

        public List<Carro> SelectCarro(String sqlText)
        {
            // variavel de conexão e instanciando
            SqlConnection con = new SqlConnection();
            //passa conexão com base de dados
            con.ConnectionString = conexao;
            //cria uma list carro
            List<Carro> listCarro = new List<Carro>();

            try
            {
                //variavel de executar query e instanciando
                SqlCommand cm = new SqlCommand(sqlText, con);
                //recebe os sql query passado pela tela
                cm.CommandText = sqlText;
                //abre a conexao
                con.Open();
                //executa a query
                SqlDataReader reader = cm.ExecuteReader();

                if (reader.HasRows)
                {
                    //foreach (MotoristaAdicional motorista in listMotoristaAdicional) ^{ 
                    //}
                    while (reader.Read())
                    {
                        //INSTANCIA DA CLASSE DE MOTORISTA OCORRE DENTRO DO WHILE DE LEITURA
                        Carro carro = new Carro();

                        //PASSANDO PARAMENTROS PARA CLASSE
                        carro.Id_carro = ((int)reader["id_carro"]);
                        carro.Name = (string)reader["nome"];
                        carro.Placa = (string)reader["placa"];
                        carro.Id_motorista_principal = (int)reader["Id_motorista_principal"];
                        carro.Id_motorista_adicional = (int)reader["Id_motorista_adicionais"];

                        //USADO PARA ADICIONAR A UM LIST OS VALORES
                        listCarro.Add(carro);
                    }
                }
                else
                {
                    MessageBox.Show("Não existe Motorista Adicional!");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }
            return listCarro;
        }

        public List<Tuple<int, string, string, string, string>> SelectCarroGrid(String sqlText)
        {
            // variavel de conexão e instanciando
            SqlConnection con = new SqlConnection();
            //passa conexão com base de dados
            con.ConnectionString = conexao;
            //cria uma list tuple
            List<Tuple<int, string, string,string,string>> gridCarro = new List<Tuple<int, string, string, string, string>>();


            try
            {
                //variavel de executar query e instanciando
                SqlCommand cm = new SqlCommand(sqlText, con);
                //recebe os sql query passado pela tela
                cm.CommandText = sqlText;
                //abre a conexao
                con.Open();
                //executa a query
                SqlDataReader reader = cm.ExecuteReader();

                if (reader.HasRows)
                {
                    //foreach (MotoristaAdicional motorista in listMotoristaAdicional) ^{ 
                    //}
                    while (reader.Read())
                    {

                        int id_carro = Convert.ToInt32(reader["id_carro"]);
                        string modelo = (string)reader["modelo"];
                        string placa = (string)reader["placa"];
                        string nome = (string)reader["nome"];
                        string tipo = (string)reader["tipo"];


                        //USADO PARA ADICIONAR A UM LIST OS VALORES
                        gridCarro.Add(Tuple.Create(id_carro,modelo,placa,nome,tipo));
                    }
                }
                else
                {
                    MessageBox.Show("Não existe Motorista Adicional!");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }
            return gridCarro;
        }




        ///DEIXAR SCRIPT DE EXEMPLO MODELO UTILIZADO NO TESTE
        /*
        static List<Colaborador> ObterColaboradores(string connectionString)
        {
            List<Colaborador> colaboradores = new List<Colaborador>();

            string query = "SELECT Id, Nome, Telefone, Departamento FROM Colaboradores";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            using (Colaborador colaborador = new Colaborador())
                            {
                                colaborador.Id_Colab = reader.GetInt32(0);
                                colaborador.Nome = reader.GetString(1);
                                colaborador.Telefone = reader.GetString(2);
                                colaborador.Departamento = reader.GetString(3);
                                colaboradores.Add(colaborador);
                            }
                        }
                    }
                }
            }

            return colaboradores;
        }
        */

    }
}



