<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VerifiedUpdate.aspx.cs" Inherits="trial1.VerifiedUpdate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Update my information</title>
            <style>
div {
 width:200px;
 padding:0.5px;
 background:#ffffff;
 border:nonesolid;

}     
  </style>
</head>
<body background="ab2.jpg">
   <form id="form1" runat="server">

        <div>
             <h1> Updating Verified Reviewer's Information</h1>
        </div>
       
     
        <br />
        <font size="7" color="WHITE">New Frist Name:</font>
        <asp:TextBox ID="teamname" runat="server" />
        <br />
        
       <font size="7" color="WHITE">New Last Name:</font>
        <asp:TextBox ID="comname" runat="server" />
          <br />
        
        <font size="7" color="WHITE">New Date of Experence:</font>
        <asp:TextBox ID="formation" runat="server" />
      
       <br />
            <asp:Button ID="done" runat="server" Text="Done"  OnClick="done_Click" />
        
    </form>
</body>
</html>
