<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="trial1.Homepage" %>

<!DOCTYPE html>

<head runat="server">
    <title>Gamers Network</title>
    <meta charset="utf-8" />
    <meta name="description"content="This is a communtiy for gamers where they can review,rate and know all the latest news about their favourate games"
   <div align="top">
         <img src="Games_for_Windows_logo.png" />
     </div>
    
        
</head>
<body background="watch_dogs_hd_wallpaper_by_valencygraphics-d6jv0dv (1).jpg">
     
    <style>
        
div {
 align=" top center";
 width:500px;
 padding:2px;
 background:#808080;
 border:solid;

}     
  </style>
    
  <div >  
      <h1 align="center">Gamers Network </h1>
    <h5 align="center">THE BIGGEST COMMUNITY FOR GAMMERS EVER MADE !!!!</h5>
  </div>
    
    <form id="form1" runat="server">
       
        
  <div>
   <asp:button id="login" runat="server" text="Login" OnClick="login_Click" />
        <asp:button id="Signup" runat="server" text="Sign Up" OnClick="Signup_Click" />
   
    </form>
</body>
</html>
