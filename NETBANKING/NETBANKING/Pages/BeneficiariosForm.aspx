<%@ Page Title="" Language="C#" MasterPageFile="~/MP.Master" AutoEventWireup="true" CodeBehind="BeneficiariosForm.aspx.cs" Inherits="NETBANKING.Pages.BeneficiariosForm" %>
<asp:Content ID="Title" ContentPlaceHolderID="Title" runat="server">
    <h1 >Beneficiarios</h1>
</asp:Content>
<asp:Content ID="Content" ContentPlaceHolderID="Content" runat="server">
    <div class="row">
        <div class="col-md-5" class="contenedor">
            <div class="card" style="width: 18rem;">
      <div class="card-body">
        <h5 class="card-title">Allen Silverio</h5>
        <h6 class="card-subtitle mb-2 text-muted">Banco BHD</h6>
        <p class="card-text">1234567890986</p>
        <a href="\Pages\TransaccionesInterbancariasForm.aspx" class="card-link">Realizar una transacción</a>
      </div>
        </div>
             <div class="card" style="width: 18rem;">
      <div class="card-body">
        <h5 class="card-title">Angel Moreno</h5>
        <h6 class="card-subtitle mb-2 text-muted">Banco Unión</h6>
        <p class="card-text">1234567890986</p>
        <a href="\Pages\TransaccionesPropiasForm.aspx" class="card-link">Realizar una transacción</a>
      </div>
    </div>
    </div>

      <div class="col-md-4">
          <div class="form-group">
            <h3>Registro de beneficiarios</h3>

            <asp:Label ID="LabelBanco" runat="server" Text="Banco: "></asp:Label>
            <br />
            <br />
             <asp:DropDownList ID="DdBanco" runat="server" Width="185px">
                 <asp:ListItem>Banco BHD</asp:ListItem>
                 <asp:ListItem>Banco 2</asp:ListItem>
             </asp:DropDownList>
        <div class="form-group">
            <h3>Registro de beneficiarios</h3>

            <asp:Label ID="LabelTipoDocumento" runat="server" Text="Tipo de documento: "></asp:Label>
            <br />
            <br />
             <asp:DropDownList ID="DdTipoDocumento" runat="server" Width="185px">
                 <asp:ListItem>Cédula</asp:ListItem>
                 <asp:ListItem>Pasaporte</asp:ListItem>
             </asp:DropDownList>
            <br />
            <br />
        </div>
        <div class="form-group">
             <asp:Label ID="LabelDocumento" runat="server" Text="Documento:"></asp:Label> 
                <br />
               <br />
             <asp:TextBox ID="txtDocumento" runat="server" CssClass="form-control" placeholder="Documento" Width="185px"></asp:TextBox>
         </div>
           <br />
        <div class="form-group">
             <asp:Label ID="LabelAlias" runat="server" Text="Alias:"></asp:Label> 
                <br />
               <br />
             <asp:TextBox ID="txtAlias" runat="server" CssClass="form-control" placeholder="Alias" Width="185px"></asp:TextBox>
         </div>
      <br />
        <div class="form-group">
             <asp:Label ID="LabelCorreo" runat="server" Text="Correo:"></asp:Label> 
                <br />
               <br />
             <asp:TextBox ID="txtCorreo" runat="server" CssClass="form-control" placeholder="Correo" Width="185px"></asp:TextBox>
         </div>
      <br />
         <br />
      <asp:Button ID="btnGuardar" runat="server" Text="Guardar" Width="185px" OnClick="btnGuardar_Click" CssClass="btn bg-purple col-12"/>
          <br />
          </div>
        </div>
   
    </asp:Content>
