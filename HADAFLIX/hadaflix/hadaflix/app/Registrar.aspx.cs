using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Biblioteca;
using System.Windows.Forms;

namespace hadaflix.app
{
    public partial class Registrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistro_Click1(object sender, EventArgs e)
        {

            bool usuari = false;
            bool email = false;
            bool registrado = true;
            int valor = 0;

            if(edadTextBox.Text != "")
            {
                valor = Int32.Parse(edadTextBox.Text);
            }

            ENCliente cliente = new ENCliente();
            List<ENCliente> lClientes;
            

            lClientes = cliente.BuscarCliente();

            for(int i = 0; i < lClientes.Count ;i++)
            {
                if(txt_username.Text == lClientes[i].Dni)
                {
                    usuari = true;
                }

                if(mailTextBox.Text == lClientes[i].Mail)
                {
                    email = true;
                }
            }

            if(usuari == true)
            {
                MessageBox.Show("Username ya utilizado", "Registro de datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                registrado = false;
            }

            if(email == true || contiene_espacios(mailTextBox.Text)==true)
            {
                MessageBox.Show("El correo electronico introducido ya esta registrado", "Registro de datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                registrado = false;
            }

            if (valor < 18)
            {
                MessageBox.Show("La edad no es la recomendada", "Registro de datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                registrado = false;
            }
            

            if(nombreTextBox.Text == "" || apellidosTextBox.Text == "" || edadTextBox.Text == "" || mailTextBox.Text == "" || direccionTextBox.Text == "" || 
               provinciaTextBox.Text == "" || poblacionTextBox.Text == "" || paisTextBox.Text == "" || codposTextBox.Text == "" || 
               fechanacTextBox.Text == "" || telTextBox.Text == "" || txt_username.Text == "" || passTextBox.Text == "")
            {
                MessageBox.Show("Alguno de los campos esta vacio", "Registro de datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                registrado = false;
            }

            if(registrado == true)
            {
                ENCliente nouClient = new ENCliente();

                nouClient.Dni = txt_username.Text;
                nouClient.NSocio = lClientes.Count;
                nouClient.Nombre = nombreTextBox.Text;
                nouClient.Apellidos = apellidosTextBox.Text;
                nouClient.Edad = valor;
                nouClient.Mail = mailTextBox.Text;
                nouClient.Direccion = direccionTextBox.Text;
                nouClient.Provincia = provinciaTextBox.Text;
                nouClient.Poblacion = poblacionTextBox.Text;
                nouClient.Pais = paisTextBox.Text;
                nouClient.CodPostal = codposTextBox.Text;
                nouClient.FechaNac = DateTime.Parse(fechanacTextBox.Text);
                nouClient.Telefono = telTextBox.Text;
                nouClient.Contraseña = passTextBox.Text;

                nouClient.InsertarCliente();
                MessageBox.Show("Registrado correctamente !! :)", "Registro de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Response.Redirect("Login.aspx");

            }
            
        }

        
        protected void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txt_username.Text))
            {
                DateTime da = new DateTime();
                ENCliente usuario1 = new ENCliente(txt_username.Text, 1, "", "", 23, "", ""
                , "", "", "", "", "", da, "");
                ENCliente usuario2 = new ENCliente();
                usuario2 = usuario1.getUserByNick();
                
                if (usuario2.Dni != "")
                {
                    label_message.Text = "Este usuario no está disponible";
                    label_message.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    label_message.Text = "Este usuario está disponible";
                    label_message.ForeColor = System.Drawing.Color.Green;
                }
            }

        }

        public bool contiene_espacios(string sentence)
        {
            bool contiene = false;
            for (int i=0;i<sentence.Length && contiene==false;i++)
            {
                if (sentence[i]==' ')
                {
                    contiene = true;
                }
            }
            return contiene;
        }

        protected void mailTextBox_TextChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(mailTextBox.Text))
            {
                DateTime da = new DateTime();
                ENCliente usuario1 = new ENCliente("", 1, "", "", 23, mailTextBox.Text, ""
                , "", "", "", "", "", da, "");
                List<ENCliente> lClientes;
                lClientes = usuario1.BuscarClienteMail();


                if (lClientes.Count > 0 && contiene_espacios(mailTextBox.Text)==false)
                {
                    label_message2.Text = "Este mail no está disponible";
                    label_message2.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    label_message2.Text = "Este mail está disponible";
                    label_message2.ForeColor = System.Drawing.Color.Green;
                }
            }

        }

    }
}