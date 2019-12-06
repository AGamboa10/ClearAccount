<%@ Page Title="Clientes" Language="C#" MasterPageFile="~/WebForms/MenuPrincipal.Master" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="ClearAccount.WebApp.Clientes" %>

<asp:Content ID="ContentClientes" ContentPlaceHolderID="MainContent" runat="server">

    <div id="Container">
        <div class="row">

            <div class="col-6 dropdown" style="padding-left: 10%">
                <h1><strong>Lista de clientes</strong></h1>
                <br />
                <br />

                <!--Este es el dropdown-->

                <div class="dropdown">
                    <asp:DropDownList ID="DropClient"
                        runat="server" OnSelectedIndexChanged="dropdownClientes_ServerClick" CssClass="form-control">
                    </asp:DropDownList>
                </div>
                <!--Label y Text para nombre del cliente-->
                <div class="form-group row" style="padding-bottom: 5%; padding-top: 5%">
                    <label for="inputNombre" class="col-sm-2 col-form-label">Nombre</label>
                    <div class="col-sm-10">
                        <input id="inputNombre" class="form-control" placeholder="Nombres..." runat="server">
                    </div>
                </div>

                <!--Label y Text para nombre del cliente-->
                <div class="form-group row" style="padding-bottom: 5%">
                    <label for="inputApellido" class="col-sm-2 col-form-label">Apellidos</label>
                    <div class="col-sm-10">
                        <input id="inputApellido" class="form-control" placeholder="Apellidos..." runat="server">
                    </div>
                </div>

                <!--Label y Text para telefono del cliente-->
                <div class="form-group row" style="padding-bottom: 5%">
                    <label for="inputTelefono" class="col-sm-2 col-form-label">#Telefono</label>
                    <div class="col-sm-10">
                        <input id="inputTelefono" class="form-control" placeholder="Telefono" runat="server">
                    </div>
                </div>

                <!--Label y Text para direccion del cliente-->
                <div class="form-group row" style="padding-bottom: 5%">
                    <label for="inputDireccion" class="col-sm-2 col-form-label">Direccion</label>
                    <div class="col-sm-10">
                        <input id="inputDireccion" class="form-control" placeholder="Direccion completa..." runat="server">
                    </div>
                </div>

                <!--Label y Text para correo electronio del cliente-->
                <div class="form-group row" style="padding-bottom: 5%">
                    <label for="inputCorreo" class="col-sm-2 col-form-label">Correo</label>
                    <div class="col-sm-10">
                        <input id="inputCorreo" class="form-control" placeholder="nombre@ejemplo.com" runat="server">
                    </div>
                </div>
                <!--contenedor de los botones-->

                <div style="padding-left: 20%">
                    <button onclick="location.href='https://localhost:44334/WebForms/Pago'" id="btnPago" class="btn btn-primary btn-lg" type="submit" runat="server">Pago</button>
                    <button onclick="location.href='https://localhost:44334/WebForms/Cargo' " id="btnCargo" class="btn btn-danger btn-lg" type="submit">Cargo</button>
                </div>

            </div>

            <div class="col-2">
                <!--Bajar botones laterales hasta el centro-->
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <!--Botones laterales; Modificar, Guardar, Eliminar-->
                <div>
                    <button id="btnModificar" class="btn btn-info btn-block" type="submit">Modificar</button>
                </div>
                <br />
                <br />
                <div>
                    <button id="btnGuardar" class="btn btn-primary btn-block" type="submit" runat="server">Guardar</button>
                </div>
                <br />
                <div>
                    <button id="btnEliminar" class="btn btn-danger btn-block" type="submit" disabled>Eliminar</button>
                </div>


            </div>
        </div>

        <br />
        <br />
        <br />
    </div>

</asp:Content>
