<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CommentReviews.aspx.cs" Inherits="trial1.CommentReviews" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:GridView ID="gv" CssClass="table table" runat="server"  OnRowDeleting="gv_RowDeleting">
        <Columns>
            <asp:ButtonField CommandName="Delete" HeaderText="Delete comment" ShowHeader="True" Text="Button" />
        </Columns>
    </asp:GridView>
        </div>
    </form>
</body>
</html>
