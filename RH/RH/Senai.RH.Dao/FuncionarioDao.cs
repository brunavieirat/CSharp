using RH.Senai.RH._Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RH.Senai.RH.Dao
{
    class FuncionarioDao : IDao<Funcionario>
    {
        // atributos
        // conexão com o banco de dados
        private SqlConnection connection;

        // instrução sql
        private string sql = null;

        // mensagem do messagebox
        private string msg = null;

        // título do messagebox
        private string titulo = null;

        // construtor
        public FuncionarioDao()
        {
            // cria uma conexão com o banco de dados
            connection = new ConnectionFactory().GetConnection();
        }

        // métodos
        public List<Funcionario> Consultar()
        {
            // comando sql de consulta
            sql = "SELECT * FROM Funcionario";

            // lista de funcionários cadastrados
            List<Funcionario> funcionarios = new List<Funcionario>();

            try
            {
                // abre a conexão com o banco de dados
                connection.Open();

                // comando sql
                SqlCommand cmd = new SqlCommand(sql, connection);

                // cria um leitor de dados
                SqlDataReader leitor = cmd.ExecuteReader();

                // enquanto o leitor tiver dados para ler
                while (leitor.Read())
                {
                    Funcionario funcionario = new Funcionario();
                    funcionario.ID = (long)leitor["IDFuncionario"];
                    funcionario.Nome = leitor["Nome"].ToString();
                    funcionario.CPF = leitor["Cpf"].ToString();
                    funcionario.RG = leitor["Rg"].ToString();
                    funcionario.Email = leitor["Email"].ToString();
                    funcionario.Telefone = leitor["Telefone"].ToString();
                    // adiciona o funcionário na lista de funcionários
                    funcionarios.Add(funcionario);
                } // fim do while
            }
            catch (SqlException ex)
            {
                msg = "Erro ao consultar os funcionários cadastrados: " + ex.Message;
                titulo = "Erro...";
                MessageBox.Show(msg, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
            return funcionarios;
        }

        public void Excluir(Funcionario t)
        {
            throw new NotImplementedException();
        }

        public void Salvar(Funcionario funcionario)
        {
            try
            {
                sql = "INSERT INTO Funcionario(Nome, Cpf, Rg, Email, Telefone) VALUES (@Nome, @Cpf, @Rg, @Email, @Telefone)";

                // abre uma conexão com o banco de dados
                connection.Open();

                // comando sql
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@Nome", funcionario.Nome);
                cmd.Parameters.AddWithValue("@Cpf", funcionario.CPF);
                cmd.Parameters.AddWithValue("@Rg", funcionario.RG);
                cmd.Parameters.AddWithValue("@Email", funcionario.Email);
                cmd.Parameters.AddWithValue("@Telefone", funcionario.Telefone);

                // executa o INSERT
                cmd.ExecuteNonQuery();

                msg = "Funcionario " + funcionario.Nome + " salvo com sucesso !";
                titulo = "Sucesso...";
                MessageBox.Show(msg, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (SqlException ex)
            {
                msg = "Erro o salvar o funcionário: " + ex.Message;
                titulo = "Erro...";
                MessageBox.Show(msg, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
