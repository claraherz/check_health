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

        public static void ComboAno(List<int> ano)
        {
            int anos = 2021;

            for (int i = 0; i < 10; i++)
            {
                ano.Add(anos);
                anos++;
            }
        }

        public static void ComboMes(List<string> mes)
        {
            mes.Add("Janeiro");
            mes.Add("Fevereiro");
            mes.Add("Março");
            mes.Add("Abril");
            mes.Add("Maio");
            mes.Add("Junho");
            mes.Add("Julho");
            mes.Add("Agosto");
            mes.Add("Setembro");
            mes.Add("Outubro");
            mes.Add("Novembro");
            mes.Add("Dezembro");
        }
    }
}
