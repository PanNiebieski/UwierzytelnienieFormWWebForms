<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="UwierzytelnienieForm.Index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:label id="lblUserInfo" runat="server" text="Label" /><br /><br />
    <asp:button id="btnLogOut" runat="server" text="Wyloguj" 
        onclick="btnLogOut_Click" />
<asp:LoginView ID="LoginView1" runat="server">
    <RoleGroups>
        <asp:RoleGroup Roles="Admin">
            <ContentTemplate>
                Tutaj umieść pole administratora.
            </ContentTemplate>
        </asp:RoleGroup>
        <asp:RoleGroup Roles="Użytkownicy" >
            <ContentTemplate>
                Tutaj umieść logo.
            </ContentTemplate>
        </asp:RoleGroup>
    </RoleGroups>
</asp:LoginView>
    </form>
</body>
</html>
