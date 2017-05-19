using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Biblioteca;
using System.Drawing;
using System.Windows.Forms;

namespace hadaflix.app
{
    public partial class Peliculas : System.Web.UI.Page
    {

        /*
        public string getId()
        {
            string htmlCadena = "";
            ENProducto producto = new ENProducto();
            List<ENProducto> lProductes;


            lProductes = producto.BuscarProducto();
            int i;

                    htmlCadena += Server.HtmlEncode("<a href =\"\" target=\"_blank\" data-toggle=\"modal\" data-target=\"#serviceModal1\">" +
                                     "<div class=\"col-md-3 col-xs-6 col-sm-3\">" +
                                         "<div class=\"thumbnail\">" +
                                             "<asp:ImageButton id=\"Foto" + 0.ToString() + "\" TextMode =\"MultiLine\" Columns =\"30\" Rows =\"10\" runat =\"server\">" +
                                             "</asp:ImageButton>" +
                                         "</div>" +
                                     "</div>" +
                                 "</a>");


            return htmlCadena;
        }
        */
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

            Pelicula0.ImageUrl = lProductes[0].Imagen;
            Pelicula1.ImageUrl = lProductes[1].Imagen;
            Pelicula2.ImageUrl = lProductes[2].Imagen;
            
            Pelicula3.ImageUrl = lProductes[3].Imagen;
            Pelicula4.ImageUrl = lProductes[4].Imagen;
            Pelicula5.ImageUrl = lProductes[5].Imagen;
            Pelicula6.ImageUrl = lProductes[6].Imagen;
            Pelicula7.ImageUrl = lProductes[7].Imagen;
            Pelicula8.ImageUrl = lProductes[8].Imagen;
       
            Titul0.Text = lProductes[0].Titulo;
            Titul1.Text = lProductes[1].Titulo;
            Titul2.Text = lProductes[2].Titulo;
            
            Titul3.Text = lProductes[3].Titulo;

            Titul4.Text = lProductes[4].Titulo;
            Titul5.Text = lProductes[5].Titulo;
            Titul6.Text = lProductes[6].Titulo;
            Titul7.Text = lProductes[7].Titulo;
            Titul8.Text = lProductes[8].Titulo;
            
            
            Director0.Text = lProductes[0].Director;
            Director1.Text = lProductes[1].Director;
            Director2.Text = lProductes[2].Director;
            
           
            Director3.Text = lProductes[3].Director;
            Director4.Text = lProductes[4].Director;
            Director5.Text = lProductes[5].Director;
            Director6.Text = lProductes[6].Director;
            Director7.Text = lProductes[7].Director;
            Director8.Text = lProductes[8].Director;
             

            Edad0.Text = lProductes[0].EdadRecomendada.ToString();
            Edad1.Text = lProductes[1].EdadRecomendada.ToString();
            Edad2.Text = lProductes[2].EdadRecomendada.ToString();
            
            Edad3.Text = lProductes[3].EdadRecomendada.ToString();
            Edad4.Text = lProductes[4].EdadRecomendada.ToString();
            Edad5.Text = lProductes[5].EdadRecomendada.ToString();
            Edad6.Text = lProductes[6].EdadRecomendada.ToString();
            Edad7.Text = lProductes[7].EdadRecomendada.ToString();
            Edad8.Text = lProductes[8].EdadRecomendada.ToString();
            Descripcio0.Text = lProductes[0].Descripcion;
            Descripcio1.Text = lProductes[1].Descripcion;
            Descripcio2.Text = lProductes[2].Descripcion;
            
