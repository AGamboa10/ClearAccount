<%@ Page Title="Agregar nota" Language="C#" MasterPageFile="~/WebForms/MenuPrincipal.Master" AutoEventWireup="true" CodeBehind="AgregarNota.aspx.cs" Inherits="ClearAccount.WebApp.WebForms.AgregarNota" %>

<asp:Content ID="ContentAgregarNota" ContentPlaceHolderID="MainContent" runat="server">

    <div id="Container">
        <div class="row">
            <div class="col-7" style="padding-left: 10%">
                <h1><strong>Nueva nota</strong></h1>
                <br />
                <h3> Registra una nota o recordatorio para el cliente </h3>
                <br />
                <!--Este es el dropdown-->
                <div class="dropdown">
                    <button class="btn btn-secondary dropdown-toggle" type="button" id="dropdowClientes" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                        lista de clientes
                    </button>
                    <div class="dropdown-menu" aria-labelledby="dropdownmenubutton">
                        <a class="dropdown-item" href="#">action</a>
                        <a class="dropdown-item" href="#">another action</a>
                        <a class="dropdown-item" href="#">something else here</a>
                    </div>
                </div>
                <br />
                <!--Input para guardar parrafos-->
                <div class="form-group" >
                    <label for="textNota">Nota:</label>
                    <textarea id="inputNota" class="form-control"  rows="7" ></textarea>
                </div>
            </div>
        </div>
        <br />
        <!--Nueva fila para el boton-->
        <div class="row">
            <div class="col-4" style="padding-left: 13%">
                <button id="btnGuardar" class="btn btn-primary btn-lg btn-block"  type="submit">Guardar</button>
            </div>
            <br /><br /><br /><br /><br /><br /><br />

        </div>
    </div>


</asp:Content>
