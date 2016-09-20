<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="trial1.Error" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Error</title>
    <style>
        span{
            color:#ff0000
            font-weight:bold
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Either your Email or Password are wrong</h1>
        <h2>If you are a new member please <span>Sign Up </span>or if you are an old member please <span>Login</span> </h2>
        <asp:Button ID="return" runat="server" Text="Go to Login Page" OnClick="return_Click"/>
        <asp:Button ID="signup" runat="server" Text="Go to Sign Up" OnClick="signup_Click"/>
    </div>
    </form>
</body>
</html>
