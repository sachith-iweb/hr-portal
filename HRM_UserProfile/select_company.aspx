<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="select_company.aspx.cs" Inherits="HRM_UserProfile.select_company" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Select Company</title>
    <script type="text/javascript" src="js/RadWindowColose.js"></script>
  
</head>
<body>
    
    <form id="form1" runat="server">
    <div>
        <telerik:RadScriptManager ID="RadScriptManager1" runat="server"></telerik:RadScriptManager>
    <table cellpadding="5" cellspacing="5" width="100%">

                    <tr>
                        <td bgcolor="#cccccc" colspan="5">
                            <asp:Label ID="Label6" runat="server" CssClass="continue" Text="Continue ..."></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="5">
                            <asp:Label ID="Label5" runat="server" CssClass="continue" Text="You have multiple company access. Select a company to continue.."></asp:Label>
                        </td> 
                    </tr>
                    <tr>
                        <td colspan="5">
                            <telerik:RadComboBox ID="cmbCompany"   Runat="server" Skin="Silk" ViewStateMode="Enabled" Width="350px" OnDataBound="cmbCompany_DataBound" OnSelectedIndexChanged="cmbCompany_SelectedIndexChanged" AutoPostBack="True">
                            </telerik:RadComboBox>
                            <asp:RequiredFieldValidator Text="*" SetFocusOnError="true" ControlToValidate="cmbCompany"  Font-Size="X-Large" ForeColor="#ff0000" ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" Font-Bold="True" InitialValue="------------ Select Company ----------" ValidationGroup="c"></asp:RequiredFieldValidator>

                           
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:Button ID="btnContinue" OnClientClick="refreshParentPage();" runat="server" Height="30px"  Text="Continue ..." Width="125px" ValidationGroup="c" /> 
                        </td>
                        <td class="auto-style2">
                            <asp:Button ID="btnExit" runat="server" Height="30px" onclick="btnExit_Click" Text="Exit" Width="70px" />
                        </td>
                        <td class="auto-style2">&nbsp;</td>
                        <td class="auto-style2">&nbsp;</td>
                        <td align="right">
                            &nbsp;</td>
                    </tr>
                </table>
    </div>
    </form>
</body>
</html>
