using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class CADVenta : CADAdquisicion
    {
        private SqlConnection conexion = Database.getConnection();

        //CONSTRUCTOR
        public CADVenta()
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
        public void InsertarVenta(ENVenta venta)
        {
            try
            {
                string s = venta.Importe.ToString("R");
                s = s.Replace(",", ".").Replace(".", ".");

                string sentencia = "INSERT INTO adquisicion " +
                    "(codventa, importe, numfact, cliente, empleado, tipo) VALUES ('" + venta.CodVenta
                        + "' , " + s + " ,'" + venta.NumFactura + "','" + venta.DniCliente
                        + "','" + venta.DniEmpleado + "','" + 'v' + "');";

                SqlCommand cmd = new SqlCommand(sentencia, conexion);
                cmd.ExecuteNonQuery();

                sentencia = "INSERT INTO venta " +
                    "(codventa) VALUES ('" + venta.CodVenta + "');";

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

        //ACTUALIZAR VENTA
        public void ActualizarVenta(ENVenta venta)
        {
            try
            {
                string s = venta.Importe.ToString("R");
                s = s.Replace(",", ".").Replace(".", ".");

                string sentencia = "UPDATE adquisicion SET importe = '" + s + "', numfact = '" + venta.NumFactura
                     + "',cliente = '" + venta.DniCliente + "', empleado = '" + venta.DniEmpleado + "' WHERE codventa = " + "'" + venta.CodVenta + "'";
                SqlCommand cmd = new SqlCommand(sentencia, conexion);
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

        //ELIMINAR VENTA
        public void EliminarVenta(ENVenta venta)
        {
            try
            {
                string sentencia = "DELETE FROM venta WHERE codventa = '" + venta.CodVenta + "';";
                SqlCommand cmd = new SqlCommand(sentencia, conexion);
                cmd.ExecuteNonQuery();
                venta.EliminarAdquisicion();
            }
            catch (SqlException e) { throw e; }

            finally
            {
                if (conexion != null)
                    conexion.Close();
            }
        }

        //BUSCAR Y ALMACENAR LISTA DE ALQUILERES EXISTENTES
        public List<ENVenta> BuscarVentas()
        {
            try
            {
                List<ENVenta> lVentas = new List<ENVenta>();
                string sentencia = "SELECT * FROM venta";
                ENVenta auxVenta;

                SqlCommand cmd = new SqlCommand(sentencia, conexion);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();


                if (dr.HasRows)
                {
                    do
                    {
                        auxVenta = new ENVenta();
                        auxVenta.CodVenta = dr.GetString(0);
                        lVentas.Add(auxVenta);
                    } while (dr.Read());
                }
                return lVentas;
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
        public int CuentaVentas()
        {
            int numVentas = 0;
            try
            {
                string sentencia = "SELECT COUNT(*) FROM venta";
                SqlCommand cmd = new SqlCommand(sentencia, conexion);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                numVentas = dr.GetInt32(0);
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
            return numVentas;
        }
    }
}
