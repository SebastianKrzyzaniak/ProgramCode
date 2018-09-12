<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Testowa.aspx.cs" Inherits="WebApplication2.Testowa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>MojaSTRONKA</title>
    <link rel="Stylesheet" type="text/css" href="StyleSheet1.css" />
</head>
<body>
    
<style>
    div.dik2 {
        border: 1px solid #000;
        background-color: orange;
    }
    
    div.dik3 {
        border: 1px solid #000;
        background-color: orange;
    }
</style>

    <form id="form1" runat="server">
        <div class =" dik">
            <asp:Button style="color: red" ID="Button1" runat="server" Height="28px" OnClick="Button1_Click" Text="Button" Width="64px" BackColor="Yellow" BorderColor="Green" />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>    

        <div class="dik2">
            <asp:Button ID="Button2" runat="server" OnClick="Button1_Click" Text="Button" BackColor="Yellow" BorderColor="Green" />
            <asp:Label ID="Label2" runat="server" ForeColor="Red" Text="Label"></asp:Label>
        </div>

         <div class="dik3">
            <asp:Button ID="Button3" runat="server" OnClick="Button1_Click" Text="Button" BackColor="Yellow" BorderColor="Green" />
            <asp:Label ID="Label3" runat="server" ForeColor="Red" Text="Label"></asp:Label>
        </div>
        <div>
            <input class="input1" type="text" name="imie" placeholder="Imie" id="imie" runat="server"  />WITAM<br /> 
        </div>

    <ul class="menu">
         <li>Home</li>
        <li>Products</li>
        <li>About</li>
    </ul>
        <button type="button"  id="click" runat="server" ><a href="https://www.facebook.com"><img src="ih.png"></img></a></button> 
        <img src="ih.png" alt="Tu podaj tekst alternatywny" />
            <%--<a href="https://www.facebook.com">Click</a>--%>
    </form>
   
<div id="content"></div>

    <script type="text/javascript" src="JavaS.js"></script>

	<script type="text/javascript" src="JavaS2.js"></script>
		
    	<%--<script type="text/javascript" src="JavaS3.js"></script>--%>
	
</body>
</html>
