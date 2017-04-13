using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class ENCliente
    {
        #region propiedades
        private string _dni;
        private int _nSocio;
        private string _nombre;
        private string _apellidos;
        private int _edad;
        private string _mail;
        private string _direccion;
        private string _provincia;
        private string _poblacion;
        private string _pais;
        private string _codPostal;
        private string _telefono;
        private DateTime _fechaNac;
        private string _contraseña;
        #endregion

        #region Constructores

        //DEFECTO
        public ENCliente()
        {
            this._dni = "";
            this._nSocio = 0;
            this._nombre = "";
            this._apellidos = "";
            this._edad = 0;
            this._mail = "";
            this._direccion = "";
            this._provincia = "";
            this._poblacion = "";
            this._pais = "";
            this._codPostal = "";
            this._telefono = "";
            this._fechaNac = DateTime.Today;
            this._contraseña = "";
        }

        //PARAMETROS
        public ENCliente(string dni, int nSocio, string nombre, string apellidos, int edad, string mail, string direccion
            , string provincia, string poblacion, string pais,string codPostal, string telefono, DateTime fechaNac,string contraseña)
        {
            this._dni = dni;
            this._nSocio = nSocio;
            this._nombre = nombre;
            this._apellidos = apellidos;
            this._edad = edad;
            this._mail = mail;
            this._direccion = direccion;
            this._provincia = provincia;
            this._poblacion = poblacion;
            this._pais = pais;
            this._codPostal = codPostal;
            this._telefono = telefono;
            this._fechaNac = fechaNac;
            this._contraseña = contraseña;
        }

        //COPIA
        public ENCliente(ENCliente cliente)
        {
            this._dni = cliente._dni;
            this._nSocio = cliente._nSocio;
            this._nombre = cliente._nombre;
            this._apellidos = cliente._apellidos;
            this._edad = cliente._edad;
            this._mail = cliente._mail;
            this._direccion = cliente._direccion;
            this._provincia = cliente._provincia;
            this._poblacion = cliente._poblacion;
            this._pais = cliente._pais;
            this._codPostal = cliente._codPostal;
            this._telefono = cliente._telefono;
            this._fechaNac = cliente._fechaNac;
            this._contraseña = cliente._contraseña;
        }
        #endregion

        #region Propiedades
        public string Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }

        public int NSocio
        {
            get { return _nSocio; }
            set { _nSocio = value; }
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

        public string Pais
        {
            get { return _pais; }
            set { _pais = value; }
        }

        public string CodPostal
        {
            get { return _codPostal; }
            set { _codPostal = value; }
        }

        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        public DateTime FechaNac
        {
            get { return _fechaNac; }
            set { _fechaNac = value; }
        }

        public string Contraseña
        {
            get { return _contraseña; }
            set { _contraseña = value; }
        }
        #endregion

        #region CRUD
        public void InsertaCliente()
        {
            //cadCliente = new CADCliente();
            //cadCliente.InsertarClientes(this);
        }

        /*public DataSet BuscarCliente(string cliente)
        {
           cadCliente = new CADCliente();
           return (cadCliente.BuscarCliente(cliente));
        }*/


        //LISTA DE CLIENTES
        public List<ENCliente> BuscarCliente()
        {
            List<ENCliente> clientes = new List<ENCliente>();
            CADCliente c = new CADCliente();
            clientes = c.BuscarCliente();

            return clientes;

        }
        #endregion
    }
}
