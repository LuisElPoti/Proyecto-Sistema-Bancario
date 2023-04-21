<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignInForm.aspx.cs" Inherits="NETBANKING.LoginPages.SignInForm" %>

<!DOCTYPE html>

<html class="bg-white" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Validación de cuenta</title>
   <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-KK94CHFLLe+nY2dmCWGMq91rCGa5gtU4mk92HdvYe+M/SXH301p5ILy+dN9+nJOZ" crossorigin="anonymous">
    <link href="https://cdn.jsdelivr.net/npm/@fortawesome/fontawesome-free@6.2.1/css/fontawesome.min.css" rel="stylesheet" />
    <link href="../css/AdminLTE.css" rel="stylesheet" type="text/css"/>
    <style type="text/css">
    /* Cambia el tamaño del control DropDownList */
    #DdTipoDocumento {
        width: 320px; /* Cambia el ancho del control */
        height: 40px; /* Cambia la altura del control */
    }
</style>

</head>
<body class="bg-white">
    <div class="form-box" id="login-box">
    <div class="header bg-purple">Validación de cuenta</div>
    <form id="form1" runat="server">
       <div class="body bg-gray">
        <div class="form-group">
            <asp:Label ID="LabelTipoDocumento" runat="server" Text="Tipo de documento: "></asp:Label>
            <br />
             <asp:DropDownList ID="DdTipoDocumento" runat="server">
                 <asp:ListItem>Cedula</asp:ListItem>
                 <asp:ListItem>Pasaporte</asp:ListItem>
             </asp:DropDownList>
        </div>
         <div class="form-group">
             <asp:Label ID="LabelDocumento" runat="server" Text="Documento"></asp:Label>
             <asp:TextBox ID="txtDocumento" runat="server" CssClass="form-control" placeholder="Contraseña"></asp:TextBox>
         </div>
       </div>
        <div class="footer bg-gray">
            <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" CssClass="btn bg-orange col-12" />
            <br/>
             <asp:Button ID="btnAtras" runat="server" Text="Atras" CssClass="btn bg-purple col-12" OnClick="btnAtras_Click" />
        </div>
    </form>
    </div>
</body>
  </html>
