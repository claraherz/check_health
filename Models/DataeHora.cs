using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace check_health.Models
{
    class DataeHora
    {
        public static void HoraConsulta(List<string> hora)
        {

            hora.Add("9h00");
            hora.Add("10h00");
            hora.Add("11h00");
            hora.Add("12h00");
        }

        public static void ComboDia(List<int> dia)
        {
            int dias = 1;

            for (int  i = 0;  i < 31;  i++)
            {
                dia.Add(dias);
                dias++;
            }
        }
    }
}
