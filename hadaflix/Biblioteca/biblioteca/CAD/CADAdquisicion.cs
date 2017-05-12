using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class CADAdquisicion
    {
        private SqlConnection conexion = null;

        //CONSTRUCTOR
        public CADAdquisicion()
        {
            conexion = new SqlConnection();
            conexion.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\javie\documents\visual studio 2015\Projects\HADAFLIX2\bbdd\bbdd\App_Data\base de datos.mdf;Integrated Security = True; Connect Timeout = 30";
            conexion.Open();
        }

        //INSERTAR UNA ADQUISICION
        public void InsertarAdquisicion(ENAdquisicion adquisicion)
        {
            try
            {
                string s = adquisicion.Importe.ToString("R");
                s = s.Replace(",", ".").Replace(".", ".");

                string sentencia = "INSERT INTO adquisicion " +
                    "(codventa, importe, numfact, cliente, empleado, tipo) VALUES ('" + adquisicion.CodVenta
                     + "' , " + s + " ,'" + adquisicion.NumFactura + "','" + adquisicion.DniCliente
                      + "','" + adquisicion.DniEmpleado + "'"+ adquisicion.Tipo +"');";
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

        //ACTUALIZAR ADQUISICION
        public void ActualizarAdquisicion(ENAdquisicion adquisicion)
        {
            try
            {
                string s = adquisicion.Importe.ToString("R");
                s = s.Replace(",", ".").Replace(".", ".");

                string sentencia = "UPDATE adquisicion SET importe = '" + s + "', numfact = '" + adquisicion.NumFactura
                     + "',cliente = '" + adquisicion.DniCliente + "', empleado = '" + adquisicion.DniEmpleado 
                     + "', tipo = '" + adquisicion.Tipo + "' WHERE codventa = " + "'" + adquisicion.CodVenta + "'";
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

        //ELIMINAR ADQUISICION
        public void EliminarAdquisicion(ENAdquisicion adquisicion)
        {
            try
            {
                string sentencia = "DELETE FROM adquisicion WHERE codventa = '" + adquisicion.CodVenta + "';";
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

        //BUSCAR Y ALMACENAR LISTA DE ADQUISICIONES EXISTENTES
        public List<ENAdquisicion> BuscarAdquisiciones()
        {
            try
            {
                List<ENAdquisicion> lAdquisiciones = new List<ENAdquisicion>();
                string sentencia = "SELECT * FROM adquisicion";
                ENAdquisicion auxAdquisicion;

                SqlCommand cmd = new SqlCommand(sentencia, conexion);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();


                if (dr.HasRows)
                {
                    do
                    {
                        auxAdquisicion = new ENAdquisicion();
                        auxAdquisicion.CodVenta = dr.GetString(0);
                        auxAdquisicion.Importe = (float) dr.GetDouble(1);
                        auxAdquisicion.NumFactura = dr.GetString(2);
                        auxAdquisicion.DniCliente = dr.GetString(3);
                        auxAdquisicion.DniEmpleado = dr.GetString(4);
                        auxAdquisicion.Tipo = dr.GetString(5);
                        lAdquisiciones.Add(auxAdquisicion);
                    } while (dr.Read());
                }
                return lAdquisiciones;
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

        //BUSCAR Y ALMACENAR LISTA DE ALQUILERES EN FUNCION DE UN codVenta
        public List<ENAdquisicion> BuscarAlquiler(ENAlquiler alq)
        {
            try
            {
                List<ENAdquisicion> lAdquisiciones = new List<ENAdquisicion>();
                string sentencia = "SELECT * FROM adquisicion WHERE codventa = '" + alq.CodVenta + "'";
                ENAdquisicion auxAdquisicion;

                SqlCommand cmd = new SqlCommand(sentencia, conexion);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();


                if (dr.HasRows)
                {
                    do
                    {
                        auxAdquisicion = new ENAdquisicion();
                        auxAdquisicion.CodVenta = dr.GetString(0);
                        auxAdquisicion.Importe = (float)dr.GetDouble(1);
                        auxAdquisicion.NumFactura = dr.GetString(2);
                        auxAdquisicion.DniCliente = dr.GetString(3);
                        auxAdquisicion.DniEmpleado = dr.GetString(4);
                        lAdquisiciones.Add(auxAdquisicion);
                    } while (dr.Read());
                }
                return lAdquisiciones;
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
        //BUSCAR Y ALMACENAR LISTA DE ALQUILERES EN FUNCION DE UN codVenta
        public List<ENAdquisicion> BuscarVenta(ENVenta vent)
        {
            try
            {
                List<ENAdquisicion> lAdquisiciones = new List<ENAdquisicion>();
                string sentencia = "SELECT * FROM adquisicion WHERE codventa = '" + vent.CodVenta + "'";
                ENAdquisicion auxAdquisicion;

                SqlCommand cmd = new SqlCommand(sentencia, conexion);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();


                if (dr.HasRows)
                {
                    do
                    {
                        auxAdquisicion = new ENAdquisicion();
                        auxAdquisicion.CodVenta = dr.GetString(0);
                        auxAdquisicion.Importe = (float)dr.GetDouble(1);
                        auxAdquisicion.NumFactura = dr.GetString(2);
                        auxAdquisicion.DniCliente = dr.GetString(3);
                        auxAdquisicion.DniEmpleado = dr.GetString(4);
                        lAdquisiciones.Add(auxAdquisicion);
                    } while (dr.Read());
                }
                return lAdquisiciones;
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
    }
}
