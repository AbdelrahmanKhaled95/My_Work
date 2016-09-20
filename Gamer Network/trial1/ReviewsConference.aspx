<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReviewsConference.aspx.cs" Inherits="trial1.ReviewsConference" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="gv" CssClass="table table" runat="server" OnRowCancelingEdit="gv_RowCancelingEdit" OnRowEditing="gv_RowEditing" OnRowUpdating="gv_RowUpdating"  >
            <Columns>
                <asp:CommandField HeaderText="Add Comment" ShowEditButton="True" ShowHeader="True" />
            </Columns>
          </asp:GridView>
    </div>
        <p>
            <asp:TextBox ID="TextBox1" runat="server">Write Comment</asp:TextBox>
            <asp:TextBox ID="content" runat="server"></asp:TextBox>
        </p>
    </form>
</body>
</html>
