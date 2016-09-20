<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FriendRequestSent.aspx.cs" Inherits="trial1.FriendRequestSent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Friend Request Sent</title>
</head>
<body background="Empresas-Multinivel.png">
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="gv" CssClass="table table" runat="server" AutoGenerateColumns="true" >
            <AlternatingRowStyle BackColor="#F7F7F7" />
           
            <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
            <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
            <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
            <SortedAscendingCellStyle BackColor="#F4F4FD" />
            <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
            <SortedDescendingCellStyle BackColor="#D8D8F0" />
            <SortedDescendingHeaderStyle BackColor="#3E3277" />
            </asp:GridView>
         </div>
        <br />
        <div>
        <asp:Button ID="back" runat="server" Text="Back To Main Page" OnClick="back_Click"/>
    </div>
   
    </form>
</body>
</html>

