<%@ Page Title="" Language="C#" MasterPageFile="~/app/Site1.Master" AutoEventWireup="true" CodeBehind="Series.aspx.cs" Inherits="hadaflix.app.Series" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="projects_image_series" id="projects_series">
  <div class="container projects_series">
    <div class="row">
      <div class="col-xs-12">
        <div class="page-header">
          <h1 class="text-center">Series</h1>
        </div>
      </div>
    </div>

    <br />

    <div class="col-xs-12">
      <a href="producto.html" target="_blank" data-toggle="modal" data-target="#serviceModal0">
        <div class="col-md-3 col-xs-6 col-sm-3">
          <div class="thumbnail">
            <asp:ImageButton id="Serie0" TextMode="MultiLine" Columns="30" Rows="10" runat="server">
            </asp:ImageButton>
          </div>
        </div>
      </a>
	  
	  <a href="producto.html" target="_blank" data-toggle="modal" data-target="#serviceModal1">
        <div class="col-md-3 col-xs-6 col-sm-3">
          <div class="thumbnail">
            <asp:ImageButton id="Serie1" TextMode="MultiLine" Columns="30" Rows="10" runat="server">
            </asp:ImageButton>
          </div>
        </div>
      </a>
	  
	  <a href="producto.html" target="_blank" data-toggle="modal" data-target="#serviceModal2">
        <div class="col-md-3 col-xs-6 col-sm-3">
          <div class="thumbnail">
            <asp:ImageButton id="Serie2" TextMode="MultiLine" Columns="30" Rows="10" runat="server">
            </asp:ImageButton>
          </div>
        </div>
      </a>
	  
	  <a href="producto.html" target="_blank" data-toggle="modal" data-target="#serviceModal3">
        <div class="col-md-3 col-xs-6 col-sm-3">
          <div class="thumbnail">
            <asp:ImageButton id="Serie3" TextMode="MultiLine" Columns="30" Rows="10" runat="server">
            </asp:ImageButton>
          </div>
        </div>
      </a>
	  
	  <a href="producto.html" target="_blank" data-toggle="modal" data-target="#serviceModal4">
        <div class="col-md-3 col-xs-6 col-sm-3">
          <div class="thumbnail">
            <asp:ImageButton id="Serie4" TextMode="MultiLine" Columns="30" Rows="10" runat="server">
            </asp:ImageButton>
          </div>
        </div>
      </a>
	 </div>
  </div>
</div>

<!-- Service Modal 0 Creative -->
<div class="service-modal modal fade" id="serviceModal0" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
  <div class="modal-dialog" role="document">
    <div class="modal-content">	
      <div class="close-modal" data-dismiss="modal" aria-label="Close">
        <div class="close-icon">
            <div class="close-icon-r">
            </div>
        </div>
      </div>
		<a href="#"><img src="img/vikings.jpg" alt="cover" class="cover" /></a>       
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
            <asp:Button ID="Venta0" CssClass="tag" Width="100%" Text="Venta" runat="server" OnClick="venta9_Click"/>
            <asp:Button ID="Alquiler0" CssClass="tag" Width="100%" Text="Alquiler" runat="server" OnClick="alquiler9_Click"/>
		  </div> <!-- end column1 -->
		  
		  <div class="col-md-9 col-xs-6 col-sm-8">
			<div class="col-md-12 col-xs-12 col-sm-12">
				<asp:Label ID="Descripcio0" CssClass="title2" runat="server"></asp:Label>  
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
		<a href="#"><img src="img/revenge.jpg" alt="cover" class="cover" /></a>       
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
            <asp:Button ID="Venta1" CssClass="tag" Width="100%" Text="Venta" runat="server" OnClick="venta10_Click"/>
            <asp:Button ID="Alquiler1" CssClass="tag" Width="100%" Text="Alquiler" runat="server" OnClick="alquiler10_Click"/>
		  </div> <!-- end column1 -->
		  
		  <div class="col-md-9 col-xs-6 col-sm-8">
			<div class="col-md-12 col-xs-12 col-sm-12">
				<asp:Label ID="Descripcio1" CssClass="title2" runat="server"></asp:Label>  
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
		<a href="#"><img src="img/castle.jpg" alt="cover" class="cover" /></a>       
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
            <asp:Button ID="Venta2" CssClass="tag" Width="100%" Text="Venta" runat="server" OnClick="venta11_Click"/>
            <asp:Button ID="Alquiler2" CssClass="tag" Width="100%" Text="Alquiler" runat="server" OnClick="alquiler11_Click"/>
		  </div> <!-- end column1 -->
		  
		  <div class="col-md-9 col-xs-6 col-sm-8">
			<div class="col-md-12 col-xs-12 col-sm-12">
				<asp:Label ID="Descripcio2" CssClass="title2" runat="server"></asp:Label>  
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
		<a href="#"><img src="img/shild.jpg" alt="cover" class="cover" /></a>       
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
            <asp:Button ID="Venta3" CssClass="tag" Width="100%" Text="Venta" runat="server" OnClick="venta12_Click"/>
            <asp:Button ID="Alquiler3" CssClass="tag" Width="100%" Text="Alquiler" runat="server" OnClick="alquiler12_Click"/>
		  </div> <!-- end column1 -->
		  
		  <div class="col-md-9 col-xs-6 col-sm-8">
			<div class="col-md-12 col-xs-12 col-sm-12">
				<asp:Label ID="Descripcio3" CssClass="title2" runat="server"></asp:Label>  
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
		<a href="#"><img src="img/penny.jpg" alt="cover" class="cover" /></a>       
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
            <asp:Button ID="Venta4" CssClass="tag" Width="100%" Text="Venta" runat="server" OnClick="venta13_Click"/>
            <asp:Button ID="Alquiler4" CssClass="tag" Width="100%" Text="Alquiler" runat="server" OnClick="alquiler13_Click"/>
		  </div> <!-- end column1 -->
		  
		  <div class="col-md-9 col-xs-6 col-sm-8">
			<div class="col-md-12 col-xs-12 col-sm-12">
				<asp:Label ID="Descripcio4" CssClass="title2" runat="server"></asp:Label>  
			</div>
		  </div> <!-- end column2 -->
		</div> <!-- end description -->
	  </div> <!-- end container -->
	</div> <!-- end movie-card -->
</div>
</asp:Content>
