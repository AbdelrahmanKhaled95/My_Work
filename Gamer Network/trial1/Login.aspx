<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="trial1.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
</head>
<body background="BigGamesOf2015_1_1280-1419971862618.jpg">
    <form id="form1" runat="server">
     <div>
        <font size="7" color="WHITE">*Email:</font>
        <asp:TextBox ID="emailbox" runat="server" />
         <asp:RequiredFieldValidator ID="rqemail" runat="server" ControlToValidate="emailbox" ErrorMessage="Email is required" Display="Dynamic" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:RequiredFieldValidator>
        <div> 
              
            <font size="8" color="White">*Password: </font>
            <asp:TextBox ID="passBox" runat="server" TextMode="Password" />
            <asp:RequiredFieldValidator ID="rqpassword" runat="server" ControlToValidate="passbox" ValidationGroup="valgrop" CssClass="error" ErrorMessage="Password is required" Display="Dynamic" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:RequiredFieldValidator>
    </div>
        <div>
            <asp:Button ID="done" runat="server" Text="Done" OnClick="done_Click" />
        </div>
         <br />
         </form>
</body>
</html>
