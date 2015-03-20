<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Time of Day</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Time of Day</h1>
        <asp:Label ID="lblTimeSpan" runat="server" Text=""></asp:Label><br />
        <asp:Image ID="Image1" runat="server" ImageUrl="~/image1.jpg" visible="false"/>
        <asp:Image ID ="Image2" runat="server" ImageUrl="~/image2.jpg" visible ="false"/>
        <asp:Image ID ="Image3" runat="server" ImageUrl="~/image3.jpg" visible="false" />
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Timer ID="Timer1" runat="server" Enabled="true" OnTick="Timer1_Tick" Interval="1000"></asp:Timer>
                <asp:Label ID="lblTime" runat="server" Text=""></asp:Label>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
    </form>
</body>
</html>
