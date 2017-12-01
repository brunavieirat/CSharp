using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.dao
{
    class ConnectionFactory
    {
        // método para realizar a conexão com o banco de dados
        public static SqlConnection getConnection()
        {
            string serverString = @"Data Source=DYNAMICCA\SQLEXPRESS;Initial Catalog=DB_Sistema; Integrated Security=True; Pooling=False";
            SqlConnection connection = new SqlConnection(serverString);
            
            return connection;
            
        }
    }
}
