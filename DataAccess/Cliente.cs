using System;
using System.Data.SqlClient;
using System.Configuration;

namespace DataAccess
{
    public class Cliente
    {
        public bool inserir(Model.Cliente cliente)
        {
            using (SqlConnection conexao = new SqlConnection())
            {
                conexao.ConnectionString = ConfigurationManager.ConnectionStrings["Empresa"].ConnectionString;
                conexao.Open();

                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = conexao;
                    comando.CommandText = "insert into cliente (nome) values (@nome)";
                    comando.Parameters.Add("@nome", System.Data.SqlDbType.VarChar, 100).Value = cliente.Nome;
                    comando.ExecuteNonQuery();
                }
            }
            return true;
        }
    }
}
