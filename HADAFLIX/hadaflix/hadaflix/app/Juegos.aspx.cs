using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Biblioteca;

namespace hadaflix.app
{
    public partial class Juegos : System.Web.UI.Page
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

            Juego0.ImageUrl = lProductes[14].Imagen;
            Juego1.ImageUrl = lProductes[15].Imagen;
            Juego2.ImageUrl = lProductes[16].Imagen;
            Juego3.ImageUrl = lProductes[17].Imagen;
            Juego4.ImageUrl = lProductes[18].Imagen;


            Titul0.Text = lProductes[14].Titulo;
            Titul1.Text = lProductes[15].Titulo;
            Titul2.Text = lProductes[16].Titulo;
            Titul3.Text = lProductes[17].Titulo;
            Titul4.Text = lProductes[18].Titulo;


            Descripcio0.Text = lProductes[14].Descripcion;
            Descripcio1.Text = lProductes[15].Descripcion;
            Descripcio2.Text = lProductes[16].Descripcion;
            Descripcio3.Text = lProductes[17].Descripcion;
            Descripcio4.Text = lProductes[18].Descripcion;


            Edad0.Text = lProductes[14].EdadRecomendada.ToString();
            Edad1.Text = lProductes[15].EdadRecomendada.ToString();
            Edad2.Text = lProductes[16].EdadRecomendada.ToString();
            Edad3.Text = lProductes[17].EdadRecomendada.ToString();
            Edad4.Text = lProductes[18].EdadRecomendada.ToString();


            Director0.Text = lProductes[14].Director;
            Director1.Text = lProductes[15].Director;
            Director2.Text = lProductes[16].Director;
            Director3.Text = lProductes[17].Director;
            Director4.Text = lProductes[18].Director;


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
         * ***************JUEGO 14*********************
         * **********************************************/
        protected void venta14_Click(object sender, EventArgs e)
        {
            ENProducto productoBase = new ENProducto();



            ENEmpleado empleado = new ENEmpleado();
            List<ENEmpleado> empleados = empleado.BuscarEmpleado();
            empleado = empleados[0];

            List<ENProducto> lProductes;
            lProductes = productoBase.BuscarProducto();
            productoBase.IdProducto = lProductes[14].IdProducto;

            productoBase.Precio = lProductes[14].Precio;

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

        protected void alquiler14_Click(object sender, EventArgs e)
        {
            ENProducto productoBase = new ENProducto();

            ENEmpleado empleado = new ENEmpleado();
            List<ENEmpleado> empleados = empleado.BuscarEmpleado();
            empleado = empleados[0];

            List<ENProducto> lProductes;
            lProductes = productoBase.BuscarProducto();
            productoBase.IdProducto = lProductes[14].IdProducto;
            productoBase.Precio = lProductes[14].Precio;

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
         * ***************JUEGO 15*********************
         * **********************************************/
        protected void venta15_Click(object sender, EventArgs e)
        {
            ENProducto productoBase = new ENProducto();



            ENEmpleado empleado = new ENEmpleado();
            List<ENEmpleado> empleados = empleado.BuscarEmpleado();
            empleado = empleados[1];

            List<ENProducto> lProductes;
            lProductes = productoBase.BuscarProducto();
            productoBase.IdProducto = lProductes[15].IdProducto;

            productoBase.Precio = lProductes[15].Precio;

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

        protected void alquiler15_Click(object sender, EventArgs e)
        {
            ENProducto productoBase = new ENProducto();

            ENEmpleado empleado = new ENEmpleado();
            List<ENEmpleado> empleados = empleado.BuscarEmpleado();
            empleado = empleados[1];

            List<ENProducto> lProductes;
            lProductes = productoBase.BuscarProducto();
            productoBase.IdProducto = lProductes[15].IdProducto;
            productoBase.Precio = lProductes[15].Precio;

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
         * ***************JUEGO 16*********************
         * **********************************************/
        protected void venta16_Click(object sender, EventArgs e)
        {
            ENProducto productoBase = new ENProducto();



            ENEmpleado empleado = new ENEmpleado();
            List<ENEmpleado> empleados = empleado.BuscarEmpleado();
            empleado = empleados[2];

            List<ENProducto> lProductes;
            lProductes = productoBase.BuscarProducto();
            productoBase.IdProducto = lProductes[16].IdProducto;

            productoBase.Precio = lProductes[16].Precio;

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

        protected void alquiler16_Click(object sender, EventArgs e)
        {
            ENProducto productoBase = new ENProducto();

            ENEmpleado empleado = new ENEmpleado();
            List<ENEmpleado> empleados = empleado.BuscarEmpleado();
            empleado = empleados[2];

            List<ENProducto> lProductes;
            lProductes = productoBase.BuscarProducto();
            productoBase.IdProducto = lProductes[16].IdProducto;
            productoBase.Precio = lProductes[16].Precio;

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
         * ***************JUEGO 17*********************
         * **********************************************/
        protected void venta17_Click(object sender, EventArgs e)
        {
            ENProducto productoBase = new ENProducto();



            ENEmpleado empleado = new ENEmpleado();
            List<ENEmpleado> empleados = empleado.BuscarEmpleado();
            empleado = empleados[3];

            List<ENProducto> lProductes;
            lProductes = productoBase.BuscarProducto();
            productoBase.IdProducto = lProductes[17].IdProducto;

            productoBase.Precio = lProductes[17].Precio;

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

        protected void alquiler17_Click(object sender, EventArgs e)
        {
            ENProducto productoBase = new ENProducto();

            ENEmpleado empleado = new ENEmpleado();
            List<ENEmpleado> empleados = empleado.BuscarEmpleado();
            empleado = empleados[3];

            List<ENProducto> lProductes;
            lProductes = productoBase.BuscarProducto();
            productoBase.IdProducto = lProductes[17].IdProducto;
            productoBase.Precio = lProductes[17].Precio;

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
         * ***************JUEGO 18*********************
         * **********************************************/
        protected void venta18_Click(object sender, EventArgs e)
        {
            ENProducto productoBase = new ENProducto();



            ENEmpleado empleado = new ENEmpleado();
            List<ENEmpleado> empleados = empleado.BuscarEmpleado();
            empleado = empleados[4];

            List<ENProducto> lProductes;
            lProductes = productoBase.BuscarProducto();
            productoBase.IdProducto = lProductes[18].IdProducto;

            productoBase.Precio = lProductes[18].Precio;

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

        protected void alquiler18_Click(object sender, EventArgs e)
        {
            ENProducto productoBase = new ENProducto();

            ENEmpleado empleado = new ENEmpleado();
            List<ENEmpleado> empleados = empleado.BuscarEmpleado();
            empleado = empleados[4];

            List<ENProducto> lProductes;
            lProductes = productoBase.BuscarProducto();
            productoBase.IdProducto = lProductes[18].IdProducto;
            productoBase.Precio = lProductes[18].Precio;

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