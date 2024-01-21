using CarrosShop.Auxiliares;
using CarrosShop.Classes;
using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CarrosShop.Forms
{
    public partial class Fm_Venda : Form
    {
        public Fm_Venda()
        {
            InitializeComponent();
        }

        Genericos genericos = new Genericos();

        Classe_Venda venda = new Classe_Venda();

        //Variaveis
        decimal Valorcarro = 0;
        int quantidade = 1;
        decimal Taxa = 0;
        int Parcelas = 1;
        decimal Seguro = 0;
        decimal Desconto = 0;
        decimal ValorXparc = 0;

        DataTable DtvalorCarro;


        //Eventos
        private void Fm_Venda_Load(object sender, EventArgs e)
        {
            PopulaCB();
            venda.CarregaGridView(DTV_Vendas);
        }

        private void Bt_Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Cb_Pagamento_SelectedValueChanged(object sender, EventArgs e)
        {
            if(Cb_Pagamento.Text == "Pix" || Cb_Pagamento.Text == "Dinheiro")
            {
                Nud_Parcelas.Visible = false;
                Lb_Parcelas.Visible = false;
                Tb_ValorParcelas.Visible = false;
                Tb_Xparcelas.Visible = false;
                Lb_ValorParcelas.Visible = false;
            }
            else
            {
                Nud_Parcelas.Visible = true;
                Lb_Parcelas.Visible = true;

                Tb_ValorParcelas.Visible = true;
                Tb_Xparcelas.Visible = true;
                Lb_ValorParcelas.Visible = true;
            }
        }

        private void Tb_Seguro_Leave(object sender, EventArgs e)
        {
            Error_Venda.Clear();

            if (Tb_Seguro.Text == "") return;
            Tb_Seguro.Text = Tb_Seguro.Text.Replace("R$ ", "");

            if (!(Tb_Seguro.Text.All(char.IsDigit)))
            {
                if (Tb_Seguro.Text.ToString().Contains(',') || Tb_Seguro.Text.ToString().Contains('.'))
                {
                    string formatoEsperado = @"^\d{1,12},\d{1,2}$";

                    if (Regex.IsMatch(Tb_Seguro.Text, formatoEsperado))
                    {

                    }
                    else
                    {
                        Error_Venda.SetError(Tb_Seguro, "Valor não valido");
                        return;
                    }
                }
                else
                {
                    Error_Venda.SetError(Tb_Seguro, "Valor não valido");
                    return;
                }
            }

            decimal valor = Convert.ToDecimal(Tb_Seguro.Text);

            string valorFormatado = genericos.FormataValor(valor);

            if (valorFormatado == "Não numérico")
            {
                Error_Venda.SetError(Tb_Seguro, valorFormatado);
                return;
            }

            Tb_Seguro.Text = valorFormatado;
        }

        private void Tb_Desconto_Leave(object sender, EventArgs e)
        {
            Error_Venda.Clear();

            if (Tb_Desconto.Text == "") return;
            Tb_Desconto.Text = Tb_Desconto.Text.Replace("R$ ", "");

            if (!(Tb_Desconto.Text.All(char.IsDigit)))
            {
                if (Tb_Desconto.Text.ToString().Contains(',') || Tb_Desconto.Text.ToString().Contains('.'))
                {
                    string formatoEsperado = @"^\d{1,12},\d{1,2}$";

                    if (Regex.IsMatch(Tb_Desconto.Text, formatoEsperado))
                    {

                    }
                    else
                    {
                        Error_Venda.SetError(Tb_Desconto, "Valor não valido");
                        return;
                    }
                }
                else
                {
                    Error_Venda.SetError(Tb_Desconto, "Valor não valido");
                    return;
                }
            }

            decimal valor = Convert.ToDecimal(Tb_Desconto.Text);

            string valorFormatado = genericos.FormataValor(valor);

            if (valorFormatado == "Não numérico")
            {
                Error_Venda.SetError(Tb_Seguro, valorFormatado);
                return;
            }

            Tb_Desconto.Text = valorFormatado;
        }

        private void Cb_Carro_SelectedValueChanged_1(object sender, EventArgs e)
        {
            Error_Venda.Clear();

            string nomeCarro = Cb_Carro.Text;

            DtvalorCarro = venda.ValorCarro(nomeCarro);

            if (DtvalorCarro != null && DtvalorCarro.Rows.Count > 0)
            {
                decimal precoCarro = Convert.ToDecimal(DtvalorCarro.Rows[0]["Preco_Carro"]);

                Valorcarro = precoCarro;

                ValorFinal();
            }
        }

        private void Nud_Parcelas_ValueChanged(object sender, EventArgs e)
        {
            if (Nud_Parcelas.Value == null) Nud_Parcelas.Value = 1;

            Tb_ValorTotal.Text = Tb_ValorTotal.Text.Replace("R$ ", "");

            ValorXparc = Convert.ToDecimal(Tb_ValorTotal.Text) / Convert.ToDecimal(Nud_Parcelas.Value);

            Tb_ValorTotal.Text = genericos.FormataValor(Convert.ToDecimal(Tb_ValorTotal.Text));

            Tb_ValorParcelas.Text = genericos.FormataValor(ValorXparc);
        }

        private void Nud_Quantidade_ValueChanged(object sender, EventArgs e)
        {
            //Valida
            if (Cb_Carro.Text == "")
            {
                Nud_Quantidade.Value = 1;
                Error_Venda.SetError(Cb_Carro, "Escolha um Carro");
                Cb_Carro.Focus();
                return;
            }
            decimal precoCarro = Convert.ToDecimal(DtvalorCarro.Rows[0]["Preco_Carro"]);
            int quanti = Convert.ToInt32(Nud_Quantidade.Value);
            int parc = Convert.ToInt32(Nud_Parcelas.Value);
            decimal seguro = 0;
            decimal desconto = 0;
            

            if (Tb_Seguro.Text != "")
            {
                seguro = Convert.ToDecimal(Tb_Seguro.Text.Replace("R$ ", "").Replace(".", "").Replace(",", "."));
            }
            else
            {
                seguro = 0;
            }

            if (Tb_Desconto.Text != "")
            {
                desconto = Convert.ToDecimal(Tb_Desconto.Text.Replace("R$ ", "").Replace(".", "").Replace(",", "."));
            }
            else
            {
                desconto = 0;
            }
            Tb_ValorTotal.Text = venda.ValorTotal(precoCarro, quanti, parc, seguro, desconto);

            Nud_Parcelas.Value = 1;

            Tb_ValorTotal.Text = Tb_ValorTotal.Text.Replace("R$ ", "");

            ValorXparc = Convert.ToDecimal(Tb_ValorTotal.Text) / Convert.ToDecimal(Nud_Parcelas.Value);

            Tb_ValorTotal.Text = genericos.FormataValor(Convert.ToDecimal(Tb_ValorTotal.Text));

            Tb_ValorParcelas.Text = genericos.FormataValor(ValorXparc);

            quantidade = Convert.ToInt32(Nud_Quantidade.Value);
        }

        private void Nud_Taxa_ValueChanged(object sender, EventArgs e)
        {
            if (Cb_Carro.Text == "")
            {
                Error_Venda.SetError(Cb_Carro, "Escolha um Carro");
                return;
            }

            ValorFinal();

        }


        //Métodos
        private void PopulaCB()
        {
            DataTable Carros = venda.ComboCarros();
            DataTable Clientes = venda.ComboClientes();

            foreach (DataRow row in Carros.Rows)
            {
                Cb_Carro.Items.Add(row["Nome_Carro"].ToString());
            }

            foreach (DataRow row in Clientes.Rows)
            {
                Cb_Clientes.Items.Add(row["Nome_Cliente"].ToString());
            }
        }

        private void ValorFinal()
        {
            decimal valorFinal = 0;
            decimal valorTaxa;

            Taxa = Valorcarro / 100;
            valorTaxa = Taxa * Nud_Taxa.Value;

            valorFinal = ((Valorcarro + valorTaxa) * quantidade) + Seguro + Desconto;

            Tb_ValorTotal.Text = valorFinal.ToString();

            Tb_ValorTotal.Text = Tb_ValorTotal.Text.Replace("R$ ", "");

            if (!(Tb_ValorTotal.Text.All(char.IsDigit)))
            {
                if (Tb_ValorTotal.Text.ToString().Contains(',') || Tb_ValorTotal.Text.ToString().Contains('.'))
                {
                    //if (Regex.IsMatch(Tb_ValorTotal.Text, @"^\d{1,12},\d{1,2}$"))
                    //{
                        
                    //}
                    //else
                    //{
                    //    //Error_Venda.SetError(Tb_Seguro, "Valor não valido");
                    //    return;
                    //}
                }
                else
                {
                    //Error_Venda.SetError(Tb_Seguro, "Valor não valido");
                    return;
                }
            }

            decimal valor = Convert.ToDecimal(Tb_ValorTotal.Text);

            string valorFormatado = genericos.FormataValor(valor);

            if (valorFormatado == "Não numérico")
            {
                Error_Venda.SetError(Tb_Seguro, valorFormatado);
                return;
            }

            Tb_ValorTotal.Text = Convert.ToString(valorFormatado);
        }
    }
}