<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AuthTicket.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div>
            原用户名：<asp:TextBox runat="server" ID="txtLoginName1"></asp:TextBox>
        </div>
        <div>
            用户名：<asp:TextBox runat="server" ID="txtLoginName"></asp:TextBox>
        </div>
        <div>
            密码：<asp:TextBox runat="server" ID="txtLoginPwd"></asp:TextBox>
        </div>
        <div>
            <asp:Button Text="登录" runat="server"  ID="btnLogOn" OnClick="btnLogOn_Click"/>
        </div>
    </form>
</body>
</html>
