using System;
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
                    nome.Add(dr[0].ToString());
                }
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

        public static List<string> EspecialidadeSelect(List<string> especialidade)
        {
            //string select = $"SELECT Especialidade from dbo.Medico";
            //SqlCommand cmd = new SqlCommand(select, ConnectionString.Connection);

            //try
            //{
            //    ConnectionString.Connection.Open();
            //    SqlDataReader dr = cmd.ExecuteReader();
            //    while (dr.Read())
            //    {
            //        especialidade.Add(dr[0].ToString());
            //    }
            //    ConnectionString.Connection.Close();

            //    return new Response
            //    {
            //        Executed = true
            //    };

            //}
            //catch (Exception e)
            //{
            //    return ExceptionGet(e);
            //}

            especialidade.Add("Cardiologista");
            especialidade.Add("Neurologista");
            especialidade.Add("Dentista");
            especialidade.Add("Ortopedista");
            especialidade.Add("Pediatra");
            especialidade.Add("Clinico Geral");
            especialidade.Add("Psicólogo");
            especialidade.Add("Fonoaudiólogo");
            especialidade.Add("Gineclogista e obstetra");

            return especialidade;
        }
    }
}
