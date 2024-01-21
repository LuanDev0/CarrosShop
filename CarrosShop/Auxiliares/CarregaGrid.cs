using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarrosShop.Auxiliares
{
    public class CarregaGrid
    {

        Conexao conexao = new Conexao();

        public void CarregaGridView(DataGridView gridView, string consulta)
        {
            try
            {
                using (SqlConnection connection = conexao.AbrirConexao())
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(consulta, connection);

                    DataTable Tabela = new DataTable();

                    adapter.Fill(Tabela);

                    gridView.DataSource = Tabela;

                    conexao.FecharConexao();
                }

                gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            }
            catch (Exception ex)
            {

            }
            finally
            {

            }

        }
    }
}