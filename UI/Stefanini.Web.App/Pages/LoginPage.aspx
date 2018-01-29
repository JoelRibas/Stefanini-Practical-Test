<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Stefanini.Web.App.Pages.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title>Stefanini Practical</title>

    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <script type="text/javascript" src="/Scripts/SearchAdvancedOptions1.js"></script>

    <link rel="stylesheet" href="/Styles/Buttons.css" />
    <link rel="stylesheet" href="/Styles/GridPager.css" />
    <link rel="stylesheet" href="/Styles/GridViewPaginationBootstrapStyle.css" />
    <link rel="stylesheet" href="/Styles/SearchAdvancedOptions1.css" />

    <link rel="apple-touch-icon" sizes="57x57" href="/Img/Favicon/apple-icon-57x57.png" />
    <link rel="apple-touch-icon" sizes="60x60" href="/Img/Favicon/apple-icon-60x60.png" />
    <link rel="apple-touch-icon" sizes="72x72" href="/Img/Favicon/apple-icon-72x72.png" />
    <link rel="apple-touch-icon" sizes="76x76" href="/Img/Favicon/apple-icon-76x76.png" />
    <link rel="apple-touch-icon" sizes="114x114" href="/Img/Favicon/apple-icon-114x114.png" />
    <link rel="apple-touch-icon" sizes="120x120" href="/Img/Favicon/apple-icon-120x120.png" />
    <link rel="apple-touch-icon" sizes="144x144" href="/Img/Favicon/apple-icon-144x144.png" />
    <link rel="apple-touch-icon" sizes="152x152" href="/Img/Favicon/apple-icon-152x152.png" />
    <link rel="apple-touch-icon" sizes="180x180" href="/Img/Favicon/apple-icon-180x180.png" />
    <link rel="icon" type="image/png" sizes="192x192"  href="/Img/Favicon/android-icon-192x192.png" />
    <link rel="icon" type="image/png" sizes="32x32" href="/Img/Favicon/favicon-32x32.png" />
    <link rel="icon" type="image/png" sizes="96x96" href="/Img/Favicon/favicon-96x96.png" />
    <link rel="icon" type="image/png" sizes="16x16" href="/Img/Favicon/favicon-16x16.png" />
    <link rel="manifest" href="/Img/Favicon/manifest.json" />
    <meta name="msapplication-TileColor" content="#ffffff" />
    <meta name="msapplication-TileImage" content="/Img/Favicon/ms-icon-144x144.png" />
    <meta name="theme-color" content="#ffffff" />

</head>
<body>

    <div class="container">    
        
        <div id="loginbox" class="mainbox col-md-6 col-md-offset-3 col-sm-6 col-sm-offset-3"> 
        
           <div class="row">                
                <div class="iconmelon">
                  <svg viewBox="0 0 0 0">

                  </svg>
                </div>
            </div>
        
            <div class="panel panel-default" >
                <div class="panel-heading">
                    <div class="panel-title text-center">Login</div>
                </div>     

                <div class="panel-body" >

                    <form runat="server" name="form" id="form1" class="form-horizontal" enctype="multipart/form-data" method="POST">
                   


                        <div class="input-group">
                            <span class="input-group-addon"><i class="glyphicon glyphicon-user"></i></span>                        
                            <input runat="server" id="UserName" type="text" class="form-control" name="user" value="" placeholder="Usuário" />                                        
                        </div>


                        <div class="input-group" style="margin-top: 10px;">
                            <span class="input-group-addon"><i class="glyphicon glyphicon-lock"></i></span>
                            <input id="Password" runat="server" type="password" class="form-control" name="password" placeholder="Senha" />
                        </div>                                                                  

                        <div class="checkbox">
                            <label><input runat="server" id="RememerMe" type="checkbox" value="" />Manter-me Logado</label>                                                
                        </div>

                        <div class="form-group">
                            <!-- Button -->
                            <div class="col-sm-12 controls">
                                <button runat="server" id="LoginButton" onserverclick="LoginButton_Click" type="submit" class="btn btn-primary pull-right"><i class="glyphicon glyphicon-log-in"></i> Entrar</button>                         
                            </div>
                        </div>

                        <div runat="server" id="MessageDiv" visible="false" class="alert alert-warning">
                            <asp:Label runat="server" ID="LoginErrorLiteral"></asp:Label>
                        </div>

                    </form>     

                </div>                     
            </div>  
        </div>
    </div>

</body>
</html>
