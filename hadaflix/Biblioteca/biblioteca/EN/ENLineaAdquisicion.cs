﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class ENLineaAdquisicion
    {
        #region propiedades
        private string _codAdquisicion;
        private string _codProducto;
        private float _cantidad;
        private float _subtotal;
        #endregion

        #region Constructores

        //DEFECTO
        public ENLineaAdquisicion()
        {
            this._codAdquisicion = "";
            this._codProducto = "";
            this._cantidad = 0.0f;
            this._cantidad = 0.0f;

        }

        //PARAMETROS
        public ENLineaAdquisicion(string codAdquisicion, string codProducto, float cantidad, float subtotal)
        {
            this._codAdquisicion = codAdquisicion;
            this._codProducto = codProducto;
            this._cantidad = cantidad;
            this._subtotal = subtotal;
        }
        #endregion

        #region Propiedades
        public string LVCodAdquisicion
        {
            get { return _codAdquisicion; }
            set { _codAdquisicion = value; }
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
        // CREATE LineaAdquisicion
        // -------------
        // CREAR/INSERTAR LineaAdquisicion
        public void InsertarLineaAdquisicion()
        {
            CADLineaAdquisicion cadLineaAdquisicion;
            cadLineaAdquisicion = new CADLineaAdquisicion();
            cadLineaAdquisicion.InsertarLineaAdquisicion(this);
        }

        // READ LineaAdquisicion
        // -------------
        // BUSCAR/LEER/ALMACENAR LISTA DE LineaAdquisiciones
        public List<ENLineaAdquisicion> BuscarLineaAdquisicion()
        {
            List<ENLineaAdquisicion> lineaadquisiciones = new List<ENLineaAdquisicion>();
            CADLineaAdquisicion c = new CADLineaAdquisicion();
            lineaadquisiciones = c.BuscarLineaAdquisicion();

            return lineaadquisiciones;
        }

        // UPDATE LineaAdquisicion
        // -------------
        // ACTUALIZAR LineaAdquisicion
        public void ActualizarLineaAdquisicion()
        {
            CADLineaAdquisicion cadLineaAdquisicion;
            cadLineaAdquisicion = new CADLineaAdquisicion();
            cadLineaAdquisicion.ActualizarLineaAdquisicion(this);
        }

        // DELETE LineaAdquisicion
        // -------------
        // ELIMINAR LineaAdquisicion
        public void EliminarLineaAdquisicion()
        {
            CADLineaAdquisicion cadLineaAdquisicion;
            cadLineaAdquisicion = new CADLineaAdquisicion();
            cadLineaAdquisicion.EliminarLineaAdquisicion(this);
        }
        #endregion
    }
}