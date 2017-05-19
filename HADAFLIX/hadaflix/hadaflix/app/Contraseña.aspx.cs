using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Biblioteca;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace hadaflix.app
{
    public partial class Contraseña : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEmail_Click1(object sender, EventArgs e)
        {
            string nombre = "";
            string contraseñaValida = "";
            string apellido = "";
            ENCliente cliente = new ENCliente();
            List<ENCliente> lClientes;
            bool correu = false;

            lClientes = cliente.BuscarCliente();

            for (int i = 0; i < lClientes.Count && correu == false; i++)
            {

                if (correoTextBox.Text == lClientes[i].Mail)
                {
                    nombre = lClientes[i].Nombre;
                    contraseñaValida = lClientes[i].Contraseña;
                    apellido = lClientes[i].Apellidos;
                    correu = true;
                }

            }

            if (correu == true)
            {

                MailMessage msj = new MailMessage();
                SmtpClient cli = new SmtpClient();
                String email = correoTextBox.Text;


                msj.From = new MailAddress("hadaflix@gmail.com");
                msj.To.Add(new MailAddress(email));
                msj.Subject = "Bienvenido";
                string cuerpo = "Hola " + nombre.ToString() + " " + apellido.ToString() + "\nbienvenido a HADAFLIX\n" + "Su contraseña es: " + contraseñaValida.ToString();
                msj.Body = cuerpo;
                msj.IsBodyHtml = false;

                cli.Host = "smtp.gmail.com";
                cli.UseDefaultCredentials = true;
                cli.Port = 587;
                cli.Credentials = new NetworkCredential("hadaflix@gmail.com", "hadaflix1234");
                cli.EnableSsl = true;
                cli.Send(msj);
                MessageBox.Show("REVISE SU CORREO. \n       GRACIAS", "HADAFLIX!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                correoTextBox.Text = "";

                Response.Redirect("Login.aspx");
            }

            else
            {
                MessageBox.Show("Correo electrónico no encontrado", "Comprobar Correo Electrónico", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                Response.Redirect("Contraseña.aspx");
            }
        }
    }
}