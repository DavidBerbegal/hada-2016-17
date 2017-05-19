<%@ Page Title="" Language="C#" MasterPageFile="~/app/Site1.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="hadaflix.app.Carrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 
<style type="text/css">
* {  
    padding: 0;  
    margin: 0;  
}  
   
body {  
    font: 11px Tahoma;  
}  
   
h1 {  
    font: bold 32px Times;  
    color: #666;  
    text-align: center;  
    padding: 20px 0;  
}  
   
#container {  
    width: 700px;  
    margin: 10px auto;  
}  
   
.mGrid {  
    width: 100%;  
    background-color: #fff;  
    margin: 5px 0 10px 0;  
    border: solid 1px #525252;  
    border-collapse: collapse;  
}  
   
.mGrid td {  
    padding: 2px;  
    border: solid 1px #c1c1c1;  
    color: #717171;  
}  
   
.mGrid th {  
    padding: 4px 2px;  
    color: #fff;  
    background: #424242 url(grd_head.png) repeat-x top;  
    border-left: solid 1px #525252;  
    font-size: 0.9em;  
}  
   
.mGrid .alt {  
    background: #fcfcfc url(grd_alt.png) repeat-x top;  
}  
   
.mGrid .pgr {  
    background: #424242 url(grd_pgr.png) repeat-x top;  
}  
   
.mGrid .pgr table {  
    margin: 5px 0;  
}  
   
.mGrid .pgr td {  
    border-width: 0;  
    padding: 0 6px;  
    border-left: solid 1px #666;  
    font-weight: bold;  
    color: #fff;  
    line-height: 12px;  
}  
   
.mGrid .pgr a {  
    color: #666;  
    text-decoration: none;  
}  
   
.mGrid .pgr a:hover {  
    color: #000;  
    text-decoration: none;  
} 

.image {
    background-image: url('img/login1.jpg');
    width: 100%;
    height: 100%;
    position: absolute;
    background-size: cover;
}
    </style>

 <div class ="image">
  <div class="container projects">
    <div class="row">
      <div class="col-xs-12">
        <div class="page-header">
          <h1 class="text-center">Tu Carrito</h1>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1"
                AllowPaging="True" CssClass="mGrid" PagerStyle-CssClass="pgr" AlternatingRowStyle-CssClass="alt" 
                PageSize="7">
                <Columns>
                    <asp:BoundField DataField="titulo" HeaderText="titulo" SortExpression="titulo" />
                    <asp:BoundField DataField="precio" HeaderText="precio" SortExpression="precio" />
                    <asp:BoundField DataField="tipo" HeaderText="tipo" SortExpression="tipo" />
                    <asp:BoundField DataField="cantidad" HeaderText="cantidad" SortExpression="cantidad" />
                    <asp:BoundField DataField="subtotal" HeaderText="subtotal" SortExpression="subtotal" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT lineaadquisicion.codadquisicion, lineaadquisicion.codproducto, productos.titulo, productos.precio, adquisicion.tipo, lineaadquisicion.cantidad, lineaadquisicion.subtotal FROM lineaadquisicion INNER JOIN adquisicion ON lineaadquisicion.codadquisicion = adquisicion.codventa INNER JOIN productos ON lineaadquisicion.codproducto = productos.idproducto ORDER BY adquisicion.tipo"></asp:SqlDataSource>
            <br />
            <br />
                     <asp:Button ID="Pago"  Text="Realizar Compra" CssClass="tag" OnClick="buttonpago" runat ="server" />
                     <asp:Button ID="Cancelar"  Text="Cancelar Compra" CssClass="tag" OnClick="buttoncancelar" runat ="server" />
        </div>
      </div>
    </div>
  </div>

</asp:Content>