using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibManagement
{
    public static class connString
    {
        public static string connectionString { get; } = "Data Source=VU-NGUYEN;Initial Catalog=QUANLYTHUVIEN;Integrated Security=True";
    }
}
