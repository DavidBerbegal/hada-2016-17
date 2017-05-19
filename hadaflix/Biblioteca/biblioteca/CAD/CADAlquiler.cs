using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class CADAlquiler : CADAdquisicion
    {
        private SqlConnection conexion = Database.getConnection();

        //CONSTRUCTOR
        public CADAlquiler()
        {
            try
            {
                /*
                conexion = new SqlConnection();
                // string s = "data source=.\\SQLEXPRESS;Integrated Security = SSPI; AttachDBFilename =| DataDirectory |\\Database1.mdf; User Instance = true";
                conexion.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\base de datos.mdf;Integrated Security = True; Connect Timeout = 30";
                //conexion.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\javie\documents\visual studio 2015\Projects\HADAFLIX2\bbdd\bbdd\App_Data\base de datos.mdf;Integrated Security = True; Connect Timeout = 30";
                */
                conexion.Open();
                //conexion.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
            }

        }

        // INSERTAR UN ALQUILER
        public void InsertarAlquiler(ENAlquiler alquiler)
        {
            try
            {
                string s = alquiler.Importe.ToString("R");
                s = s.Replace(",", ".").Replace(".", ".");

                string sentencia = "INSERT INTO adquisicion " +
                    "(codventa, importe, numfact, cliente, empleado, tipo) VALUES ('" + alquiler.CodVenta
                        + "' , " + s + " ,'" + alquiler.NumFactura + "','" + alquiler.DniCliente
                        + "','" + alquiler.DniEmpleado + "', '"+ 'a' + "');";

                SqlCommand cmd = new SqlCommand(sentencia, conexion);
                cmd.ExecuteNonQuery();

                s = alquiler.Recargo.ToString("R");
                s = s.Replace(",", ".").Replace(".", ".");

                sentencia = "INSERT INTO alquiler " +
                    "(codventa, fechaini, fechafin, recargo) VALUES ('" + alquiler.CodVenta + "','" +
                    alquiler.FechaInicio + "','" + alquiler.FechaFin + "'," + s + ");";

                cmd = new SqlCommand(sentencia, conexion);
                cmd.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }
            finally
            {
                if (conexion != null)
                    conexion.Close();
            }
        }

        //ACTUALIZAR ALQUILER
        public void ActualizarAlquiler(ENAlquiler alquiler)
        {
            try
            {
                string s = alquiler.Importe.ToString("R");
                s = s.Replace(",", ".").Replace(".", ".");

                string sentencia = "UPDATE adquisicion SET importe = '" + s + "', numfact = '" + alquiler.NumFactura
                     + "',cliente = '" + alquiler.DniCliente + "', empleado = '" + alquiler.DniEmpleado + "' WHERE codventa = " + "'" + alquiler.CodVenta + "'";
                SqlCommand cmd = new SqlCommand(sentencia, conexion);
                cmd.ExecuteNonQuery();

                s = alquiler.Recargo.ToString("R");
                s = s.Replace(",", ".").Replace(".", ".");
                sentencia = "UPDATE alquiler SET fechaini = '" + alquiler.FechaInicio + "', fechafin = '" + alquiler.FechaFin
                      + "',recargo = '" + s + "' WHERE codventa = " + "'" + alquiler.CodVenta + "'";
                cmd = new SqlCommand(sentencia, conexion);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }
            finally
            {
                if (conexion != null)
                    conexion.Close();
            }
        }

        //ELIMINAR ALQUILER
        public void EliminarAlquiler(ENAlquiler alquiler)
        {
            try
            {
                string sentencia = "DELETE FROM alquiler WHERE codventa = '" + alquiler.CodVenta + "';";
                SqlCommand cmd = new SqlCommand(sentencia, conexion);
                cmd.ExecuteNonQuery();
                alquiler.EliminarAdquisicion();
            }
            catch (SqlException e) { throw e; }

            finally
            {
                if (conexion != null)
                    conexion.Close();
            }
        }

        //BUSCAR Y ALMACENAR LISTA DE ALQUILERES EXISTENTES
        public List<ENAlquiler> BuscarAlquileres()
        {
            try
            {
                List<ENAlquiler> lAlquileres = new List<ENAlquiler>();
                string sentencia = "SELECT * FROM alquiler";
                ENAlquiler auxAlquiler;

                SqlCommand cmd = new SqlCommand(sentencia, conexion);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();


                if (dr.HasRows)
                {
                    do
                    {
                        auxAlquiler = new ENAlquiler();
                        auxAlquiler.CodVenta = dr.GetString(0);
                        auxAlquiler.FechaInicio = dr.GetDateTime(1);
                        auxAlquiler.FechaFin = dr.GetDateTime(2);
                        auxAlquiler.Recargo = (float)dr.GetDouble(3);
                        lAlquileres.Add(auxAlquiler);
                    } while (dr.Read());
                }
                return lAlquileres;
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                if (conexion != null)
                    conexion.Close();
            }
        }
        public int CuentaAlquileres()
        {
            int numAlquileres = 0;
            try
            {
                string sentencia = "SELECT COUNT(*) FROM alquiler";
                SqlCommand cmd = new SqlCommand(sentencia, conexion);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                numAlquileres = dr.GetInt32(0);
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                if (conexion != null)
                    conexion.Close();
            }
            return numAlquileres;
        }

    }
}
