using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Biblioteca;

namespace hadaflix.app
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["UserInfo"];

            if (cookie != null)
            {
                if (cookie["Name"] != null)
                {
                    Label1.Text = "Bienvenido, " + cookie["Name"];
                }
                loadCookie(cookie);

                //UserLink.Text = "Welcome, " + Session["UserDni"].ToString();
                /*
                LogOutLink.Text = "Log Out";
                LoginLink.Visible = false;
                SignupLink.Visible = false;
                LogInMotivator.Visible = false;
                OpenCorchete.Visible = false;
                CloseCorchete.Visible = false;
                */

            }
            else
            {
                UserLink.Visible = false;
                /*
                LogOutLink.Visible = false;
                SignupLink.Visible = true;
                LoginLink.Visible = true;
                LogInMotivator.Visible = true;
                */

            }

        }


        public static void loadCookie(HttpCookie userCookie)
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
        }

        protected void Cerrarsesion(object sender, EventArgs e)
        {
            Session.Abandon();
            Session.RemoveAll();
            Session.Clear();

            HttpCookie userOut = new HttpCookie("UserNickname");
            userOut.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(userOut);

            Response.Redirect("Login.aspx");
        }
    }
}