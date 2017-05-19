using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class CADCliente
    {
        private SqlConnection conexion = Database.getConnection();

        //CONSTRUCTOR
        public CADCliente()
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
            } catch (Exception ex) {
                Console.WriteLine("Error: {0}", ex.Message);
            }

        }

        //INSERTAR UN CLIENTE
        public void InsertarCliente(ENCliente cliente) {
            try
            {
                string sentencia = "INSERT INTO cliente " +
                    "(dni,nsocio,nombre,apellido,edad,mail,direccion,provincia,poblacion, pais,codpostal ,fechanac, numero ,contraseña)" +
                    "VALUES ('" + cliente.Dni + "','" + cliente.NSocio + "','" + cliente.Nombre + "','" + cliente.Apellidos + "','" +
                    cliente.Edad + "','" + cliente.Mail + "','" + cliente.Direccion + "','" + cliente.Provincia + "','" +
                    cliente.Poblacion + "','" + cliente.Pais + "','" + cliente.CodPostal + "','" + cliente.FechaNac + "','" + cliente.Telefono + "','" +
                    cliente.Contraseña + "');";
                SqlCommand cmd = new SqlCommand(sentencia, conexion);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e){
                Console.WriteLine("Error: {0}", e.Message);
            }
            finally
            {
                if (conexion != null)
                    conexion.Close();
            }
        }

        //ACTUALIZAR CLIENTE
        public void ActualizarCliente(ENCliente cliente)
        {
            try
            {
                string sentencia = "UPDATE cliente SET nsocio = " + cliente.NSocio + " , nombre = " + "'" + cliente.Nombre + "'" + " , apellido = " + "'" + cliente.Apellidos + "'"
                     + " , edad = " + cliente.Edad + " , mail = " + "'" + cliente.Mail + "'" + " , direccion = " + "'" + cliente.Direccion + "'" + " , provincia = " + "'" + cliente.Provincia + "'"
                     + " , poblacion = " + "'" + cliente.Poblacion + "'" + " , pais = " + "'" + cliente.Pais + "'" + " , codpostal = " + "'" + cliente.CodPostal + "'" + " , fechanac = " + "'" + cliente.FechaNac + "'"
                     + " , numero = " + "'" + cliente.Telefono + "' , contraseña = " + "'" + cliente.Contraseña + "'" + " WHERE dni = " + "'" + cliente.Dni + "'";
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
        public void EliminarCliente(ENCliente cliente)
        {
            try
            {
                string sentencia = "DELETE FROM cliente WHERE dni = '" + cliente.Dni + "';";
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
        public List<ENCliente> BuscarCliente()
        {
            try
            {
                List<ENCliente> lClientes = new List<ENCliente>();
                string sentencia = "SELECT * FROM cliente";
                ENCliente auxCliente;

                SqlCommand cmd = new SqlCommand(sentencia, conexion);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                

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
                        auxCliente.FechaNac = dr.GetDateTime(11);
                        auxCliente.Telefono = dr.GetString(12);
                        auxCliente.Contraseña = dr.GetString(13);
                        lClientes.Add(auxCliente);
                    } while (dr.Read());
                }
                return lClientes;   
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

        public ENCliente BuscarCliente(string nickname)
        {
            try
            {

                string sentencia = "SELECT * FROM cliente where dni = '" + nickname + "'";
                ENCliente auxCliente = new ENCliente();

                SqlCommand cmd = new SqlCommand(sentencia, conexion);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();


                if (dr.HasRows)
                {
                    do
                    {
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
                        auxCliente.FechaNac = dr.GetDateTime(11);
                        auxCliente.Telefono = dr.GetString(12);
                        auxCliente.Contraseña = dr.GetString(13);
                    } while (dr.Read());
                }
                return auxCliente;
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

        public List<ENCliente> BuscarClienteMail(string mail)
        {
            try
            {
                List<ENCliente> lClientes = new List<ENCliente>();
                string sentencia = "SELECT * FROM cliente where mail = '"+ mail +"'";
                ENCliente auxCliente;

                SqlCommand cmd = new SqlCommand(sentencia, conexion);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();


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
                        auxCliente.FechaNac = dr.GetDateTime(11);
                        auxCliente.Telefono = dr.GetString(12);
                        auxCliente.Contraseña = dr.GetString(13);
                        lClientes.Add(auxCliente);
                    } while (dr.Read());
                }
                return lClientes;
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
