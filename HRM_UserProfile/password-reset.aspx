<%@ Page Title="" Language="C#" MasterPageFile="~/userprofile.Master" AutoEventWireup="true" CodeBehind="password-reset.aspx.cs" Inherits="HRM_UserProfile.password_reset" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div style="margin:0 auto; width:400px;">
   <telerik:RadAjaxPanel ID="RadAjaxPanel1" runat="server"  HorizontalAlign="NotSet" LoadingPanelID="RadAjaxLoadingPanel1">

    <div class="divGroupBlock">
        <div class="divGroupBlockHeader" >
            Password reset</div>

        <div class="divGroupBlockBody">






            <table>
                <tr>
                    <td>Username</td>
                    <td>:</td>
                    <td>
                        <telerik:RadTextBox ID="txtUsername" Runat="server" ReadOnly="True" Width="200px">
                            <EmptyMessageStyle Resize="None" />
                            <ReadOnlyStyle Resize="None" />
                            <FocusedStyle Resize="None" />
                            <DisabledStyle Resize="None" />
                            <InvalidStyle Resize="None" />
                            <HoveredStyle Resize="None" />
                            <EnabledStyle Resize="None" />
                        </telerik:RadTextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="r1" runat="server" ControlToValidate="txtUsername" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" ForeColor="Red" ValidationGroup="i"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Current Password</td>
                    <td>:</td>
                    <td>
                        <telerik:RadTextBox ID="txtCurrentPassword" Runat="server" Width="200px" TextMode="Password">
                            <EmptyMessageStyle Resize="None" />
                            <ReadOnlyStyle Resize="None" />
                            <FocusedStyle Resize="None" />
                            <DisabledStyle Resize="None" />
                            <InvalidStyle Resize="None" />
                            <HoveredStyle Resize="None" />
                            <EnabledStyle Resize="None" />
                        </telerik:RadTextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="r2" runat="server" ControlToValidate="txtCurrentPassword" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" ForeColor="Red" ValidationGroup="i"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>New Password</td>
                    <td>:</td>
                    <td>
                        <telerik:RadTextBox ID="txtNewPassword" Runat="server" Width="200px" TextMode="Password">
                            <EmptyMessageStyle Resize="None" />
                            <ReadOnlyStyle Resize="None" />
                            <FocusedStyle Resize="None" />
                            <DisabledStyle Resize="None" />
                            <InvalidStyle Resize="None" />
                            <HoveredStyle Resize="None" />
                            <EnabledStyle Resize="None" />
                        </telerik:RadTextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="r3" runat="server" ControlToValidate="txtNewPassword" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" ForeColor="Red" ValidationGroup="i"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>New Password Again</td>
                    <td>:</td>
                    <td>
                        <telerik:RadTextBox ID="txtNewPasswordAgain" Runat="server" Width="200px" TextMode="Password">
                            <EmptyMessageStyle Resize="None" />
                            <ReadOnlyStyle Resize="None" />
                            <FocusedStyle Resize="None" />
                            <DisabledStyle Resize="None" />
                            <InvalidStyle Resize="None" />
                            <HoveredStyle Resize="None" />
                            <EnabledStyle Resize="None" />
                        </telerik:RadTextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="r5" runat="server" ControlToValidate="txtNewPasswordAgain" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" ForeColor="Red" ValidationGroup="i"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td colspan="4" style="text-align:center;">
                
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtNewPassword" ControlToValidate="txtNewPasswordAgain" ErrorMessage="Two passwords not matched" Font-Bold="True" Font-Size="Small" ForeColor="Red" Display="Dynamic"></asp:CompareValidator>
&nbsp;
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                
                <asp:Button ID="btnChangePassword" runat="server" CssClass="btnCheckForChanges" Height="35px" Text="Change Password" Width="100%" OnClick="btnSave_Click" ValidationGroup="i" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="3">                               
                <asp:Button ID="btnClear" runat="server" CssClass="btnResetToDefault" Height="35px" Text="Clear " Width="100%" OnClick="btnReset_Click" />
                                            </td>
                    <td>&nbsp;</td>
                </tr>
            </table>





       </div>


         </telerik:RadAjaxPanel>
      </div>  
     <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" runat="server" BackColor="White" EnableEmbeddedSkins="false">      
     <img src="images/loading_animation.gif" width="150px" style="margin-top:5%"/>   
    </telerik:RadAjaxLoadingPanel>

</asp:Content>
