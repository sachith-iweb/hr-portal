<%@ Page Title="" Language="C#" MasterPageFile="~/userprofile.Master" AutoEventWireup="true" CodeBehind="outstation_allowance.aspx.cs" Inherits="HRM_UserProfile.outstation_allowance" %>
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
            Outstation Allowances
        </div>

        <div class="divGroupBlockBody">

                 <div class="divGroupBlockHeaderSmall"> Submit Outstation Allowance Request  </div>
         <div class="divGroupBlockBody">
    <table>
        <tr>
            <td class="tdbg">

               <table cellpadding="3">
        <tr>
            <td class="auto-style4" >
                <asp:Label ID="lblCustomer" runat="server" CssClass="labal" Text="Customer"></asp:Label>
            </td>
            <td >
                <asp:Label ID="lblColon1" runat="server" CssClass="labal" Text=":"></asp:Label>
            </td>
            <td>
                <telerik:RadTextBox ID="txtCustomer" Runat="server" CssClass="textBoxes" Skin="Silk" Width="250px">
                </telerik:RadTextBox>
            </td>
            <td >
                <asp:RequiredFieldValidator ID="r1" runat="server" ControlToValidate="txtCustomer" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" Font-Strikeout="False" ForeColor="Red" ValidationGroup="r"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style4" >
                <asp:Label ID="lblReason" runat="server" CssClass="labal" Text="Reason"></asp:Label>
            </td>
            <td >
                <asp:Label ID="lblColon2" runat="server" CssClass="labal" Text=":"></asp:Label>
            </td>
            <td >
                <telerik:RadTextBox ID="txtReason" Runat="server" CssClass="textBoxes" Rows="3" Skin="Silk" TextMode="MultiLine" Width="100%">
                </telerik:RadTextBox>
            </td>
            <td >
                <asp:RequiredFieldValidator ID="r2" runat="server" ControlToValidate="txtReason" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" Font-Strikeout="False" ForeColor="Red" ValidationGroup="r"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="lblFromDate" runat="server" Text="From Date" CssClass="labal"></asp:Label>
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
                <asp:Label ID="lblToDate" runat="server" Text="To Date" CssClass="labal"></asp:Label>
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
                <asp:Label ID="lblOverstayNights" runat="server" Text="Overstay Nights" CssClass="labal"></asp:Label>
            </td>
            <td>
                :</td>
            <td >
                <telerik:RadNumericTextBox ID="txtOverstayNights" Runat="server" CssClass="textBoxes" Skin="Silk" Width="150px"
                    DataType="System.Int32" MinValue="0" Value="0">
                    <NumberFormat DecimalDigits="0" GroupSeparator="" />
                </telerik:RadNumericTextBox>
            </td>
            <td >
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="lblHolidayNights" runat="server" Text="Holiday Nights" CssClass="labal"></asp:Label>
            </td>
            <td>
                :</td>
            <td >
                <telerik:RadNumericTextBox ID="txtHolidayNights" Runat="server" CssClass="textBoxes" Skin="Silk" Width="150px"
                    DataType="System.Int32" MinValue="0" Value="0">
                    <NumberFormat DecimalDigits="0" GroupSeparator="" />
                </telerik:RadNumericTextBox>
            </td>
            <td >
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="lblOther" runat="server" Text="Other" CssClass="labal"></asp:Label>
            </td>
            <td>
                :</td>
            <td >
                <telerik:RadNumericTextBox ID="txtOther" Runat="server" CssClass="textBoxes" Skin="Silk" Width="150px"
                    DataType="System.Int32" MinValue="0" Value="0">
                    <NumberFormat DecimalDigits="0" GroupSeparator="" />
                </telerik:RadNumericTextBox>
            </td>
            <td >
                &nbsp;
            </td>
        </tr>
                   <tr>
                       <td class="auto-style4">&nbsp;</td>
                       <td>&nbsp;</td>
                       <td>
                <asp:Button ID="btnSave" runat="server" CssClass="btnCheckForChanges" Height="35px" OnClick="btnSave_Click" Text="Submit Request" Width="250px" ValidationGroup="r" />
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



         <div class="divGroupBlockHeaderSmall"> Existing Outstation Allowance Requests</div>
         <div class="divGroupBlockBody">

             <telerik:RadGrid ID="dgOutstationAllowance" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" GroupPanelPosition="Top" OnDetailTableDataBind="dgOutstationAllowance_DetailTableDataBind" onitemcommand="dgOutstationAllowance_ItemCommand" onneeddatasource="dgOutstationAllowance_NeedDataSource" Skin="Silk" Width="100%">
                 <MasterTableView DataKeyNames="OutstationAllowanceId">
                     <DetailTables>
                         <telerik:GridTableView runat="server" DataKeyNames="OutstationAllowanceId">
                             <RowIndicatorColumn Visible="False">
                                 <HeaderStyle Width="41px" />
                             </RowIndicatorColumn>
                             <ExpandCollapseColumn>
                                 <HeaderStyle Width="41px" />
                             </ExpandCollapseColumn>
                             <Columns>
                                 <telerik:GridBoundColumn DataField="OutstationAllowanceId" Display="False" FilterControlAltText="Filter OutstationAllowanceId column" HeaderText="OutstationAllowanceId" UniqueName="OutstationAllowanceId">
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
                                 <telerik:GridBoundColumn DataField="Status" FilterControlAltText="Filter Status column" HeaderText="Status" UniqueName="DetailStatus">
                                     <ColumnValidationSettings>
                                         <ModelErrorMessage Text="" />
                                     </ColumnValidationSettings>
                                 </telerik:GridBoundColumn>
                                 <telerik:GridBoundColumn DataField="ForwardRemark" FilterControlAltText="Filter ForwardRemark column" HeaderText="Fwd. Remark" UniqueName="ForwardRemark">
                                     <ColumnValidationSettings>
                                         <ModelErrorMessage Text="" />
                                     </ColumnValidationSettings>
                                 </telerik:GridBoundColumn>
                                 <telerik:GridBoundColumn DataField="Remark" FilterControlAltText="Filter Remark column" HeaderText="Remark" UniqueName="DetailRemark">
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
                         <telerik:GridBoundColumn DataField="OutstationAllowanceId" Display="False" HeaderText="OutstationAllowanceId" UniqueName="OutstationAllowanceId">
                             <ColumnValidationSettings>
                                 <ModelErrorMessage Text="" />
                             </ColumnValidationSettings>
                         </telerik:GridBoundColumn>
                         <telerik:GridBoundColumn DataField="RequestDate" DataFormatString="{0:d}" HeaderText="Request Date" UniqueName="RequestDate">
                             <ColumnValidationSettings>
                                 <ModelErrorMessage Text="" />
                             </ColumnValidationSettings>
                         </telerik:GridBoundColumn>
                         <telerik:GridBoundColumn DataField="Customer" HeaderText="Customer" UniqueName="Customer">
                             <ColumnValidationSettings>
                                 <ModelErrorMessage Text="" />
                             </ColumnValidationSettings>
                         </telerik:GridBoundColumn>
                         <telerik:GridDateTimeColumn DataField="FromDate" DataFormatString="{0:d}" HeaderText="From Date" UniqueName="FromDate">
                             <ColumnValidationSettings>
                                 <ModelErrorMessage Text="" />
                             </ColumnValidationSettings>
                         </telerik:GridDateTimeColumn>
                         <telerik:GridDateTimeColumn DataField="ToDate" DataFormatString="{0:d}" HeaderText="To Date" UniqueName="ToDate">
                             <ColumnValidationSettings>
                                 <ModelErrorMessage Text="" />
                             </ColumnValidationSettings>
                         </telerik:GridDateTimeColumn>
                         <telerik:GridBoundColumn DataField="OverstayNights" HeaderText="Overstay Nights" UniqueName="OverstayNights">
                             <ColumnValidationSettings>
                                 <ModelErrorMessage Text="" />
                             </ColumnValidationSettings>
                             <ItemStyle Width="80px" />
                         </telerik:GridBoundColumn>
                         <telerik:GridBoundColumn DataField="HolidayNights" HeaderText="Holiday Nights" UniqueName="HolidayNights">
                             <ColumnValidationSettings>
                                 <ModelErrorMessage Text="" />
                             </ColumnValidationSettings>
                             <ItemStyle Width="80px" />
                         </telerik:GridBoundColumn>
                         <telerik:GridBoundColumn DataField="Other" HeaderText="Other" UniqueName="Other">
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
                         <telerik:GridBoundColumn DataField="Reason" HeaderText="Reason" UniqueName="Reason">
                             <ColumnValidationSettings>
                                 <ModelErrorMessage Text="" />
                             </ColumnValidationSettings>
                         </telerik:GridBoundColumn>
                         <telerik:GridCheckBoxColumn DataField="IsActive" Display="False" HeaderText="Active" UniqueName="IsActive">
                         </telerik:GridCheckBoxColumn>
                         <telerik:GridButtonColumn CommandName="Delete" ConfirmText="Are you sure you want to cancel this request?" ConfirmTitle="Confirmation" Text="Cancel" UniqueName="Delete" Visible="False">
                             <ItemStyle Width="25px" />
                         </telerik:GridButtonColumn>
                     </Columns>
                 </MasterTableView>
             </telerik:RadGrid>
         </div>

    </div>


</asp:Content>
