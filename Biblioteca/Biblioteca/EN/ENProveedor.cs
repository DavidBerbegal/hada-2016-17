using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class ENProveedor
    {
        #region propiedades
        private string _cif;
        private string _nombre;
        private string _mail;
        private string _direccion;
        private string _provincia;
        private string _poblacion;
        private string _codPostal;
        private string _telefono;
        #endregion

        #region Constructores

        //DEFECTO
        public ENProveedor()
        {
            this._cif= "";
            this._nombre = "";
            this._mail = "";
            this._direccion = "";
            this._provincia = "";
            this._poblacion = "";
            this._codPostal = "";
            this._telefono = "";
        }

        //PARAMETROS
        public ENProveedor(string cif, string nombre, string mail, string direccion
            , string provincia, string poblacion, string codPostal, string telefono)
        {
            this._cif = cif;
            this._nombre = nombre;
            this._mail = mail;
            this._direccion = direccion;
            this._provincia = provincia;
            this._poblacion = poblacion;
            this._codPostal = codPostal;
            this._telefono = telefono;
        }

        //COPIA
        public ENProveedor(ENProveedor proveedor)
        {
            this._cif = proveedor._cif;
            this._nombre = proveedor._nombre;
            this._mail = proveedor._mail;
            this._direccion = proveedor._direccion;
            this._provincia = proveedor._provincia;
            this._poblacion = proveedor._poblacion;
            this._codPostal = proveedor._codPostal;
            this._telefono = proveedor._telefono;
        }
        #endregion

        #region Propiedades
        public string Cif
        {
            get { return _cif; }
            set { _cif = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
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

        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        #endregion

        #region CRUD
        public void InsertaProveedor()
        {
            
        }

        public void BorrarProveedor()
        {

        }

        /*public DataSet BuscarCliente(string cliente)
        {
           cadCliente = new CADCliente();
           return (cadCliente.BuscarCliente(cliente));
        }*/


        //LISTA DE PROVEEDORES
        /* public List<ENProveedor> BuscarProveedor()
         {
             List<ENProveedor> proveedores = new List<ENProveedor>();
             CADProveedor pr = new CADProveedor();
             proveedores = c.BuscarProveedor();

             return proveedores;

         }*/
        #endregion
    }
}
