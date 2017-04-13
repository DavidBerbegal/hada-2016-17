using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class ENVenta:ENAdquisicion
    {
        private string _codVenta;

        public string CodVenta
        {
            get { return _codVenta; }
            set { _codVenta = value; }
        }
    }
}
