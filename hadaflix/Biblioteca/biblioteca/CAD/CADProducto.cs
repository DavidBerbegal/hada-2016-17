using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class CADProducto
    {
        private SqlConnection conexion = null;

        //CONSTRUCTOR
        public CADProducto()
        {
            conexion = new SqlConnection();
            conexion.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Virginia Aracil\Desktop\bbdd\bbdd\App_Data\base de datos.mdf;Integrated Security=True; Connect Timeout = 30";
            conexion.Open();
        }

        //INSERTAR UN PRODUCTO
        public void InsertarProducto(ENProducto producto)
        {
            string s = producto.Precio.ToString("R");
            s = s.Replace(",", ".").Replace(".", ".");

            string sentencia = "INSERT INTO productos " +
                "(idproducto,proveedor,titulo,director,duracion,tipo,precio,descripcion,edadrecomendada,imagen)" +
                "VALUES ('" + producto.IdProducto + "','" + producto.CodProveedor + "','" + producto.Titulo + "','" + producto.Director + "','" +
                producto.Duracion + "','" + producto.Tipo + "','" + s + "','" +
                producto.Descripcion + "','" + producto.EdadRecomendada + "','" + producto.Imagen + "');";

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


        //ELIMINAR PRODUCTO
        public void EliminarProducto(ENProducto producto)
        {
            string sentencia = "DELETE FROM productos WHERE idproducto = '" + producto.IdProducto + "';";

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

        // ACTUALIZAR PRODUCTO
        public void ActualizarProducto(ENProducto prod)
        {
            try
            {
                string s = prod.Precio.ToString("R");
                s = s.Replace(",", ".").Replace(".", ".");

                string sentencia = "UPDATE productos SET titulo = '" + prod.Titulo + "' , director = " + "'" + prod.Director + "'" + " , duracion = " + "'" + prod.Duracion + "'"
                     + " , tipo = '" + prod.Tipo + "' , precio = " + s + " , descripcion = " + "'" + prod.Descripcion + "'" + " , edadrecomendada = " + prod.EdadRecomendada + " , proveedor = " + "'" + prod.CodProveedor + "'" + prod.Imagen + "'" + "WHERE idproducto = " + "'" + prod.IdProducto + "'";
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

        //BUSCAR PRODUCTO
        public List<ENProducto> BuscarProducto()
        {
            List<ENProducto> lProductos = new List<ENProducto>();
            string sentencia = "SELECT * FROM productos";
            ENProducto auxProducto = null;

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
                        auxProducto = new ENProducto();
                        auxProducto.IdProducto = dr.GetString(0);
                        auxProducto.Titulo = dr.GetString(1);
                        auxProducto.Director = dr.GetString(2);
                        auxProducto.Duracion = dr.GetString(3);
                        var buffer = new char[1];
                        dr.GetChars(4, 0, buffer, 0, 1);
                        auxProducto.Tipo = buffer[0];
                        auxProducto.Precio = (float)dr.GetDouble(5);
                        auxProducto.Descripcion = dr.GetString(6);
                        auxProducto.EdadRecomendada = dr.GetInt32(7);
                        auxProducto.CodProveedor = dr.GetString(8);
                        auxProducto.Imagen = dr.GetString(9);
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
