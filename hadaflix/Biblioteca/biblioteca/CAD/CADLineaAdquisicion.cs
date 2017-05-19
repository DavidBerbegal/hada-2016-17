using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class CADLineaAdquisicion
    {
        private SqlConnection conexion = Database.getConnection();

        //CONSTRUCTOR
        public CADLineaAdquisicion()
        {
            try
            {
                /*
                conexion = new SqlConnection();
                conexion.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\javie\Documents\Visual Studio 2015\Projects\HADAFLIX2\bbdd\bbdd\App_Data\base de datos.mdf;Integrated Security = True; Connect Timeout = 30";
                */            
                conexion.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
            }
        }

        //INSERTAR UNA LINEAADQUISICION
        public void InsertarLineaAdquisicion(ENLineaAdquisicion lineaAdquisicion)
        {
            try
            {
                string s = lineaAdquisicion.Subtotal.ToString("R");
                s = s.Replace(",", ".").Replace(".", ".");

                string sentencia = "INSERT INTO lineaadquisicion " +
                    "(codadquisicion,codproducto,cantidad,subtotal) VALUES ('" + lineaAdquisicion.LVCodAdquisicion + "','" +
                     lineaAdquisicion.LVCodProducto + "','" + lineaAdquisicion.Cantidad + "','" + s + "');";
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

        //ACTUALIZAR LINEAADQUISICION
        public void ActualizarLineaAdquisicion(ENLineaAdquisicion ladquisicion)
        {
            try
            {
                string s = ladquisicion.Subtotal.ToString("R");
                s = s.Replace(",", ".").Replace(".", ".");

                string sentencia = "UPDATE lineaadquisicion SET codadquisicion = '" + ladquisicion.LVCodAdquisicion + "' , codproducto = '" + ladquisicion.LVCodProducto + "'" + " , cantidad = " + ladquisicion.Cantidad
                     + " , subtotal = '" + s + "'";
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


        //ELIMINAR LINEAADQUISICION
        public void EliminarLineaAdquisicion(ENLineaAdquisicion lineaAdquisicion)
        {
            try
            {
                string sentencia = "DELETE FROM lineaadquisicion WHERE codadquisicion = '" + lineaAdquisicion.LVCodAdquisicion + "';";
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


        //BUSCAR LINEAADQUISICION
        public List<ENLineaAdquisicion> BuscarLineaAdquisicion()
        {
            try
            {
                List<ENLineaAdquisicion> lLineaAdquisiciones = new List<ENLineaAdquisicion>();
                string sentencia = "SELECT * FROM LINEAADQUISICION";
                ENLineaAdquisicion auxlAdquisicion;

                SqlCommand cmd = new SqlCommand(sentencia, conexion);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();


                if (dr.HasRows)
                {
                    do
                    {
                        auxlAdquisicion = new ENLineaAdquisicion();
                        auxlAdquisicion.LVCodAdquisicion = dr.GetString(0);
                        auxlAdquisicion.LVCodProducto = dr.GetString(1);
                        auxlAdquisicion.Cantidad = dr.GetInt32(2);
                        auxlAdquisicion.Subtotal = (float) dr.GetDouble(3);
                        lLineaAdquisiciones.Add(auxlAdquisicion);
                    } while (dr.Read());
                }

                return lLineaAdquisiciones;
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

        public float subtotal()
        {
            float subtotal = 0;
            try
            {

                /*
                string s = lineaAdquisicion.Subtotal.ToString("R");
                s = s.Replace(",", ".").Replace(".", ".");
                */
                string sentencia = "select sum(subtotal) suma from lineaadquisicion;";
                SqlCommand cmd = new SqlCommand(sentencia, conexion);
                cmd.ExecuteNonQuery();

                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    subtotal = (float)dr.GetDouble(0);
                }

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

            return subtotal;
        }

        public void EliminarNombre(string nombre)
        {
            string codprod;
            try
            {
                string sentencia = "select idproducto from productos where titulo = '" + nombre + "'";
                SqlCommand cmd = new SqlCommand(sentencia, conexion);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                codprod = dr.GetString(0);
                sentencia = "DELETE FROM lineaadquisicion WHERE codadquisicion = '" + codprod + "';";
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

        public void EliminarAdquisiciones()
        {
            try
            {
                string sentencia = "DELETE FROM lineaadquisicion";
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
    }
}
