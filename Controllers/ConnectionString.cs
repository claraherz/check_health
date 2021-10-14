using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace check_health.Models
{
    public static class ConnectionString
    {
        public static SqlConnection Connection { get; } = new SqlConnection("Data Source=bue205d14;Initial Catalog=BDMariaClara;Persist Security Info=True;User ID=guest01;Password=@Senac2021");
    }
}
