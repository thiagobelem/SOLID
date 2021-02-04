using System.Data;
using Microsoft.Data.SqlClient;

namespace SOLID.DIP.Violacao
{
    public class ClienteRepository
    {
        public void Adicionar(Cliente cliente)
        {
            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "ConnectionString";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO CLIENTE (NOME, EMAIL CPF) VALUES (@nome, @email, @cpf))";

                cmd.Parameters.AddWithValue("nome", cliente.Nome);
                cmd.Parameters.AddWithValue("email", cliente.Email);
                cmd.Parameters.AddWithValue("cpf", cliente.CPF);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
