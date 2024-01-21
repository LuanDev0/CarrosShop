using CarrosShop.Forms;
using System;
using System.Windows.Forms;

namespace CarrosShop
{
    public partial class Fm_Login : Form
    {
        public Fm_Login()
        {
            InitializeComponent();
        }

        Boolean Valida = false;

        private void Bt_Acessar_Click(object sender, EventArgs e)
        {
            Erp_Login.Clear();
            Erp_Senha.Clear();

            if (Tb_Login.Text == "" || Tb_Senha.Text == "")
            {
                if (Tb_Login.Text == "")
                {
                    Erp_Login.SetError(Tb_Login, "Campo Obrigatório");
                }
                if (Tb_Senha.Text == "")
                {
                    Erp_Login.SetError(Tb_Senha, "Campo Obrigatório");
                }
                return;
            }

            string Usuario, Senha_acesso;

            Usuario = Tb_Login.Text;
            Senha_acesso = Tb_Senha.Text;

            Classe_Login login = new Classe_Login(Usuario, Senha_acesso);


            if (login.mensagem == "Conectado com sucesso")
            {
                Valida = true;
                Fm_Menu_Principal fm_Menu = new Fm_Menu_Principal();
                fm_Menu.Show();

            }
        }

    }
}
