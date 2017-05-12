using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class CADPedido
    {
        private SqlConnection conexion = null;

        //CONSTRUCTOR
        public CADPedido()
        {
            conexion = new SqlConnection();
            conexion.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Virginia Aracil\Desktop\bbdd\bbdd\App_Data\base de datos.mdf;Integrated Security = True; Connect Timeout = 30";
            conexion.Open();
        }

        //INSERTAR UN PEDIDO
        public void InsertarPedido(ENPedido pedido)
        {
            List<ENProducto> listaProductos;
            CADProducto listaProds = new CADProducto();
            listaProductos = listaProds.BuscarProducto();
            float precioProducto = 0.0F;
            for(int i = 0; i < listaProductos.Count; i++)
            {
                if(listaProductos[i].IdProducto == pedido.CodProducto)
                {
                    precioProducto = listaProductos[i].Precio;
                }
            }
            float aux;

            aux = pedido.Cantidad * precioProducto;
            string s = aux.ToString("R");
            s = s.Replace(",", ".").Replace(".", ".");

            string sentencia = "INSERT INTO pedido " +
                "(codproducto,codempleado,cantidad,precio) VALUES ('" + pedido.CodProducto + "','" +
                pedido.CodEmpleado + "','" + pedido.Cantidad + "','" + s + "');";

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
        public void EliminarPedido(ENPedido pedido)
        {
            string sentencia = "DELETE FROM pedido WHERE codempleado = '" + pedido.CodEmpleado + "';";

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

        //ACTUALIZAR CLIENTE
        public void ActualizarPedido(ENPedido pedido)
        {
            try
            {
                string s = pedido.Precio.ToString("R");
                s = s.Replace(",", ".").Replace(".", ".");

                string sentencia = "UPDATE cliente SET cantidad = " + pedido.Cantidad + " , precio = " +
                    "'" + s + "'" + " WHERE codproducto = " + "'" + pedido.CodProducto + "' and codempleado = '" +
                    pedido.CodEmpleado + "'";
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


        //BUSCAR CLIENTE
        public List<ENPedido> BuscarPedido()
        {
            try
            {
                List<ENPedido> lPedidos = new List<ENPedido>();
                string sentencia = "SELECT * FROM pedido";
                ENPedido auxPedido;

                SqlCommand cmd = new SqlCommand(sentencia, conexion);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    do
                    {
                        auxPedido = new ENPedido();
                        auxPedido.CodProducto = dr.GetString(0);
                        auxPedido.CodEmpleado = dr.GetString(1);
                        auxPedido.Cantidad = dr.GetInt32(2);
                        auxPedido.Precio = (float) dr.GetDouble(3);
                        lPedidos.Add(auxPedido);
                    } while (dr.Read());
                }
                return lPedidos;
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
