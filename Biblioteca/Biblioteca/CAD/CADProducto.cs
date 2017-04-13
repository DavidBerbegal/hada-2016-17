using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class CADProducto
    {
        private SqlConnection conexion = null;

        //CONSTRUCTOR
        public CADProducto()
        {
            conexion = new SqlConnection();
            conexion.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\HADAFLIX\bd_hadaflix.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            conexion.Open();
        }

        //INSERTAR UN CLIENTE
        public void InsertarProducto(ENProducto producto)
        {
            string sentencia = "INSERT INTO productos " +
                "(idproducto,codproveedor,titulo,director,duracion,tipo,precio,descripcion,edadrecomendada)" +
                "VALUE ('" + producto.IdProducto + "','" + producto.CodProveedor + "','" + producto.Titulo + "','" + producto.Director + "','" +
                producto.Duracion + "','" + producto.Tipo + "','" + producto.Precio + "','" +
                producto.Descripcion + "','" + producto.EdadRecomendada + "');";

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
        public void EliminarProducto(ENProducto producto)
        {
            string sentencia = "DELETE FROM producto WHERE idproducto = '" + producto.IdProducto + "');";

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
        public List<ENProducto> BuscarProducto()
        {
            List<ENProducto> lProductos = new List<ENProducto>();
            string sentencia = "SELECT * FROM producto";
            ENProducto auxProducto = null;

            try
            {
                SqlCommand cmd = new SqlCommand(sentencia, conexion);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    do
                    {
                        auxProducto = new ENProducto();
                        auxProducto.IdProducto = dr.GetString(0);
                        auxProducto.Titulo = dr.GetString(1);
                        auxProducto.Director = dr.GetString(2);
                        auxProducto.Duracion = dr.GetString(3);
                        //PRUEBA
                        var buffer = new char[1];
                        dr.GetChars(4, 0, buffer, 0, 1);
                        auxProducto.Tipo = buffer[0];
                        //FIN PRUEBA
                        auxProducto.Precio = dr.GetFloat(5);
                        auxProducto.Descripcion = dr.GetString(6);
                        auxProducto.EdadRecomendada = dr.GetInt32(7);
                        lProductos.Add(auxProducto);
                    } while (dr.Read());
                }
                return lProductos;
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
