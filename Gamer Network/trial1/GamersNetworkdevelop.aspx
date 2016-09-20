<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GamersNetworkdevelop.aspx.cs" Inherits="trial1.GamersNetworkdevelop" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Gamers Network</title>
</head>
<body background="Tom-Clancys-The-Division-2015-Game-Wallpaper.jpg">

    <form id="form1" runat="server">
   
        <asp:Button ID="updateme" runat="server" Text="Update my Profile" OnClick="updateme_Click" />
        <asp:Button ID="com" runat="server" Text="Communtiy" OnClick="com_Click" />
        <asp:Button ID="games" runat="server" Text="Games" OnClick="games_Click" />
        <asp:Button ID="conferences" runat="server" Text="My Conferences" OnClick="conferences_Click" />
        <asp:Button ID="addgame" runat="server" Text="Add New Game" OnClick="addgame_Click" />
        <asp:Button ID="attend" runat="server" Text="Add conference" OnClick="attend_Click" />
         <asp:Button ID="conrew" runat="server" Text="Review conference" OnClick="conrew_Click" />
         <asp:Button ID="reviewcomments" runat="server" Text="Review conference comments" OnClick="reviewcomments_Click" />
         <asp:Button ID="viewcon" runat="server" Text="View conference " OnClick="viewcon_Click" />
        <asp:Button ID="delete" runat="server" Text="Delete conference comments" OnClick="delete_Click" />
        <asp:Button ID="logout" runat="server" Text="LogOut" OnClick="logout_Click" />
 
          
    <style>
        
div {
 align=" top center";
 width:500px;
 padding:2px;
 background:#808080;
 border:solid;

}     
  </style>

        <div>
   <asp:GridView ID="gv" CssClass="table table" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" >
       <AlternatingRowStyle BackColor="#CCCCCC" />
       <FooterStyle BackColor="#CCCCCC" />
       <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
       <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
       <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
       <SortedAscendingCellStyle BackColor="#F1F1F1" />
       <SortedAscendingHeaderStyle BackColor="#808080" />
       <SortedDescendingCellStyle BackColor="#CAC9C9" />
       <SortedDescendingHeaderStyle BackColor="#383838" />
   </asp:GridView>
    </div>
        <div align="center">
            <label>Search:</label>
       <asp:TextBox ID="search" runat="server" placeholder="Games,Conferences,Communities,Verified reviewers and Development team" Width="380px" style="margin-left: 0px"></asp:TextBox>
             <asp:Button ID="searchbtn" runat="server" Text="Search" OnClick="searchbtn_Click" />
   </div>
   
    </form>
</body>
</html>

