<%@ Page Language="C#" AutoEventWireup="true" CodeFile="testUpload.aspx.cs" Inherits="views_testUpload" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Index2</title>

    <script src="../Js/jquery.js"></script>

    <script src="../Js/bootstrap.min.js"></script>

    <script src="../Js/fileUpLoad/Index.js"></script>
    <script src="../Js/fileUpLoad/fileinput.min.js"></script>

    <script src="../Js/fileUpLoad/fileinput_locale_zh.js"></script>


    <link href="../Css/bootstrap.min.css" rel="stylesheet" />
    <link href="../Css/fileinput.min.css" rel="stylesheet" />
</head>
<body>
    <div>
        <button id="btn_import" type="button" class="btn btn-default">
            <span class="glyphicon glyphicon-import" aria-hidden="true"></span>导入
        </button>
    </div>

    <form>
        <div class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
            <div class="modal-dialog" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                        <h4 class="modal-title" id="myModalLabel">请选择Excel文件</h4>
                    </div>
                    <div class="modal-body">
                        <a href="~/Data/ExcelTemplate/Order.xlsx" class="form-control" style="border: none;">下载导入模板</a>
                        <input type="file" name="txt_file" id="txt_file" multiple class="file-loading" />
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
