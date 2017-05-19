using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;
using Biblioteca;
using System.Windows.Forms;

namespace hadaflix.app
{
    public partial class Pago : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RealizarPago_Click(object sender, EventArgs e)
        {
            string nombre = "";
            string contraseñaValida = "";
            string apellido = "";
            ENCliente cliente = new ENCliente();
            List<ENCliente> lClientes;
            ENLineaAdquisicion adq = new ENLineaAdquisicion();
            float subtotal = adq.subtotalcliente();
            bool pago = false;

            lClientes = cliente.BuscarCliente();

            for (int i = 0; i < lClientes.Count && pago == false; i++)
            {

                if (email.Text == lClientes[i].Mail)
                {
                    nombre = lClientes[i].Nombre;
                    contraseñaValida = lClientes[i].Contraseña;
                    apellido = lClientes[i].Apellidos;
                    pago = true;
                }

            }

            if (pago == true)
            {


                MailMessage msj = new MailMessage();
                SmtpClient cli = new SmtpClient();
                String correo = email.Text;


                msj.From = new MailAddress("hadaflix@gmail.com");
                msj.To.Add(new MailAddress(correo));
                msj.Subject = "Bienvenido";
                string cuerpo = "Hola " + nombre.ToString() + " " + apellido.ToString() + "\nbienvenido a HADAFLIX\n" + "El pago de " + subtotal.ToString("R") + " se ha realizado correctamente.";
                msj.Body = cuerpo;
                msj.IsBodyHtml = false;

                cli.Host = "smtp.gmail.com";
                cli.UseDefaultCredentials = true;
                cli.Port = 587;
                cli.Credentials = new NetworkCredential("hadaflix@gmail.com", "hadaflix1234");
                cli.EnableSsl = true;
                cli.Send(msj);
                MessageBox.Show("REVISE SU CORREO. \n       GRACIAS", "HADAFLIX!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                email.Text = "";

                ENLineaAdquisicion linia = new ENLineaAdquisicion();

                linia.EliminarAdquisiciones();

                Response.Redirect("Defecto.aspx");
            }

            else
            {
                MessageBox.Show("No se ha podido realizar el pago correctamente", "Pago", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                Response.Redirect("Pago.aspx");
            }
        }
    }
}