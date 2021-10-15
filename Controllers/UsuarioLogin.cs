using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using check_health.Models;

namespace check_health.Controllers
{
    public class UsuarioLogin
    {
        public int idPaciente { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
