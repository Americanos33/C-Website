﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page2.aspx.cs" Inherits="TestApp.page2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height:400px; background-color:lightskyblue;">

        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Goto Page 1 with linkbutton</asp:LinkButton>
    
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="var1 = "></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server" Text="ID = "></asp:Label>
    
    </div>
    </form>
</body>
</html>
