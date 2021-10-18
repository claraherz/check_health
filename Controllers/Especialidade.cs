using System;
using check_health.Controllers;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace check_health.Models
{
    public class EspecialidadeModel
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



        ///<summary>
        /// a função preenche a lista nome
        ///</summary>
        public static Response MedicoSelect(string especialidade, List<string> nome)
        {
            string select = $"SELECT Nome from dbo.Medico WHERE Especialidade = '{especialidade}'";
            SqlCommand cmd = new SqlCommand(select, ConnectionString.Connection);

            try
            {
                ConnectionString.Connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();



                while (dr.Read())
                {
                    nome.Add(dr[1].ToString());
                }
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
