using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Data;

namespace spirit.Data
{
    class queries
    {       
            public static DataSet npgsDataSet(string npgsQuery)
            {
                DataSet npgsDs = new DataSet();
                Npgsql.NpgsqlDataAdapter npgsAdapter = new Npgsql.NpgsqlDataAdapter();
                Npgsql.NpgsqlConnection npgsCon = new Npgsql.NpgsqlConnection();
                npgsCon.ConnectionString = connection.GetPostGresConString();
                npgsCon.Open();
                npgsAdapter.SelectCommand = new Npgsql.NpgsqlCommand(npgsQuery, npgsCon);
                npgsAdapter.Fill(npgsDs,"Tabla");
                npgsCon.Close();                
                return npgsDs;
            }

            public static int Execute(string sql, CommandType cType = CommandType.Text)
            {
                var cmd =connection.NpgsqlConnection(connection.GetPostGresConString()).CreateCommand();
                cmd.CommandText = sql;
                cmd.CommandType = cType;
                //
                cmd.Connection.Open();

                var r = cmd.ExecuteNonQuery();
                return r;

                cmd.Connection.Close();

                //try
                //{
                //    var r = cmd.ExecuteNonQuery();

                //    return r;
                //}

                //catch (Exception e)
                //{
                    
                //    e.Message.ToString(); ;
                //    return 0;
                //}
                //finally
                //{
                //    cmd.Connection.Close();
                //}

            }
    }
}
