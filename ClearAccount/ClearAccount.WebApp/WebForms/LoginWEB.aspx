<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginWEB.aspx.cs" Inherits="ClearAccount.WebApp.WebForms.LoginWEB" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

 <link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" />
    <script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
    <script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>

    <link href="/Content/login.css" rel="stylesheet"/>

   

    <title>Hola</title>
</head>
<body>
    <form id="formLogin" class="form"  method="post" runat="server">
        <div id="login">
            <h3 class="text-center text-white pt-5"><strong>ClearAccount</strong></h3>
            <div class="container">
                <div id="login-row" class="row justify-content-center align-items-center">
                    <div id="login-column" class="col-md-6">
                        <div class="login-box col-md-12">

                            <h3 class="text-center text-info">LogIn</h3>
                            <div class="form-group">
                                <label for="Usuario" class="text-info">Usuario:</label><br />
                                <input type="text" name="inputUsuario" id="inputUsuario" class="form-control" runat="server" />
                            </div>
                            <div class="form-group">
                                <label for="Contraseña" class="text-info">Contraseña:</label><br />
                                <input type="password" name="inputContraseña" id="inputContraseña" class="form-control" runat="server" />
                            </div>
                            <div class="form-group">
                                <label for="remember-me" class="text-info"><span>Remember me</span><span><input id="inputRemember-me" name="remember-me" type="checkbox" /></span></label><br />
                                <!--Boton para ingresar-->
                                <button id="btnIngresar" class="btn btn-info btn-md" type="button" runat="server">Ingresar</button>
                            </div>
                            <div id="register-link" class="text-right">
                                <a href="https://localhost:44334/WebForms/RegistroUsuarios1" class="text-info"><strong>Registrate aqui</strong></a>
                            </div>

                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>