<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Document.aspx.cs" Inherits="SitoECDocs.Pages.Document" Async="true" %>


<!DOCTYPE html>
<html>
<head runat="server">
    <title>Documenti</title>
</head>
<body>
    <form id="form1" runat="server">

        <asp:GridView
            ID="gvDocuments"
            runat="server"
            AutoGenerateColumns="true">
        </asp:GridView>

    </form>
</body>
</html>

