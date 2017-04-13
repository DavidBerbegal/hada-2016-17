using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class CADEmpleado
    {
        private SqlConnection conexion = null;

        //CONSTRUCTOR
        public CADEmpleado()
        {
            conexion = new SqlConnection();
            conexion.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\HADAFLIX\bd_hadaflix.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            conexion.Open();
        }

        //INSERTAR UN CLIENTE
        public void InsertarEmpleado(ENEmpleado empleado)
        {
            string sentencia = "INSERT INTO empleado " +
                "(dni,nombre,apellido,edad,mail,direccion,provincia,poblacion,codpostal,fechanac,tipoempleado,telefono,contraseña,pais,sexo)" +
                "VALUE ('" + empleado.Dni + "','" + empleado.Nombre + "','" + empleado.Apellidos + "','" +
                empleado.Edad + "','" + empleado.Direccion + "','" + empleado.Provincia + "','" +
                empleado.Poblacion + "','" + empleado.CodPostal + "','" + empleado.FechaNac + "','" + 
                empleado.TipoEmpleado + "','" + empleado.Telefono + "','" + empleado.Contraseña + "','" + empleado.Pais
                + "','" + empleado.Sexo + "');";

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
        public void EliminarEmpleado(ENEmpleado empleado)
        {
            string sentencia = "DELETE FROM empleado WHERE dni = '" + empleado.Dni + "');";

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
        public List<ENEmpleado> BuscarEmpleado()
        {
            List<ENEmpleado> lEmpleado = new List<ENEmpleado>();
            string sentencia = "SELECT * FROM empleado";
            ENEmpleado auxEmpleado = null;

            try
            {
                SqlCommand cmd = new SqlCommand(sentencia, conexion);
                SqlDataReader dr = cmd.ExecuteReader();

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
            catch (SqlException e) { throw e; }

            finally
            {
                if (conexion != null)
                    conexion.Close();
            }
        }

    }
}