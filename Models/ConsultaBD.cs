using System;
using System.Collections.Generic;
using check_health.Controllers;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace check_health.Models
{
    public class ConsultaBD
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

        //public static Response ConsultaSelect(Consulta dados)
        //{
        //    string select = $"SELECT * from dbo.Consulta WHERE idConsulta IS NOT NULL";
        //    SqlCommand cmd = new SqlCommand(select, ConnectionString.Connection);

        //    try
        //    {
        //        ConnectionString.Connection.Open();
        //        SqlDataReader dr = cmd.ExecuteReader();
        //        while (dr.Read())
        //        {
        //            dados.idPaciente = Convert.ToInt32(dr[6]);
        //        }
        //        ConnectionString.Connection.Close();

        //        if (dados.idConsulta != 0)
        //        {
        //            return new Response
        //            {
        //                Executed = true
        //            };
        //        }
        //        else
        //        {
        //            return ConsultaInsert(dados);
        //        }
        //    }
        //    catch (Exception e)
        //    {

        //        return ExceptionGet(e);
        //    }
        //}
        public static Response ConsultaInsert(string datas, string horario, string profissional, string especialidade)
        {
            string insert = $"INSERT into dbo.Consulta(DataConsulta,HorarioConsulta,Profissional,Especialidade) values('{datas}','{horario}','{profissional}','{especialidade}')";

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

        public static Response ConsultaSelect(Consulta dados)
        {
            string select = $"Select * from dbo.Consulta";

            SqlCommand cmd = new SqlCommand(select, ConnectionString.Connection);

            try
            {
                ConnectionString.Connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dados.idConsulta = Convert.ToInt32(dr[0]);
                    dados.DataConsulta = dr[1].ToString();
                    dados.Horario = dr[2].ToString();
                    dados.Profissional = dr[3].ToString();
                    dados.Especialidade = dr[4].ToString();
                }
                ConnectionString.Connection.Close();

                if (dados.idConsulta != 0)
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
