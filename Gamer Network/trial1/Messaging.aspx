<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Messaging.aspx.cs" Inherits="trial1.Messaging" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Messaging</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="gv" CssClass="table table" runat="server" AutoGenerateColumns="true">
         
         <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
         <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
         <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
         <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
         <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
         <SortedAscendingCellStyle BackColor="#FFF1D4" />
         <SortedAscendingHeaderStyle BackColor="#B95C30" />
         <SortedDescendingCellStyle BackColor="#F1E5CE" />
         <SortedDescendingHeaderStyle BackColor="#93451F" />
            </asp:GridView>
             
            <br/>
            <label>Content:</label>
             <asp:TextBox ID="TextBox1" runat="server" style="width: 300px;height:100px"/>
            <br/>
    <asp:Button ID="send" runat="server" Text="Send" OnClick="send_Click" />
         <asp:Button ID="back" runat="server" Text="Back To Main Page" OnClick="back_Click"/>
    </div>
    </form>
</body>
</html>
