<%@ Page Title="Pago" Language="C#" MasterPageFile="~/WebForms/MenuPrincipal.Master" AutoEventWireup="true" CodeBehind="Pago.aspx.cs" Inherits="ClearAccount.WebApp.WebForms.Pago" %>

<asp:Content ID="ContentPago" ContentPlaceHolderID="MainContent" runat="server">

    <div id="container">
        <div class="row">
            <div class="col-6" style="padding-left: 10%">
                <h1><strong>[-] PAGO</strong></h1>
                <br />
                <br />

                <!--Label y Text para el adeudo -->
                <div class="form-group row" style="padding-bottom: 5%">
                    <label for="inputAdeudo" class="col-sm-4 col-form-label">Adeudo actual: </label>
                    <div class="col-sm-10">
                        <input id="inputAdeudoP" class="form-control" placeholder="Adeudo" disabled runat="server">
                    </div>
                </div>

                <!--Label y Text para el monto del pago -->
                <div class="form-group row" style="padding-bottom: 5%">
                    <label for="inputPago" class="col-sm-4 col-form-label">Monto del pago: </label>
                    <div class="col-sm-10">
                        <input id="inputPago" class="form-control" placeholder="Pago" runat="server">
                        <br />
                        <!--Boton para ver el total parcial -->
                        <button id="btnVerTotalP" class="btn btn-success btn-sm" type="submit">Ver total parcial</button>
                    </div>
                </div>

                <!--Label y Text para el adeudo parcial-->
                <div class="form-group row" style="padding-bottom: 5%">
                    <label for="inputTotalParcial" class="col-sm-4 col-form-label">Total parcial: </label>
                    <div class="col-sm-10">
                        <input id="inputTotalParcial" class="form-control" placeholder="Total parcial" disabled runat="server">
                    </div>
                </div>

                <!--Boton para guardar los cambios-->
                <div class="col-sm-8">
                    <button id="btnGuardarPago" class="btn btn-primary btn-block" type="submit">Guardar</button>
                </div>
                <br /><br /><br /><br /><br /><br />
            </div>
        </div>
    </div>

</asp:Content>
