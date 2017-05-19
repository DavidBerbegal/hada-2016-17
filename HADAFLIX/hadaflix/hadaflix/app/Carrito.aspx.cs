using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Biblioteca;
using System.Windows.Forms;
using System.Data;

namespace hadaflix.app
{
    public partial class Carrito : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void buttonsuma1_Click(object sender, EventArgs e)
        {
            
        }

        protected void buttonpago(object sender, EventArgs e)
        {

            Response.Redirect("Pago.aspx");

        }

        protected void buttoncancelar(object sender, EventArgs e)
        {
            ENLineaAdquisicion adq = new ENLineaAdquisicion();
            adq.EliminarAdquisiciones();

            Response.Redirect("Carrito.aspx");

        }

        protected void BindGrid()
        {
            GridView1.DataSource = ViewState["dt"] as DataTable;
            GridView1.DataBind();
        }
    }
}