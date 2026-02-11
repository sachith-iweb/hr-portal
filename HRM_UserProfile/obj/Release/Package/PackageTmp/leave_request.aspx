<%@ Page Title="" Language="C#" MasterPageFile="~/userprofile.Master" AutoEventWireup="true" CodeBehind="leave_request.aspx.cs" Inherits="HRM_UserProfile.leave_request" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style4 {
            width: 130px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="divGroupBlock">
        <div class="divGroupBlockHeader">
            Leave Requests
        </div>

        <div class="divGroupBlockBody">

                 <div class="divGroupBlockHeaderSmall"> Submit Leave Request  </div>
         <div class="divGroupBlockBody">
    <table>        
        <tr>
            <td class="tdbg">
           
               <table cellpadding="3">
        <tr>
            <td class="auto-style4" >
                <asp:Label ID="lblLeaveType" runat="server" CssClass="labal" Text="Leave Type"></asp:Label>
            </td>
            <td >
                <asp:Label ID="lblEmployee1" runat="server" CssClass="labal" Text=":"></asp:Label>
            </td>
            <td>
                <telerik:RadComboBox ID="cmbLeaveType" Runat="server" CssClass="comboBoxes" Skin="Silk" Width="250px" OnDataBound="cmbLeaveType_DataBound">
                </telerik:RadComboBox>
            </td>
            <td >
                <asp:RequiredFieldValidator ID="r1" runat="server" ControlToValidate="cmbLeaveType" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" Font-Strikeout="False" ForeColor="Red" ValidationGroup="r" InitialValue="---Select---"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="Label5" runat="server" CssClass="labal" Text="Leave Unit"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblEmployee2" runat="server" CssClass="labal" Text=":"></asp:Label>
            </td>
            <td >
                <telerik:RadComboBox ID="cmbLeaveUnit" Runat="server" CssClass="comboBoxes" Skin="Silk" Width="250px" OnDataBound="cmbLeaveUnit_DataBound">
                </telerik:RadComboBox>
            </td>
            <td >
                <asp:RequiredFieldValidator ID="r2" runat="server" ControlToValidate="cmbLeaveUnit" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" Font-Strikeout="False" ForeColor="Red" ValidationGroup="r" InitialValue="---Select---"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="Label1" runat="server" Text="From Date" CssClass="labal"></asp:Label>
            </td>
            <td>
                :</td>
            <td >
                <telerik:RadDatePicker ID="dptFromDate" Runat="server" AutoPostBack="True" 
                    onselecteddatechanged="dptFromDate_SelectedDateChanged" Culture="en-US" 
                    EnableTyping="False" CssClass="dateTimePicker" Skin="Silk" Width="250px">
<Calendar UseRowHeadersAsSelectors="False" UseColumnHeadersAsSelectors="False" ViewSelectorText="x" Skin="Silk"></Calendar>

<DateInput DisplayDateFormat="dd/MM/yyyy" DateFormat="dd/MM/yyyy" AutoPostBack="True" 
                        ReadOnly="True">
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
            </td>
            <td >
                <asp:RequiredFieldValidator ID="r3" runat="server" ControlToValidate="dptFromDate" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" Font-Strikeout="False" ForeColor="Red" ValidationGroup="r"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="Label2" runat="server" Text="To Date" CssClass="labal"></asp:Label>
            </td>
            <td>
                :</td>
            <td >
                <telerik:RadDatePicker ID="dptToDate" Runat="server" AutoPostBack="True" 
                    onselecteddatechanged="dptToDate_SelectedDateChanged" Culture="en-US" 
                    EnableTyping="False" CssClass="dateTimePicker" Skin="Silk" Width="250px">
<Calendar UseRowHeadersAsSelectors="False" UseColumnHeadersAsSelectors="False" ViewSelectorText="x" Skin="Silk"></Calendar>

<DateInput DisplayDateFormat="dd/MM/yyyy" DateFormat="dd/MM/yyyy" AutoPostBack="True" 
                        ReadOnly="True">
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
            </td>
            <td >
                <asp:RequiredFieldValidator ID="r4" runat="server" ControlToValidate="dptToDate" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" Font-Strikeout="False" ForeColor="Red" ValidationGroup="r"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="Label4" runat="server" Text="Number Of Units" CssClass="labal"></asp:Label>
            </td>
            <td>
                :</td>
            <td >
                <telerik:RadTextBox ID="txtNumberOfUnits" Runat="server" Enabled="False" 
                    CssClass="textBoxes" Skin="Silk" Width="150px">
                </telerik:RadTextBox>
            </td>
            <td >
                <asp:RequiredFieldValidator ID="r5" runat="server" ControlToValidate="txtNumberOfUnits" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" Font-Strikeout="False" ForeColor="Red" ValidationGroup="r"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style4" >
                <asp:Label ID="Label3" runat="server" CssClass="labal" Text="Remarks"></asp:Label>
            </td>
            <td >
                <asp:Label ID="lblEmployee9" runat="server" CssClass="labal" Text=":"></asp:Label>
            </td>
            <td >
                <telerik:RadTextBox ID="txtRemarks" Runat="server" CssClass="textBoxes" Rows="3" Skin="Silk" TextMode="MultiLine" Width="100%">
                </telerik:RadTextBox>
            </td>
            <td >
                <asp:RequiredFieldValidator ID="r6" runat="server" ControlToValidate="txtRemarks" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" Font-Strikeout="False" ForeColor="Red" ValidationGroup="r"></asp:RequiredFieldValidator>
            </td>
        </tr>
                   <tr>
                       <td class="auto-style4">Acting Employee</td>
                       <td>:</td>
                       <td>
                           <telerik:RadComboBox ID="cmbActingEmployeeDetails" Runat="server" CssClass="comboBoxes" Filter="Contains" Height="250px" MarkFirstMatch="True" OnDataBound="cmbEmployeeDetails_DataBound" Skin="Silk" Width="100%">
                           </telerik:RadComboBox>
                       </td>
                       <td>
                           <asp:RequiredFieldValidator ID="r7" runat="server" ControlToValidate="cmbActingEmployeeDetails" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" ForeColor="#FF3300"  SetFocusOnError="True" ValidationGroup="r">*</asp:RequiredFieldValidator>
                       </td>
                   </tr>
                   <tr>
                       <td class="auto-style4">
                <asp:Label ID="lblEmployee7" runat="server" CssClass="labal"></asp:Label>
                       </td>
                       <td>&nbsp;</td>
                       <td>
                           <asp:CheckBox ID="chkIsSendMail" runat="server"  Text="Send Email To Acting Employee" />
                       </td>
                       <td>&nbsp;</td>
                   </tr>
                   <tr>
                       <td class="auto-style4">&nbsp;</td>
                       <td>&nbsp;</td>
                       <td>
                <asp:Button ID="btnSave" runat="server" CssClass="btnCheckForChanges" Height="35px" OnClick="btnSave_Click" Text="Request Leave" Width="250px" ValidationGroup="r" />
                &nbsp;<asp:Button ID="btnReset" runat="server" CssClass="btnResetToDefault" Height="35px" OnClick="btnReset_Click" Text="Reset To Default" Width="200px" />
            &nbsp;
                       </td>
                       <td>&nbsp;</td>
                   </tr>
        </table>
           </td>
        </tr>
        </table>
        </div>
      


         <div class="divGroupBlockHeaderSmall"> Existing Leave Requests</div>
         <div class="divGroupBlockBody">
             
             <telerik:RadGrid ID="dgLeaveRequest" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" GroupPanelPosition="Top" OnDetailTableDataBind="dgLeaveRequest_DetailTableDataBind" onitemcommand="dgLeaveRequest_ItemCommand" onneeddatasource="dgLeaveRequest_NeedDataSource" Skin="Silk" Width="100%">
                 <MasterTableView DataKeyNames="LeaveRequestId">
                     <DetailTables>
                         <telerik:GridTableView runat="server" DataKeyNames="LeaveRequestId">
                             <RowIndicatorColumn Visible="False">
                                 <HeaderStyle Width="41px" />
                             </RowIndicatorColumn>
                             <ExpandCollapseColumn>
                                 <HeaderStyle Width="41px" />
                             </ExpandCollapseColumn>
                             <Columns>
                                 <telerik:GridBoundColumn DataField="LeaveRequestId" Display="False" FilterControlAltText="Filter LeaveRequestId column" HeaderText="LeaveRequestId" UniqueName="LeaveRequestId">
                                     <ColumnValidationSettings>
                                         <ModelErrorMessage Text="" />
                                     </ColumnValidationSettings>
                                 </telerik:GridBoundColumn>
                                 <telerik:GridBoundColumn DataField="Sequance" FilterControlAltText="Filter Sequance column" HeaderText="Seq." UniqueName="Sequance">
                                     <ColumnValidationSettings>
                                         <ModelErrorMessage Text="" />
                                     </ColumnValidationSettings>
                                 </telerik:GridBoundColumn>
                                 <telerik:GridBoundColumn DataField="Designation" FilterControlAltText="Filter Designation column" HeaderText="Designation" UniqueName="Designation">
                                     <ColumnValidationSettings>
                                         <ModelErrorMessage Text="" />
                                     </ColumnValidationSettings>
                                 </telerik:GridBoundColumn>
                                 <telerik:GridBoundColumn DataField="ApprovingEmployee" FilterControlAltText="Filter ApprovingEmployee column" HeaderText="Approving Employee" UniqueName="ApprovingEmployee">
                                     <ColumnValidationSettings>
                                         <ModelErrorMessage Text="" />
                                     </ColumnValidationSettings>
                                 </telerik:GridBoundColumn>
                                 <telerik:GridBoundColumn DataField="Status" FilterControlAltText="Filter Status column" HeaderText="Status" UniqueName="Status">
                                     <ColumnValidationSettings>
                                         <ModelErrorMessage Text="" />
                                     </ColumnValidationSettings>
                                 </telerik:GridBoundColumn>
                                 <telerik:GridBoundColumn DataField="ForwardRemark" FilterControlAltText="Filter ForwardRemark column" HeaderText="Fwd. Remark" UniqueName="ForwardRemark">
                                     <ColumnValidationSettings>
                                         <ModelErrorMessage Text="" />
                                     </ColumnValidationSettings>
                                 </telerik:GridBoundColumn>
                                 <telerik:GridBoundColumn DataField="Remark" FilterControlAltText="Filter Remark column" HeaderText="Remark" UniqueName="Remark">
                                     <ColumnValidationSettings>
                                         <ModelErrorMessage Text="" />
                                     </ColumnValidationSettings>
                                 </telerik:GridBoundColumn>
                                 <telerik:GridBoundColumn DataField="UpdatedOn" FilterControlAltText="Filter UpdatedOn column" HeaderText="Updated On" UniqueName="UpdatedOn">
                                     <ColumnValidationSettings>
                                         <ModelErrorMessage Text="" />
                                     </ColumnValidationSettings>
                                 </telerik:GridBoundColumn>
                             </Columns>
                         </telerik:GridTableView>
                     </DetailTables>
                     <RowIndicatorColumn>
                         <HeaderStyle Width="20px" />
                     </RowIndicatorColumn>
                     <ExpandCollapseColumn>
                         <HeaderStyle Width="20px" />
                     </ExpandCollapseColumn>
                     <Columns>
                         <telerik:GridBoundColumn DataField="LeaveRequestId" Display="False" HeaderText="LeaveRequestId" UniqueName="LeaveRequestId">
                             <ColumnValidationSettings>
                                 <ModelErrorMessage Text="" />
                             </ColumnValidationSettings>
                         </telerik:GridBoundColumn>
                         <telerik:GridBoundColumn DataField="RequestDate" DataFormatString="{0:d}" HeaderText="RequestDate" UniqueName="RequestDate">
                             <ColumnValidationSettings>
                                 <ModelErrorMessage Text="" />
                             </ColumnValidationSettings>
                         </telerik:GridBoundColumn>
                         <telerik:GridBoundColumn DataField="EmployeeId" Display="False" HeaderText="EmployeeId" UniqueName="EmployeeId">
                             <ColumnValidationSettings>
                                 <ModelErrorMessage Text="" />
                             </ColumnValidationSettings>
                         </telerik:GridBoundColumn>
                         <telerik:GridBoundColumn DataField="Name" Display="False" HeaderText="Name" UniqueName="Name">
                             <ColumnValidationSettings>
                                 <ModelErrorMessage Text="" />
                             </ColumnValidationSettings>
                         </telerik:GridBoundColumn>
                         <telerik:GridBoundColumn DataField="LeaveTypeId" Display="False" HeaderText="LeaveTypeId" UniqueName="LeaveTypeId">
                             <ColumnValidationSettings>
                                 <ModelErrorMessage Text="" />
                             </ColumnValidationSettings>
                         </telerik:GridBoundColumn>
                         <telerik:GridBoundColumn DataField="LeaveType" HeaderText="Leave Type" UniqueName="LeaveType">
                             <ColumnValidationSettings>
                                 <ModelErrorMessage Text="" />
                             </ColumnValidationSettings>
                         </telerik:GridBoundColumn>
                         <telerik:GridBoundColumn DataField="NoOfUnits" HeaderText="No Of Units" UniqueName="NoOfUnits">
                             <ColumnValidationSettings>
                                 <ModelErrorMessage Text="" />
                             </ColumnValidationSettings>
                             <ItemStyle Width="50px" />
                         </telerik:GridBoundColumn>
                         <telerik:GridBoundColumn DataField="Status" Display="False" HeaderText="Status" UniqueName="Status">
                             <ColumnValidationSettings>
                                 <ModelErrorMessage Text="" />
                             </ColumnValidationSettings>
                         </telerik:GridBoundColumn>
                         <telerik:GridBoundColumn DataField="StatusDesc" HeaderText="Status" UniqueName="StatusDesc">
                             <ColumnValidationSettings>
                                 <ModelErrorMessage Text="" />
                             </ColumnValidationSettings>
                         </telerik:GridBoundColumn>
                         <telerik:GridDateTimeColumn DataField="FromDate" DataFormatString="{0:d}" HeaderText="FromDate" UniqueName="FromDate">
                             <ColumnValidationSettings>
                                 <ModelErrorMessage Text="" />
                             </ColumnValidationSettings>
                         </telerik:GridDateTimeColumn>
                         <telerik:GridDateTimeColumn DataField="ToDate" DataFormatString="{0:d}" HeaderText="ToDate" UniqueName="ToDate">
                             <ColumnValidationSettings>
                                 <ModelErrorMessage Text="" />
                             </ColumnValidationSettings>
                         </telerik:GridDateTimeColumn>
                         <telerik:GridBoundColumn DataField="Remark" HeaderText="Remark" UniqueName="Remark">
                             <ColumnValidationSettings>
                                 <ModelErrorMessage Text="" />
                             </ColumnValidationSettings>
                         </telerik:GridBoundColumn>
                         <telerik:GridBoundColumn DataField="LeaveUnitId" Display="False" HeaderText="LeaveUnitId" UniqueName="LeaveUnitId">
                             <ColumnValidationSettings>
                                 <ModelErrorMessage Text="" />
                             </ColumnValidationSettings>
                         </telerik:GridBoundColumn>
                         <telerik:GridBoundColumn DataField="LeaveUnitName" HeaderText="LeaveUnitName" UniqueName="LeaveUnitName">
                             <ColumnValidationSettings>
                                 <ModelErrorMessage Text="" />
                             </ColumnValidationSettings>
                         </telerik:GridBoundColumn>
                         <telerik:GridCheckBoxColumn DataField="IsActive" Display="False" HeaderText="Active" UniqueName="IsActive">
                         </telerik:GridCheckBoxColumn>
                         <telerik:GridBoundColumn DataField="IsActive" Display="False" HeaderText="IsActive" UniqueName="IsActive1">
                             <ColumnValidationSettings>
                                 <ModelErrorMessage Text="" />
                             </ColumnValidationSettings>
                         </telerik:GridBoundColumn>
                         <telerik:GridButtonColumn CommandName="Delete" ConfirmText="Are you sure you want to delete this request?" ConfirmTitle="Confirmation" Text="Cancel" UniqueName="Delete" Visible="False">
                             <ItemStyle Width="25px" />
                         </telerik:GridButtonColumn>
                     </Columns>
                 </MasterTableView>
             </telerik:RadGrid>
         </div>

    </div> 

   
</asp:Content>
