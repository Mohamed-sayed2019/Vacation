<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Vacation.vacationforms.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 277px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style1">UserName</td>
                    <td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Password</td>
                    <td>
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" ></asp:TextBox>
                    </td>
                </tr>
               <tr>
                   <td></td>
                   <td>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="LogIn" />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                   </td>
               </tr>
            </table>
        </div>
    </form>
</body>
</html>
