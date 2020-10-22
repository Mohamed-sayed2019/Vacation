<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="createacation.aspx.cs" Inherits="Vacation.vacationforms.createacation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
   
    <style type="text/css">
        .auto-style1 {
            width: 371px;
        }
    </style>
   
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style1">submissiondate:</td>
                    <td>
            <asp:TextBox ID="Label1" runat="server" Text=""></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">UserName:</td>
                    <td><asp:TextBox ID="TextBox1" runat="server" required ReadOnly></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Titel:</td>
                    <td><asp:TextBox ID="TextBox2" runat="server" required ReadOnly></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Depaerment:</td>
                    <td><asp:TextBox ID="TextBox3" runat="server" required ReadOnly></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">From:</td>
                    <td><asp:TextBox ID="date1" runat="server" placeholder="mm/dd/yyyy" Textmode="Date" ReadOnly = "false" required ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">To:</td>
                    <td><asp:TextBox ID="date2" runat="server" placeholder="mm/dd/yyyy" Textmode="Date" ReadOnly = "false" onchange="getduration()" required ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Return:</td>
                    <td><asp:TextBox ID="TextBox4" runat="server" required ReadOnly></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Duration:</td>
                    <td><asp:TextBox ID="Label2" runat="server" required ReadOnly ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Note:</td>
                    <td><asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td>
<asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
            <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td>
                        <asp:Button ID="Button2" runat="server" Text="Vew  vacation requst To you and your team" OnClick="Button2_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>

<script language="JavaScript" type="text/javascript">
    // To calulate difference b/w two dates
    

    function getduration() {
        debugger;
        var date1 = new Date(document.getElementById("date1").value);
        var date2 = new Date(document.getElementById("date2").value);
        var diff = Math.floor(date2.getTime() - date1.getTime());
        var day = 1000 * 60 * 60 * 24;
        var days = Math.floor(diff / day);
        document.getElementById("Label2").value = days+1;
        date2.setDate(date2.getDate() + days+1);
        var month = "0" + (date2.getMonth() + 1);
        var date = "0" + date2.getDate();
        month = month.slice(-2);
        date = date.slice(-2);
        var date = date + "/" + month + "/" + date2.getFullYear();
        document.getElementById("TextBox4").value = date;
        }

</script>