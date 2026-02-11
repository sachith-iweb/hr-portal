<%@ Page Title="" Language="C#" MasterPageFile="~/userprofile.Master" AutoEventWireup="true" CodeBehind="letter_request.aspx.cs" Inherits="HRM_UserProfile.letter_request" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style4 {
            width: 118px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="divGroupBlock">
        <div class="divGroupBlockHeader">
            Letter Requests
        </div>

       
<div class="divGroupBlockBody">
   
    <div class="divGroupBlockHeaderSmall">Submit new request</div>
     <div class="divGroupBlockBody">        
     <table cellpadding="5">
        <tr>
            <td class="auto-style4" >
                <asp:Label ID="lblLeaveType" runat="server" CssClass="labal" Text="Letter Type"></asp:Label>
            </td>
            <td >
                <asp:Label ID="lblEmployee1" runat="server" CssClass="labal" Text=":"></asp:Label>
            </td>
            <td>
                <telerik:RadComboBox ID="cmbLetterType" Runat="server" CssClass="comboBoxes" Skin="Silk" Width="350px" OnDataBound="cmbLetterType_DataBound">
                </telerik:RadComboBox>
            </td>
            <td >
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="cmbLetterType" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" Font-Strikeout="False" ForeColor="Red" ValidationGroup="r" InitialValue="---Select---"></asp:RequiredFieldValidator>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4" >
               Remarks<br />
                Ex: Address to;
            </td>
            <td >
                <asp:Label ID="lblEmployee9" runat="server" CssClass="labal" Text=":"></asp:Label>
            </td>
            <td >
                <telerik:RadTextBox ID="txtRemarks" Runat="server" CssClass="textBoxes" Rows="4" MaxLength="1000" Skin="Silk" TextMode="MultiLine" Width="600px">
                </telerik:RadTextBox>
            </td>
            <td >
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtRemarks" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" Font-Strikeout="False" ForeColor="Red" ValidationGroup="r"></asp:RequiredFieldValidator>
            </td>
            <td >
                &nbsp;</td>
            <td class="style11">
                &nbsp;</td>
            <td >
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
                   </table>


                <asp:Button ID="btnSave" runat="server" CssClass="btnCheckForChanges" Height="35px" OnClick="btnSave_Click" Text="Request Letter" Width="250px" ValidationGroup="r" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnReset" runat="server" CssClass="btnResetToDefault" Height="35px" OnClick="btnReset_Click" Text="Reset To Default" Width="200px" />
</div> 
    
    <div class="divGroupBlockHeaderSmall">Existing Letter Requests</div>
    <div class="divGroupBlockBody">

        <telerik:RadGrid ID="dgLetterRequest" runat="server" AutoGenerateColumns="False" GroupPanelPosition="Top">
            <MasterTableView>
                <Columns>
                    <telerik:GridBoundColumn DataField="RequestDateTime" FilterControlAltText="Filter RequestDateTime column" HeaderText="Request D/T" UniqueName="RequestDateTime">
                        <ColumnValidationSettings>
                            <ModelErrorMessage Text="" />
                        </ColumnValidationSettings>
                    </telerik:GridBoundColumn>
                    <telerik:GridBoundColumn DataField="LetterRequestId" Display="False" FilterControlAltText="Filter LetterRequestId column" HeaderText="LetterRequestId" UniqueName="LetterRequestId">
                        <ColumnValidationSettings>
                            <ModelErrorMessage Text="" />
                        </ColumnValidationSettings>
                    </telerik:GridBoundColumn>
                    <telerik:GridBoundColumn DataField="LetterTypeId" Display="False" FilterControlAltText="Filter LetterTypeId column" HeaderText="LetterTypeId" UniqueName="LetterTypeId">
                        <ColumnValidationSettings>
                            <ModelErrorMessage Text="" />
                        </ColumnValidationSettings>
                    </telerik:GridBoundColumn>
                    <telerik:GridBoundColumn DataField="LetterTypeName" FilterControlAltText="Filter LetterTypeName column" HeaderText="Letter Type" UniqueName="LetterTypeName">
                        <ColumnValidationSettings>
                            <ModelErrorMessage Text="" />
                        </ColumnValidationSettings>
                    </telerik:GridBoundColumn>
                    <telerik:GridBoundColumn DataField="EmployeeId" Display="False" FilterControlAltText="Filter EmployeeId column" HeaderText="EmployeeId" UniqueName="EmployeeId">
                        <ColumnValidationSettings>
                            <ModelErrorMessage Text="" />
                        </ColumnValidationSettings>
                    </telerik:GridBoundColumn>
                    <telerik:GridBoundColumn DataField="RequestedUserId" Display="False" FilterControlAltText="Filter RequestedUserId column" HeaderText="RequestedUserId" UniqueName="RequestedUserId">
                        <ColumnValidationSettings>
                            <ModelErrorMessage Text="" />
                        </ColumnValidationSettings>
                    </telerik:GridBoundColumn>
                    <telerik:GridBoundColumn DataField="RequestRemark" EmptyDataText="" FilterControlAltText="Filter RequestRemark column" HeaderText="Request Remark" UniqueName="RequestRemark">
                        <ColumnValidationSettings>
                            <ModelErrorMessage Text="" />
                        </ColumnValidationSettings>
                    </telerik:GridBoundColumn>
                    <telerik:GridBoundColumn DataField="IsReady" Display="False" FilterControlAltText="Filter IsReady column" HeaderText="IsReady" UniqueName="IsReady">
                        <ColumnValidationSettings>
                            <ModelErrorMessage Text="" />
                        </ColumnValidationSettings>
                    </telerik:GridBoundColumn>
                    <telerik:GridCheckBoxColumn DataField="IsReady" DataType="System.Boolean" FilterControlAltText="Filter IsReady1 column" HeaderText="Is Ready" UniqueName="IsReady1">
                    </telerik:GridCheckBoxColumn>
                    <telerik:GridBoundColumn DataField="LetterPrepaierdUserId" Display="False" FilterControlAltText="Filter LetterPrepaierdUserId column" HeaderText="LetterPrepaierdUserId" UniqueName="LetterPrepaierdUserId">
                        <ColumnValidationSettings>
                            <ModelErrorMessage Text="" />
                        </ColumnValidationSettings>
                    </telerik:GridBoundColumn>
                    <telerik:GridBoundColumn DataField="ReadyDateTime" FilterControlAltText="Filter ReadyDateTime column" HeaderText="Ready D/T" UniqueName="ReadyDateTime">
                        <ColumnValidationSettings>
                            <ModelErrorMessage Text="" />
                        </ColumnValidationSettings>
                    </telerik:GridBoundColumn>
                    <telerik:GridBoundColumn DataField="IsIssued" Display="False" FilterControlAltText="Filter IsIssued column" HeaderText="IsIssued" UniqueName="IsIssued">
                        <ColumnValidationSettings>
                            <ModelErrorMessage Text="" />
                        </ColumnValidationSettings>
                    </telerik:GridBoundColumn>
                    <telerik:GridCheckBoxColumn DataField="IsIssued" DataType="System.Boolean" FilterControlAltText="Filter IsIssued1 column" HeaderText="Is Issued" UniqueName="IsIssued1">
                    </telerik:GridCheckBoxColumn>
                    <telerik:GridBoundColumn DataField="IssuedUserId" Display="False" FilterControlAltText="Filter IssuedUserId column" HeaderText="IssuedUserId" UniqueName="IssuedUserId">
                        <ColumnValidationSettings>
                            <ModelErrorMessage Text="" />
                        </ColumnValidationSettings>
                    </telerik:GridBoundColumn>
                    <telerik:GridBoundColumn DataField="IssuedDateTime" FilterControlAltText="Filter IssuedDateTime column" HeaderText="Issued D/T" UniqueName="IssuedDateTime">
                        <ColumnValidationSettings>
                            <ModelErrorMessage Text="" />
                        </ColumnValidationSettings>
                    </telerik:GridBoundColumn>
                </Columns>
            </MasterTableView>
        </telerik:RadGrid>

    </div>
       
    </div>     
</asp:Content>
