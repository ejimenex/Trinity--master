using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace spirit.Data
{
    public static class connection
    {
        public static String GetPostGresConString()
        {
            Npgsql.NpgsqlConnection PostGresCon = new Npgsql.NpgsqlConnection();
            return ConfigurationManager.ConnectionStrings["PostGreCon"].ConnectionString;
        }
        public static Npgsql.NpgsqlConnection NpgsqlConnection(string sContring)
        {
            return new Npgsql.NpgsqlConnection(sContring);
        }
    }
    
}
