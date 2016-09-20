<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="trial1.Signup" %>

<!DOCTYPE html>
 <title>Sign Up</title>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   
</head>
<body>
   <form id="form1" runat="server">
       <div align="center">
            <img  src="110-gaming-logo.png" />
       </div>
      
    <h1 align="center">It's Free and it will always Be</h1>
        
       
        
        <div align="center">
            <font size="7" color="red">Register As</font>
             </div>
       <div align="center">
            <asp:Button ID="normal" runat="server" Text="Normal User" OnClick="normal_Click" />
            <asp:Button ID="verified" runat="server" Text="Verified Reviwer" OnClick="verified_Click" />
            <asp:Button ID="development" runat="server" Text="Development Team" OnClick="development_Click" />
         </div>
       <div align="center">
            <img  src="WikiProject_Video_Games_Controller_Logo_Revised_2014_-_Small.svg.png"width="800"height="400" />
       </div>
     </form>
</body>
</html>