            Descripcio3.Text = lProductes[3].Descripcion;
            Descripcio4.Text = lProductes[4].Descripcion;
            Descripcio5.Text = lProductes[5].Descripcion;
            Descripcio6.Text = lProductes[6].Descripcion;
            Descripcio7.Text = lProductes[7].Descripcion;
            Descripcio8.Text = lProductes[8].Descripcion;           
            
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
         * ***************PELICULA 0*********************
         * **********************************************/
        protected void venta0_Click(object sender, EventArgs e)
        {
            ENProducto productoBase = new ENProducto();



            ENEmpleado empleado = new ENEmpleado();
            List<ENEmpleado> empleados = empleado.BuscarEmpleado();
            empleado = empleados[0];

            List<ENProducto> lProductes;
            lProductes = productoBase.BuscarProducto();
            productoBase.IdProducto = lProductes[0].IdProducto;

            productoBase.Precio = lProductes[0].Precio;

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

        protected void alquiler0_Click(object sender, EventArgs e)
        {
            ENProducto productoBase = new ENProducto();

            ENEmpleado empleado = new ENEmpleado();
            List<ENEmpleado> empleados = empleado.BuscarEmpleado();
            empleado = empleados[0];

            List<ENProducto> lProductes;
            lProductes = productoBase.BuscarProducto();
            productoBase.IdProducto = lProductes[0].IdProducto;
            productoBase.Precio = lProductes[0].Precio;

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
        * ***************PELICULA 1*********************
        * **********************************************/
        protected void venta1_Click(object sender, EventArgs e)
        {
            ENProducto productoBase = new ENProducto();



            ENEmpleado empleado = new ENEmpleado();
            List<ENEmpleado> empleados = empleado.BuscarEmpleado();
            empleado = empleados[1];

            List<ENProducto> lProductes;
            lProductes = productoBase.BuscarProducto();
            productoBase.IdProducto = lProductes[1].IdProducto;

            productoBase.Precio = lProductes[1].Precio;

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

        protected void alquiler1_Click(object sender, EventArgs e)
        {
            ENProducto productoBase = new ENProducto();

            ENEmpleado empleado = new ENEmpleado();
            List<ENEmpleado> empleados = empleado.BuscarEmpleado();
            empleado = empleados[1];

            List<ENProducto> lProductes;
            lProductes = productoBase.BuscarProducto();
            productoBase.IdProducto = lProductes[1].IdProducto;
            productoBase.Precio = lProductes[1].Precio;

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
       * ***************PELICULA 2*********************
       * **********************************************/
        protected void venta2_Click(object sender, EventArgs e)
        {
            ENProducto productoBase = new ENProducto();



            ENEmpleado empleado = new ENEmpleado();
            List<ENEmpleado> empleados = empleado.BuscarEmpleado();
            empleado = empleados[2];

            List<ENProducto> lProductes;
            lProductes = productoBase.BuscarProducto();
            productoBase.IdProducto = lProductes[2].IdProducto;

            productoBase.Precio = lProductes[2].Precio;

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

        protected void alquiler2_Click(object sender, EventArgs e)
        {
            ENProducto productoBase = new ENProducto();

            ENEmpleado empleado = new ENEmpleado();
            List<ENEmpleado> empleados = empleado.BuscarEmpleado();
            empleado = empleados[2];

            List<ENProducto> lProductes;
            lProductes = productoBase.BuscarProducto();
            productoBase.IdProducto = lProductes[2].IdProducto;
            productoBase.Precio = lProductes[2].Precio;

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
       * ***************PELICULA 3*********************
       * **********************************************/
        protected void venta3_Click(object sender, EventArgs e)
        {
            ENProducto productoBase = new ENProducto();



            ENEmpleado empleado = new ENEmpleado();
            List<ENEmpleado> empleados = empleado.BuscarEmpleado();
            empleado = empleados[3];

            List<ENProducto> lProductes;
            lProductes = productoBase.BuscarProducto();
            productoBase.IdProducto = lProductes[3].IdProducto;

            productoBase.Precio = lProductes[3].Precio;

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

        protected void alquiler3_Click(object sender, EventArgs e)
        {
            ENProducto productoBase = new ENProducto();

            ENEmpleado empleado = new ENEmpleado();
            List<ENEmpleado> empleados = empleado.BuscarEmpleado();
            empleado = empleados[3];

            List<ENProducto> lProductes;
            lProductes = productoBase.BuscarProducto();
            productoBase.IdProducto = lProductes[3].IdProducto;
            productoBase.Precio = lProductes[3].Precio;

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
       * ***************PELICULA 4*********************
       * **********************************************/
        protected void venta4_Click(object sender, EventArgs e)
        {
            ENProducto productoBase = new ENProducto();



            ENEmpleado empleado = new ENEmpleado();
            List<ENEmpleado> empleados = empleado.BuscarEmpleado();
            empleado = empleados[4];

            List<ENProducto> lProductes;
            lProductes = productoBase.BuscarProducto();
            productoBase.IdProducto = lProductes[4].IdProducto;

            productoBase.Precio = lProductes[4].Precio;

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

        protected void alquiler4_Click(object sender, EventArgs e)
        {
            ENProducto productoBase = new ENProducto();

            ENEmpleado empleado = new ENEmpleado();
            List<ENEmpleado> empleados = empleado.BuscarEmpleado();
            empleado = empleados[4];

            List<ENProducto> lProductes;
            lProductes = productoBase.BuscarProducto();
            productoBase.IdProducto = lProductes[4].IdProducto;
            productoBase.Precio = lProductes[4].Precio;

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
       * ***************PELICULA 5*********************
       * **********************************************/
        protected void venta5_Click(object sender, EventArgs e)
        {
            ENProducto productoBase = new ENProducto();



            ENEmpleado empleado = new ENEmpleado();
            List<ENEmpleado> empleados = empleado.BuscarEmpleado();
            empleado = empleados[0];

            List<ENProducto> lProductes;
            lProductes = productoBase.BuscarProducto();
            productoBase.IdProducto = lProductes[5].IdProducto;

            productoBase.Precio = lProductes[5].Precio;

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

        protected void alquiler5_Click(object sender, EventArgs e)
        {
            ENProducto productoBase = new ENProducto();

            ENEmpleado empleado = new ENEmpleado();
            List<ENEmpleado> empleados = empleado.BuscarEmpleado();
            empleado = empleados[0];

            List<ENProducto> lProductes;
            lProductes = productoBase.BuscarProducto();
            productoBase.IdProducto = lProductes[5].IdProducto;
            productoBase.Precio = lProductes[5].Precio;

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
       * ***************PELICULA 6*********************
       * **********************************************/
        protected void venta6_Click(object sender, EventArgs e)
        {
            ENProducto productoBase = new ENProducto();



            ENEmpleado empleado = new ENEmpleado();
            List<ENEmpleado> empleados = empleado.BuscarEmpleado();
            empleado = empleados[1];

            List<ENProducto> lProductes;
            lProductes = productoBase.BuscarProducto();
            productoBase.IdProducto = lProductes[6].IdProducto;

            productoBase.Precio = lProductes[6].Precio;

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

        protected void alquiler6_Click(object sender, EventArgs e)
        {
            ENProducto productoBase = new ENProducto();

            ENEmpleado empleado = new ENEmpleado();
            List<ENEmpleado> empleados = empleado.BuscarEmpleado();
            empleado = empleados[1];

            List<ENProducto> lProductes;
            lProductes = productoBase.BuscarProducto();
            productoBase.IdProducto = lProductes[6].IdProducto;
            productoBase.Precio = lProductes[6].Precio;

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
       * ***************PELICULA 7*********************
       * **********************************************/
        protected void venta7_Click(object sender, EventArgs e)
        {
            ENProducto productoBase = new ENProducto();



            ENEmpleado empleado = new ENEmpleado();
            List<ENEmpleado> empleados = empleado.BuscarEmpleado();
            empleado = empleados[2];

            List<ENProducto> lProductes;
            lProductes = productoBase.BuscarProducto();
            productoBase.IdProducto = lProductes[7].IdProducto;

            productoBase.Precio = lProductes[7].Precio;

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

        protected void alquiler7_Click(object sender, EventArgs e)
        {
            ENProducto productoBase = new ENProducto();

            ENEmpleado empleado = new ENEmpleado();
            List<ENEmpleado> empleados = empleado.BuscarEmpleado();
            empleado = empleados[2];

            List<ENProducto> lProductes;
            lProductes = productoBase.BuscarProducto();
            productoBase.IdProducto = lProductes[7].IdProducto;
            productoBase.Precio = lProductes[7].Precio;

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
       * ***************PELICULA 8*********************
       * **********************************************/
        protected void venta8_Click(object sender, EventArgs e)
        {
            ENProducto productoBase = new ENProducto();



            ENEmpleado empleado = new ENEmpleado();
            List<ENEmpleado> empleados = empleado.BuscarEmpleado();
            empleado = empleados[3];

            List<ENProducto> lProductes;
            lProductes = productoBase.BuscarProducto();
            productoBase.IdProducto = lProductes[8].IdProducto;

            productoBase.Precio = lProductes[8].Precio;

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

        protected void alquiler8_Click(object sender, EventArgs e)
        {
            ENProducto productoBase = new ENProducto();

            ENEmpleado empleado = new ENEmpleado();
            List<ENEmpleado> empleados = empleado.BuscarEmpleado();
            empleado = empleados[3];

            List<ENProducto> lProductes;
            lProductes = productoBase.BuscarProducto();
            productoBase.IdProducto = lProductes[8].IdProducto;
            productoBase.Precio = lProductes[8].Precio;

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