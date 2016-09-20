<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Game.aspx.cs" Inherits="trail1.Game" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" style="margin-top: 3px" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnRowCancelingEdit="GridView1_RowCancelingEdit">
            <Columns>
                <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                <asp:BoundField DataField="release_date" HeaderText="release_date" SortExpression="release_date" />
                <asp:BoundField DataField="age_limit" HeaderText="age_limit" SortExpression="age_limit" />
                <asp:BoundField DataField="team_name" HeaderText="team_name" SortExpression="team_name" />
                <asp:BoundField DataField="screen shot" HeaderText="screen shot" SortExpression="screen shot" />
                <asp:BoundField DataField="video" HeaderText="video" SortExpression="video" />
                <asp:CheckBoxField DataField="Real_time" HeaderText="Real_time" SortExpression="Real_time" />
                <asp:BoundField DataField="sub_genre" HeaderText="sub_genre" SortExpression="sub_genre" />
                <asp:BoundField DataField="type_of_sport" HeaderText="type_of_sport" SortExpression="type_of_sport" />
                <asp:BoundField DataField="story_line" HeaderText="story_line" SortExpression="story_line" />
                <asp:CheckBoxField DataField="PvP" HeaderText="PvP" SortExpression="PvP" />
                <asp:BoundField DataField="content" HeaderText="content" SortExpression="content" />
                <asp:CommandField EditText="Rate Comments" HeaderText="Rating" ShowEditButton="True" ShowHeader="True" UpdateText="Confirm" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Team %>" SelectCommand="gameViewinformation" SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:ControlParameter ControlID="Label1" Name="name" PropertyName="Text" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
    
    </div>
    </form>
</body>
</html>
