using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CarrosShop { 

    public class Conexao
    {
        SqlConnection connection = new SqlConnection();

        //Construtor
        public Conexao()
        {
            connection.ConnectionString = "Server=DESKTOP-08F513I;Database=CarrosShop;User ID=sa;Password=Master123";
        }

        //Metodo Conectar
        public SqlConnection Conectar()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }

            return connection;
        }
        //Metodo Desconectar
        public SqlConnection Desconectar()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }

            return connection;
        }
    }
}