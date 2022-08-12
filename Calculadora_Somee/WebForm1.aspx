<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Calculadora_Somee.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:TextBox ID="txtLabel" runat="server" Height="47px" Width="216px"></asp:TextBox>
        </p>
        <p>
            <asp:Button runat="server" Text="1" OnClick="Button4_Click" style="width: 21px" />
            <asp:Button ID="Button5" runat="server" Text="2" OnClick="Button5_Click" />
            <asp:Button ID="Button6" runat="server" Text="3" OnClick="Button6_Click" />
            <asp:Button ID="Button13" runat="server" Text="+" OnClick="Button13_Click" />
        </p>
            <asp:Button ID="Button7" runat="server" Text="4" OnClick="Button7_Click" />
            <asp:Button ID="Button8" runat="server" Text="5" OnClick="Button8_Click" />
            <asp:Button ID="Button9" runat="server" Text="6" OnClick="Button9_Click" />
            <asp:Button ID="Button14" runat="server" Text="-" OnClick="Button14_Click" />
        <p>
            <asp:Button ID="Button10" runat="server" Text="7" OnClick="Button10_Click" />
            <asp:Button ID="Button1" runat="server"  Text="8" OnClick="Button1_Click" />
            <asp:Button ID="Button3" runat="server" Text="9" OnClick="Button3_Click" />
            <asp:Button ID="Button15" runat="server" Text="x" OnClick="Button15_Click" />
        </p>
        <p>
            <asp:Button ID="Button2" runat="server" Text="." OnClick="Button2_Click" style="height: 26px" />
            <asp:Button ID="Button11" runat="server" Text="0" OnClick="Button11_Click" />
            <asp:Button ID="Button12" runat="server" Text="C" />
            <asp:Button ID="Button16" runat="server" Text="/" OnClick="Button16_Click" />
        </p>
        <p>
            <asp:Button ID="Button17" runat="server" Text="%" OnClick="Button17_Click" />
            <asp:Button ID="Button19" runat="server" Text="!" OnClick="Button19_Click" />
            <asp:Button ID="Button21" runat="server" Text="Log" OnClick="Button21_Click" />
            <asp:Button ID="Button23" runat="server" Text="=" OnClick="Button23_Click" />
        </p>
        <p>
            <asp:Button ID="Button18" runat="server" Text="|a|" OnClick="Button18_Click" />
            <asp:Button ID="Button20" runat="server" Text="raiz" OnClick="Button20_Click" />
            <asp:Button ID="Button22" runat="server" Text="^" OnClick="Button22_Click" />
        </p>
    </form>
</body>
</html>
