<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="NETBANKING.LoginForm" %>

<!DOCTYPE html>

<html class="bg-white" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Inicio de sesión</title>
   <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-KK94CHFLLe+nY2dmCWGMq91rCGa5gtU4mk92HdvYe+M/SXH301p5ILy+dN9+nJOZ" crossorigin="anonymous">
    <link href="https://cdn.jsdelivr.net/npm/@fortawesome/fontawesome-free@6.2.1/css/fontawesome.min.css" rel="stylesheet" />
    <link href="../css/AdminLTE.css" rel="stylesheet" type="text/css"/>
</head>
<body class="bg-white">
    <div class="form-box" id="login-box">
    <div class="header bg-purple">Iniciar sesión</div>
    <form id="form1" runat="server">
       <div class="body bg-gray">
        <div class="form-group">
            <asp:Label ID="LabelUsuario" runat="server" Text="Usuario"></asp:Label>
            <asp:TextBox ID="txtUsuario" runat="server" CssClass="form-control" placeholder="Nombre de usuario"></asp:TextBox>
        </div>
         <div class="form-group" class="bg-gray">
             <asp:Label ID="LabelClave" runat="server" Text="Contraseña"></asp:Label>
             <asp:TextBox ID="txtClave" runat="server" CssClass="form-control" placeholder="Contraseña"></asp:TextBox>
         </div>
       </div>
        <div class="footer bg-gray">
            <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" CssClass="btn bg-orange col-12" OnClick="btnAceptar_Click1" />
        <asp:Button ID="btnNuevoUsuario" runat="server" Text="Nuevo usuario" CssClass="btn bg-purple col-12" OnClick="btnNuevoUsuario_Click" />
        </div>
    </form>
    </div>
</body>
</html>
