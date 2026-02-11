<%@ Page Title="" Language="C#" MasterPageFile="~/userprofile.Master" AutoEventWireup="true" CodeBehind="relationship.aspx.cs" Inherits="HRM_UserProfile.relationship" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style type="text/css">
        .auto-style4 {}
        .auto-style5 {
            width: 17px;
        }
        .auto-style6 {
            width: 18px;
        }
        .auto-style7 {
            width: 29px;
        }
        .auto-style8 {
            width: 100px;
        }
        .auto-style9 {
            width: 144px;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="divGroupBlock">
        <div class="divGroupBlockHeader">
            Relationship Informations
        </div>

        <div class="divGroupBlockBody">

<div class="divGroupBlockHeaderSmall">Add / Edit Relationship Details</div>
            <div class="divGroupBlockBody">
        <table cellpaddint="3" cellspacing="3">
        <tr>
            <td class="auto-style8" >
                <asp:Label ID="Label2" runat="server" Text="Relationship" CssClass="labal"></asp:Label>
            </td>
            <td >
                <asp:Label ID="Label15" runat="server" Text=":" CssClass="labal"></asp:Label>
            </td>
            <td class="auto-style4" >
                <telerik:RadComboBox ID="cmbRelationship" Runat="server"                      
                    CssClass="comboBoxes" Skin="Silk" Width="200px" OnDataBound="cmbRelationship_DataBound">
                </telerik:RadComboBox>
                <asp:HiddenField ID="hdnRelationship" runat="server" />
            </td>
            <td>
                <asp:RequiredFieldValidator ID="r1" runat="server" ControlToValidate="cmbRelationship" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" Font-Strikeout="False" ForeColor="Red" ValidationGroup="r" InitialValue="---Select---"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style7">
                &nbsp;</td>
            <td class="auto-style9" >
                <asp:Label ID="Label11" runat="server" Text="Work Place"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label29" runat="server" Text=":" CssClass="labal"></asp:Label>
            </td>
            <td>
                <telerik:RadTextBox ID="txtWorkPlace" Runat="server" CssClass="textBoxes" Width="250px" Skin="Silk">
                </telerik:RadTextBox>
            </td>
            <td>
                <%--<asp:RequiredFieldValidator ID="r11" runat="server" ControlToValidate="txtWorkPlace" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" Font-Strikeout="False" ForeColor="Red" ValidationGroup="r"></asp:RequiredFieldValidator>--%>
            </td>
        </tr>
        <tr>
            <td class="auto-style8" >
                <asp:Label ID="Label3" runat="server" Text="Name" CssClass="labal"></asp:Label>
            </td>
            <td >
                <asp:Label ID="Label16" runat="server" Text=":" CssClass="labal"></asp:Label>
            </td>
            <td class="auto-style4" >
                <telerik:RadTextBox ID="txtName" Runat="server" CssClass="textBoxes" Skin="Silk" Width="200px">
                </telerik:RadTextBox>
                <asp:HiddenField ID="hdnName" runat="server" />
            </td>
            <td>
                <asp:RequiredFieldValidator ID="r2" runat="server" ControlToValidate="txtName" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" Font-Strikeout="False" ForeColor="Red" ValidationGroup="r"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style7">
                &nbsp;</td>
            <td class="auto-style9" >
                <asp:Label ID="Label12" runat="server" Text="Work Place Address"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label30" runat="server" Text=":" CssClass="labal"></asp:Label>
            </td>
            <td>
                <telerik:RadTextBox ID="txtWorkPlaceAddress" Runat="server" 
                    CssClass="textBoxes" Width="250px" Skin="Silk">
                </telerik:RadTextBox>
                <asp:HiddenField ID="hdnWorkPlace" runat="server" />
            </td>
            <td>
                <%--<asp:RequiredFieldValidator ID="r12" runat="server" ControlToValidate="txtWorkPlaceAddress" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" Font-Strikeout="False" ForeColor="Red" ValidationGroup="r"></asp:RequiredFieldValidator>--%>
            </td>
        </tr>
        <tr>
            <td class="auto-style8" >
                <asp:Label ID="Label4" runat="server" Text="Date of Birth" CssClass="labal"></asp:Label>
            </td>
            <td class="auto-style5" >
                <asp:Label ID="Label17" runat="server" Text=":" CssClass="labal"></asp:Label>
            </td>
            <td class="auto-style6" >
                <telerik:RadDatePicker ID="dtpDateOfBirth" Runat="server" 
                    CssClass="dateTimePicker" Skin="Silk" Width="200px" MinDate="1900-01-01">
<Calendar UseRowHeadersAsSelectors="False" UseColumnHeadersAsSelectors="False" EnableWeekends="True" FastNavigationNextText="&amp;lt;&amp;lt;" Skin="Silk"></Calendar>

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
                <asp:HiddenField ID="hdnDateOfBirth" runat="server" />
            </td>
            <td class="auto-style5">
                <%--<asp:RequiredFieldValidator ID="r3" runat="server" ControlToValidate="dtpDateOfBirth" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" Font-Strikeout="False" ForeColor="Red" ValidationGroup="r"></asp:RequiredFieldValidator>--%>
            </td>
            <td class="auto-style7">
                </td>
            <td class="auto-style9">
                <asp:Label ID="Label13" runat="server" Text="Work Place Telephone"></asp:Label>
                </td>
            <td class="auto-style5">
                <asp:Label ID="Label31" runat="server" Text=":" CssClass="labal"></asp:Label>
                </td>
            <td class="auto-style5">
                <telerik:RadTextBox ID="txtWorkPlaceTelephone" Runat="server" 
                    CssClass="textBoxes" Width="250px" Skin="Silk">
                </telerik:RadTextBox>
                <asp:HiddenField ID="hdnWorkPlaceTelephone" runat="server" />
                </td>
            <td class="auto-style5">
                <%--<asp:RequiredFieldValidator ID="r8" runat="server" ControlToValidate="txtWorkPlaceTelephone" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" Font-Strikeout="False" ForeColor="Red" ValidationGroup="r"></asp:RequiredFieldValidator>--%>
                </td>
        </tr>
        <tr>
            <td class="auto-style8">
                <asp:Label ID="Label5" runat="server" Text="Civil Status" CssClass="labal"></asp:Label>
            </td>
            <td >
                <asp:Label ID="Label18" runat="server" Text=":" CssClass="labal"></asp:Label>
            </td>
            <td class="auto-style4">
                <telerik:RadComboBox ID="cmbCivilStatus" Runat="server" CssClass="comboBoxes" Skin="Silk" Width="200px" OnDataBound="cmbCivilStatus_DataBound">
                </telerik:RadComboBox>
                <asp:HiddenField ID="hdnCivilStatus" runat="server" />
            </td>
            <td>
                <asp:RequiredFieldValidator ID="r4" runat="server" ControlToValidate="cmbCivilStatus" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" Font-Strikeout="False" ForeColor="Red" ValidationGroup="r" InitialValue="---Select---"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style7">
                &nbsp;</td>
            <td class="auto-style9" >
                <asp:Label ID="Label10" runat="server" Text="Priority"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label32" runat="server" Text=":" CssClass="labal"></asp:Label>
            </td>
            <td>
                <asp:HiddenField ID="hdnPriority" runat="server" />

            

                <telerik:RadComboBox ID="cmbPriority" Runat="server" CssClass="comboBoxes" Skin="Silk" Width="100px">
                    <Items>
                        <telerik:RadComboBoxItem runat="server" Text="1" Value="1" />
                        <telerik:RadComboBoxItem runat="server" Text="2" Value="2" />
                        <telerik:RadComboBoxItem runat="server" Text="3" Value="3" />
                        <telerik:RadComboBoxItem runat="server" Text="4" Value="4" />
                        <telerik:RadComboBoxItem runat="server" Text="5" Value="5" />
                        <telerik:RadComboBoxItem runat="server" Text="6" Value="6" />
                        <telerik:RadComboBoxItem runat="server" Text="7" Value="7" />
                        <telerik:RadComboBoxItem runat="server" Text="8" Value="8" />
                    </Items>
                </telerik:RadComboBox>



            </td>
            <td>
                <%--<asp:RequiredFieldValidator ID="r9" runat="server" ControlToValidate="txtPriority" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" Font-Strikeout="False" ForeColor="Red" ValidationGroup="r"></asp:RequiredFieldValidator>--%>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">
                <asp:Label ID="Label6" runat="server" Text="Email" CssClass="labal"></asp:Label>
            </td>
            <td >
                <asp:Label ID="Label19" runat="server" Text=":" CssClass="labal"></asp:Label>
            </td>
            <td class="auto-style4" >
                <telerik:RadTextBox ID="txtEmail" Runat="server" CssClass="textBoxes" Skin="Silk" Width="200px">
                </telerik:RadTextBox>
                <asp:HiddenField ID="hdnEmail" runat="server" />
            </td>
            <td>
                <%--<asp:RequiredFieldValidator ID="r5" runat="server" ControlToValidate="txtEmail" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" Font-Strikeout="False" ForeColor="Red" ValidationGroup="r"></asp:RequiredFieldValidator>--%>
            </td>
            <td class="auto-style7">
                &nbsp;</td>
            <td class="auto-style9">
                <asp:Label ID="Label9" runat="server" Text="Remarks"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label33" runat="server" Text=":" CssClass="labal"></asp:Label>
            </td>
            <td rowspan="2">
                <asp:HiddenField ID="hdnRemark" runat="server" />
                <telerik:RadTextBox ID="txtRemarks" Runat="server" CssClass="textBoxes" 
                    TextMode="MultiLine" Width="300px" Skin="Silk" Rows="3">
                </telerik:RadTextBox>
            </td>
            <td>
                <%--<asp:RequiredFieldValidator ID="r10" runat="server" ControlToValidate="txtRemarks" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" Font-Strikeout="False" ForeColor="Red" ValidationGroup="r"></asp:RequiredFieldValidator>--%>
            </td>
        </tr>
        <tr>
            <td class="auto-style8" >
                <asp:Label ID="Label7" runat="server" Text="Telephone" CssClass="labal"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label20" runat="server" Text=":" CssClass="labal"></asp:Label>
            </td>
            <td class="auto-style4" >
                <telerik:RadTextBox ID="txtTelephone" Runat="server" CssClass="textBoxes" Skin="Silk" Width="200px">
                </telerik:RadTextBox>
                <asp:HiddenField ID="hdnPersonalTelephone" runat="server" />
            </td>
            <td >
                <asp:RequiredFieldValidator ID="r6" runat="server" ControlToValidate="txtTelephone" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" Font-Strikeout="False" ForeColor="Red" ValidationGroup="r"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style7" >
                &nbsp;</td>
            <td class="auto-style9" >
                &nbsp;</td>
            <td >
                &nbsp;</td>
            <td >
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8" >
                <asp:Label ID="Label8" runat="server" Text="Address" CssClass="labal"></asp:Label>
            </td>
            <td >
                <asp:Label ID="Label21" runat="server" Text=":" CssClass="labal"></asp:Label>
            </td>
            <td class="auto-style4" >
                <telerik:RadTextBox ID="txtAddress" Runat="server" CssClass="textBoxes" Skin="Silk" Width="200px" Rows="3" TextMode="MultiLine">
                </telerik:RadTextBox>
                <asp:HiddenField ID="hdnAddress" runat="server" />
            </td>
            <td>
                <%--<asp:RequiredFieldValidator ID="r7" runat="server" ControlToValidate="txtAddress" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" Font-Strikeout="False" ForeColor="Red" ValidationGroup="r"></asp:RequiredFieldValidator>--%>
            </td>
            <td class="auto-style7">
                &nbsp;</td>
            <td class="auto-style9" >
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                <asp:CheckBox ID="chkActive" runat="server" Text="Active" 
                    CssClass="checkBoxes" Checked="True" Enabled="False" />
                <asp:HiddenField ID="hdnIsActive" runat="server" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8" >
                &nbsp;</td>
            <td >
                &nbsp;</td>
            <td class="auto-style4" colspan="6" >
                
                <asp:Button ID="btnSave" runat="server" CssClass="btnCheckForChanges" Height="35px" Text="Request To Change" Width="250px" OnClick="btnSave_Click" ValidationGroup="r" />
                 &nbsp;&nbsp;                               
                <asp:Button ID="btnReset" runat="server" CssClass="btnResetToDefault" Height="35px" Text="Reset To Default" Width="200px" OnClick="btnReset_Click" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        </table>
</div>

            <div class="divGroupBlockHeaderSmall">Existing relationship details</div>
            <div class="divGroupBlockBody">
                <telerik:RadGrid ID="dgEmployeeWiseRelationshipDetails" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" onitemcommand="dgEmployeeWiseRelationshipDetails_ItemCommand" onneeddatasource="dgEmployeeWiseRelationshipDetails_NeedDataSource" onpageindexchanged="dgEmployeeWiseRelationshipDetails_PageIndexChanged" onpagesizechanged="dgEmployeeWiseRelationshipDetails_PageSizeChanged" onsortcommand="dgEmployeeWiseRelationshipDetails_SortCommand" PageSize="5" Skin="Silk" GroupPanelPosition="Top">
                    <ExportSettings ExportOnlyData="True">
                    </ExportSettings>
                    <MasterTableView>
                        <RowIndicatorColumn Visible="False">
                            <HeaderStyle Width="41px" />
                        </RowIndicatorColumn>
                        <ExpandCollapseColumn Created="True">
                            <HeaderStyle Width="41px" />
                        </ExpandCollapseColumn>
                        <CommandItemSettings ShowAddNewRecordButton="False" ShowExportToCsvButton="True" ShowExportToPdfButton="True" ShowRefreshButton="False" />
                        <Columns>
                            <telerik:GridBoundColumn DataField="EmployeeWiseRelationshipId" Display="False" EmptyDataText="" HeaderText="EmployeeWiseRelationshipId" UniqueName="EmployeeWiseRelationshipId">
                                <ColumnValidationSettings>
                                    <ModelErrorMessage Text="" />
                                </ColumnValidationSettings>
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="EmployeeId" Display="False" EmptyDataText="" HeaderText="EmployeeId" UniqueName="EmployeeId">
                                <ColumnValidationSettings>
                                    <ModelErrorMessage Text="" />
                                </ColumnValidationSettings>
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="EmployeeName" EmptyDataText="" HeaderText="EmployeeName" UniqueName="EmployeeName" Visible="False">
                                <ColumnValidationSettings>
                                    <ModelErrorMessage Text="" />
                                </ColumnValidationSettings>
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="RelationshipId" Display="False" EmptyDataText="" HeaderText="RelationshipId" UniqueName="RelationshipId">
                                <ColumnValidationSettings>
                                    <ModelErrorMessage Text="" />
                                </ColumnValidationSettings>
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="RelationshipName" EmptyDataText="" HeaderText="Relationship Name" UniqueName="RelationshipName">
                                <ColumnValidationSettings>
                                    <ModelErrorMessage Text="" />
                                </ColumnValidationSettings>
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Name" EmptyDataText="" HeaderText="Name" UniqueName="Name">
                                <ColumnValidationSettings>
                                    <ModelErrorMessage Text="" />
                                </ColumnValidationSettings>
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="DateOfBirth" Display="False" EmptyDataText="" HeaderText="Date of Birth" UniqueName="DateOfBirth">
                                <ColumnValidationSettings>
                                    <ModelErrorMessage Text="" />
                                </ColumnValidationSettings>
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="CivilStatusId" Display="False" EmptyDataText="" HeaderText="CivilStatusId" UniqueName="CivilStatusId">
                                <ColumnValidationSettings>
                                    <ModelErrorMessage Text="" />
                                </ColumnValidationSettings>
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="CivilStatusName" Display="False" EmptyDataText="" HeaderText="Civi lStatus" UniqueName="CivilStatusName">
                                <ColumnValidationSettings>
                                    <ModelErrorMessage Text="" />
                                </ColumnValidationSettings>
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Email" Display="False" EmptyDataText="" HeaderText="Email" UniqueName="Email">
                                <ColumnValidationSettings>
                                    <ModelErrorMessage Text="" />
                                </ColumnValidationSettings>
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Telephone" EmptyDataText="" HeaderText="Telephone" UniqueName="Telephone">
                                <ColumnValidationSettings>
                                    <ModelErrorMessage Text="" />
                                </ColumnValidationSettings>
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Address" EmptyDataText="" HeaderText="Address" UniqueName="Address">
                                <ColumnValidationSettings>
                                    <ModelErrorMessage Text="" />
                                </ColumnValidationSettings>
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Remarks" EmptyDataText="" HeaderText="Remarks" UniqueName="Remarks" Visible="False">
                                <ColumnValidationSettings>
                                    <ModelErrorMessage Text="" />
                                </ColumnValidationSettings>
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="PriorityId" EmptyDataText="" HeaderText="Priority" UniqueName="PriorityId">
                                <ColumnValidationSettings>
                                    <ModelErrorMessage Text="" />
                                </ColumnValidationSettings>
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="WorkPlace" Display="False" EmptyDataText="" HeaderText="Work Place" UniqueName="WorkPlace">
                                <ColumnValidationSettings>
                                    <ModelErrorMessage Text="" />
                                </ColumnValidationSettings>
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="WorkPlaceAddress" Display="False" EmptyDataText="" HeaderText="Work Place Address" UniqueName="WorkPlaceAddress">
                                <ColumnValidationSettings>
                                    <ModelErrorMessage Text="" />
                                </ColumnValidationSettings>
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="WorkPlaceTelephoneNumber" Display="False" EmptyDataText="" HeaderText="Work Place TelephoneNumber" UniqueName="WorkPlaceTelephoneNumber">
                                <ColumnValidationSettings>
                                    <ModelErrorMessage Text="" />
                                </ColumnValidationSettings>
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="IsActive" Display="False" EmptyDataText="" HeaderText="Active" UniqueName="IsActive">
                                <ColumnValidationSettings>
                                    <ModelErrorMessage Text="" />
                                </ColumnValidationSettings>
                            </telerik:GridBoundColumn>
                            <telerik:GridCheckBoxColumn DataField="IsActive" HeaderText="Active" UniqueName="IsActive1">
                            </telerik:GridCheckBoxColumn>
                            <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Select" ImageUrl="~/images/btn_edit.png" Text="Edit" UniqueName="Edit">
                            </telerik:GridButtonColumn>
                            <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" ConfirmDialogHeight="150px" ConfirmDialogType="RadWindow" ConfirmText="Are you sure you want to delete this record ? " ConfirmTitle="Confirmation..." ImageUrl="~/images/btn_delete.png" Text="Delete" UniqueName="Delete" Visible="False">
                            </telerik:GridButtonColumn>
                        </Columns>
                    </MasterTableView>
                </telerik:RadGrid>
            </div>


        </div>
    </div> 


</asp:Content>
