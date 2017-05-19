<%@ Page Title="" Language="C#" MasterPageFile="~/app/Site1.Master" AutoEventWireup="true" CodeBehind="Peliculas.aspx.cs" Inherits="hadaflix.app.Peliculas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="projects_image" id="projects">
  <div class="container projects">
    <div class="row">
      <div class="col-xs-12">
        <div class="page-header">
          <h1 class="text-center">Películas</h1>
        </div>
      </div>
    </div>

    <br />

    <div class="col-xs-12">

      <a href="" target="_blank" data-toggle="modal" data-target="#serviceModal0">
        <div class="col-md-3 col-xs-6 col-sm-3">
          <div class="thumbnail">
            <asp:ImageButton ID="Pelicula0" TextMode="MultiLine" Columns="30" Rows="10" runat="server" >

            </asp:ImageButton>
          </div>
        </div>
      </a>
	  
	  <a href="" target="_blank" data-toggle="modal" data-target="#serviceModal1">
        <div class="col-md-3 col-xs-6 col-sm-3">
          <div class="thumbnail">
            <asp:ImageButton id="Pelicula1" TextMode="MultiLine" Columns="30" Rows="10" runat="server" >
       
            </asp:ImageButton>
          </div>
        </div>
      </a>
	  
	  <a href="" target="_blank" data-toggle="modal" data-target="#serviceModal2">
        <div class="col-md-3 col-xs-6 col-sm-3">
          <div class="thumbnail">
            <asp:ImageButton id="Pelicula2" TextMode="MultiLine" Columns="30" Rows="10" runat="server" >

            </asp:ImageButton>
          </div>
        </div>
      </a>

      <a href="" target="_blank" data-toggle="modal" data-target="#serviceModal3">
        <div class="col-md-3 col-xs-6 col-sm-3">
          <div class="thumbnail">
            <asp:ImageButton id="Pelicula3" TextMode="MultiLine" Columns="30" Rows="10" runat="server" >

            </asp:ImageButton>
          </div>
        </div>
      </a>
	  
	  <a href="" target="_blank" data-toggle="modal" data-target="#serviceModal4">
        <div class="col-md-3 col-xs-6 col-sm-3">
          <div class="thumbnail">
            <asp:ImageButton id="Pelicula4" TextMode="MultiLine" Columns="30" Rows="10" runat="server" >

            </asp:ImageButton>
          </div>
        </div>
      </a>
	  
	  <a href="" target="_blank" data-toggle="modal" data-target="#serviceModal5">
        <div class="col-md-3 col-xs-6 col-sm-3">
          <div class="thumbnail">
            <asp:ImageButton id="Pelicula5" TextMode="MultiLine" Columns="30" Rows="10" runat="server" >

            </asp:ImageButton>
          </div>
        </div>
      </a>
	  
	  <a href="" target="_blank" data-toggle="modal" data-target="#serviceModal6">
        <div class="col-md-3 col-xs-6 col-sm-3">
          <div class="thumbnail">
            <asp:ImageButton id="Pelicula6" TextMode="MultiLine" Columns="30" Rows="10" runat="server">

            </asp:ImageButton>
          </div>
        </div>
      </a>

        
      <a href="" target="_blank" data-toggle="modal" data-target="#serviceModal7">
        <div class="col-md-3 col-xs-6 col-sm-3">
          <div class="thumbnail">
            <asp:ImageButton id="Pelicula7" TextMode="MultiLine" Columns="30" Rows="10" runat="server">

            </asp:ImageButton>
          </div>
        </div>
      </a>

      <a href="" target="_blank" data-toggle="modal" data-target="#serviceModal8">
        <div class="col-md-3 col-xs-6 col-sm-3">
          <div class="thumbnail">
            <asp:ImageButton id="Pelicula8" TextMode="MultiLine" Columns="30" Rows="10" runat="server" >
       
            </asp:ImageButton>
          </div>
        </div>
      </a>

    </div>
  </div>
</div>

 <div class="service-modal modal fade" id="serviceModal0" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
  <div class="modal-dialog" role="document">
    <div class="modal-content">	
      <div class="close-modal" data-dismiss="modal" aria-label="Close">
        <div class="close-icon">
            <div class="close-icon-r">
            </div>
        </div>
      </div>
		<a href="#"><img src="img/grease.jpg" alt="cover" class="cover" /></a>       
		<div class="hero">   
		  <div class="details">
			<div class="title1"><asp:Label ID="Titul0" runat="server"></asp:Label>
                <span class="pegi">PG-<asp:Label ID="Edad0" runat="server">
                                     </asp:Label></span>
			</div>
			<div class="title2"><asp:Label ID="Director0" runat="server"></asp:Label></div>    
		  </div> <!-- end details -->      
		</div> <!-- end hero -->    
		
		
		
		<div class="description">     
		  <div class="column1">
			<span class="tag"><asp:Button ID="Venta0" Width="100%" Text="Venta" runat="server" OnClick="venta0_Click"/></span>
			<span class="tag"><asp:Button ID="Alquiler0" Width="100%" Text="Alquiler" runat="server" OnClick="alquiler0_Click"/></span>
		  </div> <!-- end column1 -->
		  
		  <div class="col-md-9 col-xs-6 col-sm-8">
			<div class="col-md-12 col-xs-12 col-sm-12">
				<p><asp:Label ID="Descripcio0" runat="server"></asp:Label>  </p>
			</div>
		  </div> <!-- end column2 -->
		</div> <!-- end description -->
	  </div> <!-- end container -->
	</div> <!-- end movie-card -->
