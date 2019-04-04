<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmailLink.aspx.cs" Inherits="MailLinkControl.EmailLink" %>
<%@ Register namespace="MailLinkControl" Assembly="MailLinkControl" tagprefix="alexCo" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            <table class="style1">
                <tr>
                    <td class="style2">
                        <span>ToEmail</span></td>
                    <td>
                        <asp:TextBox ID="txtToEmail" runat="server" Width="100%"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style2">
                        <span>CCEmail</span></td>
                    <td>
                        <asp:TextBox ID="txtCCEmail" runat="server" Width="100%"></asp:TextBox>
                    </td>
                </tr>                 
                <tr>
                    <td class="style2">
                        <span>BCCEmail</span></td>
                    <td>
                        <asp:TextBox ID="txtBCCEmail" runat="server" Width="100%"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style2">
                        <span>Subject</span></td>
                    <td>
                        <asp:TextBox ID="txtSubject" runat="server" Width="100%"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style2">
                        <span>Body</span></td>
                    <td>
                        <asp:TextBox ID="txtBody" runat="server" Height="119px" TextMode="MultiLine" 
                            Width="255px"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <br />
            <a id="thelink" name="thelink" runat="server" onclick="Link_Click">
            Generate Email Link
            </a> 
            <br />
            <br />  
            <alexCo:MailLinkControl ID="emailLink" runat="server"  /> 
            <br />
    
    </form>
</body>
</html>
