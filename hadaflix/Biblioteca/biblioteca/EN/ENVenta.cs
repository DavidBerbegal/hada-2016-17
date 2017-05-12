using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class ENVenta : ENAdquisicion
    {

        public ENVenta()
        {
            this._codVenta = "";
            this._tipo = "v";
        }

        public ENVenta(string codVenta, float importe, string numFactura, string dniCliente, string dniEmpleado)
        {
            this._codVenta = codVenta;
            this._dniCliente = dniCliente;
            this._dniEmpleado = dniEmpleado;
            this._importe = importe;
            this._numFactura = numFactura;
        }

        #region CRUD
        // CREATE VENTA
        // ------------------
        // CREAR/INSERTAR VENTA
        public void InsertarVenta()
        {
            CADVenta cadAlquiler;
            cadAlquiler = new CADVenta();
            cadAlquiler.InsertarVenta(this);
        }

        // READ VENTA
        // ----------------
        // BUSCAR/LEER/ALMACENAR LISTA DE VENTAS
        public List<ENVenta> BuscarAlquileres()
        {
            List<ENVenta> ventas = new List<ENVenta>();
            CADVenta c = new CADVenta();
            ventas = c.BuscarVentas();

            return ventas;
        }

        // UPDATE ADQUISICION
        // ------------------
        // ACTUALIZAR ADQUISICIONES
        public void ActualizarVenta()
        {
            CADVenta cadVenta;
            cadVenta = new CADVenta();
            cadVenta.ActualizarVenta(this);
        }

        // DELETE ADQUISICION
        // ------------------
        // ELIMINAR ADQUISICION
        public void EliminarVenta()
        {
            CADVenta cadVenta;
            cadVenta = new CADVenta();
            cadVenta.EliminarVenta(this);
        }
        #endregion

        // BUSCAR/LEER/ALMACENAR LISTA DE ALQUILERES EN FUNCION DE UN CODALQUILER
        public List<ENAdquisicion> BuscarVenta(ENVenta vent)
        {
            List<ENAdquisicion> adquisiciones = new List<ENAdquisicion>();
            CADAdquisicion c = new CADAdquisicion();
            adquisiciones = c.BuscarVenta(vent);

            return adquisiciones;
        }
    }
}
