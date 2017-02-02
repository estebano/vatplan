<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="WebForm1.aspx.cs" Inherits="vatplan.Forms.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 211px">
    
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <asp:Button ID="Button1" runat="server" Text="Button" />
    
        <asp:FormView ID="FormView1" runat="server" Height="140px" Width="544px">
            <HeaderTemplate>
                <asp:Label ID="Label1" runat="server" Text="Label one"></asp:Label>
            </HeaderTemplate>
        </asp:FormView>
    
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
    
    </div>
    </form>
</body>
</html>
