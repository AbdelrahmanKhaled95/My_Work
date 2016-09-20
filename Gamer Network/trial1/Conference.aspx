<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Conference.aspx.cs" Inherits="trial1.Conference" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <title>Conferences</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="gv" CssClass="table table" runat="server" OnRowEditing="gv_RowEditing" OnRowCancelingEdit="gv_RowCancelingEdit" OnRowUpdating="gv_RowUpdating" >
            <Columns>
                <asp:CommandField EditText="Review" HeaderText="Review" ShowEditButton="True" ShowHeader="True" UpdateText="Confirm" />
            </Columns>
            </asp:GridView>
         </div>
    </form>
</body>
</html>
