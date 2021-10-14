using check_health.Controllers;
using check_health.Models.ModelCadastroeLogin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace check_health.Controllers
{
    class Controller
    {
        public static void CadastroDados(string a, string b, string c)
        {
            UsuarioCadastro user = new UsuarioCadastro();

            user.Nome = a;
            user.Email = b;
            user.Senha = c;

            UsuarioCadastroController.CheckerInsert(user);
        }

        public static void LoginDados(string a, string b)
        {
            UsuarioLogin user = new UsuarioLogin();

            user.Email = a;
            user.Senha = b;

            UsuarioLoginController.CheckerSelect(a, b);
        }


    }
}
