<%@ Page Title="" Language="C#" MasterPageFile="~/MP.Master" AutoEventWireup="true" CodeBehind="InicioForm.aspx.cs" Inherits="NETBANKING.Pages.InicioForm" %>
<asp:Content ID="Title" ContentPlaceHolderID="Title" runat="server">
    <h1>Panel General</h1>
</asp:Content>
<asp:Content ID="Content" ContentPlaceHolderID="Content" runat="server">
    <div class="col-md-6">
        <h2>Cuentas</h2>
        <div class="card w-50">
  <div class="card-body">
    <h5 class="card-title">123456789</h5>
    <p class="card-text">Cuenta de ahorro</p>
      <asp:Button ID="btnVerMas" runat="server" Text="Ver mas" Width="163px" OnClick="btnVerMas_Click" CssClass="btn bg-purple col-12" Height="36px"/>
</div>
  </div>
  <div class="card w-50">
  <div class="card-body">
    <h5 class="card-title">123456789</h5>
    <p class="card-text">Cuenta de ahorro</p>
      <asp:Button ID="Button1" runat="server" Text="Ver mas" Width="163px" OnClick="btnVerMas_Click" CssClass="btn bg-purple col-12" Height="36px"/>
</div>
  </div>
 </asp:Content>
