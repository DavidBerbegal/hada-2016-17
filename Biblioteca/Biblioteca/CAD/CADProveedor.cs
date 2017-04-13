using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class CADProveedor
    {
        private SqlConnection conexion = null;

        //CONSTRUCTOR
        public CADProveedor()
        {
            conexion = new SqlConnection();
            conexion.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\HADAFLIX\bd_hadaflix.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            conexion.Open();
        }

        //INSERTAR UN CLIENTE
        public void InsertarProveedor(ENProveedor proveedor)
        {
            string sentencia = "INSERT INTO proveedor " +
                "(cif,nombre,mail,direccion,provincia,poblacion,codpostal,telefono)" +
                "VALUE ('" + proveedor.Cif + "','" + proveedor.Nombre + "','" + proveedor.Direccion + "','" + 
                proveedor.Provincia + "','" + proveedor.Poblacion + "','" + proveedor.CodPostal + "','" + 
                proveedor.Telefono + "');";

            try
            {
                SqlCommand cmd = new SqlCommand(sentencia, conexion);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e) { throw e; }

            finally
            {
                if (conexion != null)
                    conexion.Close();
            }
        }


        //ELIMINAR CLIENTE
        public void EliminarProveedor(ENProveedor proveedor)
        {
            string sentencia = "DELETE FROM proveedor WHERE cif = '" + proveedor.Cif + "');";

            try
            {
                SqlCommand cmd = new SqlCommand(sentencia, conexion);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e) { throw e; }

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
                SqlDataReader dr = cmd.ExecuteReader();

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
            catch (SqlException e) { throw e; }

            finally
            {
                if (conexion != null)
                    conexion.Close();
            }
        }

    }
}