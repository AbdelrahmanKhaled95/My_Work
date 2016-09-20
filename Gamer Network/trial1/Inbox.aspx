<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inbox.aspx.cs" Inherits="trial1.Inbox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Inbox</title>
</head>
<body background="5x7-golden-yellow.png" align="center">
    <form id="form1" runat="server">
    <div>
        <img src="Outlook_Icon.gif" />
        </div>
        <div>
     <asp:GridView ID="gv" CssClass="table table" runat="server" AutoGenerateColumns="false" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" OnRowEditing="gv_RowEditing" OnRowUpdating="gv_RowUpdating" OnRowCancelingEdit="gv_RowCancelingEdit">
         <Columns>
             <asp:BoundField DataField="first_name" HeaderText="First Name" />
             <asp:BoundField DataField="last_name" HeaderText="Last Name" />
             <asp:BoundField DataField="email" HeaderText="Email" />
             <asp:CommandField ButtonType="Button" EditText="Send Message" HeaderText="Message" ShowEditButton="True" ShowHeader="True" UpdateText="OK" />
         </Columns>
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
 
    </div>
        <p class="marquee">
    <span id="dtText">
        <asp:Button ID="back" runat="server" Text="Back To Main Page" OnClick="back_Click"/>
            </span>
</p>
    </form>
</body>
</html>
