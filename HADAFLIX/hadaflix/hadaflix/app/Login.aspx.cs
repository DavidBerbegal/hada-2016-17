using Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;


namespace hadaflix.app
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click1(object sender, EventArgs e)
        {
            
            bool logeado = false;
            
            ENCliente cliente = new ENCliente();
            List<ENCliente> lClientes;

            lClientes = cliente.BuscarCliente();
            
            for (int i = 0; i < lClientes.Count && logeado == false; i++)
            {
                
                if(textuser.Text == lClientes[i].Dni && textpass.Text == lClientes[i].Contraseña)
                {
                    logeado = true;

                    HttpCookie cookie = new HttpCookie("UserInfo");

                    cookie["Name"] = textuser.Text;
                    cookie["Password"] = textpass.Text;

                    Response.Cookies.Add(cookie);

                }
                
            }
           
            if(logeado == true)
            {
                ENLineaAdquisicion adq = new ENLineaAdquisicion();
                adq.EliminarAdquisiciones();

                Response.Redirect("Defecto.aspx");
            }

            else
            {
                MessageBox.Show("Nombre de usuario o Contraseña Incorrectos", "Login", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}