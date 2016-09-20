<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add Confeerence.aspx.cs" Inherits="trial1.Add_Confeerence" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:GridView ID="gv" CssClass="table table" runat="server" AutoGenerateColumns="true" OnRowEditing="gv_RowEditing" OnRowUpdating="gv_RowUpdating" OnRowCancelingEdit="gv_RowCancelingEdit" >
        <Columns>
            <asp:CommandField EditText="Attend" HeaderText="Attend" ShowEditButton="True" ShowHeader="True" UpdateText="Confirm" />
        </Columns>
            </asp:GridView>
    </div>
    </form>
</body>
</html>