</div>


<!-- Service Modal 1 Creative -->
<div class="service-modal modal fade" id="serviceModal1" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
  <div class="modal-dialog" role="document">
    <div class="modal-content">	
      <div class="close-modal" data-dismiss="modal" aria-label="Close">
        <div class="close-icon">
            <div class="close-icon-r">
            </div>
        </div>
      </div>
		<a href="#"><img src="img/doctor.jpg" alt="cover" class="cover" /></a>       
		<div class="hero">   
		  <div class="details">
			<div class="title1"><asp:Label ID="Titul1" runat="server"></asp:Label>
                <span class="pegi">PG-<asp:Label ID="Edad1" runat="server">
                                     </asp:Label></span>
			</div>
			<div class="title2"><asp:Label ID="Director1" runat="server"></asp:Label></div>    
		  </div> <!-- end details -->      
		</div> <!-- end hero -->    
		
		
		
		<div class="description">     
		  <div class="column1">
			<span class="tag"><asp:Button ID="Venta1" Width="100%" Text="Venta" runat="server" OnClick="venta1_Click"/></span>
			<span class="tag"><asp:Button ID="Alquiler1" Width="100%" Text="Alquiler" runat="server" OnClick="alquiler1_Click"/></span>
		  </div> <!-- end column1 -->
		  
		  <div class="col-md-9 col-xs-6 col-sm-8">
			<div class="col-md-12 col-xs-12 col-sm-12">
				<p><asp:Label ID="Descripcio1" runat="server"></asp:Label>  </p>
			</div>
		  </div> <!-- end column2 -->
		</div> <!-- end description -->
	  </div> <!-- end container -->
	</div> <!-- end movie-card -->
</div>

<!-- Service Modal 2 Creative -->
<div class="service-modal modal fade" id="serviceModal2" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
  <div class="modal-dialog" role="document">
    <div class="modal-content">	
      <div class="close-modal" data-dismiss="modal" aria-label="Close">
        <div class="close-icon">
            <div class="close-icon-r">
            </div>
        </div>
      </div>
		<a href="#"><img src="img/50.jpg" alt="cover" class="cover" /></a>       
		<div class="hero">   
		  <div class="details">
			<div class="title1"><asp:Label ID="Titul2" runat="server"></asp:Label>
                <span class="pegi">PG-<asp:Label ID="Edad2" runat="server">
                                     </asp:Label></span>
			</div>
			<div class="title2"><asp:Label ID="Director2" runat="server"></asp:Label></div>    
		  </div> <!-- end details -->      
		</div> <!-- end hero -->    
		
		
		
		<div class="description">     
		  <div class="column1">
			<span class="tag"><asp:Button ID="Venta2" Width="100%" Text="Venta" runat="server" OnClick="venta2_Click"/></span>
			<span class="tag"><asp:Button ID="Alquiler2" Width="100%" Text="Alquiler" runat="server" OnClick="alquiler2_Click"/></span>
		  </div> <!-- end column1 -->
		  
		  <div class="col-md-9 col-xs-6 col-sm-8">
			<div class="col-md-12 col-xs-12 col-sm-12">
				<p><asp:Label ID="Descripcio2" runat="server"></asp:Label>  </p>
			</div>
		  </div> <!-- end column2 -->
		</div> <!-- end description -->
	  </div> <!-- end container -->
	</div> <!-- end movie-card -->
</div>

