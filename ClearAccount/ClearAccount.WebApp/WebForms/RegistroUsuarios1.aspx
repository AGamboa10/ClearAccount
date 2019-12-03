<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroUsuarios1.aspx.cs" Inherits="ClearAccount.WebApp.RegistroUsuarios1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />

    <link href="//netdna.bootstrapcdn.com/twitter-bootstrap/2.3.2/css/bootstrap-combined.min.css" rel="stylesheet" />
    <script src="//netdna.bootstrapcdn.com/twitter-bootstrap/2.3.2/js/bootstrap.min.js"></script>
    <script src="//code.jquery.com/jquery-1.11.1.min.js"></script>


    <title>ClearAccount</title>
</head>
<body style="background: #fff690" runat="server">
    <form class="form-horizontal" method="post" id="formRegistroUsurios" runat="server">
        <fieldset>
            <div id="Register" style="padding-left: 35%">
                <br />
                <h1 style="padding-bottom: 4%">Registro de usuarios</h1>
            </div>
            <div class="control-group">
                <br />
                <div class="row">
                    <div class="col-6" style="padding-left: 28%">
                        <!-- Username -->
                        <label class="control-label" for="usuario">Usuario</label>
                        <div class="controls">
                            <input type="text" id="inputUsuario" name="username" placeholder="Nombre..." class="input-xlarge" runat="server" />
                            <p class="help-block">Puede contener numeros y letras.</p>
                        </div>
                        <br />
                        <!-- Password-->
                        <div class="control-group">
                            <label class="control-label" for="contraseña">Contraseña</label>
                            <div class="controls">
                                <input type="password" id="inputContraseña" name="contraseña" placeholder="Contraseña" class="input-xlarge" runat="server" />
                                <p class="help-block">Debe contener al menos 4 caracteres</p>
                            </div>
                        </div>

                        <div class="control-group">
                            <!-- Confirm Password -->
                            <label class="control-label" for="confirmar_contraseña">Contraseña (Confirmar)</label>
                            <div class="controls">
                                <input type="password" id="inputconfirmar_contraseña" name="confirmar_contraseña" placeholder="confirma..." class="input-xlarge" runat="server" />
                                <p class="help-block">Por favor, confirma tu contraseña</p>
                            </div>
                        </div>
                        <div class="control-group">
                            <!-- Button -->
                            <div class="controls" style="padding-left: 4%">
                                <div>
                                    <button id="btnRegistrar" type="button" class="btn btn-success" runat="server">Registrar</button>
                                    <button id="btnLoguear" type="button" class="btn btn-info" runat="server">Regresar login</button>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </fieldset>
    </form>
</body>
</html>
