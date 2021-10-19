using check_health.Controllers;
using check_health.Models;
using check_health.Models.ModelCadastroeLogin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using check_health.Views;

namespace check_health.Controllers
{
    class Controller
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

        public static void CadastroDados(string a, string b, string c)
        {
            
            UsuarioCadastro user = new UsuarioCadastro();

            user.Nome = a;
            user.Email = b;
            user.Senha = c;

            UsuarioCadastroController.CheckerInsert(user);
        }

        public static void VerificaCadastro(string a, string b, string c, out UsuarioCadastro user)
        {
            user = new UsuarioCadastro();

            user.Nome = a;
            user.Email = b;
            user.Senha = c;

            UsuarioCadastroController.CheckerSelect(a, b, out user);

            try
            {
                if (user.idPaciente == 0)
                {
                    CadastroDados(a, b, c);
                }
            }
            catch (Exception e)
            {
                ExceptionGet(e);
            }

        }

        public static void LoginDados(string a, string b, out UsuarioLogin user)
        {
            user = new UsuarioLogin();

            user.Email = a;
            user.Senha = b;

            UsuarioLoginController.CheckerSelect(a, b, out user);
        }

        public static void EspecialiadeController(List<string> especialidade)
        {
            EspecialidadeModel.EspecialidadeSelect(especialidade);
        }

        public static void MedicoController(string especialidade, List<string> nome)
        {
            EspecialidadeModel.MedicoSelect(especialidade, nome);
        }

        public static void HoraConsulta(List<string> hora)
        {
            DataeHora.HoraConsulta(hora);
        }

        public static void ConsultaController(Consulta dados)
        {
            dados = new Consulta();

            ConsultaBD.ConsultaInsert(dados);
        }

        public static void ComboDia(List<int>dia)
        {
            DataeHora.ComboDia(dia);
        }
    }
}
