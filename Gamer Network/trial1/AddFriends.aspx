<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddFriends.aspx.cs" Inherits="trial1.AddFriends" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Friends</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="gv" CssClass="table table" runat="server" AutoGenerateColumns="False" OnRowEditing="gv_RowEditing" OnRowUpdating="gv_RowUpdating" OnRowCancelingEdit="gv_RowCancelingEdit" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" OnSelectedIndexChanged="gv_SelectedIndexChanged" >
            <AlternatingRowStyle BackColor="#F7F7F7" />
            <columns>
                <asp:BoundField DataField="email" HeaderText="Email" />
                <asp:CommandField HeaderText="ADD" ShowEditButton="true" EditText="Add" UpdateText="Ok" />
            </columns>
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
        <p>
        <asp:Button ID="back" runat="server" Text="Back To Main Page" OnClick="back_Click"/>
        </p>
    </form>
</body>
</html>
