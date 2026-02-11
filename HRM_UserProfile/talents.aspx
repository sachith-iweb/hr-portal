<%@ Page Title="" Language="C#" MasterPageFile="~/userprofile.Master" AutoEventWireup="true" CodeBehind="talents.aspx.cs" Inherits="HRM_UserProfile.talents" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   

<div class="divGroupBlockHeader">Employee Talent Details</div>
    <div class="divGroupBlockBody">

        <div class="divGroupBlockHeaderSmall">Add / Edit Talent Details</div>
        <div class="divGroupBlockBody">
             <table cellpadding="3" cellspacing="3">
                    <tr>
                        <td class="style2">
                            <asp:Label ID="Label2" runat="server" CssClass="labal" Text="Category"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label5" runat="server" CssClass="labal" Text=":"></asp:Label>
                        </td>
                        <td>
                            <telerik:RadComboBox ID="cmbCategory" Runat="server" 
                                AppendDataBoundItems="True" AutoPostBack="True" 
                                onselectedindexchanged="cmbCategory_SelectedIndexChanged" Skin="Silk" Width="400px" OnDataBound="cmbCategory_DataBound">
                            </telerik:RadComboBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="cmbCategory" ErrorMessage="*" Font-Size="X-Large" ForeColor="#FF3300" InitialValue="---Select---" ValidationGroup="r" Font-Bold="True"></asp:RequiredFieldValidator>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                ControlToValidate="cmbCategory" ErrorMessage="RequiredFieldValidator" 
                                Font-Bold="True" ForeColor="White" InitialValue="-- Choose --" 
                                ValidationGroup="i"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label3" runat="server" CssClass="labal" Text="Sub Category"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label6" runat="server" CssClass="labal" Text=":"></asp:Label>
                        </td>
                        <td>
                            <telerik:RadComboBox ID="cmbSubCategory" Runat="server" 
                                AppendDataBoundItems="True" 
                                onselectedindexchanged="cmbSubCategory_SelectedIndexChanged" Skin="Silk" Width="400px" OnDataBound="cmbSubCategory_DataBound">
                            </telerik:RadComboBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="cmbSubCategory" ErrorMessage="*" Font-Size="X-Large" ForeColor="#FF3300" InitialValue="---Select---" ValidationGroup="r" Font-Bold="True"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">
                            <asp:Label ID="Label4" runat="server" CssClass="labal" Text="Tallent in Detail"></asp:Label>
                        </td>
                        <td class="auto-style4">
                            <asp:Label ID="Label8" runat="server" CssClass="labal" Text=":"></asp:Label>
                        </td>
                        <td class="auto-style4">
                            <telerik:RadTextBox ID="txtRemark" Runat="server" TextMode="MultiLine" Rows="3" Width="600px">
                            </telerik:RadTextBox>
                        </td>
                        <td class="auto-style4">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtRemark" ErrorMessage="*" Font-Size="X-Large" ForeColor="#FF3300" ValidationGroup="r" Font-Bold="True"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            <asp:CheckBox ID="chkIsActive" runat="server" Text="Active" Checked="True" Enabled="False" />
                        </td>
                        <td>
                        </td>
                    </tr>

                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                
                <asp:Button ID="btnSave" runat="server" CssClass="btnCheckForChanges" Height="35px" Text="Request To Change" Width="250px" OnClick="btnSave_Click" ValidationGroup="r" />
                 &nbsp;&nbsp;                               
                <asp:Button ID="btnReset" runat="server" CssClass="btnResetToDefault" Height="35px" Text="Reset To Default" Width="200px" OnClick="btnReset_Click" />
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>

                    </table>
        </div>

             
          <div class="divGroupBlockHeaderSmall">Existing Talents</div>
        <div>
               

                <telerik:RadGrid ID="dgEmployeeWiseTalent" runat="server" AllowPaging="True" AllowSorting="True" 
                    AutoGenerateColumns="False" 
                    onitemcommand="dgEmployeeWiseTalent_ItemCommand" 
                    onneeddatasource="dgEmployeeWiseTalent_NeedDataSource" 
                    onpageindexchanged="dgEmployeeWiseTalent_PageIndexChanged" 
                    onpagesizechanged="dgEmployeeWiseTalent_PageSizeChanged" Skin="Silk">
<MasterTableView>
    <Columns>
        <telerik:GridBoundColumn DataField="TalentCategoryId" Display="False" 
            HeaderText="TalentCategoryId" UniqueName="TalentCategoryId">
<ColumnValidationSettings>
<ModelErrorMessage Text=""></ModelErrorMessage>
</ColumnValidationSettings>
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="NameWithInitials" 
            HeaderText="Name With Initials" UniqueName="NameWithInitials" Visible="False">
<ColumnValidationSettings>
<ModelErrorMessage Text=""></ModelErrorMessage>
</ColumnValidationSettings>
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="TalentCatName" HeaderText="Category" 
            UniqueName="TalentCatName">
<ColumnValidationSettings>
<ModelErrorMessage Text=""></ModelErrorMessage>
</ColumnValidationSettings>
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="TalentSubCatName" 
            HeaderText="Sub Category" UniqueName="TalentSubCatName">
<ColumnValidationSettings>
<ModelErrorMessage Text=""></ModelErrorMessage>
</ColumnValidationSettings>
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="EmployeeWiseTalentId" Display="False" 
            HeaderText="EmployeeWiseTalentId" UniqueName="EmployeeWiseTalentId">
<ColumnValidationSettings>
<ModelErrorMessage Text=""></ModelErrorMessage>
</ColumnValidationSettings>
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="EmployeeId" Display="False" 
            HeaderText="EmployeeId" UniqueName="EmployeeId">
<ColumnValidationSettings>
<ModelErrorMessage Text=""></ModelErrorMessage>
</ColumnValidationSettings>
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="TalentSubCatId" Display="False" 
            HeaderText="TalentSubCatId" UniqueName="TalentSubCatId">
<ColumnValidationSettings>
<ModelErrorMessage Text=""></ModelErrorMessage>
</ColumnValidationSettings>
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Remarks" HeaderText="Remarks" 
            UniqueName="Remarks">
<ColumnValidationSettings>
<ModelErrorMessage Text=""></ModelErrorMessage>
</ColumnValidationSettings>
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="IsActive" Display="False" 
            HeaderText="IsActive" UniqueName="IsActive">
<ColumnValidationSettings>
<ModelErrorMessage Text=""></ModelErrorMessage>
</ColumnValidationSettings>
        </telerik:GridBoundColumn>
        <telerik:GridCheckBoxColumn DataField="IsActive" HeaderText="Active" 
            UniqueName="IsActive1">
            <ItemStyle Width="10px" />
        </telerik:GridCheckBoxColumn>
        <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Select" 
            ImageUrl="~/images/btn_edit.png" UniqueName="Edit">
            <ItemStyle Width="10px" />
        </telerik:GridButtonColumn>
        <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" 
            ImageUrl="~/Img/deleteRecordBtn.gif" UniqueName="Delete" Visible="False">
            <ItemStyle Width="10px" />
        </telerik:GridButtonColumn>
    </Columns>
</MasterTableView>
                </telerik:RadGrid>
            </div>

    </div>

</asp:Content>
