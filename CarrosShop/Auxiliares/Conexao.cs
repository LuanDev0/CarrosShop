using System;
using System.Data.SqlClient;

namespace CarrosShop
{
    public class Conexao
    {
        private SqlConnection connection;
        private string connectionString = "Server=DESKTOP-NO8NECE;Database=CarrosShop;User ID=sa;Password=Master123";

        public SqlConnection AbrirConexao()
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                return connection;
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao conectar ao banco de dados: " + ex.Message);
            }
        }

        public void FecharConexao()
        {
            try
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao fechar conexão com o banco de dados: " + ex.Message);
            }
        }
    }
}
