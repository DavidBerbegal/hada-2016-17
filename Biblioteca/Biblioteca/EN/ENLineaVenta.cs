using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class ENLineaVenta
    {
        #region propiedades
        private string _codVenta;
        private string _codProducto;
        private float _cantidad;
        private float _subtotal;
        #endregion

        #region Constructores

        //DEFECTO
        public ENLineaVenta()
        {
            this._codVenta = "";
            this._codProducto = "";
            this._cantidad = 0.0f;
            this._cantidad = 0.0f;

        }

        //PARAMETROS
        public ENLineaVenta(string codVenta, string codProducto, float cantidad, float subtotal)
        {
            this._codVenta = codVenta;
            this._codProducto = codProducto;
            this._cantidad = cantidad;
            this._subtotal = subtotal;
        }
        #endregion

        #region Propiedades
        public string LVCodVenta
        {
            get { return _codVenta; }
            set { _codVenta = value; }
        }

        public string LVCodProducto
        {
            get { return _codProducto; }
            set { _codProducto = value; }
        }

        public float Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        public float Subtotal
        {
            get { return _subtotal; }
            set { _subtotal = value; }
        }
        #endregion

        #region CRUD
        public void InsertaLineaVenta()
        {
            //cadCliente = new CADCliente();
            //cadCliente.InsertarClientes(this);
        }

        public void BorrarLineaVenta()
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
        public List<ENLineaVenta> ConsultarLineaVenta()
        {
            List<ENLineaVenta> clientes = new List<ENLineaVenta>();
            CADLineaVenta c = new CADLineaVenta();
            //clientes = c.BuscarCliente();

            return clientes;

        }
        #endregion
    }
}