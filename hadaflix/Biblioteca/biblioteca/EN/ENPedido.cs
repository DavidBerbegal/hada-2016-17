using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class ENPedido
    {
        #region propiedades
        private string _codProducto;
        private string _codEmpleado;
        private int _cantidad;
        private float _precio;
        #endregion

        #region Constructores

        //DEFECTO
        public ENPedido()
        {
            this._codProducto = "";
            this._codEmpleado = "";
            this._cantidad = 0;
            this._precio = 0.0F;

        }

        //PARAMETROS
        public ENPedido(string codProducto, string codEmpleado, int cantidad)
        {
            this._codProducto = codProducto;
            this._codEmpleado = codEmpleado;
            this._cantidad = cantidad;
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

        public int Cantidad
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
            CADPedido nuevoPedido = new CADPedido();
            nuevoPedido.InsertarPedido(this);
        }

        public void BorrarPedido()
        {
            CADPedido viejoPedido = new CADPedido();
            viejoPedido.EliminarPedido(this);
        }

        // UPDATE PEDIDO
        // -------------
        // ACTUALIZAR PEDIDO
        public void ActualizarPedido()
        {
            CADPedido cadPedido;
            cadPedido = new CADPedido();
            cadPedido.ActualizarPedido(this);
        }

        //LISTA DE PEDIDOS
        public List<ENPedido> BuscarPedido()
        {
            List<ENPedido> pedidos = new List<ENPedido>();
            CADPedido pr = new CADPedido();
            pedidos = pr.BuscarPedido();

            return pedidos;
        }
        #endregion
    }
}
