<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Site1.Index" %>
<%@ Register Src="~/WebUserControl1.ascx" TagPrefix="uc" TagName="sitemap" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       <uc:sitemap runat="server"></uc:sitemap>
    </div>
    </form>
</body>
</html>
