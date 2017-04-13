using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class ENAdquisicion
    {
        private string _codVenta;
        private string _dniCliente;
        private string _dniEmpleado;
        private float _importe;
        private int _numFactura;

        #region Constructores
  
        //DEFECTO
        public ENAdquisicion()
        {
            this._codVenta = "";
            this._dniCliente = "";
            this._dniEmpleado = "";
            this._importe = 0.0f;
            this._numFactura = 0;
        }

        //PARAMETROS
        public ENAdquisicion(string codVenta, string dniCliente, string dniEmpleado, float importe, int numFactura)
        {
            this._codVenta = codVenta;
            this._dniCliente = dniCliente;
            this._dniEmpleado = dniEmpleado;
            this._importe = importe;
            this._numFactura = numFactura;
        }

        //COPIA
        public ENAdquisicion(ENAdquisicion venta)
        {
            this._codVenta = venta._codVenta;
            this._dniCliente = venta._dniCliente;
            this._dniEmpleado = venta._dniEmpleado;
            this._importe = venta._importe;
            this._numFactura = venta._numFactura;
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

        public int NumFactura
        {
            get { return _numFactura; }
            set { _numFactura = value; }
        }

        #endregion

        #region CRUD
        public void RealizarVenta()
        {
            //cadCliente = new CADCliente();
            //cadCliente.InsertarClientes(this);
        }

        public void Devolucion()
        {
        }

        /*public DataSet BuscarCliente(string cliente)
        {
           cadCliente = new CADCliente();
           return (cadCliente.BuscarCliente(cliente));
        }*/


        //LISTA DE CLIENTES
        /*public List<ENCliente> ListadoDeVentas()
        {
            List<ENCliente> clientes = new List<ENCliente>();
            CADCliente c = new CADCliente();
            clientes = c.BuscarCliente();

            return clientes;

        }*/
        #endregion
       

    }
}
