<%@ Page Title="" Language="C#" MasterPageFile="~/userprofile.Master" AutoEventWireup="true" CodeBehind="basic_info.aspx.cs" Inherits="HRM_UserProfile.basic_info" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style4 {
        width: 23px;
    }
    .auto-style5 {
        width: 11px;
    }
        .auto-style6 {
            width: 122px;
        }
        .auto-style7 {
            width: 123px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="divGroupBlock">
        <div class="divGroupBlockHeader" >
           Basic Informations
        </div>

        <div class="divGroupBlockBody">

     
                  <table  cellpadding="3" cellspacing="3" >
                                        <tr>
                                            <td class="auto-style7">
                                                <asp:Label ID="lblTitle" runat="server" Text="Title"></asp:Label>
                                            </td>
                                            <td class="auto-style5">
                                                <asp:Label ID="Label49" runat="server" Text=":"></asp:Label>
                                            </td>
                                            <td class="style28">
                                                <telerik:RadComboBox ID="cmbTitle" Runat="server" Width="150px" 
                                                    AppendDataBoundItems="True" Skin="Silk" OnDataBound="cmbTitle_DataBound">
                                                </telerik:RadComboBox>
                                                <asp:Label ID="lblCurrentValueTitle" runat="server" Font-Bold="False" ForeColor="#CC0000" Visible="False"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:RequiredFieldValidator ID="r1" runat="server" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" Font-Strikeout="False" ForeColor="Red" ValidationGroup="r" ControlToValidate="cmbTitle" InitialValue="---Select---"></asp:RequiredFieldValidator>
                                            </td>
                                            <td class="auto-style4">
                                                &nbsp;</td>
                                            <td class="auto-style6">
                                                <asp:Label ID="lblNationality" runat="server" Text="Nationatity "></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label33" runat="server" Text=":"></asp:Label>
                                            </td>
                                            <td>
                                                <telerik:RadComboBox ID="cmbNationality" Runat="server" Width="250px" 
                                                    AppendDataBoundItems="True" Skin="Silk" OnDataBound="cmbNationality_DataBound">
                                                </telerik:RadComboBox>
                                                <asp:Label ID="lblCurrentValuenationality" runat="server" Font-Bold="False" ForeColor="#CC0000" Visible="False"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:RequiredFieldValidator ID="r7" runat="server" ControlToValidate="cmbNationality" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" Font-Strikeout="False" ForeColor="Red" ValidationGroup="r" InitialValue="---Select---"></asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style7">
                                                <asp:Label ID="lblFirstName" runat="server" Text="First Name"></asp:Label>
                                            </td>
                                            <td class="auto-style5">
                                                <asp:Label ID="Label28" runat="server" Text=":"></asp:Label>
                                            </td>
                                            <td class="style28">
                                                <telerik:RadTextBox ID="txtFirstName" Runat="server" Width="250px" Skin="Silk">
                                                </telerik:RadTextBox>
                                                <asp:Label ID="lblCurrentValueFname" runat="server" Font-Bold="False" ForeColor="#CC0000" Visible="False"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:RequiredFieldValidator ID="r2" runat="server" ControlToValidate="txtFirstName" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" Font-Strikeout="False" ForeColor="Red" ValidationGroup="r"></asp:RequiredFieldValidator>
                                            </td>
                                            <td class="auto-style4">
                                                &nbsp;</td>
                                            <td class="auto-style6">
                                                <asp:Label ID="lblRace" runat="server" Text="Race"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label50" runat="server" Text=":"></asp:Label>
                                            </td>
                                            <td>
                                                <telerik:RadComboBox ID="cmbRace" Runat="server" Width="250px" 
                                                    AppendDataBoundItems="True" Skin="Silk" OnDataBound="cmbRace_DataBound">
                                                </telerik:RadComboBox>
                                                <asp:Label ID="lblCurrentValueRace" runat="server" Font-Bold="False" ForeColor="#CC0000" Visible="False"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:RequiredFieldValidator ID="r8" runat="server" ControlToValidate="cmbRace" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" Font-Strikeout="False" ForeColor="Red" ValidationGroup="r" InitialValue="---Select---"></asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style7">
                                                <asp:Label ID="lblMiddleName" runat="server" Text="Middle Name"></asp:Label>
                                            </td>
                                            <td class="auto-style5">
                                                <asp:Label ID="Label29" runat="server" Text=":"></asp:Label>
                                            </td>
                                            <td class="style28">
                                                <telerik:RadTextBox ID="txtMiddleName" Runat="server" Width="250px" Skin="Silk">
                                                </telerik:RadTextBox>
                                                <asp:Label ID="lblCurrentValueMname" runat="server" Font-Bold="False" ForeColor="#CC0000" Visible="False"></asp:Label>
                                            </td>
                                            <td>
                                                &nbsp;</td>
                                            <td class="auto-style4">
                                                &nbsp;</td>
                                            <td class="auto-style6">
                                                <asp:Label ID="lblReligion" runat="server" Text="Religion"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label51" runat="server" Text=":"></asp:Label>
                                            </td>
                                            <td>
                                                <telerik:RadComboBox ID="cmbReligion" Runat="server" Width="250px" 
                                                    AppendDataBoundItems="True" Skin="Silk" OnDataBound="cmbReligion_DataBound">
                                                </telerik:RadComboBox>
                                                <asp:Label ID="lblCurrentValueReligion" runat="server" Font-Bold="False" ForeColor="#CC0000" Visible="False"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:RequiredFieldValidator ID="r9" runat="server" ControlToValidate="cmbReligion" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" Font-Strikeout="False" ForeColor="Red" ValidationGroup="r" InitialValue="---Select---"></asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style7">
                                                <asp:Label ID="lblLastName" runat="server" Text="Last Name"></asp:Label>
                                            </td>
                                            <td class="auto-style5">
                                                <asp:Label ID="Label30" runat="server" Text=":"></asp:Label>
                                            </td>
                                            <td class="style28">
                                                <telerik:RadTextBox ID="txtLastName" Runat="server" Width="250px" Skin="Silk">
                                                </telerik:RadTextBox>
                                                <asp:Label ID="lblCurrentValueLname" runat="server" Font-Bold="False" ForeColor="#CC0000" Visible="False"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:RequiredFieldValidator ID="r3" runat="server" ControlToValidate="txtLastName" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" Font-Strikeout="False" ForeColor="Red" ValidationGroup="r"></asp:RequiredFieldValidator>
                                            </td>
                                            <td class="auto-style4">
                                                &nbsp;</td>
                                            <td class="auto-style6">
                                                <asp:Label ID="lblGender" runat="server" Text="Gender"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label52" runat="server" Text=":"></asp:Label>
                                            </td>
                                            <td>
                                                <telerik:RadComboBox ID="cmbGender" Runat="server" Width="250px" Skin="Silk" OnDataBound="cmbGender_DataBound">
                                                    <Items>
                                                        <telerik:RadComboBoxItem runat="server" Text="Male" Value="M" />
                                                        <telerik:RadComboBoxItem runat="server" Text="Female" Value="F" />
                                                    </Items>
                                                </telerik:RadComboBox>
                                                <asp:Label ID="lblCurrentValueGender" runat="server" Font-Bold="False" ForeColor="#CC0000" Visible="False"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:RequiredFieldValidator ID="r10" runat="server" ControlToValidate="cmbGender" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" Font-Strikeout="False" ForeColor="Red" ValidationGroup="r" InitialValue="---Select---"></asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style7">
                                                <asp:Label ID="lblNameWithInitials" runat="server" Text="Name with Initials"></asp:Label>
                                            </td>
                                            <td class="auto-style5">
                                                <asp:Label ID="Label31" runat="server" Text=":"></asp:Label>
                                            </td>
                                            <td class="style28">
                                                <telerik:RadTextBox ID="txtNameWithInitials" Runat="server" Width="250px" Skin="Silk">
                                                </telerik:RadTextBox>
                                                <asp:Label ID="lblCurrentValueNameWithInitials" runat="server" Font-Bold="False" ForeColor="#CC0000" Visible="False"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:RequiredFieldValidator ID="r4" runat="server" ControlToValidate="txtNameWithInitials" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" Font-Strikeout="False" ForeColor="Red" ValidationGroup="r"></asp:RequiredFieldValidator>
                                            </td>
                                            <td class="auto-style4">
                                                &nbsp;</td>
                                            <td class="auto-style6">
                                                <asp:Label ID="lblCivilStatus" runat="server" Text="Civil Status"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label54" runat="server" Text=":"></asp:Label>
                                            </td>
                                            <td>
                                                <telerik:RadComboBox ID="cmbCivilStatus" Runat="server" Width="250px" 
                                                    AppendDataBoundItems="True" Skin="Silk" OnDataBound="cmbCivilStatus_DataBound">
                                                </telerik:RadComboBox>
                                                <asp:Label ID="lblCurrentValueCivilStatus" runat="server" Font-Bold="False" ForeColor="#CC0000" Visible="False"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:RequiredFieldValidator ID="r11" runat="server" ControlToValidate="cmbCivilStatus" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" Font-Strikeout="False" ForeColor="Red" ValidationGroup="r" InitialValue="---Select---"></asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style7">
                                                <asp:Label ID="lblDateOfBirth" runat="server" Text="Date of Birth"></asp:Label>
                                            </td>
                                            <td class="auto-style5">
                                                <asp:Label ID="Label32" runat="server" Text=":"></asp:Label>
                                            </td>
                                            <td class="style28">
                                                <telerik:RadDatePicker ID="rdpBdateOfBirth" Runat="server" Culture="en-US" Skin="Silk" Width="250px" MinDate="1900-12-01">
<Calendar UseRowHeadersAsSelectors="False" UseColumnHeadersAsSelectors="False" EnableWeekends="True" FastNavigationNextText="&amp;lt;&amp;lt;" EnableKeyboardNavigation="True" Skin="Silk"></Calendar>

<DateInput DisplayDateFormat="M/d/yyyy" DateFormat="M/d/yyyy" LabelWidth="40%">
<EmptyMessageStyle Resize="None"></EmptyMessageStyle>

<ReadOnlyStyle Resize="None"></ReadOnlyStyle>

<FocusedStyle Resize="None"></FocusedStyle>

<DisabledStyle Resize="None"></DisabledStyle>

<InvalidStyle Resize="None"></InvalidStyle>

<HoveredStyle Resize="None"></HoveredStyle>

<EnabledStyle Resize="None"></EnabledStyle>
</DateInput>

<DatePopupButton ImageUrl="" HoverImageUrl=""></DatePopupButton>
                                                </telerik:RadDatePicker>
                                                <asp:Label ID="lblCurrentValueDateOfBirth" runat="server" Font-Bold="False" ForeColor="#CC0000" Visible="False"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:RequiredFieldValidator ID="r5" runat="server" ControlToValidate="rdpBdateOfBirth" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" Font-Strikeout="False" ForeColor="Red" ValidationGroup="r"></asp:RequiredFieldValidator>
                                            </td>
                                            <td class="auto-style4">
                                                &nbsp;</td>
                                            <td class="auto-style6">
                                                <asp:Label ID="lblCivilStatus0" runat="server" Text="Profile Picture" Visible="False"></asp:Label>
                                            </td>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                <asp:FileUpload ID="fuImage" runat="server" Width="250px" Visible="False" />
                                                <br />
                                                </td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="style27" colspan="8">                                               
                                                </div>
                                                <asp:Label ID="lblChanges" runat="server"></asp:Label>
                                            </td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="style27" colspan="8">
                                                 <asp:Button ID="btnCheckForChanges" runat="server" CssClass="btnCheckForChanges" Height="35px" Text="Check For Changes" Width="178px" OnClick="btnCheckForChanges_Click" BackColor="#FF9900" />
                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                <asp:Button ID="btnSave" runat="server" CssClass="btnCheckForChanges" Height="35px" Text="Request To Change" Width="250px" OnClick="btnSave_Click" ValidationGroup="r" />
                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                <asp:Button ID="btnReset" runat="server" CssClass="btnResetToDefault" Height="35px" Text="Reset To Default" Width="200px" OnClick="btnReset_Click" />
                                            </td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        </table>

 
        </div>
 

</asp:Content>
