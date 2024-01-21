using CarrosShop.Auxiliares;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarrosShop.Classes
{
    public class Classe_Venda
    {
        CarregaGrid grid = new CarregaGrid();

        SelectDB select = new SelectDB();

        Genericos genericos = new Genericos();

        public DataTable ComboCarros()
        {
            String query = "SELECT Nome_Carro FROM Carro";

            DataTable Tabela;

            Tabela = select.SelectDataBase(query);
            
            return Tabela;
        }

        public DataTable ComboClientes()
        {
            String query = "SELECT Nome_Cliente FROM Cliente";

            DataTable Tabela;

            Tabela = select.SelectDataBase(query);

            return Tabela;
        }

        public void CarregaGridView(DataGridView gridView)
        {
            try
            {
                string consulta = "SELECT Id_Venda, Cliente.Nome_Cliente, Carro.Nome_Carro, Quantidade_Venda, Data_Venda " +
                " FROM Venda " +
                "LEFT JOIN Cliente ON " +
                "Venda.Id_Cliente = Cliente.Id_Cliente " +
                "LEFT JOIN Carro ON " +
                "Venda.Id_Carro = Carro.Id_Carro ";

                grid.CarregaGridView(gridView, consulta);

                gridView.Columns["Id_Venda"].HeaderText = "Id";
                gridView.Columns["Nome_Cliente"].HeaderText = "Cliente";
                gridView.Columns["Nome_Carro"].HeaderText = "Carro";
                gridView.Columns["Quantidade_Venda"].HeaderText = "Quantidade";
                gridView.Columns["Data_Venda"].HeaderText = "Data";

                gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch(Exception ex)
            {

            }
            finally
            {

            }
        }

        public DataTable ValorCarro(string nomeCarro)
        {
            string Consulta = "SELECT Preco_Carro " +
                              "FROM Carro " +
                              "WHERE Nome_Carro = '" + nomeCarro + "'";

            DataTable Valor = new DataTable();

            Valor = select.SelectDataBase(Consulta);

            return Valor;
        }

        public string ValorTotal(decimal valorCarro, int quantidade, int parcelas, decimal seguro, decimal desconto)
        {
            decimal valorTotal = 0;
            string valorForm;

            valorTotal = (valorCarro * quantidade) + seguro + desconto;

            valorForm = genericos.FormataValor(valorTotal);

            return  valorForm;
        }
    }
}
