using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class ENProducto
    {
        #region propiedades
        private string _idProducto;
        private string _codProveedor;
        private string _titulo;
        private string _director;
        private string _duracion;
        private char _tipo;
        private float _precio;
        private string _descripcion;
        private int _edadRecomendada;
        private string _imagen;
        #endregion

        #region Constructores

        //DEFECTO
        public ENProducto()
        {
            this._idProducto = "";
            this._codProveedor = "";
            this._titulo = "";
            this._director = "";
            this._duracion = "";
            this._tipo = ' ';
            this._precio = 0.0F;
            this._descripcion = "";
            this._edadRecomendada = 0;
            this._imagen = "";
        }

        //PARAMETROS
        public ENProducto(string idProducto, string codProveedor, string titulo, string director, string duracion, char tipo
            , float precio, string descripcion, int edadRecomendada, string imagen)
        {
            this._idProducto = idProducto;
            this._codProveedor = codProveedor;
            this._titulo = titulo;
            this._director = director;
            this._duracion = duracion;
            this._tipo = tipo;
            this._precio = precio;
            this._descripcion = descripcion;
            this._edadRecomendada = edadRecomendada;
            this._imagen = imagen;
        }

        //COPIA
        public ENProducto(ENProducto producto)
        {
            this._idProducto = producto._idProducto;
            this._codProveedor = producto._codProveedor;
            this._titulo = producto._titulo;
            this._director = producto._director;
            this._duracion = producto._duracion;
            this._tipo = producto._tipo;
            this._precio = producto._precio;
            this._descripcion = producto._descripcion;
            this._edadRecomendada = producto._edadRecomendada;
            this._imagen = producto._imagen;
        }
        #endregion

        #region Propiedades
        public string IdProducto
        {
            get { return _idProducto; }
            set { _idProducto = value; }
        }

        public string CodProveedor
        {
            get { return _codProveedor; }
            set { _codProveedor = value; }
        }

        public string Titulo
        {
            get { return _titulo; }
            set { _titulo = value; }
        }

        public string Director
        {
            get { return _director; }
            set { _director = value; }
        }

        public string Duracion
        {
            get { return _duracion; }
            set { _duracion = value; }
        }

        public char Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        public float Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public int EdadRecomendada
        {
            get { return _edadRecomendada; }
            set { _edadRecomendada = value; }
        }
        public string Imagen
        {
            get { return _imagen; }
            set { _imagen = value; }
        }
        #endregion

        #region CRUD
        // CREATE PRODUCTO
        // -------------
        // CREAR/INSERTAR PRODUCTO
        public void InsertarProducto()
        {
            CADProducto cadProducto;
            cadProducto = new CADProducto();
            cadProducto.InsertarProducto(this);
        }

        // READ PRODUCTO
        // -------------
        // BUSCAR/LEER/ALMACENAR LISTA DE PRODUCTOS
        public List<ENProducto> BuscarProducto()
        {
            List<ENProducto> productos = new List<ENProducto>();
            CADProducto c = new CADProducto();
            productos = c.BuscarProducto();

            return productos;
        }

        // UPDATE PRODUCTO
        // -------------
        // ACTUALIZAR PRODUCTO
        public void ActualizarProducto()
        {
            CADProducto cadProducto;
            cadProducto = new CADProducto();
            cadProducto.ActualizarProducto(this);
        }

        // DELETE PRODUCTO
        // -------------
        // ELIMINAR PRODUCTO
        public void EliminarProducto()
        {
            CADProducto cadProducto;
            cadProducto = new CADProducto();
            cadProducto.EliminarProducto(this);
        }
        #endregion
    }
}
