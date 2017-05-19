<%@ Page Title="" Language="C#" MasterPageFile="~/app/Site1.Master" AutoEventWireup="true" CodeBehind="Contactos.aspx.cs" Inherits="hadaflix.app.Contactos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Start Contact Me -->
     <div id="map"></div>
    <!-- End Contact Me -->
    <script>

      // This example displays a marker at the center of Australia.
      // When the user clicks the marker, an info window opens.
         
      function initMap() {
          var mimapa = { lat: 38.385867, lng: -0.512046 };
          var CentroMapa = { lat: 38.389, lng: -0.512046 };
        var map = new google.maps.Map(document.getElementById('map'), {
          zoom: 15,
          center: CentroMapa,
          mapTypeControl: true,
          mapTypeControlOptions: {
              style: google.maps.MapTypeControlStyle.HORIZONTAL_BAR,
              position: google.maps.ControlPosition.BOTTOM_CENTER
          },
          zoomControl: true,
          zoomControlOptions: {
              position: google.maps.ControlPosition.LEFT_CENTER
          },
          scaleControl: true,
          streetViewControl: true,
          streetViewControlOptions: {
              position: google.maps.ControlPosition.RIGHT_BOTTOM
          },
          fullscreenControl: true
        });

        var contentString = '<div id="content">' +
            '<div id="siteNotice">' +
            '</div>' +
            '<h1 id="firstHeading" class="firstHeading">HADAFLIX</h1>' +
            '<div id="bodyContent">' +
            '<p>Somo los creadores de <b>HADAFLIX</b>, puede contactar con ' +
            'nosotros de la siguiente forma:' +
            '<ol><p>gg52.alu@ua.es</p></ol>' +
            '<ol><p>jma86@alu.ua.es</p></ol>' +
            '<ol><p>jrl12@alu.ua.es</p></ol>' +
            '<ol><p>jrg81@alu.ua.es</p></ol>' +
            '<ol><p>dbe4@alu.ua.es</p></ol>' +
            '<p>Asignatura: Edificio 24 - Facultad De Educacion 1, <a href="http://www.dlsi.ua.es/eines/assig.cgi?id=cas&assig=HADA">' +
            'http://www.dlsi.ua.es/eines/assig.cgi?id=cas&assig=HADA</a> ' +
            '</p>' +
            '</div>' +
            '</div>';

        var infowindow = new google.maps.InfoWindow({
          content: contentString
        });

        var marker = new google.maps.Marker({
            position: mimapa,
          map: map,
          title: 'Edificio 24 - Facultad De Educacion 1'
        });
        marker.addListener('click', function() {
          infowindow.open(map, marker);
        });
      }
    </script>

</asp:Content>
