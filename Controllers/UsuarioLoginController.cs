using check_health.Models;
using check_health.Models.ModelCadastroeLogin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace check_health.Controllers
{
    public class UsuarioLoginController
    {
        public static Response CheckerSelect(string email, string senha, out UsuarioLogin user)
        {
            user = new UsuarioLogin();

            if (!string.IsNullOrEmpty(email) && email.Length < 51)
            {
                if (!string.IsNullOrEmpty(senha) && senha.Length < 51)
                {
                    return UsuarioLoginBD.Select(email, senha, out user);
                }
                else
                {
                    return new Response
                    {
                        Executed = false,
                        ErrorMessage = "Senha está incorreta"
                    };
                }
            }
            else
            {
                return new Response
                {
                    Executed = false,
                    ErrorMessage = "E-mail está incorreto"
                };
            }

        }
    }
}
