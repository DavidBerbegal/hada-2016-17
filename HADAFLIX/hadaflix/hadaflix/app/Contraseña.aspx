<%@ Page Title="" Language="C#" MasterPageFile="~/app/Site2.Master" AutoEventWireup="true" CodeBehind="Contraseña.aspx.cs" Inherits="hadaflix.app.Contraseña" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>HADAFLIX</h1>
        <div class ="image">
        <div class="main-form">
            <i class="logo"></i>
                <h2>No recuerdo mi contraseña</h2>
                <p>Introduce tu correo electronico: 
                    <asp:TextBox id="correoTextBox" TextMode="SingleLine" Columns="30" runat="server" />
                </p>
              <asp:Button ID="btnEmail" CssClass="input" Width="101%" runat="server" Text="Enviar" OnClick="btnEmail_Click1" />
            </div>
            </div>


</asp:Content>
