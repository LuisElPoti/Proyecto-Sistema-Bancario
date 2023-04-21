<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignInFormPt2.aspx.cs" Inherits="NETBANKING.LoginPages.SignInFormPt2" %>

<!DOCTYPE html>

<html class="bg-white" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registro de usuario</title>
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
    <div class="header bg-purple">Registro de usuario</div>
    <form id="form1" runat="server">
       <div class="body bg-gray">
        <div class="form-group">
            <asp:Label ID="LabelNombreUsuario" runat="server" Text="Ingrese el nombre de usuario que desea: "></asp:Label>
       <asp:TextBox ID="TextNombreUsuario" runat="server" CssClass="form-control" placeholder="Nombre de usuario"></asp:TextBox>

        </div>
         <div class="form-group">
             <asp:Label ID="LabelContraseña" runat="server" Text="Ingrese su contraseña: "></asp:Label>
             <asp:TextBox ID="txtContraseña" runat="server" CssClass="form-control" placeholder="Contraseña"></asp:TextBox>
         </div>
       </div>
        <div class="footer bg-gray">
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn bg-orange col-12" />
            <br/>
             <asp:Button ID="btnAtras" runat="server" Text="Atras" CssClass="btn bg-purple col-12" OnClick="btnAtras_Click" />
        </div>
    </form>
    </div>
</body>
</html>
