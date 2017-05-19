using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Biblioteca
{
    class Database
    {
        public static SqlConnection getConnection(){
            SqlConnection conexion = new SqlConnection();

            conexion.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\base de datos.mdf;Integrated Security = True; Connect Timeout = 30";

            //string s = Properties.Settings.Default.DataBaseConnection;
            //Console.WriteLine(s);
            //conexion = new SqlConnection();

            return conexion;
        }
    }
}
