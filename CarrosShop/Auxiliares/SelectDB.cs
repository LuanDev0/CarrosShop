using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrosShop.Auxiliares
{
    public class SelectDB
    {

        Conexao conexao = new Conexao();

        public DataTable SelectDataBase(string query)
        {
            SqlConnection connection = conexao.AbrirConexao();
            DataTable table = new DataTable();

            try
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conexao.FecharConexao();
            }

            return table;
        }

    }
}
