using CarrosShop.Auxiliares;
using CarrosShop.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace CarrosShop
{
    public class Classe_Login
    {
        ExecProc proc = new ExecProc();

        public string mensagem;
        public int NivelAcesso;

        public void Acessar(string login, string senha)
        {
            SqlParameter paramLogin = new SqlParameter("@Vproc_Login", SqlDbType.VarChar);
            paramLogin.Value = login;

            SqlParameter paramSenha = new SqlParameter("@Vproc_Senha", SqlDbType.VarChar);
            paramSenha.Value = senha;

            proc.ExecProcedure("Proc_Login", paramLogin, paramSenha);

            if (proc.mensagem == "Conectado com sucesso")
            {
                mensagem = "Conectado com sucesso";
            }else
            {
                mensagem = "Não conectado - Credenciais inválidas";
            }
        }
    }
}