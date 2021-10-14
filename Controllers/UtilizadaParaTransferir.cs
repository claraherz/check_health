using System;
using check_health.Models;
using check_health.Models.ModelCadastroeLogin;
using check_health.Views;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace check_health.Controllers
{
    class UtilizadaParaTransferir
    {
        public static void Dados(string a, string b, string c)
        {
            UsuarioCadastro user = new UsuarioCadastro();

            user.Nome = a;
            user.Email = b;
            user.Senha = c;

            UsuarioCadastroController.CheckerInsert(user);
        }
    }
}
