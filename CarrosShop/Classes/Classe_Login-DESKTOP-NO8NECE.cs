using CarrosShop.Forms;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CarrosShop
{
    public class Classe_Login
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public string mensagem;
        public int NivelAcesso;

        public Classe_Login(string login, string senha)
        {
            try
            {



                using (SqlConnection connection = conexao.AbrirConexao())
                {
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "Proc_Login";

                    cmd.Parameters.AddWithValue("@Vproc_Login", login);
                    cmd.Parameters.AddWithValue("@Vproc_Senha", senha);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        //retornar o valor do nivel de acesso aqui
                        mensagem = "Conectado com sucesso";
                    }
                    else
                    {
                        mensagem = "Não conectado - Credenciais inválidas";
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                mensagem = "Não foi possível conectar. Erro: " + ex.Message;
            }

        }

        public Boolean TipoAcesso()
        {
            if (mensagem == "Conectado com sucesso")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

    

