using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarrosShop.Forms
{
    public partial class Fm_Menu_Principal : Form
    {

        private bool valida;

        public Fm_Menu_Principal()
        {
            InitializeComponent();
        }

        private void Fm_Menu_Principal_Load(object sender, EventArgs e)
        {
            menuStrip1.Enabled = false;
            Tb_Senha.UseSystemPasswordChar = true;
        }
        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fm_Cadastro cadastro = new Fm_Cadastro();
            cadastro.MdiParent = this;
            cadastro.Show();

        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Bt_Acessar_Click(object sender, EventArgs e)
        {
            Erp_Menu.Clear();

            if (Tb_Login.Text == "" || Tb_Senha.Text == "")
            {
                if (Tb_Login.Text == "")
                {
                    Erp_Menu.SetError(Tb_Login, "Campo Obrigatório");
                }
                if (Tb_Senha.Text == "")
                {
                    Erp_Menu.SetError(Tb_Senha, "Campo Obrigatório");
                }
                return;
            }

            string Usuario, Senha_acesso;

            Usuario = Tb_Login.Text;
            Senha_acesso = Tb_Senha.Text;

            Classe_Login login = new Classe_Login(Usuario, Senha_acesso);


            if (login.mensagem == "Conectado com sucesso")
            {
                menuStrip1.Enabled = true;
                Tb_Login.Enabled = false;
                Tb_Senha.Enabled = false;
                MessageBox.Show("Conectado");
                if (login.NivelAcesso == 1)
                {

                }
                if (login.NivelAcesso == 2)
                {
                    cadastroToolStripMenuItem.Enabled = false;
                    relatórioToolStripMenuItem.Enabled = false;
                }
                if (login.NivelAcesso == 3)
                {
                    cadastroToolStripMenuItem.Enabled = false;
                    vendaToolStripMenuItem.Enabled = false;
                    compraToolStripMenuItem.Enabled = false;
                }
                
                
            }


        }

        private void Tb_Senha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Bt_Acessar_Click(sender, e);
            }
        }
    }
}
