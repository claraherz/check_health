using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace check_health.Models.ModelCadastroeLogin
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

        public static Response Select(string email, string senha, out UsuarioCadastro user)
        {
            user = new UsuarioCadastro();
            string select = $"SELECT * from dbo.Paciente WHERE Email = '{email}' and  Senha = '{senha}'";
            SqlCommand cmd = new SqlCommand(select, ConnectionString.Connection);

            try
            {
                ConnectionString.Connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    user.idPaciente = Convert.ToInt32(dr[0]);
                }
                ConnectionString.Connection.Close();

                if (user.idPaciente != 0)
                {
                    return new Response
                    {
                        Executed = true
                    };
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception e)
            {
                return ExceptionGet(e);
            }
        }
    }
}
