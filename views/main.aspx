<%@ Page Language="C#" AutoEventWireup="true" CodeFile="main.aspx.cs" Inherits="views_main" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="UTF-8">
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title></title>
    <link rel="stylesheet" href="../Css/bootstrap.min.css">
    <link rel="stylesheet" href="../Css/bootstrap-datepicker.min.css">
    <link href="../Css/fileinput.min.css" rel="stylesheet" />
    <!--<link rel="stylesheet" href="../css/ionic.css" th:href="@{/css/ionic.css}">-->
    <!-- HTML5 shim 和 Respond.js 是为了让 IE8 支持 HTML5 元素和媒体查询（media queries）功能 -->
    <!-- 警告：通过 file:// 协议（就是直接将 html 页面拖拽到浏览器中）访问页面时 Respond.js 不起作用 -->
    <!--[if lt IE 9]>
    <script src="https://cdn.jsdelivr.net/npm/html5shiv@3.7.3/dist/html5shiv.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/respond.js@1.4.2/dest/respond.min.js"></script>
    <![endif]-->
    <style type="text/css">
        @media (min-width: 780px) {
            #menu_left {
                width: 250px;
                margin-top: 51px;
                position: absolute;
                z-index: 1;
                height: 600px;
            }

            .search-bar {
                margin-top: 10px;
                margin-bottom: 10px;
            }

            .page_main {
                margin-top: 0;
                margin-left: 255px;
            }

            .mybreadcrmb {
                margin-top: 0;
            }
        }
    </style>
</head>
<body ng-app="actionApp">
    <!--导航-->
    <nav class="navbar navbar-default  navbar-static-top">
        <div class="navbar-header">
            <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#menu_left"
                aria-expanded="false" aria-controls="navbar">
                <span class="sr-only">Toggle navigation</span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
            </button>
            <a href="#" class="navbar-brand">文件上传管理系统</a>
        </div>

        <ul class="nav navbar-nav navbar-right" style="margin-right: 30px">
            <li><a href="#"><span class="badge" style="background-color: red">223</span></a></li>
            <li><a href="#"><span th:text="${MenuModel.userloginname}" /></a></li>
            <li></li>
            <li><a href="/logout"><span class="glyphicon glyphicon-off">&nbsp;注销</span></a></li>
        </ul>
        <!--侧边栏-->
        <!--媒体导入 解决大屏幕样式全屏问题-->
        <div class="navbar-default navbar-collapse panel-group" id="menu_left">
            <ul class="nav">
                <li id="mySearch">
                    <!--搜索-->
                    <div class="input-group search-bar">
                        <input type="text" class="form-control">
                        <!--一行-->
                        <span class="input-group-btn">
                            <button type="button" class="btn btn-default">
                                <span class="glyphicon glyphicon-search"></span>
                            </button>
                        </span>

                    </div>
                </li>
            </ul>

        </div>
    </nav>
    <!--右侧内容-->
    <div class="page_main">

        <!--导航-->
        <ol class="breadcrumb mybreadcrmb">
            <li><a href="javascirpt:0">主页</a></li>
            <li><a href="#!/servInfo">Library</a></li>
            <li class="active">Data</li>
        </ol>

        <div class="content">
            <ng-view></ng-view>
        </div>


    </div>

    <script src="../Js/jquery.js"></script>
    <script src="../Js/bootstrap.js"></script>

    <script src="../Js/iniPageInfo/iniPage.js"></script>
    <script src="../Js/angular1.7.min.js"></script>
    <script src="../Js/angular-route1.7.min.js"></script>
    <script src="../Js/ui-bootstrap-tpls.js"></script>

    <script src="../Js/bootstrap-datepicker.min.js"></script>
    <script src="../Js/bootstrap-datepicker.zh-CN.min.js"></script>

    <script src="../Js/angularController/routeConfigure.js"></script>



    <script src="../Js/fileUpLoad/Index.js"></script>
    <script src="../Js/fileUpLoad/fileinput.min.js"></script>
    <script src="../Js/fileUpLoad/fileinput_locale_zh.js"></script>




    <script type="text/javascript">
  
        var menuCollections =<%=  getMenu() %>;

        $.ready(readMenu(menuCollections));//JQ获取菜单并动态显示
    </script>

</body>
</html>
