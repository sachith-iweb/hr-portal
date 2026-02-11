<%@ Page Title="" Language="C#" MasterPageFile="~/userprofile.Master" AutoEventWireup="true" CodeBehind="health_profile.aspx.cs" Inherits="HRM_UserProfile.health_profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style type="text/css">
        .auto-style4 {
            width: 58px;
        }
        .auto-style5 {
            width: 61px;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="divGroupBlock">
        <div class="divGroupBlockHeader">
            Health Profile Informations
        </div>

        <div class="divGroupBlockBody">
           
            <div class="divGroupBlockHeaderSmall">Employee Health Details</div>
            <div class="divGroupBlockBody">

                <table cellpadding="3" cellspacing="3">
        <tr>
            <td >
                <asp:Label ID="Label10" runat="server" 
                    Text="Blood Group" CssClass="labal"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label1" runat="server" Text=":" CssClass="labal"></asp:Label>
            </td>
            <td >
                <telerik:RadComboBox ID="cmbBloodGroup" Runat="server" CssClass="comboBoxes" Width="100px" Skin="Silk" OnDataBound="cmbBloodGroup_DataBound" >
                </telerik:RadComboBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                <asp:RequiredFieldValidator ID="r1" runat="server" 
                            ControlToValidate="cmbBloodGroup" ErrorMessage="*" 
                    ValidationGroup="r" Font-Bold="True" Font-Size="X-Large" Font-Strikeout="False" ForeColor="Red" InitialValue="---Select---" 
                    ></asp:RequiredFieldValidator>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="auto-style4">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td >
                <asp:Label ID="Label17" runat="server" Text="Alergies" CssClass="labal"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label8" runat="server" Text=":" CssClass="labal"></asp:Label>
            </td>
            <td colspan="6" >
                <telerik:RadTextBox ID="txtAlergies" Runat="server" CssClass="textBoxes" 
                    TextMode="MultiLine" Width="500px" Skin="Silk" Rows="3">
                </telerik:RadTextBox>
            </td>
            <td class="auto-style4">
                <%--<asp:RequiredFieldValidator ID="r2" runat="server" ControlToValidate="txtAlergies" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" Font-Strikeout="False" ForeColor="Red" ValidationGroup="r"></asp:RequiredFieldValidator>--%>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td >
                <asp:Label ID="Label18" runat="server" Text="Illness" CssClass="labal"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label9" runat="server" Text=":" CssClass="labal"></asp:Label>
            </td>
            <td colspan="6" >
                <telerik:RadTextBox ID="txtIllness" Runat="server" CssClass="textBoxes" 
                    TextMode="MultiLine" Width="500px" Skin="Silk" Rows="3">
                </telerik:RadTextBox>
            </td>
            <td class="auto-style4">
                <%--<asp:RequiredFieldValidator ID="r3" runat="server" ControlToValidate="txtIllness" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" Font-Strikeout="False" ForeColor="Red" ValidationGroup="r"></asp:RequiredFieldValidator>--%>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td >
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td colspan="7" >
                <asp:CheckBox ID="chkActive" runat="server" Text="Active" 
                    CssClass="checkBoxes" Checked="True" Enabled="False" />
                <asp:HiddenField ID="hdnEmployeeWiseHelthProfileID" runat="server" Value="0" />
            </td>
            <td>
                &nbsp;</td>
        </tr>

        </table>
            </div>


            <div class="divGroupBlockHeaderSmall">Family Doctor Details</div>
            <div class="divGroupBlockBody">
                <table cellspacing="3" cellpadding="3">
        <tr>
            <td >
                <asp:Label ID="Label12" runat="server" Text="Name" CssClass="labal"></asp:Label>
            </td>
            <td >
                <asp:Label ID="Label23" runat="server" Text=":" CssClass="labal"></asp:Label>
            </td>
            <td >
                <telerik:RadTextBox ID="txtName" Runat="server" CssClass="textBoxes" Width="250px" Skin="Silk">
                </telerik:RadTextBox>
            </td>
            <td >
                <%--<asp:RequiredFieldValidator ID="r4" runat="server" ControlToValidate="txtName" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" Font-Strikeout="False" ForeColor="Red" ValidationGroup="r"></asp:RequiredFieldValidator>--%>
            </td>
            <td class="auto-style5" >
                <asp:Label ID="Label27" runat="server" CssClass="labal"></asp:Label>
            </td>
            <td >
                <asp:Label ID="Label15" runat="server" Text="Email" CssClass="labal"></asp:Label>
            </td>
            <td >
                <asp:Label ID="Label25" runat="server" Text=":" CssClass="labal"></asp:Label>
            </td>
            <td >
                <telerik:RadTextBox ID="txtEmail" Runat="server" CssClass="textBoxes" Width="250px" Skin="Silk">
                </telerik:RadTextBox>
            </td>
            <td class="auto-style4" >
                <%--<asp:RequiredFieldValidator ID="r7" runat="server" ControlToValidate="txtEmail" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" Font-Strikeout="False" ForeColor="Red" ValidationGroup="r"></asp:RequiredFieldValidator>--%>
            </td>
            <td >
                &nbsp;</td>
        </tr>
        <tr>
            <td >
                <asp:Label ID="Label14" runat="server" Text="Contact No" CssClass="labal"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label4" runat="server" Text=":" CssClass="labal"></asp:Label>
            </td>
            <td >
                <telerik:RadTextBox ID="txtContactNo" Runat="server" CssClass="textBoxes" Width="250px" Skin="Silk">
                </telerik:RadTextBox>
            </td>
            <td>
                <%--<asp:RequiredFieldValidator ID="r6" runat="server" ControlToValidate="txtContactNo" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" Font-Strikeout="False" ForeColor="Red" ValidationGroup="r"></asp:RequiredFieldValidator>--%>
            </td>
            <td class="auto-style5">
                &nbsp;</td>
            <td>
                <asp:Label ID="Label16" runat="server" Text="Hospital" CssClass="labal"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label26" runat="server" Text=":" CssClass="labal"></asp:Label>
            </td>
            <td>
                <telerik:RadTextBox ID="txtHospital" Runat="server" CssClass="textBoxes" Width="250px" Skin="Silk">
                </telerik:RadTextBox>
            </td>
            <td class="auto-style4">
                <%--<asp:RequiredFieldValidator ID="r8" runat="server" ControlToValidate="txtHospital" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" Font-Strikeout="False" ForeColor="Red" ValidationGroup="r"></asp:RequiredFieldValidator>--%>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td >
                <asp:Label ID="Label13" runat="server" Text="Address" CssClass="labal"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label24" runat="server" Text=":" CssClass="labal"></asp:Label>
            </td>
            <td >
                <telerik:RadTextBox ID="txtAddress" Runat="server" CssClass="textBoxes" Width="250px" Skin="Silk" Rows="3" TextMode="MultiLine">
                </telerik:RadTextBox>
            </td>
            <td>
                <%--<asp:RequiredFieldValidator ID="r5" runat="server" ControlToValidate="txtAddress" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" Font-Strikeout="False" ForeColor="Red" ValidationGroup="r"></asp:RequiredFieldValidator>--%>
            </td>
            <td class="auto-style5">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="auto-style4">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="10" >

                                                <asp:Button ID="btnSave" runat="server" CssClass="btnCheckForChanges" Height="35px" Text="Request To Change" Width="250px" OnClick="btnSave_Click" ValidationGroup="r" />
                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                <asp:Button ID="btnReset" runat="server" CssClass="btnResetToDefault" Height="35px" Text="Reset To Default" Width="200px" OnClick="btnReset_Click" />
                                           

            </td>
        </tr>


        </table>
            </div>
          

     
             
       
         </div>
    </div> 

    

</asp:Content>
