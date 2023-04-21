<%@ Page Title="" Language="C#" MasterPageFile="~/MP.Master" AutoEventWireup="true" CodeBehind="TransaccionesInterbancariasForm.aspx.cs" Inherits="NETBANKING.Pages.TransaccionesInterbancariasForm" %>
<asp:Content ID="Title" ContentPlaceHolderID="Title" runat="server">
    <h1>Transferencias interbancarias</h1>
</asp:Content>
<asp:Content ID="Content" ContentPlaceHolderID="Content" runat="server">
    <div class="row">
    <div class="col-md-4">
        <div class="form-group">
            <h3>Nueva transacción</h3>

            <asp:Label ID="LabelCuentaOirgen" runat="server" Text="Cuenta origen: "></asp:Label>
            <br />
            <br />
             <asp:DropDownList ID="DdCuentaOrigen" runat="server" Width="185px">
                 <asp:ListItem>Cuenta 1</asp:ListItem>
                 <asp:ListItem>Cuenta 2</asp:ListItem>
             </asp:DropDownList>
            <br />
            <br />
        </div>
        <div class="form-group">
             <asp:Label ID="LabelBeneficiario" runat="server" Text="Beneficiario: "></asp:Label> 
                <br />
            <br />
              <asp:DropDownList ID="DbCuentaDestino" runat="server" Width="185px">
                 <asp:ListItem>Beneficiario 1</asp:ListItem>
                 <asp:ListItem>Beneficiario 2</asp:ListItem>
             </asp:DropDownList>
               <br />
         </div>
        <br />
        <div class="form-group">
             <asp:Label ID="LabelBanco" runat="server" Text="Banco: "></asp:Label> 
                <br />
            <br />
              <asp:DropDownList ID="DdBanco" runat="server" Width="185px">
                 <asp:ListItem>Banco 1</asp:ListItem>
                 <asp:ListItem>Banco 2</asp:ListItem>
             </asp:DropDownList>
               <br />
         </div>
           <br />
        <div class="form-group">
             <asp:Label ID="LabelCuentaDestino" runat="server" Text="Cuenta destino:"></asp:Label> 
               <br />
            <br />
             <asp:TextBox ID="txtCuentaDestino" runat="server" CssClass="form-control" placeholder="Cuenta destino" Width="185px"></asp:TextBox>
         </div>
      <br />
         <div class="form-group">
             <asp:Label ID="LabelCorreoCliente" runat="server" Text="Correo cliente:"></asp:Label> 
                <br />
               <br />
             <asp:TextBox ID="txtCorreoCliente" runat="server" CssClass="form-control" placeholder="Correo cliente" Width="185px"></asp:TextBox>
         </div>
        </div>
        <div class="col-md-4">
        <br />
            <br />
        <div class="form-group">
             <asp:Label ID="LabelCorreoBeneficiario" runat="server" Text="Correo beneficiario:"></asp:Label> 
                <br />
               <br />
             <asp:TextBox ID="txtCorreoBeneficiario" runat="server" CssClass="form-control" placeholder="Correo beneficiario" Width="185px"></asp:TextBox>
         </div>
        <br />
        <div class="form-group">
             <asp:Label ID="LabelConcepto" runat="server" Text="Concepto:"></asp:Label> 
                <br />
               <br />
             <asp:TextBox ID="TxtConcepto" runat="server" CssClass="form-control" placeholder="Concepto" Width="185px"></asp:TextBox>
         </div>
        <br />
        <div class="form-group">
             <asp:Label ID="LabelMonto" runat="server" Text="Monto:"></asp:Label> 
                <br />
               <br />
             <asp:TextBox ID="txtMonto" runat="server" CssClass="form-control" placeholder="Monto" Width="185px"></asp:TextBox>
         </div>
      <br />
         <br />
  <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" Width="185px" class="btn btn-primary" CssClass="btn bg-orange col-12"/>

      <asp:Button ID="btnSiguiente" runat="server" Text="Siguiente" Width="185px" class="btn btn-primary" CssClass="btn bg-purple col-12"/>

          <br />
          </div>
     </div>
  
</asp:Content>
