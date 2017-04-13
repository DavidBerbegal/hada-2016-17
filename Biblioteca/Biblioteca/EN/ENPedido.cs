using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class ENPedido
    {
        #region propiedades
        private string _codProducto;
        private string _codEmpleado;
        private float _cantidad;
        private float _precio;
        #endregion

        #region Constructores

        //DEFECTO
        public ENPedido()
        {
            this._codProducto = "";
            this._codEmpleado = "";
            this._cantidad = 0.0f;
            this._cantidad = 0.0f;

        }

        //PARAMETROS
        public ENPedido(string codProducto, string codEmpleado, float cantidad, float subtotal)
        {
            this._codProducto = codProducto;
            this._codEmpleado = codEmpleado;
            this._cantidad = cantidad;
            this._precio = subtotal;
        }
        #endregion

        #region Propiedades
        public string CodEmpleado
        {
            get { return _codEmpleado; }
            set { _codEmpleado = value; }
        }

        public string CodProducto
        {
            get { return _codProducto; }
            set { _codProducto = value; }
        }

        public float Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        public float Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }
        #endregion

        #region CRUD
        public void InsertaPedido()
        {
            //cadCliente = new CADCliente();
            //cadCliente.InsertarClientes(this);
        }

        public void BorrarPedido()
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
        public List<ENPedido> ConsultarPedido()
        {
            List<ENPedido> pedidos = new List<ENPedido>();
            CADPedido c = new CADPedido();
            //clientes = c.BuscarCliente();

            return pedidos;

        }
        #endregion
    }
}
