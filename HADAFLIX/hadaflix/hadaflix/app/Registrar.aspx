<%@ Page Title="" Language="C#" MasterPageFile="~/app/Site2.Master" AutoEventWireup="true" CodeBehind="Registrar.aspx.cs" Inherits="hadaflix.app.Registrar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
        <h1>HADAFLIX</h1>
        <div class ="image">
            <div class="clearfix">
	        <div class="col-md-4 col-xs-0 col-sm-3"></div>
		    <div class="col-md-4 col-xs-12 col-sm-6">
                <div class="panel">
                    <div class="row"><h2>Regístrate</h2></div>
				<div class="row">
                    <div class="col-sm-6"><asp:TextBox id="nombreTextBox" placeholder="Nombre" TextMode="SingleLine" Columns="30" runat="server" /></div>
                    <div class="col-sm-6"><asp:TextBox id="apellidosTextBox" placeholder="Apellidos" TextMode="SingleLine" Columns="30" runat="server"/></div>
                </div>
                <div class="row">
                    <div class="col-sm-6"><asp:TextBox id="edadTextBox" placeholder="Edad (+ 18)" TextMode="SingleLine" Columns="30" runat="server"/></div>
                    <div class="col-sm-6"><asp:TextBox id="fechanacTextBox" placeholder="Fecha Nacimiento" TextMode="SingleLine" Columns="30" runat="server"/></div>
                </div>
                                                    <asp:ScriptManager ID="ScriptManager2" runat="server"></asp:ScriptManager>
                                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                <div class="row">
                    <div class="col-sm-12"><asp:TextBox id="mailTextBox" placeholder="Email" TextMode="SingleLine" Columns="30" runat="server" AutoPostBack="True" OnTextChanged="mailTextBox_TextChanged"/></div>
                </div>

                <div class="row">
                    <div class="col-sm-6"><asp:TextBox id="direccionTextBox" placeholder="Direccion" TextMode="SingleLine" Columns="30" runat="server"/></div>
                    <div class="col-sm-6"><asp:TextBox id="provinciaTextBox" placeholder="Provincia" TextMode="SingleLine" Columns="30" runat="server"/></div>
                </div>
                <div class="row">
                    <div class="col-sm-6"><asp:TextBox id="poblacionTextBox" placeholder="Poblacion" TextMode="SingleLine" Columns="30" runat="server"/></div>
                    <div class="col-sm-6"><asp:TextBox id="paisTextBox" placeholder="Pais" TextMode="SingleLine" Columns="30" runat="server"/></div>
                </div>
                <div class="row">
                    <div class="col-sm-6"><asp:TextBox id="codposTextBox"  placeholder="Codigo Postal" TextMode="SingleLine" Columns="30" runat="server"/></div>
                    <div class="col-sm-6"><asp:TextBox id="telTextBox"  placeholder="Numero de telefono" TextMode="SingleLine" Columns="30" runat="server"/></div>
                </div>

                <div class="row">
                    <div class="col-sm-6"><asp:TextBox id="txt_username" placeholder="Username" TextMode="SingleLine" Columns="30" runat="server" AutoPostBack="True"  OnTextChanged="usernameTextBox_TextChanged"/></div>
                    <div class="col-sm-6"><asp:TextBox id="passTextBox" placeholder="Contraseña" TextMode="Password" Columns="30" runat="server"/></div>
                </div>
                                        <div class="ajaxsContenedor" <asp:Label ID="label_message" runat="server" CssClass="ajaxs"></asp:Label></div>
                    <div class="ajaxsContenedor" <asp:Label ID="label_message2" runat="server" CssClass="ajaxs"></asp:Label></div>

                                                    </ContentTemplate>
            </asp:UpdatePanel>
                    <div class="row">
                    <div class="col-sm-12"><asp:Button ID="btnRegistro" CssClass="input" runat="server" Text="Registrarse" OnClick="btnRegistro_Click1" /></div>
                </div>



                    
               </div>
        </div>
    </div>  
</div>

</asp:Content>
