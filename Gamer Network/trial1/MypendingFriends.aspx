<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MypendingFriends.aspx.cs" Inherits="trial1.MypendingFriends" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>My pending Friends</title>
</head>
<body background="Empresas-Multinivel.png">
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="gv" CssClass="table table" runat="server" AutoGenerateColumns="False" OnRowEditing="gv_RowEditing" OnRowUpdating="gv_RowUpdating" OnRowCancelingEdit="gv_RowCancelingEdit" OnRowDeleting="gv_RowDeleting">
            <columns>
                <asp:BoundField DataField="first_name" HeaderText="First Name" />
                <asp:BoundField DataField="last_name" HeaderText="Last Name" />
                <asp:BoundField DataField="email" HeaderText="Email" />
                <asp:CheckBoxField DataField="accept" HeaderText="Acceptance" />
                <asp:CommandField HeaderText="Accept" ShowEditButton="true" EditText="Accept" UpdateText="OK" />
                <asp:CommandField HeaderText="Reject" ShowDeleteButton="true" EditText="Reject" UpdateText="Ok" />
            </columns>
            </asp:GridView>
         </div>
        <br />
        <div>
        <asp:Button ID="back" runat="server" Text="Back To Main Page" OnClick="back_Click"/>
    </div>
   
    </form>
</body>
</html>
