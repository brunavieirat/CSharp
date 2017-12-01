using Sistema.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.dao
{
    class UsuarioDao
    {

        string sql = null;
        SqlConnection connection;

        // insert 
        public void Salvar(Usuario usuario)
        {
            connection = ConnectionFactory.getConnection();
            sql = "INSERT INTO usuario (Email, Senha, Nome) VALUES (@email, @senha, @nome)";
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@email", usuario.Email);
                cmd.Parameters.AddWithValue("@senha", usuario.Senha);
                cmd.Parameters.AddWithValue("@nome", usuario.Nome);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuário cadastrado com sucesso !", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Problemas ao cadastrar o usuário " + ex, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }


        // select
        public bool Consultar(Usuario usuario)
        {
           // connection = ConnectionFactory.getConnection();
           // bool result = false;

            string serverString = @"Data Source=DYNAMICCA\SQLEXPRESS;Initial Catalog=DB_Sistema; Integrated Security=True; Pooling=False";
            SqlConnection connection = new SqlConnection(serverString);

            try
            {
                connection.Open();
                //sql = "SELECT * FROM Usuario WHERE Email = '" + usuario.Email + "' AND Senha = '" + usuario.Senha + "'";
                sql = "SELECT * FROM Usuario WHERE Email= @email AND Senha= @senha";
                
                SqlCommand cmd = new SqlCommand(sql, connection);
                 cmd.Parameters.AddWithValue("@email", usuario.Email);
                 cmd.Parameters.AddWithValue("@senha", usuario.Senha);
                SqlDataReader reader = cmd.ExecuteReader();
                MessageBox.Show(sql);
             //   result = reader.HasRows;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Problemas ao consultar o usuário " + ex, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
          //  return result;
        }

        // update 

        // delete
    }
}
