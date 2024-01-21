namespace CarrosShop.Forms
{
    partial class Fm_Venda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Bt_Incluir = new System.Windows.Forms.Button();
            this.Bt_Excluir = new System.Windows.Forms.Button();
            this.DTV_Vendas = new System.Windows.Forms.DataGridView();
            this.Bt_Finalizar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Nud_Parcelas = new System.Windows.Forms.NumericUpDown();
            this.Cb_Pagamento = new System.Windows.Forms.ComboBox();
            this.Nud_Taxa = new System.Windows.Forms.NumericUpDown();
            this.Cb_Clientes = new System.Windows.Forms.ComboBox();
            this.Lb_Parcelas = new System.Windows.Forms.Label();
            this.Cb_Carro = new System.Windows.Forms.ComboBox();
            this.Nud_Quantidade = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.Tb_Seguro = new System.Windows.Forms.TextBox();
            this.Tb_ValorTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Tb_Desconto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.Bt_Fechar = new System.Windows.Forms.Button();
            this.Tb_ValorParcelas = new System.Windows.Forms.TextBox();
            this.Lb_ValorParcelas = new System.Windows.Forms.Label();
            this.Tb_Xparcelas = new System.Windows.Forms.TextBox();
            this.Error_Venda = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DTV_Vendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Parcelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Taxa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Quantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error_Venda)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carro : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Taxa % :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cliente :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantidade : ";
            // 
            // Bt_Incluir
            // 
            this.Bt_Incluir.Location = new System.Drawing.Point(401, 447);
            this.Bt_Incluir.Name = "Bt_Incluir";
            this.Bt_Incluir.Size = new System.Drawing.Size(75, 23);
            this.Bt_Incluir.TabIndex = 4;
            this.Bt_Incluir.Text = "Incluir";
            this.Bt_Incluir.UseVisualStyleBackColor = true;
            // 
            // Bt_Excluir
            // 
            this.Bt_Excluir.Location = new System.Drawing.Point(513, 447);
            this.Bt_Excluir.Name = "Bt_Excluir";
            this.Bt_Excluir.Size = new System.Drawing.Size(75, 23);
            this.Bt_Excluir.TabIndex = 5;
            this.Bt_Excluir.Text = "Excluir";
            this.Bt_Excluir.UseVisualStyleBackColor = true;
            // 
            // DTV_Vendas
            // 
            this.DTV_Vendas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.DTV_Vendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTV_Vendas.Location = new System.Drawing.Point(401, 45);
            this.DTV_Vendas.Name = "DTV_Vendas";
            this.DTV_Vendas.Size = new System.Drawing.Size(387, 396);
            this.DTV_Vendas.TabIndex = 6;
            // 
            // Bt_Finalizar
            // 
            this.Bt_Finalizar.Location = new System.Drawing.Point(695, 447);
            this.Bt_Finalizar.Name = "Bt_Finalizar";
            this.Bt_Finalizar.Size = new System.Drawing.Size(93, 23);
            this.Bt_Finalizar.TabIndex = 7;
            this.Bt_Finalizar.Text = "Finalizar Compra";
            this.Bt_Finalizar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Forma de Pagamento :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Data :";
            // 
            // Nud_Parcelas
            // 
            this.Nud_Parcelas.Location = new System.Drawing.Point(128, 238);
            this.Nud_Parcelas.Maximum = new decimal(new int[] {
            36,
            0,
            0,
            0});
            this.Nud_Parcelas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Nud_Parcelas.Name = "Nud_Parcelas";
            this.Nud_Parcelas.Size = new System.Drawing.Size(42, 20);
            this.Nud_Parcelas.TabIndex = 10;
            this.Nud_Parcelas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Nud_Parcelas.Visible = false;
            this.Nud_Parcelas.ValueChanged += new System.EventHandler(this.Nud_Parcelas_ValueChanged);
            // 
            // Cb_Pagamento
            // 
            this.Cb_Pagamento.FormattingEnabled = true;
            this.Cb_Pagamento.Items.AddRange(new object[] {
            "Pix",
            "Dinheiro",
            "Boleto",
            "Crédito"});
            this.Cb_Pagamento.Location = new System.Drawing.Point(49, 213);
            this.Cb_Pagamento.Name = "Cb_Pagamento";
            this.Cb_Pagamento.Size = new System.Drawing.Size(121, 21);
            this.Cb_Pagamento.TabIndex = 11;
            this.Cb_Pagamento.SelectedValueChanged += new System.EventHandler(this.Cb_Pagamento_SelectedValueChanged);
            // 
            // Nud_Taxa
            // 
            this.Nud_Taxa.Location = new System.Drawing.Point(230, 132);
            this.Nud_Taxa.Name = "Nud_Taxa";
            this.Nud_Taxa.Size = new System.Drawing.Size(121, 20);
            this.Nud_Taxa.TabIndex = 12;
            this.Nud_Taxa.ValueChanged += new System.EventHandler(this.Nud_Taxa_ValueChanged);
            // 
            // Cb_Clientes
            // 
            this.Cb_Clientes.FormattingEnabled = true;
            this.Cb_Clientes.Location = new System.Drawing.Point(230, 59);
            this.Cb_Clientes.Name = "Cb_Clientes";
            this.Cb_Clientes.Size = new System.Drawing.Size(121, 21);
            this.Cb_Clientes.TabIndex = 13;
            // 
            // Lb_Parcelas
            // 
            this.Lb_Parcelas.AutoSize = true;
            this.Lb_Parcelas.Location = new System.Drawing.Point(46, 240);
            this.Lb_Parcelas.Name = "Lb_Parcelas";
            this.Lb_Parcelas.Size = new System.Drawing.Size(54, 13);
            this.Lb_Parcelas.TabIndex = 14;
            this.Lb_Parcelas.Text = "Parcelas :";
            this.Lb_Parcelas.Visible = false;
            // 
            // Cb_Carro
            // 
            this.Cb_Carro.FormattingEnabled = true;
            this.Cb_Carro.Location = new System.Drawing.Point(49, 59);
            this.Cb_Carro.Name = "Cb_Carro";
            this.Cb_Carro.Size = new System.Drawing.Size(121, 21);
            this.Cb_Carro.TabIndex = 15;
            this.Cb_Carro.SelectedValueChanged += new System.EventHandler(this.Cb_Carro_SelectedValueChanged_1);
            // 
            // Nud_Quantidade
            // 
            this.Nud_Quantidade.Location = new System.Drawing.Point(49, 131);
            this.Nud_Quantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Nud_Quantidade.Name = "Nud_Quantidade";
            this.Nud_Quantidade.Size = new System.Drawing.Size(121, 20);
            this.Nud_Quantidade.TabIndex = 16;
            this.Nud_Quantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Nud_Quantidade.ValueChanged += new System.EventHandler(this.Nud_Quantidade_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(230, 213);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Valor do Seguro :";
            // 
            // Tb_Seguro
            // 
            this.Tb_Seguro.Location = new System.Drawing.Point(49, 314);
            this.Tb_Seguro.Name = "Tb_Seguro";
            this.Tb_Seguro.Size = new System.Drawing.Size(121, 20);
            this.Tb_Seguro.TabIndex = 19;
            this.Tb_Seguro.Leave += new System.EventHandler(this.Tb_Seguro_Leave);
            // 
            // Tb_ValorTotal
            // 
            this.Tb_ValorTotal.Enabled = false;
            this.Tb_ValorTotal.Location = new System.Drawing.Point(230, 390);
            this.Tb_ValorTotal.Name = "Tb_ValorTotal";
            this.Tb_ValorTotal.Size = new System.Drawing.Size(121, 20);
            this.Tb_ValorTotal.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(227, 374);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Valor Total :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(227, 297);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Desconto :";
            // 
            // Tb_Desconto
            // 
            this.Tb_Desconto.Location = new System.Drawing.Point(230, 313);
            this.Tb_Desconto.Name = "Tb_Desconto";
            this.Tb_Desconto.Size = new System.Drawing.Size(121, 20);
            this.Tb_Desconto.TabIndex = 23;
            this.Tb_Desconto.Leave += new System.EventHandler(this.Tb_Desconto_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(46, 374);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Tipo de carta :";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "A - Moto",
            "B - Carros",
            "C - Veiculo de carga",
            "D - Veiculo de lotação",
            "E - Veiculo Articulado"});
            this.comboBox4.Location = new System.Drawing.Point(49, 390);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 25;
            // 
            // Bt_Fechar
            // 
            this.Bt_Fechar.Location = new System.Drawing.Point(763, 13);
            this.Bt_Fechar.Name = "Bt_Fechar";
            this.Bt_Fechar.Size = new System.Drawing.Size(25, 23);
            this.Bt_Fechar.TabIndex = 26;
            this.Bt_Fechar.Text = "X";
            this.Bt_Fechar.UseVisualStyleBackColor = true;
            this.Bt_Fechar.Click += new System.EventHandler(this.Bt_Fechar_Click);
            // 
            // Tb_ValorParcelas
            // 
            this.Tb_ValorParcelas.Enabled = false;
            this.Tb_ValorParcelas.Location = new System.Drawing.Point(230, 447);
            this.Tb_ValorParcelas.Name = "Tb_ValorParcelas";
            this.Tb_ValorParcelas.Size = new System.Drawing.Size(121, 20);
            this.Tb_ValorParcelas.TabIndex = 27;
            this.Tb_ValorParcelas.Visible = false;
            // 
            // Lb_ValorParcelas
            // 
            this.Lb_ValorParcelas.AutoSize = true;
            this.Lb_ValorParcelas.Location = new System.Drawing.Point(227, 428);
            this.Lb_ValorParcelas.Name = "Lb_ValorParcelas";
            this.Lb_ValorParcelas.Size = new System.Drawing.Size(93, 13);
            this.Lb_ValorParcelas.TabIndex = 28;
            this.Lb_ValorParcelas.Text = "Valor por parcela :";
            this.Lb_ValorParcelas.Visible = false;
            // 
            // Tb_Xparcelas
            // 
            this.Tb_Xparcelas.Enabled = false;
            this.Tb_Xparcelas.Location = new System.Drawing.Point(326, 425);
            this.Tb_Xparcelas.Name = "Tb_Xparcelas";
            this.Tb_Xparcelas.Size = new System.Drawing.Size(25, 20);
            this.Tb_Xparcelas.TabIndex = 29;
            this.Tb_Xparcelas.Visible = false;
            // 
            // Error_Venda
            // 
            this.Error_Venda.ContainerControl = this;
            // 
            // Fm_Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.Tb_Xparcelas);
            this.Controls.Add(this.Lb_ValorParcelas);
            this.Controls.Add(this.Tb_ValorParcelas);
            this.Controls.Add(this.Bt_Fechar);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Tb_Desconto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Tb_ValorTotal);
            this.Controls.Add(this.Tb_Seguro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Nud_Quantidade);
            this.Controls.Add(this.Cb_Carro);
            this.Controls.Add(this.Lb_Parcelas);
            this.Controls.Add(this.Cb_Clientes);
            this.Controls.Add(this.Nud_Taxa);
            this.Controls.Add(this.Cb_Pagamento);
            this.Controls.Add(this.Nud_Parcelas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Bt_Finalizar);
            this.Controls.Add(this.DTV_Vendas);
            this.Controls.Add(this.Bt_Excluir);
            this.Controls.Add(this.Bt_Incluir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Fm_Venda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fm_Venda";
            this.Load += new System.EventHandler(this.Fm_Venda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTV_Vendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Parcelas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Taxa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Quantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error_Venda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Bt_Incluir;
        private System.Windows.Forms.Button Bt_Excluir;
        private System.Windows.Forms.DataGridView DTV_Vendas;
        private System.Windows.Forms.Button Bt_Finalizar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown Nud_Parcelas;
        private System.Windows.Forms.ComboBox Cb_Pagamento;
        private System.Windows.Forms.NumericUpDown Nud_Taxa;
        private System.Windows.Forms.ComboBox Cb_Clientes;
        private System.Windows.Forms.Label Lb_Parcelas;
        private System.Windows.Forms.ComboBox Cb_Carro;
        private System.Windows.Forms.NumericUpDown Nud_Quantidade;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Tb_Seguro;
        private System.Windows.Forms.TextBox Tb_ValorTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Tb_Desconto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button Bt_Fechar;
        private System.Windows.Forms.TextBox Tb_ValorParcelas;
        private System.Windows.Forms.Label Lb_ValorParcelas;
        private System.Windows.Forms.TextBox Tb_Xparcelas;
        private System.Windows.Forms.ErrorProvider Error_Venda;
    }
}