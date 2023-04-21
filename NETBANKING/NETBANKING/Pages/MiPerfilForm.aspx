<%@ Page Title="" Language="C#" MasterPageFile="~/MP.Master" AutoEventWireup="true" CodeBehind="MiPerfilForm.aspx.cs" Inherits="NETBANKING.Pages.MiPerfilForm" %>
<asp:Content ID="Title" ContentPlaceHolderID="Title" runat="server">
    <h1>Mi perfil</h1>
</asp:Content>
<asp:Content ID="Content" ContentPlaceHolderID="Content" runat="server">
  <section class="vh-0" style="background-color: whitesmoke;">
  <div class="container py-0 h-0">
    <div class="row d-flex justify-content-start align-items-center h-10">
      <div class="col col-lg-6 mb-4 mb-lg-0">
        <div class="card mb-3" style="border-radius: .5rem;">
          <div class="row g-0">
          <%--  <div class="col-md-4 gradient-custom text-center text-white" style="border-top-left-radius: .5rem; border-bottom-left-radius: .5rem; display: flex; align-items: center; justify-content: center;">
              <h5>Marie Horwitz</h5>
            </div>--%>
            <div class="col-md-8">
              <div class="card-body p-4">
                <h6>Informacion de usuario (Activo)</h6>
                <hr class="mt-0 mb-4">
                    <div class="row pt-1">
                    <div class="col-6 mb-3">
                    <h6>Nombres</h6>
                    <p class="text-muted">Dolor sit amet</p>
                  </div>
                    <div class="col-6 mb-3">
                    <h6>Apellidos</h6>
                    <p class="text-muted">Dolor sit amet</p>
                  </div>
                 <hr class="mt-0 mb-4">
              
                  <div class="col-6 mb-3">
                    <h6>Correo</h6>
                    <p class="text-muted">info@example.com</p>
                  </div>
                  <div class="col-6 mb-3">
                    <h6>Telefono</h6>
                    <p class="text-muted">123 456 789</p>
                  </div>
                </div>
                <hr class="mt-0 mb-4">
                <div class="row pt-1">
                  <div class="col-6 mb-3">
                    <h6>Tipo de documento</h6>
                    <p class="text-muted">Lorem ipsum</p>
                  </div>
                  <div class="col-6 mb-3">
                    <h6>Documento</h6>
                    <p class="text-muted">Dolor sit amet</p>
                  </div>
                    
              </div>

                </div>
             
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</section>

</asp:Content>

