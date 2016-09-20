<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DevelopmentTeam.aspx.cs" Inherits="trial1.DevelopmentTeam" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Development Team</title>
    
</head>
<body background="maxresdefault.jpg">
    <form id="form1" runat="server">

        <div>
        <font size="7" color="WHITE">*Team Name:</font>
        <asp:TextBox ID="teamname" runat="server" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="emailbox" ErrorMessage="Team Name is required" Display="Dynamic" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
        <div>
       <font size="7" color="WHITE">*Company Name:</font>
        <asp:TextBox ID="comname" runat="server" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="emailbox" ErrorMessage="Company Name is required" Display="Dynamic" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:RequiredFieldValidator>
           </div>
        <div>
        <font size="7" color="WHITE">*Date of Formation:</font>
        <asp:TextBox ID="formation" runat="server" placeholder="YYYY-MM-DD" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="emailbox" ErrorMessage="Date of Formation is required" Display="Dynamic" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
            <div>
        <font size="7" color="WHITE">Email:</font>
        <asp:TextBox ID="emailbox" runat="server" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="emailbox" ErrorMessage="Email is required" Display="Dynamic" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:RequiredFieldValidator>
        <div> 
              
            <font size="8" color="White">Password: </font>
            <asp:TextBox ID="passBox" runat="server"  TextMode="Password" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="emailbox" ErrorMessage="Password is required" Display="Dynamic" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <font size="8" color="White">Prefered Genre: </font>
            <asp:DropDownList ID="genres" runat="server" >
            <asp:ListItem  Text="Sports" Value="Sports" />
            <asp:ListItem Text="Action" Value="Action" />
            <asp:ListItem Text="Strategy" Value="Strategy" />
            <asp:ListItem Text="RGPs" Value="RGPs" />
            </asp:DropDownList>

        </div>
         
        <div algin="south">
            <asp:Button ID="done" runat="server" Text="Done" OnClick="done_Click" />
        </div>
         <div align="bottom">
         <img src="EA_Sports_Logo.png" width="200" height="200" />
         <img src="EA-E3-persconferentie-datum-bekend.png" width="200" height="200" />
         <img src="Activision_logo.png" width="250" height="200" />
         <img src="Rockstar_Games.png" width="200" height="200" />
         <img src="Ubisoft.png"  />
         <img src="Naughty_Dog_30_Years.png" width="200" height="200" />
         </div>
    </form>
</body>
</html>
