using CarrosShop.Auxiliares;
using CarrosShop.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarrosShop.Forms
{
    public partial class Fm_Cadastro : Form
    {
        public Fm_Cadastro()
        {
            InitializeComponent();
        }

        Genericos genericos = new Genericos();

        Classe_Cadastro cadastro = new Classe_Cadastro();

        //Variaveis
        Boolean Valida = false;
        int TipoOperacao;

        private void Fm_Cadastro_Load(object sender, EventArgs e)
        {
            cadastro.CarregaGridView(DGV_GridCarros);

            Mtb_Ano.PromptChar = ' ';
            Tb_Valor.RightToLeft = RightToLeft.Yes;

            Tb_NomeCarro.Enabled = false;
            Cb_Categoria.Enabled = false;
            Tb_Valor.Enabled = false;
            Cb_Pais.Enabled = false;
            Cb_Condicao.Enabled = false;
            Nud_Quantidade.Enabled = false;
            Mtb_Ano.Enabled = false;

            Bt_Cancelar.Enabled = false;
            Bt_Confirmar.Enabled = false;
        }

        private void Bt_Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Tb_Valor_Leave(object sender, EventArgs e)
        {
            Error_Cadastro.Clear();

            if(Tb_Valor.Text == "")return;
            Tb_Valor.Text = Tb_Valor.Text.Replace("R$ ", "");

            if (!(Tb_Valor.Text.All(char.IsDigit)))
            {
                if (Tb_Valor.Text.ToString().Contains(',') || Tb_Valor.Text.ToString().Contains('.'))
                {
                    string formatoEsperado = @"^\d{1,12},\d{1,2}$";

                    if (Regex.IsMatch(Tb_Valor.Text, formatoEsperado))
                    {

                    }
                    else
                    {
                        Error_Cadastro.SetError(Tb_Valor, "Valor não valido");
                        return;
                    }
                }
                else
                {
                    Error_Cadastro.SetError(Tb_Valor, "Valor não valido");
                    return;
                }
            }

            decimal valor = Convert.ToDecimal(Tb_Valor.Text);

            string valorFormatado = genericos.FormataValor(valor);

            if(valorFormatado == "Não numérico")
            {
                Error_Cadastro.SetError(Tb_Valor, valorFormatado);
                return;
            }

            Tb_Valor.Text = valorFormatado;
        }

        private void Bt_Cadastrar_Click(object sender, EventArgs e)
        {
            Tb_NomeCarro.Enabled = true;
            Cb_Categoria.Enabled = true;
            Tb_Valor.Enabled = true;
            Cb_Pais.Enabled = true;
            Cb_Condicao.Enabled = true;
            Nud_Quantidade.Enabled = true;
            Mtb_Ano.Enabled = true;

            Bt_Cadastrar.Enabled = false;
            Bt_Alterar.Enabled = false;
            Bt_Excluir.Enabled = false;

            Bt_Confirmar.Enabled = true;
            Bt_Cancelar.Enabled = true;

            Tb_NomeCarro.Focus();

            TipoOperacao = 1;
        }

        private void Bt_Alterar_Click(object sender, EventArgs e)
        {
            int Categ, Quanti, ano ;
            string nome, pais, cond;
            double valor;

            Error_Cadastro.Clear();

            if (DGV_GridCarros.SelectedCells.Count == 0 || DGV_GridCarros.SelectedRows.Count == 0)
            {
                Error_Cadastro.SetError(Bt_Alterar, "Selecione um item na Tabela");
                return;
            }

            nome = DGV_GridCarros.SelectedRows[0].Cells[1].Value.ToString(); 
            Categ = Convert.ToInt32(DGV_GridCarros.SelectedRows[0].Cells[2].Value.ToString());
            string categ = "";

            if (Categ == 1) categ = "Utilitarios";
            if (Categ == 2) categ = "Executivos";
            if (Categ == 3) categ = "Luxo";

            ano = Convert.ToInt32(DGV_GridCarros.SelectedRows[0].Cells[3].Value.ToString()); 
            cond = DGV_GridCarros.SelectedRows[0].Cells[4].Value.ToString(); 
            pais = DGV_GridCarros.SelectedRows[0].Cells[5].Value.ToString(); 
            Quanti = Convert.ToInt32(DGV_GridCarros.SelectedRows[0].Cells[6].Value.ToString()); 
            valor = Convert.ToDouble(DGV_GridCarros.SelectedRows[0].Cells[7].Value.ToString());

            Tb_NomeCarro.Text = nome;
            Cb_Categoria.Text = categ;
            Tb_Valor.Text = Convert.ToString(valor);
            Cb_Pais.Text = pais;
            Cb_Condicao.Text = cond;
            Nud_Quantidade.Value = Quanti;
            Mtb_Ano.Text = Convert.ToString(ano);

            Tb_NomeCarro.Enabled = true;
            Cb_Categoria.Enabled = true;
            Tb_Valor.Enabled = true;
            Cb_Pais.Enabled = true;
            Cb_Condicao.Enabled = true;
            Nud_Quantidade.Enabled = true;
            Mtb_Ano.Enabled = true;

            Bt_Cadastrar.Enabled = false;
            Bt_Alterar.Enabled = false;
            Bt_Excluir.Enabled = false;

            Bt_Confirmar.Enabled = true;
            Bt_Cancelar.Enabled = true;

            Tb_NomeCarro.Focus();

            DGV_GridCarros.Enabled = false;

            TipoOperacao = 2;
        }

        private void Bt_Excluir_Click(object sender, EventArgs e)
        {


            if (DGV_GridCarros.SelectedCells.Count == 0 || DGV_GridCarros.SelectedRows.Count == 0)
            {
                Error_Cadastro.SetError(Bt_Excluir, "Selecione um item na Tabela");
                return;
            }

            Bt_Cadastrar.Enabled = false;
            Bt_Alterar.Enabled = false;
            Bt_Excluir.Enabled = false;

            Bt_Confirmar.Enabled = true;
            Bt_Cancelar.Enabled = true;

            DGV_GridCarros.Enabled = false;

            TipoOperacao = 3;
        }

        private void Bt_Confirmar_Click(object sender, EventArgs e)
        {

            if(TipoOperacao == 1) //Cadastrar
            {
                ValidaDados(Valida);

                if (Valida == true) return;

                Tb_Valor.Text = Tb_Valor.Text.Replace("R$ ", "");

                cadastro.RegistraCarro(Tb_NomeCarro.Text, Cb_Categoria.Text, Convert.ToDouble(Tb_Valor.Text), Cb_Pais.Text,
                                       Cb_Condicao.Text, Convert.ToInt32(Nud_Quantidade.Text), Convert.ToInt32(Mtb_Ano.Text));

                cadastro.CarregaGridView(DGV_GridCarros);

                Tb_NomeCarro.Text = "";
                Cb_Categoria.Text = "";
                Tb_Valor.Text = "";
                Cb_Pais.Text = "";
                Cb_Condicao.Text = "";
                Nud_Quantidade.Text = "0";
                Mtb_Ano.Text = "";

                Tb_NomeCarro.Enabled = false;
                Cb_Categoria.Enabled = false;
                Tb_Valor.Enabled = false;
                Cb_Pais.Enabled = false;
                Cb_Condicao.Enabled = false;
                Nud_Quantidade.Enabled = false;
                Mtb_Ano.Enabled = false;

                Bt_Alterar.Enabled = true;
                Bt_Cadastrar.Enabled = true;
                Bt_Excluir.Enabled = true;

                Bt_Cancelar.Enabled = false;
                Bt_Confirmar.Enabled = false;
            }

            if (TipoOperacao == 2) //Alterar
            {
                Error_Cadastro.Clear();

                int Id;

                ValidaDados(Valida);

                if (Valida == true) return;

                Tb_Valor.Text = Tb_Valor.Text.Replace("R$ ", "");

                Id = Convert.ToInt32(DGV_GridCarros.SelectedRows[0].Cells[0].Value.ToString());

                cadastro.AlteraCarro(Id, Tb_NomeCarro.Text, Cb_Categoria.Text, Convert.ToDouble(Tb_Valor.Text), Cb_Pais.Text,
                                       Cb_Condicao.Text, Convert.ToInt32(Nud_Quantidade.Text), Convert.ToInt32(Mtb_Ano.Text));

                cadastro.CarregaGridView(DGV_GridCarros);

                Tb_NomeCarro.Text = "";
                Cb_Categoria.Text = "";
                Tb_Valor.Text = "";
                Cb_Pais.Text = "";
                Cb_Condicao.Text = "";
                Nud_Quantidade.Text = "0";
                Mtb_Ano.Text = "";
                Error_Cadastro.Clear();

                Tb_NomeCarro.Enabled = false;
                Cb_Categoria.Enabled = false;
                Tb_Valor.Enabled = false;
                Cb_Pais.Enabled = false;
                Cb_Condicao.Enabled = false;
                Nud_Quantidade.Enabled = false;
                Mtb_Ano.Enabled = false;

                Bt_Alterar.Enabled = true;
                Bt_Cadastrar.Enabled = true;
                Bt_Excluir.Enabled = true;

                Bt_Cancelar.Enabled = false;
                Bt_Confirmar.Enabled = false;

                DGV_GridCarros.Enabled = true;
            }

            if (TipoOperacao == 3) //Excluir
            {
                Error_Cadastro.Clear();
                int Id;

                Id = Convert.ToInt32(DGV_GridCarros.SelectedRows[0].Cells[0].Value.ToString());

                cadastro.ExcluiCarro(Id);

                cadastro.CarregaGridView(DGV_GridCarros);

                Tb_NomeCarro.Text = "";
                Cb_Categoria.Text = "";
                Tb_Valor.Text = "";
                Cb_Pais.Text = "";
                Cb_Condicao.Text = "";
                Nud_Quantidade.Text = "0";
                Mtb_Ano.Text = "";
                Error_Cadastro.Clear();

                Bt_Alterar.Enabled = true;
                Bt_Cadastrar.Enabled = true;
                Bt_Excluir.Enabled = true;

                Bt_Cancelar.Enabled = false;
                Bt_Confirmar.Enabled = false;

                DGV_GridCarros.Enabled = true;
            }
        }

        private Boolean ValidaDados(bool valida)
        {
            bool Error = false;

            Error_Cadastro.Clear();

            if (Tb_NomeCarro.Text == "")
            {
                Error_Cadastro.SetError(Tb_NomeCarro, "Campo obrigatório");
                Error = true;
            }
            if (Cb_Categoria.Text == "")
            {
                Error_Cadastro.SetError(Cb_Categoria, "Campo obrigatório");
                Error = true;
            }
            if (Tb_Valor.Text == "")
            {
                Error_Cadastro.SetError(Tb_Valor, "Campo obrigatório");
                Error = true;
            }
            if (Cb_Pais.Text == "")
            {
                Error_Cadastro.SetError(Cb_Pais, "Campo obrigatório");
                Error = true;
            }
            if (Cb_Condicao.Text == "")
            {
                Error_Cadastro.SetError(Cb_Condicao, "Campo obrigatório");
                Error = true;
            }
            if (Nud_Quantidade.Text == "0")
            {
                Error_Cadastro.SetError(Nud_Quantidade, "Campo obrigatório");
                Error = true;
            }
            if (Mtb_Ano.Text == "")
            {
                Error_Cadastro.SetError(Mtb_Ano, "Campo obrigatório");
                Error = true;
            }

            if (Error == true)
            {
                return Valida = true;
            }
            else
            {
                return Valida = false;
            }
        }

        private void Bt_Cancelar_Click(object sender, EventArgs e)
        {
            Tb_NomeCarro.Text = "";
            Cb_Categoria.Text = "";
            Tb_Valor.Text = "";
            Cb_Pais.Text = "";
            Cb_Condicao.Text = "";
            Nud_Quantidade.Text = "0";
            Mtb_Ano.Text = "";
            Error_Cadastro.Clear();

            Tb_NomeCarro.Enabled = false;
            Cb_Categoria.Enabled = false;
            Tb_Valor.Enabled = false;
            Cb_Pais.Enabled = false;
            Cb_Condicao.Enabled = false;
            Nud_Quantidade.Enabled = false;
            Mtb_Ano.Enabled = false;

            Bt_Alterar.Enabled = true;
            Bt_Cadastrar.Enabled = true;
            Bt_Excluir.Enabled = true;

            Bt_Cancelar.Enabled = false;
            Bt_Confirmar.Enabled = false;

            DGV_GridCarros.Enabled = true;

            TipoOperacao = 0;

        }
    }
}
