﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ClearAccount.WebApp.Login" %>

<!doctype html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">

    <title>Signin=" Template · Bootstrap</title>


    
    <link rel="stylesheet" href="/Content/bootstrap-theme.css" />
    <link rel="stylesheet" href="/Content/bootstrap-theme.css.map" />
    <link rel="stylesheet" href="/Content/bootstrap-theme.min.css" />
    <link rel="stylesheet" href="/Content/bootstrap-theme.min.css.map" />
    <link rel="stylesheet" href="/Content/bootstrap.css" />
    <link rel="stylesheet" href="/Content/bootstrap.css.map" />
    <link rel="stylesheet" href="/Content/bootstrap.min.css" />
    <link rel="stylesheet" href="/Content/bootstrap.min.css.map" />

    <!-- Bootstrap core CSS -->

    <style>
        .bd-placeholder-img {
            font-size: 1.125rem;
            text-anchor: middle;
            -webkit-user-select: none;
            -moz-user-select: none;
            -ms-user-select: none;
            user-select: none;
        }

        @media (min-width: 768px) {
            .bd-placeholder-img-lg {
                font-size: 3.5rem;
            }
        }
    </style>
    <!-- Custom styles for this template -->
    <link href="signin.css" rel="stylesheet">
</head>
<body class="text-center">
    <form class="form-signin">
        <img class="mb-4" src="/docs/4.3/assets/brand/bootstrap-solid.svg" alt="" width="72" height="72">
        <h1 class="h3 mb-3 font-weight-normal">Please sign in</h1>
        <label for="inputEmail" class="sr-only">Email address</label>
        <input type="email" id="inputEmail" class="form-control" placeholder="Email address" required autofocus>
        <label for="inputPassword" class="sr-only">Password</label>
        <input type="password" id="inputPassword" class="form-control" placeholder="Password" required>
        <div class="checkbox mb-3">
            <label>
                <input type="checkbox" value="remember-me">
                Remember me
            </label>
        </div>
        <button class="btn btn-lg btn-primary btn-block" type="submit">Sign in</button>
        <p class="mt-5 mb-3 text-muted">&copy; 2017-2019</p>
    </form>
</body>
</html>
