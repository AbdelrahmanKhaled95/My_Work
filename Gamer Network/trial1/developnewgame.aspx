<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="developnewgame.aspx.cs" Inherits="trial1.developnewgame" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>New Game</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label ID="newgame" runat="server" Text="Enter Game Name To Add"></asp:Label>
        <asp:TextBox ID="gamename" runat="server" ></asp:TextBox>
        <asp:GridView ID="gv" CssClass="table table" runat="server" AutoGenerateColumns="true" OnRowEditing="gv_RowEditing" OnRowUpdating="gv_RowUpdating" OnRowCancelingEdit="gv_RowCancelingEdit" >
            <Columns>
                <asp:CommandField EditText="Add new game" HeaderText="New Game" ShowEditButton="True" ShowHeader="True" UpdateText="Confirm" />
            </Columns>
            </asp:GridView>
    </div>
    </form>
</body>
</html>
