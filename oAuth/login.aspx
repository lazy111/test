<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication3.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script>
        var foo = function () {

        };
        foo.prototype.hello = function () {
            alert("hello !");
        }

        var f = new foo();
        f.good = function () {
            alert("good !");
        }

        f.hi = function () {
            alert("hi!");
        }
        for (var item in f) {
            if (f.hasOwnProperty(item)) {
                f[item].call(f);
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>
</body>
</html>
