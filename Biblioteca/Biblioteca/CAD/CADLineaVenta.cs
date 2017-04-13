using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class CADLineaVenta
    {
        private SqlConnection conexion = null;

        //CONSTRUCTOR
        public CADLineaVenta()
        {
            conexion = new SqlConnection();
            conexion.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\HADAFLIX\bd_hadaflix.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            conexion.Open();
        }

        //INSERTAR UN CLIENTE
        public void InsertarLineaVenta(ENLineaVenta lineaVenta)
        {
            string sentencia = "INSERT INTO lineaventa " +
                "(codventa,codproducto,cantidad,subtotal) VALUE ('" + lineaVenta.LVCodVenta + "','" + 
                lineaVenta.LVCodProducto + "','" + lineaVenta.Cantidad + "','" + lineaVenta.Subtotal + "');";

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
        public void EliminarLineaVenta(ENLineaVenta lineaVenta)
        {
            string sentencia = "DELETE FROM lineaventa WHERE codventa = '" + lineaVenta.LVCodVenta + "');";

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


        //BUSCAR LINEAVENTA
        public void BuscarLineaVenta()
        {
            /*List<ENCliente> lClientes = new List<ENCliente>();
            string sentencia = "SELECT * FROM lineaventa";
            ENCliente auxCliente = null;

            try
            {
                SqlCommand cmd = new SqlCommand(sentencia, conexion);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    do
                    {
                        auxCliente = new ENCliente();
                        auxCliente.Dni = dr.GetString(0);
                        auxCliente.NSocio = dr.GetInt32(1);
                        auxCliente.Nombre = dr.GetString(2);
                        auxCliente.Apellidos = dr.GetString(3);
                        auxCliente.Edad = dr.GetInt32(4);
                        auxCliente.Mail = dr.GetString(5);
                        auxCliente.Direccion = dr.GetString(6);
                        auxCliente.Provincia = dr.GetString(7);
                        auxCliente.Poblacion = dr.GetString(8);
                        auxCliente.Pais = dr.GetString(9);
                        auxCliente.CodPostal = dr.GetString(10);
                        auxCliente.Telefono = dr.GetString(11);
                        auxCliente.FechaNac = dr.GetDateTime(12);
                        auxCliente.Contraseña = dr.GetString(13);
                        lClientes.Add(auxCliente);
                    } while (dr.Read());
                }
                return lClientes;
            }
            catch (SqlException e) { throw e; }

            finally
            {
                if (conexion != null)
                    conexion.Close();
            }*/
        }

    }
}
