<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AttendedCon2.aspx.cs" Inherits="trial1.AttendedCon2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>My Attended Con</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:GridView ID="gv2" CssClass="table table" runat="server" AutoGenerateColumns="true" OnRowCancelingEdit="gv_RowCancelingEdit" OnRowEditing="gv_RowEditing" OnRowUpdating="gv_RowUpdating" >
        <Columns>
            <asp:CommandField EditText="Add new review" ShowEditButton="True" />
        </Columns>

    </asp:GridView>
    </div>
        <asp:TextBox ID="TextBox1" runat="server" Width="356px">Write Review in this order: Title, Conten, Date </asp:TextBox>
        <asp:TextBox ID="t" runat="server" ></asp:TextBox>
        <asp:TextBox ID="c" runat="server"></asp:TextBox>
        <asp:TextBox ID="d" runat="server"></asp:TextBox>
    </form>
</body>
</html>
