<%@ Page Title="Notas" Language="C#" MasterPageFile="~/WebForms/MenuPrincipal.Master" AutoEventWireup="true" CodeBehind="Notas.aspx.cs" Inherits="ClearAccount.WebApp.WebForms.Notas" %>

<asp:Content ID="ContentNotas" ContentPlaceHolderID="MainContent" runat="server">

    <div id="Container">
        <div class="row">
            <div class="col-12" style="padding-left: 40%">
                <h1>NOTAS</h1>
                <br />

                <!--Este es el dropdown-->
                <div class="dropdown" >
                    <button class="btn btn-secondary dropdown-toggle" type="button" id="dropdowClientes" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                        lista de clientes
                    </button>
                    <div class="dropdown-menu" aria-labelledby="dropdownmenubutton">
                        <a class="dropdown-item" href="#">action</a>
                        <a class="dropdown-item" href="#">another action</a>
                        <a class="dropdown-item" href="#">something else here</a>
                    </div>
                </div>

                <!--Este es el option menu-->
                <div class="form-group">
                    <select class="custom-select" required>
                        <option value="">Lista de clientes</option>
                        <option value="1">One</option>
                        <option value="2">Two</option>
                        <option value="3">Three</option>
                    </select>
                    <div class="invalid-feedback">Example invalid custom select feedback</div>
                </div>
                <div>
                    
                </div>
                


            </div>

        </div>
    </div>

</asp:Content>
