<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NormalUser.aspx.cs" Inherits="trial1.NormalUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Normal User</title>
</head>
<body background="653971-video-shooting-games.jpg">
    <form id="form1" runat="server">
    <div>
        
        <font size="7" color="WHITE">*First Name:</font>
        <asp:TextBox ID="fristname" runat="server" />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="emailbox" ErrorMessage="First Name is required" Display="Dynamic" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
        <div>
       <font size="7" color="WHITE">*Last Name:</font>
        <asp:TextBox ID="lastname" runat="server" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="emailbox" ErrorMessage="Last Name is required" Display="Dynamic" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:RequiredFieldValidator>
           </div>
        <div>
        <font size="7" color="WHITE">*Date of Birth:</font>
        <asp:TextBox ID="birth" runat="server" placeholder="YYYY-MM-DD"/>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="emailbox" ErrorMessage="Date of Birth is required" Display="Dynamic" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
            <div>
        <font size="7" color="WHITE">*Email:</font>
        <asp:TextBox ID="emailbox" runat="server" />
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="emailbox" ErrorMessage="Email is required" Display="Dynamic" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:RequiredFieldValidator>
        <div> 
              
            <font size="8" color="White">*Password: </font>
            <asp:TextBox ID="passBox" runat="server" TextMode="Password" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="emailbox" ErrorMessage="Password is required" Display="Dynamic" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <font size="8" color="White">Prefered Genre: </font>
            <asp:DropDownList ID="genres" runat="server" >
            <asp:ListItem  Text="Sports" Value="Sports" />
            <asp:ListItem Text="Action" Value="Action" />
            <asp:ListItem Text="Strategy" Value="Strategy" />
            <asp:ListItem Text="RGPs" Value="RGPs" />
            </asp:DropDownList>

        </div>
       
         <div>
            <asp:Button ID="done" runat="server" Text="Done" OnClick="done_Click" />
        </div>
    </form>
</body>
</html>
