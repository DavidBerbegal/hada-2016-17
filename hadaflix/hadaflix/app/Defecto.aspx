<%@ Page Title="" Language="C#" MasterPageFile="~/app/Site1.Master" AutoEventWireup="true" CodeBehind="Defecto.aspx.cs" Inherits="hadaflix.app.Defecto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="image" id="splash_screen">
  <div class="shade">

  </div>
</div>

<div class="container splash_screen">
  <div class="row text-center">
    <div class="col-xs-12">
      <div class="page-header">
        <h1 class="name animated fadeInDown">HADAFLIX</h1>
        <h1 class="description animated fadeIn"><small><em>Tu videoclub de confianza</em></small></h1>
      </div>
    </div>
  </div>

  <div class="row">
    <div class="col-xs-12 text-center icons">
      <a href="https://github.com/DavidBerbegal/hada-2016-17" target="_blank">
        <i class="fa fa-github fa-2x"></i>
      </a>

      <a href="https://www.dropbox.com/" target="_blank">
        <i class="fa fa-dropbox fa-2x"></i>
      </a>

      <a href="https://www.linkedin.com/" target="_blank">
        <i class="fa fa-linkedin fa-2x"></i>
      </a>

      <a href="https://www.ua.es/" target="_blank">
        <i class="fa fa-university fa-2x"></i>
      </a>
    </div>
  </div>
</div>
<!-- End Splash Screen -->
</asp:Content>
