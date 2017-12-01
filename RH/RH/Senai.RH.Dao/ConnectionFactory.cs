using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Senai.RH.Dao
{
    class ConnectionFactory
    {
        // método de conexão com o banco de dados
        public SqlConnection GetConnection() { 
      
            
            // string de conexão com o servidor
            string servidor = @"Data Source=.\SQLEXPRESS; Initial Catalog=Empresa; Integrated Security=true; Pooling=false";

            // cria uma instância de SqlConnection
            SqlConnection connection = new SqlConnection(servidor);

            // retorna um SqlConnection
            return connection;
        }

    }
}
