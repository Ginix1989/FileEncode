<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>
<html xmlns:th="http://www.thymeleaf.org"
xmlns:layout="http://www.ultraq.net.nz/web/thymeleaf/layout">
<head>
    <meta charset="UTF-8">
    .
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>$Title$</title>
    <link rel="stylesheet" href="../css/bootstrap.min.css" th:href="@{/css/bootstrap.min.css}">
    <link rel="stylesheet" href="../css/login/mylogin.css" th:href="@{/css/login/mylogin.css}">

    <!-- HTML5 shim 和 Respond.js 是为了让 IE8 支持 HTML5 元素和媒体查询（media queries）功能 -->
    <!-- 警告：通过 file:// 协议（就是直接将 html 页面拖拽到浏览器中）访问页面时 Respond.js 不起作用 -->
    <!--[if lt IE 9]>
    <script src="https://cdn.jsdelivr.net/npm/html5shiv@3.7.3/dist/html5shiv.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/respond.js@1.4.2/dest/respond.min.js"></script>
    <![endif]-->
    <style>
        body {
            color: #696969;
            margin: auto;
            height: 100vh;
        }

        .center-vertical {
            position: relative;
            top: 50%;
            transform: translateY(-50%);
        }
    </style>



</head>
<body>
    <div class="container center-vertical">
        <div class="row">
            <div class="  col-md-offset-4 col-md-6 ">
                <form class="form-horizontal" id="formLogin" method="post" runat="server">
                    <span class="heading">用户登录</span>
                    <div class="form-group">

                        <asp:TextBox type="text" class="form-control" id="username" name="username" placeholder="用户名"
                            value="admin1" runat="server" ></asp:TextBox>
                        <i class="fa fa-user"></i>
                    </div>
                    <div class="form-group help">
                        <asp:TextBox  type="password" class="form-control" id="password" name="password" placeholder="密　码"
                            value="admin6"  runat="server"> </asp:TextBox>
                        <i class="fa fa-lock"></i>
                        <a href="#" class="fa fa-question-circle"></a>
                    </div>



                    <div class="form-group">
                        <asp:Button type="submit" class="btn " runat="server" onclick="loginClick" Text="登 &nbsp; &nbsp;录"></asp:Button>


                    </div>
                </form>


            </div>
        </div>
    </div>

    <script src="../js/jquery.js" th:src="@{/js/jquery.js}"></script>
    <script src="../js/bootstrap.min.js" th:src="@{/js/bootstrap.min.js}"></script>
</body>
</html>
