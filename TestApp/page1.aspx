<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page1.aspx.cs" Inherits="TestApp.page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height:400px; background-color:gray;">

        <a href="page2.aspx">Goto Page2</a>

        <br />

        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Goto Page2 linkbutton</asp:LinkButton>
    
        <br />
        <br />
        <br />
        <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Goto Page 2 with some data</asp:LinkButton>
    
    </div>
    </form>
</body>
</html>
