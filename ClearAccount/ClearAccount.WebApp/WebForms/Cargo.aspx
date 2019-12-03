<%@ Page Title="Cargo" Language="C#" MasterPageFile="~/WebForms/MenuPrincipal.Master" AutoEventWireup="true" CodeBehind="Cargo.aspx.cs" Inherits="ClearAccount.WebApp.WebForms.Cargo" %>

<asp:Content ID="ContentCargo" ContentPlaceHolderID="MainContent" runat="server">

    <div id="container">
        <div class="row">
            <div class="col-6" style="padding-left: 10%">
                <h1><strong>[+] CARGO</strong></h1>
                <br /><br />
            <!--Label y Text para el adeudo-->
                <div class="form-group row" style="padding-bottom: 5%">
                    <label for="inputAdeudo" class="col-sm-4 col-form-label">Adeudo actual: </label>
                    <div class="col-sm-10">
                        <input id="inputAdeudoC" class="form-control" placeholder="Adeudo actual" disabled runat="server">
                    </div>
                </div>

                <!--Label y Text para el monto del cargo-->
                <div class="form-group row" style="padding-bottom: 5%">
                    <label for="inputPago" class="col-sm-4 col-form-label">Monto: </label>
                    <div class="col-sm-10">
                        <input id="inputCargo" class="form-control" placeholder="0.00" runat="server">

                    </div>
                </div>

                <!--Label y Text para el anticipo-->
                <div class="form-group row" style="padding-bottom: 5%">
                    <label for="inputAnticipo" class="col-sm-4 col-form-label">Anticipo: </label>
                    <div class="col-sm-10">
                        <input id="inputAnticipo" class="form-control" placeholder="0.00" runat="server">
                        <br />
                        <!--Boton para ver el adeudo parcial-->
                        <button id="btnVerTotalC" class="btn btn-success btn-sm" type="submit">Ver total parcial</button>
                    </div>
                </div>

                 <!--Label y Text para el adeudo parcial-->
                <div class="form-group row" style="padding-bottom: 5%">
                    <label for="inputTotalParcial" class="col-sm-4 col-form-label">Total parcial: </label>
                    <div class="col-sm-10">
                        <input id="inputTotalParcial" class="form-control" placeholder="..." disabled runat="server">
                    </div>
                </div>
                <!--Boton para guardar los cambios-->
                <div class="col-sm-8">
                    <button id="btnGuardarCargo" class="btn btn-primary btn-block" type="submit">Guardar</button>
                </div>
                <br /><br /><br /><br /><br />
            </div>
        </div>
    </div>

</asp:Content>
