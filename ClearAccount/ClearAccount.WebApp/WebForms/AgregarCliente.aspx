<%@ Page Title="Agregar Cliente" Language="C#" MasterPageFile="~/WebForms/MenuPrincipal.Master" AutoEventWireup="true" CodeBehind="AgregarCliente.aspx.cs" Inherits="ClearAccount.WebApp.WebForms.AgregarCliente" %>

<asp:Content ID="ContentAgregarsUsuario" ContentPlaceHolderID="MainContent" runat="server">

    <div id="container">

        <div class="row" style="padding-left: 10%">
            <!--registro de clientes-->
            <div class="col-6">

                <h1><strong>NUEVO CLIENTE</strong></h1>
                <br />
                <br />

                <div class="form-label-txt">

                    
                    <!--Label y Text para nombre del cliente-->
                    <div class="form-group row" style="padding-bottom: 5%">
                        <label for="lblNombre" class="col-sm-2 col-form-label" runat="server">Nombre</label>
                        <div class="col-sm-10">
                            <input id="inputNombre" class="form-control"  placeholder="Nombres..." runat="server">
                        </div>
                    </div>
                    
                    <!--Label y Text para nombre del cliente-->
                    <div class="form-group row" style="padding-bottom: 5%">
                        <label for="inputApellido" class="col-sm-2 col-form-label">Apellidos</label>
                        <div class="col-sm-10">
                            <input id="inputApellido" class="form-control"  placeholder="Apellidos..." runat="server">
                        </div>
                    </div>

                    <!--Label y Text para telefono del cliente-->
                    <div class="form-group row" style="padding-bottom: 5%">
                        <label for="inputTelefono" class="col-sm-2 col-form-label">#Telefono</label>
                        <div class="col-sm-10">
                            <input id="inputTelefono" class="form-control"  placeholder="Telefono" runat="server">
                        </div>
                    </div>

                    <!--Label y Text para direccion del cliente-->
                    <div class="form-group row" style="padding-bottom: 5%">
                        <label for="inputDireccion" class="col-sm-2 col-form-label">Direccion</label>
                        <div class="col-sm-10">
                            <input id="inputDireccion" class="form-control"  placeholder="Direccion completa..." runat="server">
                        </div>
                    </div>

                    <!--Label y Text para correo electronio del cliente-->
                    <div class="form-group row" style="padding-bottom: 5%">
                        <label for="inputCorreo" class="col-sm-2 col-form-label">Correo</label>
                        <div class="col-sm-10">
                            <input id="inputCorreo" class="form-control"  placeholder="nombre@ejemplo.com" runat="server">
                        </div>
                    </div>
                    <%--Boton para agregar al cliente--%>
                    <button id="btnAgregarCliente" class="btn btn-primary btn-lg btn-block" runat="server"  type="submit">Guardar</button>
                    
                    <br />
                    <br />
                    <br />
                    <br />
                </div>

            </div>


        </div>

    </div>



</asp:Content>
