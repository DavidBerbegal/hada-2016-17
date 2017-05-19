using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Biblioteca;

namespace hadaflix.app
{
    public partial class Series : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["UserInfo"];
            ENCliente usuario;

            if (cookie != null)
            {
                usuario = loadCookie(cookie);

            }

            ENProducto producto = new ENProducto();
            List<ENProducto> lProductes;


            lProductes = producto.BuscarProducto();

            Serie0.ImageUrl = lProductes[9].Imagen;
            Serie1.ImageUrl = lProductes[10].Imagen;
            Serie2.ImageUrl = lProductes[11].Imagen;
            Serie3.ImageUrl = lProductes[12].Imagen;
            Serie4.ImageUrl = lProductes[13].Imagen;

            Titul0.Text = lProductes[9].Titulo;
            Titul1.Text = lProductes[10].Titulo;
            Titul2.Text = lProductes[11].Titulo;
            Titul3.Text = lProductes[12].Titulo;
            Titul4.Text = lProductes[13].Titulo;

            Descripcio0.Text = lProductes[9].Descripcion;
            Descripcio1.Text = lProductes[10].Descripcion;
            Descripcio2.Text = lProductes[11].Descripcion;
            Descripcio3.Text = lProductes[12].Descripcion;
            Descripcio4.Text = lProductes[13].Descripcion;

            Edad0.Text = lProductes[9].EdadRecomendada.ToString();
            Edad1.Text = lProductes[10].EdadRecomendada.ToString();
            Edad2.Text = lProductes[11].EdadRecomendada.ToString();
            Edad3.Text = lProductes[12].EdadRecomendada.ToString();
            Edad4.Text = lProductes[13].EdadRecomendada.ToString();

