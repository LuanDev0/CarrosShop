using CarrosShop.Auxiliares;
using CarrosShop.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarrosShop.Classes
{
    public class Classe_Cadastro
    {
        ExecProc proc = new ExecProc();

        CarregaGrid grid = new CarregaGrid();

        Genericos Gen = new Genericos();



        public void CarregaGridView(DataGridView gridView)
        {
            try
            {
                string Consulta = "SELECT " +
                                  "* FROM Carro ";

                grid.CarregaGridView(gridView, Consulta);

                gridView.Columns["Id_Carro"].Visible = false;
                gridView.Columns["Nome_Carro"].HeaderText = "Nome";
                gridView.Columns["Id_Categoria"].Visible = false;
                gridView.Columns["Ano_Carro"].Visible = false;
                gridView.Columns["Codicao_Carro"].HeaderText = "Condição";
                gridView.Columns["Origem_Carro"].Visible = false;
                gridView.Columns["Preco_Carro"].HeaderText = "Preço Uni.";
                gridView.Columns["Preco_Carro"].DefaultCellStyle.Format = "R$ #,##0.00";
                gridView.Columns["Estoque_Carro"].HeaderText = "Estoque";

                gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            }
            catch(Exception ex) 
            {
            
            }
            finally
            {

            }
        }

        

        //public string FormataValor(decimal valor)
        //{
        //    string valorFormatado;

        //    if (valor >= 0)
        //    {
        //        valorFormatado = valor.ToString("C2");
        //    }
        //    else
        //    {
        //        valorFormatado = "Valor negativo não pode ser formatado como preço.";
        //    }

        //    return valorFormatado;
        //}

        public void RegistraCarro(String carro, string Categoria, double valor, string pais, string condicao, int quantidade, int ano)
        {
            int NumCateg = 0;

            if (Categoria == "Utilitarios") NumCateg = 1;
            if (Categoria == "Executivos") NumCateg = 2;
            if (Categoria == "Luxo") NumCateg = 3;

            SqlParameter paramNome = new SqlParameter("@Vproc_Nome_Carro", SqlDbType.VarChar);
            paramNome.Value = carro;

            SqlParameter paramNumCateg = new SqlParameter("@Vproc_Categoria_Carro", SqlDbType.VarChar);
            paramNumCateg.Value = NumCateg;

            SqlParameter paramValor = new SqlParameter("@Vproc_Valor", SqlDbType.Decimal);
            paramValor.Value = valor;

            SqlParameter paramPais = new SqlParameter("@Vproc_Pais", SqlDbType.VarChar);
            paramPais.Value = pais;

            SqlParameter paramCondicao = new SqlParameter("@Vproc_Condicao", SqlDbType.VarChar);
            paramCondicao.Value = condicao;

            SqlParameter paramQuantidade = new SqlParameter("@Vproc_Quantidade", SqlDbType.Int);
            paramQuantidade.Value = quantidade;

            SqlParameter paramAno = new SqlParameter("@Vproc_Ano", SqlDbType.Int);
            paramAno.Value = ano;

            proc.ExecProcedure("Proc_CadastroIncluir", paramNome, paramNumCateg, paramValor, paramPais, paramCondicao, paramQuantidade, paramAno);
        }

        public void AlteraCarro(int Id, String carro, string Categoria, double valor, string pais, string condicao, int quantidade, int ano)
        {
            int NumCateg = 0;

            if (Categoria == "Utilitarios") NumCateg = 1;
            if (Categoria == "Executivos") NumCateg = 2;
            if (Categoria == "Luxo") NumCateg = 3;

            SqlParameter paramId = new SqlParameter("@Vproc_Id_Carro", SqlDbType.Int);
            paramId.Value = Id;

            SqlParameter paramNome = new SqlParameter("@Vproc_Nome_Carro", SqlDbType.VarChar);
            paramNome.Value = carro;

            SqlParameter paramNumCateg = new SqlParameter("@Vproc_Categoria_Carro", SqlDbType.VarChar);
            paramNumCateg.Value = NumCateg;

            SqlParameter paramValor = new SqlParameter("@Vproc_Valor", SqlDbType.Decimal);
            paramValor.Value = valor;

            SqlParameter paramPais = new SqlParameter("@Vproc_Pais", SqlDbType.VarChar);
            paramPais.Value = pais;

            SqlParameter paramCondicao = new SqlParameter("@Vproc_Condicao", SqlDbType.VarChar);
            paramCondicao.Value = condicao;

            SqlParameter paramQuantidade = new SqlParameter("@Vproc_Quantidade", SqlDbType.Int);
            paramQuantidade.Value = quantidade;

            SqlParameter paramAno = new SqlParameter("@Vproc_Ano", SqlDbType.Int);
            paramAno.Value = ano;

            proc.ExecProcedure("Proc_CadastroAlterar", paramId, paramNome, paramNumCateg, paramValor, paramPais, paramCondicao, paramQuantidade, paramAno);
        }

        public void ExcluiCarro(int Id)
        {
            SqlParameter paramId = new SqlParameter("@Vproc_Id_Carro", SqlDbType.Int);
            paramId.Value = Id;

            proc.ExecProcedure("Proc_CadastroExcluir", paramId);   
        }


        public bool ValidaOparacao(bool operacao)
        {
            if (operacao == true) return true;
            else  return false;
        }
    }
}