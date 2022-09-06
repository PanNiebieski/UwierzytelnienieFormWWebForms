<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogOn.aspx.cs" Inherits="UwierzytelnienieForm.LogOn" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Prosta uwierzytelnienie ASP.NET - Statyczna klasa FormsAuthentication</title>
</head>
<body>
<h1>Login Page</h1>
    <form id="form1" runat="server">
        Login_ :  <asp:Textbox id="txtLogin" runat="server" /><br /><br />
        Hasło_ : <asp:Textbox id="txtPassword" runat= "server" TextMode="Password" /><br /><br />
        <asp:checkbox id="chkPersist" runat="server" Text="Zapamiętaj mnie w ciasteczkach"  /><br /><br />
        <asp:Button id="btnLog" runat="server" Text="Zaloguj" onclick="btnLog_Click" />    
    </form>
</body>
</html>

