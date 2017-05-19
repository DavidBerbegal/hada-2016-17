using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class ENAlquiler : ENAdquisicion
    {
        private DateTime _fechaInicio;
        private DateTime _fechaFin;
        private float _recargo;

        public ENAlquiler()
        {
            this._codVenta = "";
            this._fechaInicio = DateTime.Today;
            this._fechaFin = DateTime.Today;
            this._recargo = 0.0f;
            this._tipo = "a";
        }

        public ENAlquiler(string codAlquiler, float importe, string numFactura, string dniCliente, string dniEmpleado, DateTime fechaInicio, DateTime fechaFin, float recargo)
        {
            this._codVenta = codAlquiler;
            this._fechaInicio = fechaInicio;
            this._fechaFin = fechaFin;
            this._recargo = recargo;
            this._dniCliente = dniCliente;
            this._dniEmpleado = dniEmpleado;
            this._importe = importe;
            this._numFactura = numFactura;
        }

        public DateTime FechaInicio
        {
            get { return _fechaInicio; }
            set { _fechaInicio = value; }
        }

        public DateTime FechaFin
        {
            get { return _fechaFin; }
            set { _fechaFin = value; }
        }

        public float Recargo
        {
            get { return _recargo; }
            set { _recargo = value; }
        }

        #region CRUD
        // CREATE ADQUISICION
        // ------------------
        // CREAR/INSERTAR ADQUISICION
        public void InsertarAlquiler()
        {
            CADAlquiler cadAlquiler;
            cadAlquiler = new CADAlquiler();
            cadAlquiler.InsertarAlquiler(this);
        }

        // READ ALQUILER
        // ----------------
        // BUSCAR/LEER/ALMACENAR LISTA DE ALQUILERES
        public List<ENAlquiler> BuscarAlquileres()
        {
            List<ENAlquiler> alquileres = new List<ENAlquiler>();
            CADAlquiler c = new CADAlquiler();
            alquileres = c.BuscarAlquileres();

            return alquileres;
        }

        // UPDATE ADQUISICION
        // ------------------
        // ACTUALIZAR ADQUISICIONES
        public void ActualizarAlquiler()
        {
            CADAlquiler cadAlquiler;
            cadAlquiler = new CADAlquiler();
            cadAlquiler.ActualizarAlquiler(this);
        }

        // DELETE ADQUISICION
        // ------------------
        // ELIMINAR ADQUISICION
        public void EliminarAlquiler()
        {
            CADAlquiler cadAlquiler;
            cadAlquiler = new CADAlquiler();
            cadAlquiler.EliminarAlquiler(this);
        }
        #endregion

        // BUSCAR/LEER/ALMACENAR LISTA DE ALQUILERES EN FUNCION DE UN CODALQUILER
        public List<ENAdquisicion> BuscarAlquiler(ENAlquiler alq)
        {
            List<ENAdquisicion> adquisiciones = new List<ENAdquisicion>();
            CADAdquisicion c = new CADAdquisicion();
            adquisiciones = c.BuscarAlquiler(alq);

            return adquisiciones;
        }
        public int CuentaAlquileres()
        {
            int cuantos = 0;
            CADAlquiler nuevo = new CADAlquiler();
            cuantos = nuevo.CuentaAlquileres();
            
            return cuantos;
        }
    }
}
