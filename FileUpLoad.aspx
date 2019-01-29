<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FileUpLoad.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
  <p>服务器端控件上传</p>
    <asp:FileUpload ID="MyFileUpload" runat="server" /> 
        <asp:Button ID="FileUploadButton" runat="server" Text="上传" 
            onclick="FileUploadButton_Click" />
    </form>
</body>
</html>