<!-- Service Modal 3 Creative -->
<div class="service-modal modal fade" id="serviceModal3" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
  <div class="modal-dialog" role="document">
    <div class="modal-content">	
      <div class="close-modal" data-dismiss="modal" aria-label="Close">
        <div class="close-icon">
            <div class="close-icon-r">
            </div>
        </div>
      </div>
		<a href="#"><img src="img/f8.jpg" alt="cover" class="cover" /></a>       
		<div class="hero">   
		  <div class="details">
			<div class="title1"><asp:Label ID="Titul3" runat="server"></asp:Label>
                <span class="pegi">PG-<asp:Label ID="Edad3" runat="server">
                                     </asp:Label></span>
			</div>
			<div class="title2"><asp:Label ID="Director3" runat="server"></asp:Label></div>    
		  </div> <!-- end details -->      
		</div> <!-- end hero -->    
		
		
		
		<div class="description">     
		  <div class="column1">
			<span class="tag"><asp:Button ID="Venta3" Width="100%" Text="Venta" runat="server" OnClick="venta3_Click"/></span>
			<span class="tag"><asp:Button ID="Alquiler3" Width="100%" Text="Alquiler" runat="server" OnClick="alquiler3_Click"/></span>
		  </div> <!-- end column1 -->
		  
		  <div class="col-md-9 col-xs-6 col-sm-8">
			<div class="col-md-12 col-xs-12 col-sm-12">
				<p><asp:Label ID="Descripcio3" runat="server"></asp:Label>  </p>
			</div>
		  </div> <!-- end column2 -->
		</div> <!-- end description -->
	  </div> <!-- end container -->
	</div> <!-- end movie-card -->
</div>

<!-- Service Modal 4 Creative -->
<div class="service-modal modal fade" id="serviceModal4" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
  <div class="modal-dialog" role="document">
    <div class="modal-content">	
      <div class="close-modal" data-dismiss="modal" aria-label="Close">
        <div class="close-icon">
            <div class="close-icon-r">
            </div>
        </div>
      </div>
		<a href="#"><img src="img/z.jpg" alt="cover" class="cover" /></a>       
		<div class="hero">   
		  <div class="details">
			<div class="title1"><asp:Label ID="Titul4" runat="server"></asp:Label>
                <span class="pegi">PG-<asp:Label ID="Edad4" runat="server">
                                     </asp:Label></span>
			</div>
			<div class="title2"><asp:Label ID="Director4" runat="server"></asp:Label></div>    
		  </div> <!-- end details -->      
		</div> <!-- end hero -->    
		
		
		
		<div class="description">     
		  <div class="column1">
			<span class="tag"><asp:Button ID="Venta4" Width="100%" Text="Venta" runat="server" OnClick="venta4_Click"/></span>
			<span class="tag"><asp:Button ID="Alquiler4" Width="100%" Text="Alquiler" runat="server" OnClick="alquiler4_Click"/></span>
		  </div> <!-- end column1 -->
		  
		  <div class="col-md-9 col-xs-6 col-sm-8">
			<div class="col-md-12 col-xs-12 col-sm-12">
				<p><asp:Label ID="Descripcio4" runat="server"></asp:Label>  </p>
			</div>
		  </div> <!-- end column2 -->
		</div> <!-- end description -->
	  </div> <!-- end container -->
	</div> <!-- end movie-card -->
</div>

<!-- Service Modal 5 Creative -->
<div class="service-modal modal fade" id="serviceModal5" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
  <div class="modal-dialog" role="document">
    <div class="modal-content">	
      <div class="close-modal" data-dismiss="modal" aria-label="Close">
        <div class="close-icon">
            <div class="close-icon-r">
            </div>
        </div>
      </div>
		<a href="#"><img src="img/power.jpg" alt="cover" class="cover" /></a>       
		<div class="hero">   
		  <div class="details">
			<div class="title1"><asp:Label ID="Titul5" runat="server"></asp:Label>
                <span class="pegi">PG-<asp:Label ID="Edad5" runat="server">
                                     </asp:Label></span>
			</div>
			<div class="title2"><asp:Label ID="Director5" runat="server"></asp:Label></div>    
		  </div> <!-- end details -->      
		</div> <!-- end hero -->    
		
		
		
		<div class="description">     
		  <div class="column1">
			<span class="tag"><asp:Button ID="Venta5" Width="100%" Text="Venta" runat="server" OnClick="venta5_Click"/></span>
			<span class="tag"><asp:Button ID="Alquiler5" Width="100%" Text="Alquiler" runat="server" OnClick="alquiler5_Click"/></span>
		  </div> <!-- end column1 -->
		  
		  <div class="col-md-9 col-xs-6 col-sm-8">
			<div class="col-md-12 col-xs-12 col-sm-12">
				<p><asp:Label ID="Descripcio5" runat="server"></asp:Label>  </p>
			</div>
		  </div> <!-- end column2 -->
		</div> <!-- end description -->
	  </div> <!-- end container -->
	</div> <!-- end movie-card -->
</div>

