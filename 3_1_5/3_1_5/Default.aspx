<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_3_1_5.Default" %>

<%@ Register assembly="WebValidates" namespace="WebValidates" tagprefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>用户名：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
            验证码：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <cc1:ValidateCode ID="ValidateCode1" runat="server" /><br />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
            <asp:Label ID="Label1" runat="server" Visible="False"></asp:Label><br />
        </div>
    </div>
    </form>
</body>
</html>
