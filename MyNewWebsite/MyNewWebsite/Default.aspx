<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MyNewWebsite.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td>Num1</td>
                <td>
                    <asp:TextBox ID="Num1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Num2</td>
                <td>
                    <asp:TextBox ID="Num2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Add" OnClick="btnAdd_Click" />
                </td>
                <td>
                    <asp:Button ID="Button2" runat="server" Text="Sub" OnClick="btnSub_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button3" runat="server" Text="Mul" OnClick="btnMul_Click" />
                </td>
                <td>
                    <asp:Button ID="Button4" runat="server" Text="Div" OnClick="btnDiv_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="result" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>