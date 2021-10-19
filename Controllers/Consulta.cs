using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace check_health.Controllers
{
    public class Consulta
    {
        public int idConsulta { get; set; }
        public string DataConsulta { get; set; }
        public string Horario { get; set; }
        public string Profissional { get; set; }
        public string Especialidade { get; set; }
        public int idPaciente { get; set; }
        public int idMedico { get; set; }
    }
}
