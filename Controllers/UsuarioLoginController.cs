using Check.Health.Models;
using Check.Health.Models.ModelCadastroeLogin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Check.Health.Controllers
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
