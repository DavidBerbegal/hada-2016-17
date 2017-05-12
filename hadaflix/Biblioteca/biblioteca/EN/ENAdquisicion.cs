using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class ENAdquisicion
    {
        protected string _codVenta;
        protected string _dniCliente;
        protected string _dniEmpleado;
        protected float _importe;
        protected string _numFactura;
        protected string _tipo;

        #region Constructores

        //DEFECTO
        public ENAdquisicion()
        {
            this._codVenta = "";
            this._dniCliente = "";
            this._dniEmpleado = "";
            this._importe = 0.0f;
            this._numFactura = "0";
            this._tipo = "";
        }

        //PARAMETROS
        public ENAdquisicion(string codVenta, float importe, string numFactura, string dniCliente, string dniEmpleado, string tipo)
        {
            this._codVenta = codVenta;
            this._dniCliente = dniCliente;
            this._dniEmpleado = dniEmpleado;
            this._importe = importe;
            this._numFactura = numFactura;
            this._tipo = tipo;
        }
        #endregion

        #region Propiedades
        public string CodVenta
        {
            get { return _codVenta; }
            set { _codVenta = value; }
        }

        public string DniCliente
        {
            get { return _dniCliente; }
            set { _dniCliente = value; }
        }

        public string DniEmpleado
        {
            get { return _dniEmpleado; }
            set { _dniEmpleado = value; }
        }

        public float Importe
        {
            get { return _importe; }
            set { _importe = value; }
        }

        public string NumFactura
        {
            get { return _numFactura; }
            set { _numFactura = value; }
        }

        public string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
        #endregion

        #region CRUD
        // CREATE ADQUISICION
        // ------------------
        // CREAR/INSERTAR ADQUISICION
        public void InsertarAdquisicion()
        {
            CADAdquisicion cadAdquisicion;
            cadAdquisicion = new CADAdquisicion();
            cadAdquisicion.InsertarAdquisicion(this);
        }

        // READ ADQUISICION
        // ----------------
        // BUSCAR/LEER/ALMACENAR LISTA DE ADQUISICIONES
        public List<ENAdquisicion> BuscarAdquisicion()
        {
            List<ENAdquisicion> adquisiciones = new List<ENAdquisicion>();
            CADAdquisicion c = new CADAdquisicion();
            adquisiciones = c.BuscarAdquisiciones();

            return adquisiciones;
        }

        // UPDATE ADQUISICION
        // ------------------
        // ACTUALIZAR ADQUISICIONES
        public void ActualizarAdquisicion()
        {
            CADAdquisicion cadAdquisicion;
            cadAdquisicion = new CADAdquisicion();
            cadAdquisicion.ActualizarAdquisicion(this);
        }

        // DELETE ADQUISICION
        // ------------------
        // ELIMINAR ADQUISICION
        public void EliminarAdquisicion()
        {
            CADAdquisicion cadAdquisicion;
            cadAdquisicion = new CADAdquisicion();
            cadAdquisicion.EliminarAdquisicion(this);
        }
        #endregion
    }
}
