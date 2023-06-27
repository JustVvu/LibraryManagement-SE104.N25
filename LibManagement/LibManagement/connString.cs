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
        public static string connectionString { get; } = "Data Source=LENOVO-IP3;Initial Catalog=QUANLYTHUVIEN;Integrated Security=True;";
        //public static string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
        //public static string connectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\QUANLYTHUVIEN.mdf;Integrated Security=True;User Instance=True";

    }
}
