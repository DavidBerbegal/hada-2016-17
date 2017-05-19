using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class CADEmpleado
    {
        private SqlConnection conexion = Database.getConnection();
        //Database dat = new Database();

        //CONSTRUCTOR
        public CADEmpleado()
        {
            /*
            try
            {
                conexion = Database.getConnection();
                conexion.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
            }
            */
            
            try
            {
                //conexion = new SqlConnection();
                // conexion.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\HADAFLIX\bd_hadaflix.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
                // PARA QUE FUNCIONE LA CONEXION LOCAL, LO DEL FINAL DEL TODO (User Instance=True) HAY QUE QUITARLO
                // conexion.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\javie\Downloads\ZZZZ\bbdd\bbdd\App_Data\base de datos.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
                // string s = "data source=.\\SQLEXPRESS;Integrated Security = SSPI; AttachDBFilename =| DataDirectory |\\Database1.mdf; User Instance = true";

                //string s = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\base de datos.mdf;Integrated Security = True; Connect Timeout = 30";
                //conexion = new SqlConnection(s);   
                //conexion = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["databaseConnectionString"].ConnectionString); 

                //conexion.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\javie\Downloads\ZZZZ\bbdd\bbdd\App_Data\base de datos.mdf;Integrated Security=True;Connect Timeout=30";
                conexion.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
            }
            

        }

        //INSERTAR UN EMPLEADO
        public void InsertarEmpleado(ENEmpleado empleado)
        {
            try
            {
                string sentencia = "INSERT INTO empleado " +
                    "(dni,nombre,apellido,edad,mail,direccion,provincia,poblacion,codpostal,fechanac,tipoempleado,telefono,contraseña,pais,sexo)" +
                    " VALUES ('" + empleado.Dni + "','" + empleado.Nombre + "','" + empleado.Apellidos + "','" +
                    empleado.Edad + "','" + empleado.Mail + "','" + empleado.Direccion + "','" + empleado.Provincia + "','" +
                    empleado.Poblacion + "','" + empleado.CodPostal + "','" + empleado.FechaNac + "','" +
                    empleado.TipoEmpleado + "','" + empleado.Telefono + "','" + empleado.Contraseña + "','" + empleado.Pais
                    + "','" + empleado.Sexo + "');";
                SqlCommand cmd = new SqlCommand(sentencia, conexion);
                cmd.ExecuteNonQuery();
            }catch (SqlException e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }
            finally
            {
                if (conexion != null)
                    conexion.Close();
            }
        }

        //ACTUALIZAR EMPLEADO
        public void ActualizarEmpleado(ENEmpleado empleado)
        {
            try
            {
                string sentencia = "UPDATE empleado SET nombre = " + "'" + empleado.Nombre + "'" + " , apellido = " + "'" + empleado.Apellidos + "'" + " , sexo = " + "'" + empleado.Sexo + "'"
                     + " , edad = " + empleado.Edad + " , mail = " + "'" + empleado.Mail + "'" + " , direccion = " + "'" + empleado.Direccion + "'" + " , provincia = " + "'" + empleado.Provincia + "'"
                     + " , poblacion = " + "'" + empleado.Poblacion + "'" + " , pais = " + "'" + empleado.Pais + "'" + " , codpostal = " + "'" + empleado.CodPostal + "'" + " , fechanac = " + "'" + empleado.FechaNac + "'"
                     + " , tipoempleado = " + "'" + empleado.TipoEmpleado + "'"  + " , telefono = " + "'" + empleado.Telefono + "' , contraseña = " + "'" + empleado.Contraseña + "'" + 
                     " WHERE dni = " + "'" + empleado.Dni + "'";
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

        //ELIMINAR EMPLEADO
        public void EliminarEmpleado(ENEmpleado empleado)
        {
            try
            {
                string sentencia = "DELETE FROM empleado WHERE dni = '" + empleado.Dni + "';";
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

        //BUSCAR EMPLEADO
        public List<ENEmpleado> BuscarEmpleado()
        {
            try
            {
                List<ENEmpleado> lEmpleado = new List<ENEmpleado>();
                string sentencia = "SELECT * FROM empleado";
                ENEmpleado auxEmpleado;

                SqlCommand cmd = new SqlCommand(sentencia, conexion);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    do
                    {
                        auxEmpleado = new ENEmpleado();
                        auxEmpleado.Dni = dr.GetString(0);
                        auxEmpleado.Nombre = dr.GetString(1);
                        auxEmpleado.Apellidos = dr.GetString(2);
                        auxEmpleado.Edad = dr.GetInt32(3);
                        auxEmpleado.Mail = dr.GetString(4);
                        auxEmpleado.Direccion = dr.GetString(5);
                        auxEmpleado.Provincia = dr.GetString(6);
                        auxEmpleado.Poblacion = dr.GetString(7);
                        auxEmpleado.CodPostal = dr.GetString(8);
                        auxEmpleado.FechaNac = dr.GetDateTime(9);
                        auxEmpleado.TipoEmpleado = dr.GetString(10);
                        auxEmpleado.Telefono = dr.GetString(11);
                        auxEmpleado.Contraseña = dr.GetString(12);
                        auxEmpleado.Pais = dr.GetString(13);
                        auxEmpleado.Sexo = dr.GetString(14);
                        lEmpleado.Add(auxEmpleado);
                    } while (dr.Read());
                }
                return lEmpleado;
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