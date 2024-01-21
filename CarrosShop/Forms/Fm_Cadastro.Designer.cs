namespace CarrosShop.Forms
{
    partial class Fm_Cadastro
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
            this.Tb_NomeCarro = new System.Windows.Forms.TextBox();
            this.Lb_NomeCarro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Bt_Cadastrar = new System.Windows.Forms.Button();
            this.Bt_Fechar = new System.Windows.Forms.Button();
            this.DGV_GridCarros = new System.Windows.Forms.DataGridView();
            this.Nud_Quantidade = new System.Windows.Forms.NumericUpDown();
            this.Cb_Categoria = new System.Windows.Forms.ComboBox();
            this.Mtb_Ano = new System.Windows.Forms.MaskedTextBox();
            this.Cb_Pais = new System.Windows.Forms.ComboBox();
            this.Cb_Condicao = new System.Windows.Forms.ComboBox();
            this.Tb_Valor = new System.Windows.Forms.TextBox();
            this.Error_Cadastro = new System.Windows.Forms.ErrorProvider(this.components);
            this.Bt_Alterar = new System.Windows.Forms.Button();
            this.Bt_Excluir = new System.Windows.Forms.Button();
            this.Bt_Confirmar = new System.Windows.Forms.Button();
            this.Bt_Cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_GridCarros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Quantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error_Cadastro)).BeginInit();
            this.SuspendLayout();
            // 
            // Tb_NomeCarro
            // 
            this.Tb_NomeCarro.Location = new System.Drawing.Point(48, 90);
            this.Tb_NomeCarro.Name = "Tb_NomeCarro";
            this.Tb_NomeCarro.Size = new System.Drawing.Size(100, 20);
            this.Tb_NomeCarro.TabIndex = 0;
            // 
            // Lb_NomeCarro
            // 
            this.Lb_NomeCarro.AutoSize = true;
            this.Lb_NomeCarro.Location = new System.Drawing.Point(45, 64);
            this.Lb_NomeCarro.Name = "Lb_NomeCarro";
            this.Lb_NomeCarro.Size = new System.Drawing.Size(86, 13);
            this.Lb_NomeCarro.TabIndex = 1;
            this.Lb_NomeCarro.Text = "Nome do carro : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Categoria :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valor :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ano : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Condição : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Quantidade : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(200, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Pais de origem : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(127, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Cadastro de Carros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(477, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Carros cadastrados";
            // 
            // Bt_Cadastrar
            // 
            this.Bt_Cadastrar.Location = new System.Drawing.Point(203, 283);
            this.Bt_Cadastrar.Name = "Bt_Cadastrar";
            this.Bt_Cadastrar.Size = new System.Drawing.Size(100, 23);
            this.Bt_Cadastrar.TabIndex = 7;
            this.Bt_Cadastrar.Text = "Cadastrar";
            this.Bt_Cadastrar.UseVisualStyleBackColor = true;
            this.Bt_Cadastrar.Click += new System.EventHandler(this.Bt_Cadastrar_Click);
            // 
            // Bt_Fechar
            // 
            this.Bt_Fechar.Location = new System.Drawing.Point(678, 19);
            this.Bt_Fechar.Name = "Bt_Fechar";
            this.Bt_Fechar.Size = new System.Drawing.Size(26, 23);
            this.Bt_Fechar.TabIndex = 12;
            this.Bt_Fechar.Text = "X";
            this.Bt_Fechar.UseVisualStyleBackColor = true;
            this.Bt_Fechar.Click += new System.EventHandler(this.Bt_Fechar_Click);
            // 
            // DGV_GridCarros
            // 
            this.DGV_GridCarros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_GridCarros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_GridCarros.Location = new System.Drawing.Point(345, 64);
            this.DGV_GridCarros.Name = "DGV_GridCarros";
            this.DGV_GridCarros.Size = new System.Drawing.Size(359, 374);
            this.DGV_GridCarros.TabIndex = 21;
            // 
            // Nud_Quantidade
            // 
            this.Nud_Quantidade.Location = new System.Drawing.Point(203, 222);
            this.Nud_Quantidade.Name = "Nud_Quantidade";
            this.Nud_Quantidade.Size = new System.Drawing.Size(100, 20);
            this.Nud_Quantidade.TabIndex = 5;
            // 
            // Cb_Categoria
            // 
            this.Cb_Categoria.FormattingEnabled = true;
            this.Cb_Categoria.ItemHeight = 13;
            this.Cb_Categoria.Items.AddRange(new object[] {
            "Utilitarios",
            "Executivos",
            "Luxo"});
            this.Cb_Categoria.Location = new System.Drawing.Point(203, 90);
            this.Cb_Categoria.Name = "Cb_Categoria";
            this.Cb_Categoria.Size = new System.Drawing.Size(100, 21);
            this.Cb_Categoria.TabIndex = 1;
            // 
            // Mtb_Ano
            // 
            this.Mtb_Ano.Location = new System.Drawing.Point(48, 285);
            this.Mtb_Ano.Mask = "0000";
            this.Mtb_Ano.Name = "Mtb_Ano";
            this.Mtb_Ano.Size = new System.Drawing.Size(100, 20);
            this.Mtb_Ano.TabIndex = 6;
            // 
            // Cb_Pais
            // 
            this.Cb_Pais.FormattingEnabled = true;
            this.Cb_Pais.Items.AddRange(new object[] {
            "EUA",
            "ITALO AMERICANO",
            "ITALIA",
            "JAPÃO"});
            this.Cb_Pais.Location = new System.Drawing.Point(203, 153);
            this.Cb_Pais.Name = "Cb_Pais";
            this.Cb_Pais.Size = new System.Drawing.Size(100, 21);
            this.Cb_Pais.TabIndex = 3;
            // 
            // Cb_Condicao
            // 
            this.Cb_Condicao.FormattingEnabled = true;
            this.Cb_Condicao.Items.AddRange(new object[] {
            "Novo",
            "Semi-Novo",
            "Usado"});
            this.Cb_Condicao.Location = new System.Drawing.Point(48, 222);
            this.Cb_Condicao.Name = "Cb_Condicao";
            this.Cb_Condicao.Size = new System.Drawing.Size(100, 21);
            this.Cb_Condicao.TabIndex = 4;
            // 
            // Tb_Valor
            // 
            this.Tb_Valor.Location = new System.Drawing.Point(48, 153);
            this.Tb_Valor.Name = "Tb_Valor";
            this.Tb_Valor.Size = new System.Drawing.Size(100, 20);
            this.Tb_Valor.TabIndex = 2;
            this.Tb_Valor.Leave += new System.EventHandler(this.Tb_Valor_Leave);
            // 
            // Error_Cadastro
            // 
            this.Error_Cadastro.ContainerControl = this;
            // 
            // Bt_Alterar
            // 
            this.Bt_Alterar.Location = new System.Drawing.Point(48, 330);
            this.Bt_Alterar.Name = "Bt_Alterar";
            this.Bt_Alterar.Size = new System.Drawing.Size(100, 23);
            this.Bt_Alterar.TabIndex = 8;
            this.Bt_Alterar.Text = "Alterar";
            this.Bt_Alterar.UseVisualStyleBackColor = true;
            this.Bt_Alterar.Click += new System.EventHandler(this.Bt_Alterar_Click);
            // 
            // Bt_Excluir
            // 
            this.Bt_Excluir.Location = new System.Drawing.Point(203, 330);
            this.Bt_Excluir.Name = "Bt_Excluir";
            this.Bt_Excluir.Size = new System.Drawing.Size(100, 23);
            this.Bt_Excluir.TabIndex = 9;
            this.Bt_Excluir.Text = "Excluir";
            this.Bt_Excluir.UseVisualStyleBackColor = true;
            this.Bt_Excluir.Click += new System.EventHandler(this.Bt_Excluir_Click);
            // 
            // Bt_Confirmar
            // 
            this.Bt_Confirmar.Location = new System.Drawing.Point(48, 415);
            this.Bt_Confirmar.Name = "Bt_Confirmar";
            this.Bt_Confirmar.Size = new System.Drawing.Size(99, 23);
            this.Bt_Confirmar.TabIndex = 10;
            this.Bt_Confirmar.Text = "Confirmar";
            this.Bt_Confirmar.UseVisualStyleBackColor = true;
            this.Bt_Confirmar.Click += new System.EventHandler(this.Bt_Confirmar_Click);
            // 
            // Bt_Cancelar
            // 
            this.Bt_Cancelar.Location = new System.Drawing.Point(203, 415);
            this.Bt_Cancelar.Name = "Bt_Cancelar";
            this.Bt_Cancelar.Size = new System.Drawing.Size(100, 23);
            this.Bt_Cancelar.TabIndex = 11;
            this.Bt_Cancelar.Text = "Cancelar";
            this.Bt_Cancelar.UseVisualStyleBackColor = true;
            this.Bt_Cancelar.Click += new System.EventHandler(this.Bt_Cancelar_Click);
            // 
            // Fm_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(717, 450);
            this.Controls.Add(this.Bt_Cancelar);
            this.Controls.Add(this.Bt_Confirmar);
            this.Controls.Add(this.Bt_Excluir);
            this.Controls.Add(this.Bt_Alterar);
            this.Controls.Add(this.Tb_Valor);
            this.Controls.Add(this.Cb_Pais);
            this.Controls.Add(this.Mtb_Ano);
            this.Controls.Add(this.Cb_Categoria);
            this.Controls.Add(this.Nud_Quantidade);
            this.Controls.Add(this.Cb_Condicao);
            this.Controls.Add(this.DGV_GridCarros);
            this.Controls.Add(this.Bt_Fechar);
            this.Controls.Add(this.Bt_Cadastrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lb_NomeCarro);
            this.Controls.Add(this.Tb_NomeCarro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fm_Cadastro";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Carros";
            this.Load += new System.EventHandler(this.Fm_Cadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_GridCarros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Quantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error_Cadastro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tb_NomeCarro;
        private System.Windows.Forms.Label Lb_NomeCarro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Bt_Cadastrar;
        private System.Windows.Forms.Button Bt_Fechar;
        private System.Windows.Forms.DataGridView DGV_GridCarros;
        private System.Windows.Forms.NumericUpDown Nud_Quantidade;
        private System.Windows.Forms.ComboBox Cb_Categoria;
        private System.Windows.Forms.MaskedTextBox Mtb_Ano;
        private System.Windows.Forms.ComboBox Cb_Pais;
        private System.Windows.Forms.ComboBox Cb_Condicao;
        private System.Windows.Forms.TextBox Tb_Valor;
        private System.Windows.Forms.ErrorProvider Error_Cadastro;
        private System.Windows.Forms.Button Bt_Excluir;
        private System.Windows.Forms.Button Bt_Alterar;
        private System.Windows.Forms.Button Bt_Cancelar;
        private System.Windows.Forms.Button Bt_Confirmar;
    }
}