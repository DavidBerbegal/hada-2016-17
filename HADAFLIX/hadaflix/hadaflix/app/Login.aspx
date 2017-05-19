<%@ Page Title="" Language="C#" MasterPageFile="~/app/Site2.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="hadaflix.app.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
                <h1>HADAFLIX</h1>
        <div class ="image">
        <div class="main-form">
            <i class="logo"></i>
                <asp:TextBox ID="textuser" CssClass="input" placeholder="User Name" runat="server"></asp:TextBox><br /><br />
                <asp:TextBox ID="textpass" CssClass="input" placeholder="Password" TextMode="Password"
                runat="server"></asp:TextBox><br /><br />
              <label>
                <input type="checkbox"> Remember me
              </label>
                <asp:Button ID="btnlogin" CssClass="input" Width="100%" runat="server" Text="Login" OnClick="btnlogin_Click1" />
              <a href="Contraseña.aspx" title="">Forgot your password?</a>
              <div>
                <label>Don't have an account?</label>
                <a href="Registrar.aspx" title="">Sign Up</a>
              </div>
            </div>
            </div>
</asp:Content>
