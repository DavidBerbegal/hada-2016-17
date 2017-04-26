<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="bbdd.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <div class="container">
        <div class="row">
            <div class="col-xs-8">
                <div id="custom-bootstrap-menu" class="navbar navbar-default navbar-fixed-top" role="navigation">
                    <div class="container">
                        <div class="navbar-header">
                            <a class="navbar-brand" href="#splash_screen">HADAFLIX</a>
                            <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-menubuilder">
                                <span class="sr-only">Toggle navigation</span><span class="icon-bar"></span><span class="icon-bar"></span><span class="icon-bar"></span>
                            </button>
                        </div>
                        <div class="collapse navbar-collapse navbar-menubuilder">
                            <ul class="nav navbar-nav navbar-right">
                                <li>
                                    <a href="#splash_screen">General</a>
                                </li>
                                <li>
                                    <a href="#projects">Películas</a>
                                </li>
                                <li>
                                    <a href="#projects_series">Series</a>
                                </li>
                                <li>
                                    <a href="#projects_juegos">Juegos</a>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.2/jquery.min.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.2/js/bootstrap.min.js"></script>
</asp:Content>
