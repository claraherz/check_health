using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace check_health.Models.ModelCadastroeLogin
{
    public class UsuarioCadastro
    {
        public int idPaciente { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

    }
}
