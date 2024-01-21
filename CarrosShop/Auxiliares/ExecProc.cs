using CarrosShop;
using System.Data.SqlClient;
using System.Data;
using System;

public class ExecProc
{
    Conexao conexao = new Conexao();
    public string mensagem = "";

    public void ExecProcedure(string nomeProc, params SqlParameter[] parametros)
    {
        using (SqlConnection connection = conexao.AbrirConexao())
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = nomeProc;

                if (parametros != null)
                {
                    cmd.Parameters.AddRange(parametros);
                }

                try
                {
                    if (nomeProc == "Proc_Login")
                    {
                        SqlParameter outputParam = new SqlParameter("@Mensagem", SqlDbType.NVarChar, 100);
                        outputParam.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(outputParam);
                    }

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (nomeProc == "Proc_Login")
                    {
                        mensagem = cmd.Parameters["@Mensagem"].Value.ToString();

                    }
                    
                }
                catch (Exception ex)
                {
                    mensagem = ex.Message;
                }
            }
        }
    }
}
