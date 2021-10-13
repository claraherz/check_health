using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Check.Health.Models.ModelCadastroeLogin
{
    public class UsuarioCadastroBD
    {
        public static Response ExceptionGet(Exception e)
        {
            if (ConnectionString.Connection.State == System.Data.ConnectionState.Open)
            {
                ConnectionString.Connection.Close();
            }

            return new Response
            {
                Executed = false,
                ErrorMessage = e.Message,
                Exception = e
            };
        }
        /// <summary>
        /// adiciona o usuario no banco de dados
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static Response Insert(UsuarioCadastro user)
        {
            string insert = $"INSERT into dbo.Paciente(Nome, Email, Senha) values ('{user.Nome}','{user.Email}','{user.Senha}')";

            SqlCommand cmd = new SqlCommand(insert, ConnectionString.Connection);
            try
            {
                ConnectionString.Connection.Open();
                cmd.ExecuteNonQuery();
                ConnectionString.Connection.Close();
                return new Response
                {
                    Executed = true
                };
            }
            catch (Exception e)
            {
                return ExceptionGet(e);
            }

        }
    }
}
