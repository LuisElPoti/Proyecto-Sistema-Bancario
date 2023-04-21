<%@ Page Title="" Language="C#" MasterPageFile="~/MP.Master" AutoEventWireup="true" CodeBehind="DetalleCuentaForm.aspx.cs" Inherits="NETBANKING.Pages.DetalleCuentaForm" %>
<asp:Content ID="Title" ContentPlaceHolderID="Title" runat="server">
    <h1>Detalle de la cuenta</h1>
</asp:Content>
<asp:Content ID="Content" ContentPlaceHolderID="Content" runat="server">
    <div class="row">
     <div class="col-md-5">
        <div class="card" style="width: 18rem;">
  <div class="card-body">
    <h5 class="card-title">12345678987</h5>
    <h6 class="card-subtitle mb-2 text-muted">Cuenta de ahorro</h6>
    <p class="fw-bold">Moneda:</p><p class="card-text">Pesos dominicanos(DOP)</p>
    <p class="fw-bold">Estado:</p><p class="card-text">Activa</p>
    <p class="fw-bold">Balance:</p><p class="card-text">135,954.00</p>
  </div>
</div>
    </div>
      <div class="col-md-9">
          <br />
            <div class="list-group">
                    <a href="#" class="list-group-item list-group-item-action" aria-current="true">
                        <div class="d-flex w-100 justify-content-between">
                            <h6 class="mb-1">Cuenta de Ahorro</h6>
                            <small class="estado-cargo">$20,000</small>
                        </div>
                        <p class="mb-1 small">1234567890 </p>
                        <small class="fw-bold">Activa</small>
                    </a>
                <a href="#" class="list-group-item list-group-item-action" aria-current="true">
                        <div class="d-flex w-100 justify-content-between">
                            <h6 class="mb-1">Cuenta de Ahorro</h6>
                            <small class="estado-cargo">$20,000</small>
                        </div>
                        <p class="mb-1 small">1234567890 </p>
                        <small class="fw-bold">Activa</small>
                    </a>
                </div>
        </div>
   </div>
</asp:Content>