            Director0.Text = lProductes[9].Director;
            Director1.Text = lProductes[10].Director;
            Director2.Text = lProductes[11].Director;
            Director3.Text = lProductes[12].Director;
            Director4.Text = lProductes[13].Director;

        }

        public static ENCliente loadCookie(HttpCookie userCookie)
        {

            DateTime da = new DateTime();
            ENCliente usuario1 = new ENCliente(userCookie["Name"], 1, "", "", 23, "", ""
                , "", "", "", "", "", da, "");
            ENCliente usuario = new ENCliente(usuario1.getUserByNick());

            HttpContext.Current.Session["UserDni"] = usuario.Dni;
            HttpContext.Current.Session["UserNSocio"] = usuario.NSocio;
            HttpContext.Current.Session["UserNombre"] = usuario.Nombre;
            HttpContext.Current.Session["UserApellidos"] = usuario.Apellidos;
            HttpContext.Current.Session["UserEdad"] = usuario.Edad;
            HttpContext.Current.Session["UserMail"] = usuario.Mail;
            HttpContext.Current.Session["UserDireccion"] = usuario.Direccion;
            HttpContext.Current.Session["UserProvincia"] = usuario.Provincia;
            HttpContext.Current.Session["UserPoblacion"] = usuario.Poblacion;
            HttpContext.Current.Session["UserPais"] = usuario.Pais;
            HttpContext.Current.Session["UserCodPostal"] = usuario.CodPostal;
            HttpContext.Current.Session["UserFechaNac"] = usuario.FechaNac;
            HttpContext.Current.Session["UserTelefono"] = usuario.Telefono;
            HttpContext.Current.Session["UserContraseña"] = usuario.Contraseña;

            return usuario;
        }

        /************************************************
         * ***************SERIES 9*********************
         * **********************************************/
        protected void venta9_Click(object sender, EventArgs e)
        {
            ENProducto productoBase = new ENProducto();



            ENEmpleado empleado = new ENEmpleado();
            List<ENEmpleado> empleados = empleado.BuscarEmpleado();
            empleado = empleados[0];

            List<ENProducto> lProductes;
            lProductes = productoBase.BuscarProducto();
            productoBase.IdProducto = lProductes[9].IdProducto;

            productoBase.Precio = lProductes[9].Precio;

            int numVentas = 0;
            CADVenta ven1 = new CADVenta();
            numVentas = ven1.CuentaVentas() + 1;
            string nV = numVentas.ToString();

            HttpCookie cookie = Request.Cookies["UserInfo"];
            ENCliente usuario = loadCookie(cookie);

            ENVenta nuevaVenta = new ENVenta(nV, productoBase.Precio, nV, usuario.Dni, "48627783X");
            nuevaVenta.InsertarVenta();
            ENLineaAdquisicion nuevaLinea = new ENLineaAdquisicion(nV, productoBase.IdProducto, 1);
            nuevaLinea.InsertarLineaAdquisicion();
        }

        protected void alquiler9_Click(object sender, EventArgs e)
        {
            ENProducto productoBase = new ENProducto();

            ENEmpleado empleado = new ENEmpleado();
            List<ENEmpleado> empleados = empleado.BuscarEmpleado();
            empleado = empleados[0];

            List<ENProducto> lProductes;
            lProductes = productoBase.BuscarProducto();
            productoBase.IdProducto = lProductes[9].IdProducto;
            productoBase.Precio = lProductes[9].Precio;

            CADAlquiler alq1 = new CADAlquiler();
            int numAlquileres = alq1.CuentaAlquileres() + 1;
            string nA = numAlquileres.ToString();

            HttpCookie cookie = Request.Cookies["UserInfo"];
            ENCliente usuario = loadCookie(cookie);

            ENAlquiler nuevoAlquiler = new ENAlquiler(nA, productoBase.Precio, nA, usuario.Dni, empleado.Dni, DateTime.Today, DateTime.Today.AddDays(3), 3);
            nuevoAlquiler.InsertarAlquiler();

            ENLineaAdquisicion nuevaLinea = new ENLineaAdquisicion(nA, productoBase.IdProducto, 1);
            nuevaLinea.InsertarLineaAdquisicion();
        }

        /************************************************
         * ***************SERIES 10*********************
         * **********************************************/
        protected void venta10_Click(object sender, EventArgs e)
        {
            ENProducto productoBase = new ENProducto();



            ENEmpleado empleado = new ENEmpleado();
            List<ENEmpleado> empleados = empleado.BuscarEmpleado();
            empleado = empleados[1];

            List<ENProducto> lProductes;
            lProductes = productoBase.BuscarProducto();
            productoBase.IdProducto = lProductes[10].IdProducto;

            productoBase.Precio = lProductes[10].Precio;

            int numVentas = 0;
            CADVenta ven1 = new CADVenta();
            numVentas = ven1.CuentaVentas() + 1;
            string nV = numVentas.ToString();

            HttpCookie cookie = Request.Cookies["UserInfo"];
            ENCliente usuario = loadCookie(cookie);

            ENVenta nuevaVenta = new ENVenta(nV, productoBase.Precio, nV, usuario.Dni, "48627783X");
            nuevaVenta.InsertarVenta();
            ENLineaAdquisicion nuevaLinea = new ENLineaAdquisicion(nV, productoBase.IdProducto, 1);
            nuevaLinea.InsertarLineaAdquisicion();
        }

        protected void alquiler10_Click(object sender, EventArgs e)
        {
            ENProducto productoBase = new ENProducto();

            ENEmpleado empleado = new ENEmpleado();
            List<ENEmpleado> empleados = empleado.BuscarEmpleado();
            empleado = empleados[0];

            List<ENProducto> lProductes;
            lProductes = productoBase.BuscarProducto();
            productoBase.IdProducto = lProductes[10].IdProducto;
            productoBase.Precio = lProductes[10].Precio;

            CADAlquiler alq1 = new CADAlquiler();
            int numAlquileres = alq1.CuentaAlquileres() + 1;
            string nA = numAlquileres.ToString();

            HttpCookie cookie = Request.Cookies["UserInfo"];
            ENCliente usuario = loadCookie(cookie);

            ENAlquiler nuevoAlquiler = new ENAlquiler(nA, productoBase.Precio, nA, usuario.Dni, empleado.Dni, DateTime.Today, DateTime.Today.AddDays(3), 3);
            nuevoAlquiler.InsertarAlquiler();

            ENLineaAdquisicion nuevaLinea = new ENLineaAdquisicion(nA, productoBase.IdProducto, 1);
            nuevaLinea.InsertarLineaAdquisicion();
        }

        /************************************************
         * ***************SERIES 11*********************
         * **********************************************/
        protected void venta11_Click(object sender, EventArgs e)
        {
            ENProducto productoBase = new ENProducto();



            ENEmpleado empleado = new ENEmpleado();
            List<ENEmpleado> empleados = empleado.BuscarEmpleado();
            empleado = empleados[2];

            List<ENProducto> lProductes;
            lProductes = productoBase.BuscarProducto();
            productoBase.IdProducto = lProductes[11].IdProducto;

            productoBase.Precio = lProductes[11].Precio;

            int numVentas = 0;
            CADVenta ven1 = new CADVenta();
            numVentas = ven1.CuentaVentas() + 1;
            string nV = numVentas.ToString();

            HttpCookie cookie = Request.Cookies["UserInfo"];
            ENCliente usuario = loadCookie(cookie);

            ENVenta nuevaVenta = new ENVenta(nV, productoBase.Precio, nV, usuario.Dni, "48627783X");
            nuevaVenta.InsertarVenta();
            ENLineaAdquisicion nuevaLinea = new ENLineaAdquisicion(nV, productoBase.IdProducto, 1);
            nuevaLinea.InsertarLineaAdquisicion();
        }

        protected void alquiler11_Click(object sender, EventArgs e)
        {
            ENProducto productoBase = new ENProducto();

            ENEmpleado empleado = new ENEmpleado();
            List<ENEmpleado> empleados = empleado.BuscarEmpleado();
            empleado = empleados[2];

            List<ENProducto> lProductes;
            lProductes = productoBase.BuscarProducto();
            productoBase.IdProducto = lProductes[11].IdProducto;
            productoBase.Precio = lProductes[11].Precio;

            CADAlquiler alq1 = new CADAlquiler();
            int numAlquileres = alq1.CuentaAlquileres() + 1;
            string nA = numAlquileres.ToString();

            HttpCookie cookie = Request.Cookies["UserInfo"];
            ENCliente usuario = loadCookie(cookie);

            ENAlquiler nuevoAlquiler = new ENAlquiler(nA, productoBase.Precio, nA, usuario.Dni, empleado.Dni, DateTime.Today, DateTime.Today.AddDays(3), 3);
            nuevoAlquiler.InsertarAlquiler();

            ENLineaAdquisicion nuevaLinea = new ENLineaAdquisicion(nA, productoBase.IdProducto, 1);
            nuevaLinea.InsertarLineaAdquisicion();
        }

        /************************************************
         * ***************SERIES 12*********************
         * **********************************************/
        protected void venta12_Click(object sender, EventArgs e)
        {
            ENProducto productoBase = new ENProducto();



            ENEmpleado empleado = new ENEmpleado();
            List<ENEmpleado> empleados = empleado.BuscarEmpleado();
            empleado = empleados[3];

            List<ENProducto> lProductes;
            lProductes = productoBase.BuscarProducto();
            productoBase.IdProducto = lProductes[12].IdProducto;

            productoBase.Precio = lProductes[12].Precio;

            int numVentas = 0;
            CADVenta ven1 = new CADVenta();
            numVentas = ven1.CuentaVentas() + 1;
            string nV = numVentas.ToString();

            HttpCookie cookie = Request.Cookies["UserInfo"];
            ENCliente usuario = loadCookie(cookie);

            ENVenta nuevaVenta = new ENVenta(nV, productoBase.Precio, nV, usuario.Dni, "48627783X");
            nuevaVenta.InsertarVenta();
            ENLineaAdquisicion nuevaLinea = new ENLineaAdquisicion(nV, productoBase.IdProducto, 1);
            nuevaLinea.InsertarLineaAdquisicion();
        }

        protected void alquiler12_Click(object sender, EventArgs e)
        {
            ENProducto productoBase = new ENProducto();

            ENEmpleado empleado = new ENEmpleado();
            List<ENEmpleado> empleados = empleado.BuscarEmpleado();
            empleado = empleados[3];

            List<ENProducto> lProductes;
            lProductes = productoBase.BuscarProducto();
            productoBase.IdProducto = lProductes[12].IdProducto;
            productoBase.Precio = lProductes[12].Precio;

            CADAlquiler alq1 = new CADAlquiler();
            int numAlquileres = alq1.CuentaAlquileres() + 1;
            string nA = numAlquileres.ToString();

            HttpCookie cookie = Request.Cookies["UserInfo"];
            ENCliente usuario = loadCookie(cookie);

            ENAlquiler nuevoAlquiler = new ENAlquiler(nA, productoBase.Precio, nA, usuario.Dni, empleado.Dni, DateTime.Today, DateTime.Today.AddDays(3), 3);
            nuevoAlquiler.InsertarAlquiler();

            ENLineaAdquisicion nuevaLinea = new ENLineaAdquisicion(nA, productoBase.IdProducto, 1);
            nuevaLinea.InsertarLineaAdquisicion();
        }

        /************************************************
         * ***************SERIES 13*********************
         * **********************************************/
        protected void venta13_Click(object sender, EventArgs e)
        {
            ENProducto productoBase = new ENProducto();



            ENEmpleado empleado = new ENEmpleado();
            List<ENEmpleado> empleados = empleado.BuscarEmpleado();
            empleado = empleados[4];

            List<ENProducto> lProductes;
            lProductes = productoBase.BuscarProducto();
            productoBase.IdProducto = lProductes[13].IdProducto;

            productoBase.Precio = lProductes[13].Precio;

            int numVentas = 0;
            CADVenta ven1 = new CADVenta();
            numVentas = ven1.CuentaVentas() + 1;
            string nV = numVentas.ToString();

            HttpCookie cookie = Request.Cookies["UserInfo"];
            ENCliente usuario = loadCookie(cookie);

            ENVenta nuevaVenta = new ENVenta(nV, productoBase.Precio, nV, usuario.Dni, "48627783X");
            nuevaVenta.InsertarVenta();
            ENLineaAdquisicion nuevaLinea = new ENLineaAdquisicion(nV, productoBase.IdProducto, 1);
            nuevaLinea.InsertarLineaAdquisicion();
        }

        protected void alquiler13_Click(object sender, EventArgs e)
        {
            ENProducto productoBase = new ENProducto();

            ENEmpleado empleado = new ENEmpleado();
            List<ENEmpleado> empleados = empleado.BuscarEmpleado();
            empleado = empleados[4];

            List<ENProducto> lProductes;
            lProductes = productoBase.BuscarProducto();
            productoBase.IdProducto = lProductes[13].IdProducto;
            productoBase.Precio = lProductes[13].Precio;

            CADAlquiler alq1 = new CADAlquiler();
            int numAlquileres = alq1.CuentaAlquileres() + 1;
            string nA = numAlquileres.ToString();

            HttpCookie cookie = Request.Cookies["UserInfo"];
            ENCliente usuario = loadCookie(cookie);

            ENAlquiler nuevoAlquiler = new ENAlquiler(nA, productoBase.Precio, nA, usuario.Dni, empleado.Dni, DateTime.Today, DateTime.Today.AddDays(3), 3);
            nuevoAlquiler.InsertarAlquiler();

            ENLineaAdquisicion nuevaLinea = new ENLineaAdquisicion(nA, productoBase.IdProducto, 1);
            nuevaLinea.InsertarLineaAdquisicion();
        }
    }
}