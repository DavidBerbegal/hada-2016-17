using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class ENAlquiler
    {
        private string _codVenta;
        private DateTime _fechaInicio;
        private DateTime _fechaFin;
        private float _recargo;

        ENAlquiler()
        {
            this._codVenta = "";
            this._fechaInicio = DateTime.Today;
            this._fechaFin = DateTime.Today;
            this._recargo = 0.0f;
        }

        ENAlquiler(string codVenta, DateTime fechaInicio, DateTime fechaFin, float recargo)
        {
            this._codVenta = codVenta;
            this._fechaInicio = fechaInicio;
            this._fechaFin = fechaFin;
            this._recargo = recargo;
        }

        public string CodVenta
        {
            get { return _codVenta; }
            set { _codVenta = value; }
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
    }
}