<!-- Service Modal 6 Creative -->
<div class="service-modal modal fade" id="serviceModal6" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
  <div class="modal-dialog" role="document">
    <div class="modal-content">	
      <div class="close-modal" data-dismiss="modal" aria-label="Close">
        <div class="close-icon">
            <div class="close-icon-r">
            </div>
        </div>
      </div>
		<a href="#"><img src="img/wick.jpg" alt="cover" class="cover" /></a>       
		<div class="hero">   
		  <div class="details">
			<div class="title1"><asp:Label ID="Titul6" runat="server"></asp:Label>
                <span class="pegi">PG-<asp:Label ID="Edad6" runat="server">
                                     </asp:Label></span>
			</div>
			<div class="title2"><asp:Label ID="Director6" runat="server"></asp:Label></div>    
		  </div> <!-- end details -->      
		</div> <!-- end hero -->    
		
		
		
		<div class="description">     
		  <div class="column1">
			<span class="tag"><asp:Button ID="Venta6" Width="100%" Text="Venta" runat="server" OnClick="venta6_Click"/></span>
			<span class="tag"><asp:Button ID="Alquiler6" Width="100%" Text="Alquiler" runat="server" OnClick="alquiler6_Click"/></span>
		  </div> <!-- end column1 -->
		  
		  <div class="col-md-9 col-xs-6 col-sm-8">
			<div class="col-md-12 col-xs-12 col-sm-12">
				<p><asp:Label ID="Descripcio6" runat="server"></asp:Label>  </p>
			</div>
		  </div> <!-- end column2 -->
		</div> <!-- end description -->
	  </div> <!-- end container -->
	</div> <!-- end movie-card -->
</div>

<!-- Service Modal 7 Creative -->
<div class="service-modal modal fade" id="serviceModal7" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
  <div class="modal-dialog" role="document">
    <div class="modal-content">	
      <div class="close-modal" data-dismiss="modal" aria-label="Close">
        <div class="close-icon">
            <div class="close-icon-r">
            </div>
        </div>
      </div>
		<a href="#"><img src="img/gru.jpg" alt="cover" class="cover" /></a>       
		<div class="hero">   
		  <div class="details">
			<div class="title1"><asp:Label ID="Titul7" runat="server"></asp:Label>
                <span class="pegi">PG-<asp:Label ID="Edad7" runat="server">
                                     </asp:Label></span>
			</div>
			<div class="title2"><asp:Label ID="Director7" runat="server"></asp:Label></div>    
		  </div> <!-- end details -->      
		</div> <!-- end hero -->    
		
		
		
		<div class="description">     
		  <div class="column1">
			<span class="tag"><asp:Button ID="Venta7" Width="100%" Text="Venta" runat="server" OnClick="venta7_Click"/></span>
			<span class="tag"><asp:Button ID="Alquiler7" Width="100%" Text="Alquiler" runat="server" OnClick="alquiler7_Click"/></span>
		  </div> <!-- end column1 -->
		  
		  <div class="col-md-9 col-xs-6 col-sm-8">
			<div class="col-md-12 col-xs-12 col-sm-12">
				<p><asp:Label ID="Descripcio7" runat="server"></asp:Label>  </p>
			</div>
		  </div> <!-- end column2 -->
		</div> <!-- end description -->
	  </div> <!-- end container -->
	</div> <!-- end movie-card -->
</div>

<!-- Service Modal 8 Creative -->
<div class="service-modal modal fade" id="serviceModal8" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
  <div class="modal-dialog" role="document">
    <div class="modal-content">	
      <div class="close-modal" data-dismiss="modal" aria-label="Close">
        <div class="close-icon">
            <div class="close-icon-r">
            </div>
        </div>
      </div>
		<a href="#"><img src="img/hobbit.jpg" alt="cover" class="cover" /></a>       
		<div class="hero">   
		  <div class="details">
			<div class="title1"><asp:Label ID="Titul8" runat="server"></asp:Label>
                <span class="pegi">PG-<asp:Label ID="Edad8" runat="server">
                                     </asp:Label></span>
			</div>
			<div class="title2"><asp:Label ID="Director8" runat="server"></asp:Label></div>    
		  </div> <!-- end details -->      
		</div> <!-- end hero -->    
		
		
		
		<div class="description">     
		  <div class="column1">
			<span class="tag"><asp:Button ID="Venta8" Width="100%" Text="Venta" runat="server" OnClick="venta8_Click"/></span>
			<span class="tag"><asp:Button ID="Alquiler8" Width="100%" Text="Alquiler" runat="server" OnClick="alquiler8_Click"/></span>
		  </div> <!-- end column1 -->
		  
		  <div class="col-md-9 col-xs-6 col-sm-8">
			<div class="col-md-12 col-xs-12 col-sm-12">
				<p><asp:Label ID="Descripcio8" runat="server"></asp:Label>  </p>
			</div>
		  </div> <!-- end column2 -->
		</div> <!-- end description -->
	  </div> <!-- end container -->
	</div> <!-- end movie-card -->
</div>

</asp:Content>
