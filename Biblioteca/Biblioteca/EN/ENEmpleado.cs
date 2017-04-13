using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class ENEmpleado
    {
        #region propiedades
        private string _dni;
        private string _nombre;
        private string _apellidos;
        private int _edad;
        private string _mail;
        private string _direccion;
        private string _provincia;
        private string _poblacion;
        private string _codPostal;
        private DateTime _fechaNac;
        private string _tipoEmpleado;
        private string _telefono;
        private string _contraseña;
        private string _pais;
        private string _sexo;
        #endregion

        #region Constructores

        //DEFECTO
        public ENEmpleado()
        {
            this._dni = "";
            this._nombre = "";
            this._apellidos = "";
            this._edad = 0;
            this._mail = "";
            this._direccion = "";
            this._provincia = "";
            this._poblacion = "";
            this._codPostal = "";
            this._fechaNac = DateTime.Today;
            this._tipoEmpleado = "";
            this._telefono = "";
            this._contraseña = "";
            this._pais = "";
            this._sexo = "";

        }

        //PARAMETROS
        public ENEmpleado(string dni, string nombre, string apellidos, int edad, string mail, string direccion
            , string provincia, string poblacion, string codPostal, DateTime fechaNac, string tipoEmpleado, string telefono
            , string contraseña, string pais, string sexo)
        {
            this._dni = dni;
            this._nombre = nombre;
            this._apellidos = apellidos;
            this._edad = edad;
            this._mail = mail;
            this._direccion = direccion;
            this._provincia = provincia;
            this._poblacion = poblacion;
            this._codPostal = codPostal;
            this._fechaNac = fechaNac;
            this._tipoEmpleado = tipoEmpleado;
            this._telefono = telefono;
            this._contraseña = contraseña;
            this._pais = pais;
            this._sexo = sexo;
        }

        //COPIA
        public ENEmpleado(ENEmpleado empleado)
        {
            this._dni = empleado._dni;
            this._nombre = empleado._nombre;
            this._apellidos = empleado._apellidos;
            this._edad = empleado._edad;
            this._mail = empleado._mail;
            this._direccion = empleado._direccion;
            this._provincia = empleado._provincia;
            this._poblacion = empleado._poblacion;
            this._codPostal = empleado._codPostal;
            this._fechaNac = empleado._fechaNac;
            this._tipoEmpleado = empleado._tipoEmpleado;
            this._telefono = empleado._telefono;
            this._contraseña = empleado._contraseña;
            this._pais = empleado._pais;
            this._sexo = empleado._sexo;
        }
        #endregion

        #region Propiedades
        public string Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Apellidos
        {
            get { return _apellidos; }
            set { _apellidos = value; }
        }

        public int Edad
        {
            get { return _edad; }
            set { _edad = value; }
        }

        public string Mail
        {
            get { return _mail; }
            set { _mail = value; }
        }

        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        public string Provincia
        {
            get { return _provincia; }
            set { _provincia = value; }
        }

        public string Poblacion
        {
            get { return _poblacion; }
            set { _poblacion = value; }
        }

        public string CodPostal
        {
            get { return _codPostal; }
            set { _codPostal = value; }
        }

        public DateTime FechaNac
        {
            get { return _fechaNac; }
            set { _fechaNac = value; }
        }

        public string TipoEmpleado
        {
            get { return _tipoEmpleado; }
            set { _tipoEmpleado = value; }
        }

        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        public string Contraseña
        {
            get { return _contraseña; }
            set { _contraseña = value; }
        }

        public string Pais
        {
            get { return _pais; }
            set { _pais = value; }
        }

        public string Sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }
        #endregion

        #region CRUD
        public void InsertaEmpleado()
        {
          
        }

        public void BorrarEmpleado()
        {

        }


        //LISTA DE CLIENTES
        /*public List<ENEmpleado> BuscarEmpleado()
        {
            List<ENCliente> clientes = new List<ENCliente>();
            CADCliente c = new CADCliente();
            clientes = c.BuscarCliente();

            return clientes;

        }*/
        #endregion
    }
}
