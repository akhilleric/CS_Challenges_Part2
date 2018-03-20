<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="challenge_phun.aspx.cs" Inherits="CS_35_Challenge.challenge_phun" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="runButton" runat="server" OnClick="runButton_Click" Text="Run" />
            <br />
            <br />
            <br />
            <asp:Label ID="resultLabel1" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="resultLabel2" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="resultLabel3" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="resultLabel4" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
