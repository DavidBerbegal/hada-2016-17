using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class CADProveedor
    {
        private SqlConnection conexion = null;

        //CONSTRUCTOR
        public CADProveedor()
        {
            conexion = new SqlConnection();
            conexion.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\javie\documents\visual studio 2015\Projects\HADAFLIX2\bbdd\bbdd\App_Data\base de datos.mdf;Integrated Security = True; Connect Timeout = 30";
            conexion.Open();
        }
      

        //INSERTAR UN CLIENTE
        public void InsertarProveedor(ENProveedor proveedor)
        {
            string sentencia = "INSERT INTO proveedor " +
                "(cif,nombre,mail,direccion,provincia,poblacion,codpostal,telefono)" +
                "VALUES ('" + proveedor.Cif + "','" + proveedor.Nombre + "','" + proveedor.Mail + "','" + proveedor.Direccion + "','" + 
                proveedor.Provincia + "','" + proveedor.Poblacion + "','" + proveedor.CodPostal + "','" + 
                proveedor.Telefono + "');";

            try
            {
                SqlCommand cmd = new SqlCommand(sentencia, conexion);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e) {
                throw e;
            }

            finally
            {
                if (conexion != null)
                    conexion.Close();
            }
        }

        // ACTUALIZAR PROVEEDOR
        public void ActualizarProveedor(ENProveedor prov)
        {
            try
            {

                string sentencia = "UPDATE proveedor SET nombre = '" + prov.Nombre + "' , mail = " + "'" + prov.Mail + "'" + " , direccion = " + "'" + prov.Direccion + "'"
                     + " , provincia = '" + prov.Provincia + "' , poblacion = '" + prov.Poblacion + "' , codpostal = " + "'" + prov.CodPostal + "'" + " , telefono = '" + prov.Telefono
                     + "' WHERE cif = " + "'" + prov.Cif + "'";
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


        //ELIMINAR CLIENTE
        public void EliminarProveedor(ENProveedor proveedor)
        {
            string sentencia = "DELETE FROM proveedor WHERE cif = '" + proveedor.Cif + "';";

            try
            {
                SqlCommand cmd = new SqlCommand(sentencia, conexion);
                cmd.ExecuteNonQuery();
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


        //BUSCAR CLIENTE
        public List<ENProveedor> BuscarProveedor()
        {
            List<ENProveedor> lProveedor = new List<ENProveedor>();
            string sentencia = "SELECT * FROM proveedor";
            ENProveedor auxProveedor = null;

            try
            {
                SqlCommand cmd = new SqlCommand(sentencia, conexion);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();


                if (dr.HasRows)
                {
                    do
                    {
                        auxProveedor = new ENProveedor();
                        auxProveedor.Cif = dr.GetString(0);
                        auxProveedor.Nombre = dr.GetString(1);
                        auxProveedor.Mail = dr.GetString(2);
                        auxProveedor.Direccion = dr.GetString(3);
                        auxProveedor.Provincia = dr.GetString(4);
                        auxProveedor.Poblacion = dr.GetString(5);
                        auxProveedor.CodPostal = dr.GetString(6);
                        auxProveedor.Telefono = dr.GetString(7);
                        lProveedor.Add(auxProveedor);
                    } while (dr.Read());
                }
                return lProveedor;
            }
            catch (SqlException e) {
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