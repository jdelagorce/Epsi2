<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Accueil.aspx.cs" Inherits="SiteEpsiAdministration.Accueil" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ListBox ID="ListBox1" runat="server" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" AppendDataBoundItems="True" CausesValidation="True" ValidateRequestMode="Disabled"></asp:ListBox>
    </div>
        <asp:Label ID="Label1" runat="server" Text="Label" ValidateRequestMode="Enabled"></asp:Label>
    </form>
</body>
</html>
