<%@ Page Title="" Language="C#" MasterPageFile="~/app/Site1.Master" AutoEventWireup="true" CodeBehind="Pago.aspx.cs" Inherits="hadaflix.app.Pago" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<style type="text/css">

/* CSS for Credit Card Payment form */

.credit-card-box{
  position: absolute; /* podría ser relative */
  margin: 100px auto;
}

.credit-card-box .panel-title {
    display: inline;
    font-weight: bold;
}
.credit-card-box .form-control.error {
    border-color: red;
    outline: 0;
    box-shadow: inset 0 1px 1px rgba(0,0,0,0.075),0 0 8px rgba(255,0,0,0.6);
}
.credit-card-box label.error {
  font-weight: bold;
  color: red;
  padding: 2px 8px;
  margin-top: 2px;
}
.credit-card-box .payment-errors {
  font-weight: bold;
  color: red;
  padding: 2px 8px;
  margin-top: 2px;
}
.credit-card-box label {
    display: block;
}
/* The old "center div vertically" hack */
.credit-card-box .display-table {
    display: table;
}
.credit-card-box .display-tr {
    display: table-row;
}
.credit-card-box .display-td {
    display: table-cell;
    vertical-align: middle;
    width: 50%;
}
/* Just looks nicer */
.credit-card-box .panel-heading img {
    min-width: 180px;
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
<div class="container">
  <div class="row">
    <div class="col-xs-12 col-md-4">
      <div class="panel panel-default credit-card-box" style="padding-top:0px; margin-top:50px; top:50px; left:50px; margin-bottom:0px;">
        <div class="panel-heading display-table">
          <div class="row display-tr">
            <h3 class="panel-title display-td">Payment Details</h3>
            <div class="display-td">
              <img class="img-responsive pull-right" src="http://i76.imgup.net/accepted_c22e0.png">
            </div>
          </div>
        </div>
        <div class="panel-body">
          <form role="form" id="payment-form">
            <div class="row">
              <div class="col-xs-12">
                <div class="form-group">
                  <label for="cardNumber">CARD NUMBER</label>
                  <div class="input-group">
                    <input type="tel" class="form-control" name="cardNumber" placeholder="Valid Card Number" autocomplete="cc-number" required autofocus />
                    <span class="input-group-addon"><i class="fa fa-credit-card"></i></span>
                  </div>
                </div>
              </div>
            </div>
              <div class="row">
              <div class="col-xs-12">
                <div class="form-group">
                  <label for="cardNumber">Email</label>
                  <div class="input-group">
                    <asp:TextBox ID="email" runat="server" placeholder="Valid Email" CssClass="form-control"  autocomplete="cc-number" required autofocus></asp:TextBox>
                    <span class="input-group-addon"><i class="fa fa-envelope"></i></span>
                  </div>
                </div>
              </div>
            </div>
            <div class="row">
              <div class="col-xs-7 col-md-7">
                <div class="form-group">
                  <label for="cardExpiry"><span class="hidden-xs">EXPIRATION</span><span class="visible-xs-inline">EXP</span> DATE</label>
                  <input type="tel" class="form-control" name="cardExpiry" placeholder="MM / YY" autocomplete="cc-exp" required />
                </div>
              </div>
              <div class="col-xs-5 col-md-5 pull-right">
                <div class="form-group">
                  <label for="cardCVC">CV CODE</label>
                  <input type="tel" class="form-control" name="cardCVC" placeholder="CVC" autocomplete="cc-csc" required />
                </div>
              </div>
            </div>
            <div class="row">
              <div class="col-xs-12">
                
              </div>
            </div>
            <div class="row">
              <div class="col-xs-12">
                <asp:Button ID="RealizarPago" runat="server" Text="Start Subscription" class="btn btn-success btn-lg btn-block" OnClick="RealizarPago_Click"/>
              </div>
            </div>
            <div class="row" style="display:none;">
              <div class="col-xs-12">
                <p class="payment-errors"></p>
              </div>
            </div>
          </form>
        </div>
      </div>

</asp:Content>
