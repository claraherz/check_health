using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace check_health.Models
{
    public static class ConnectionString
    {
        public static SqlConnection Connection { get; } = new SqlConnection("Data Source=desktop-n4ltmo7;Initial Catalog=BDMariaClara;Integrated Security=True");
    }
}
