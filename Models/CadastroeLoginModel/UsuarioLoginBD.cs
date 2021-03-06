using check_health.Models.ModelCadastroeLogin;
using System;
using check_health.Controllers;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace check_health.Models
{
    public class UsuarioLoginBD
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
        /// confere se existe o usuario no banco de dados
        /// </summary>
        /// <param name="email"></param>
        /// <param name="senha"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        public static Response Select(string email, string senha, out UsuarioLogin user)
        {
            user = new UsuarioLogin();
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

                //int id = 0;
                //IdPaciente(id, user.idPaciente);

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

        //public static int IdPaciente(int id, int a)
        //{
        //    id = a;
        //    return id;
        //}
    }
}
