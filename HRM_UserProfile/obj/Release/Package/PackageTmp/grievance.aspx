<%@ Page Title="" Language="C#" MasterPageFile="~/userprofile.Master" AutoEventWireup="true" CodeBehind="grievance.aspx.cs" Inherits="HRM_UserProfile.grievance" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="divGroupBlockHeader">Initiate Grivance</div>
    <div class="divGroupBlockBody">
            <div class="divGroupBlockHeaderSmall">Grivance summary</div>
            <div class="divGroupBlockBody">
                <table cellpadding="3px" cellspacing="3px">
                    <tr>
                        <td width="150px">Grivance Category</td>
                        <td width="10px">:</td>
                        <td>
                            <telerik:RadComboBox ID="cmbGrievanceCategory" Runat="server" AutoPostBack="True" ondatabound="cmbGrievanceCategory_DataBound" onselectedindexchanged="cmbGrievanceCategory_SelectedIndexChanged" Skin="Silk" Width="400px">
                            </telerik:RadComboBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="r1" runat="server" ControlToValidate="cmbGrievanceCategory" CssClass="requiredFeildValidators" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" ForeColor="Red" InitialValue="---Select---" SetFocusOnError="True" ValidationGroup="i"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblRelatedIssues" runat="server" Text="Related Issue(s)"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="lblRelatedIssuesColon" runat="server" Text=":"></asp:Label>
                        </td>
                        <td>
                            <style>

                            .checkListCSS
                            {
                                margin-left:-5px;
                            }
                            .style2
                            {
                                width: 11px;
                            }
                            .auto-style4 {
                                height: 30px;
                            }
                            .auto-style5 {
                                width: 11px;
                                height: 30px;
                            }
                        </style>
                            <asp:CheckBoxList ID="chkLstIssues" runat="server" CssClass="checkListCSS">
                            </asp:CheckBoxList>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblDescription" runat="server" Text="Description"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="lblDescriptionColon" runat="server" Text=":"></asp:Label>
                        </td>
                        <td>
                            <telerik:RadTextBox ID="txtDescription" Runat="server" Rows="3" TextMode="MultiLine" Width="600px">
                            </telerik:RadTextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="r2" runat="server" ControlToValidate="txtDescription" CssClass="requiredFeildValidators" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" ForeColor="Red" SetFocusOnError="True" ValidationGroup="i"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                </table>
                </div>
         
        <div class="divGroupBlockHeaderSmall">People Involved</div>
            <div class="divGroupBlockBody">
        <table cellpadding="3px" cellspacing="3px">
        <tr>
            <td  width="150px">
                <asp:Label ID="lblDepartment" runat="server" Text="Department" CssClass="labal"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label1" runat="server" Text=":" CssClass="labal"></asp:Label>
            </td>
            <td>
                <telerik:RadComboBox ID="cmbDepartment" Runat="server" 
                    AppendDataBoundItems="True" AutoPostBack="True" 
                    onselectedindexchanged="cmbDepartment_SelectedIndexChanged" 
                    CssClass="comboBoxes" Width="400px" ondatabound="cmbDepartment_DataBound" Skin="Silk">
                </telerik:RadComboBox>
                
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblDesignation" runat="server" Text="Designation" 
                    CssClass="labal"></asp:Label>
            </td>
            <td class="auto-style5">
                <asp:Label ID="Label2" runat="server" Text=":" CssClass="labal"></asp:Label>
            </td>
            <td class="auto-style4">
                <telerik:RadComboBox ID="cmbDesignation" Runat="server" 
                    AppendDataBoundItems="True" AutoPostBack="True" 
                    onselectedindexchanged="cmbDesignation_SelectedIndexChanged" 
                    CssClass="comboBoxes" Width="400px" ondatabound="cmbDesignation_DataBound" Skin="Silk">
                </telerik:RadComboBox> 
                
            </td>
            <td class="auto-style4">
                &nbsp;</td>
        </tr>
        <tr>
            <td >
                <asp:Label ID="lblEmployee" runat="server" Text="Employee" CssClass="labal"></asp:Label>
            </td>
            <td class="style2" >
                <asp:Label ID="Label3" runat="server" Text=":" CssClass="labal"></asp:Label>
            </td>
            <td>
                <telerik:RadComboBox ID="cmbEmployee" Runat="server" 
                    AppendDataBoundItems="True"                   
                    CssClass="comboBoxes" Width="400px" ondatabound="cmbEmployee_DataBound" Skin="Silk">
                </telerik:RadComboBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="ri3" runat="server" 
                    ControlToValidate="cmbEmployee" CssClass="requiredFeildValidators" 
                    ErrorMessage="*" InitialValue="---Select---" 
                    ValidationGroup="a" Font-Bold="True" Font-Size="X-Large" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td >
            </td>
            <td class="style2" >
                &nbsp;</td>
            <td style="vertical-align:middle !important;">
                <asp:Button ID="btnAdd" runat="server" Text="Add This Employee" 
                    onclick="btnAdd_Click" ValidationGroup="a" Width="174px" />
            &nbsp;<asp:Label ID="lblAddEmployeeMessage" runat="server" style="color: #FFFFFF"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        </table>
                <telerik:RadGrid ID="dgPeopleInvolved" runat="server" Skin="Silk" 
                    AutoGenerateColumns="False" GridLines="None" 
                    onitemcommand="dgPeopleInvolved_ItemCommand" 
                    onneeddatasource="dgPeopleInvolved_NeedDataSource">
<MasterTableView>
<RowIndicatorColumn>
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn>
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>
    <Columns>
        <telerik:GridBoundColumn DataField="DepartmentId" HeaderText="DepartmentId" 
            UniqueName="DepartmentId" Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="DesignationId" HeaderText="DesignationId" 
            UniqueName="DesignationId" Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="EmployeeId" HeaderText="EmployeeId" 
            UniqueName="EmployeeId" Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Department" HeaderText="Department" 
            UniqueName="Department">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Designation" HeaderText="Designation" 
            UniqueName="Designation">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Employee" HeaderText="Employee" 
            UniqueName="Employee">
        </telerik:GridBoundColumn>
        <telerik:GridButtonColumn CommandName="Delete" 
            ConfirmText="Are you sure you need to remove this record?" Text="Remove" 
            UniqueName="column">
            <HeaderStyle Width="100px" />
            <ItemStyle Width="100px" />
        </telerik:GridButtonColumn>
    </Columns>
</MasterTableView>
                </telerik:RadGrid>
<br />

            </div>
   

      <div class="divGroupBlockHeaderSmall">  Related Incidents (if any) </div>
        <div class="divGroupBlockBody">

            <table cellspacing="3px" cellpadding="3px">
                <tr>
                    <td  width="150px">Date Time </td>
                    <td>:</td>
                    <td>
                        <telerik:RadDateTimePicker ID="dtpIncidentDateTime" Runat="server" 
                            Width="250px"  Skin="Silk">
                        </telerik:RadDateTimePicker>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="rri" runat="server" 
                    ControlToValidate="dtpIncidentDateTime" CssClass="requiredFeildValidators" 
                    ErrorMessage="*" 
                    ValidationGroup="inci" Font-Bold="True" Font-Size="X-Large" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </td>
                </tr>

                <tr>
                    <td>Description</td>
                    <td>:</td>
                    <td>
                        <telerik:RadTextBox ID="txtIncicentDescrioption" Runat="server" 
                                TextMode="MultiLine" Width="600px" Rows="3">
                            </telerik:RadTextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="rri1" runat="server" 
                    ControlToValidate="txtIncicentDescrioption" CssClass="requiredFeildValidators" 
                    ErrorMessage="*" 
                    ValidationGroup="inci" Font-Bold="True" Font-Size="X-Large" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </td>
                </tr>

                <tr>
                    <td></td>
                    <td></td>
                    <td>
                   <asp:Button ID="btnAddIncident" runat="server" Text="Add This Incident" 
                    onclick="btnAddIncident_Click" ValidationGroup="inci" Width="174px" />
                    </td>
                    <td></td>
                </tr>

            </table>

            <br />
                <telerik:RadGrid ID="dgRelatedIncidents" runat="server" Skin="Silk" 
                    AutoGenerateColumns="False" GridLines="None" 
                    onitemcommand="dgRelatedIncidents_ItemCommand" 
                    onneeddatasource="dgRelatedIncidents_NeedDataSource">
<MasterTableView>
<RowIndicatorColumn>
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn>
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>
    <Columns>
        <telerik:GridBoundColumn DataField="DateTime" HeaderText="Date Time" 
            UniqueName="DateTime">
            <HeaderStyle Width="200px" />
            <ItemStyle Width="200px" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Incident" HeaderText="Incident" 
            UniqueName="Incident">
        </telerik:GridBoundColumn>
        <telerik:GridButtonColumn CommandName="Delete" 
            ConfirmText="Are you sure you need to remove this record?" Text="Remove" 
            UniqueName="Delete">
            <HeaderStyle Width="100px" />
            <ItemStyle Width="100px" />
        </telerik:GridButtonColumn>
    </Columns>
</MasterTableView>
                </telerik:RadGrid>
        </div>

   

       <div class="divGroupBlockHeaderSmall">  Prefered Resolving Method / Summarize Grievance / Submit </div>              

        <div class="divGroupBlockBody">
        <table cellpadding="3px" cellspacing="3px" >
        <tr>
            <td  width="150px">
                Preferrd
                Resolving Method</td>
            <td class="style2">
                :</td>
            <td>
                <telerik:RadComboBox ID="cmbPreferredResolvingMethod" Runat="server" 
                    AppendDataBoundItems="True"                   
                    CssClass="comboBoxes" Width="600px" Skin="Silk" OnDataBound="cmbPreferredResolvingMethod_DataBound1">
                </telerik:RadComboBox>
                        </td>
            <td>
                <asp:RequiredFieldValidator ID="r3" runat="server" 
                    ControlToValidate="cmbPreferredResolvingMethod" ErrorMessage="*" 
                     ValidationGroup="i" CssClass="requiredFeildValidators" Font-Bold="True" Font-Size="X-Large" ForeColor="Red" SetFocusOnError="True" InitialValue="---Select---"></asp:RequiredFieldValidator>
                        </td>
        </tr>
        <tr>
            <td>
                Summary</td>
            <td class="style2">
                <asp:Label ID="Label4" runat="server" Text=":" CssClass="labal"></asp:Label>
            </td>
            <td>
                            <telerik:RadTextBox ID="txtSummary" Runat="server" 
                                TextMode="MultiLine" Width="600px" Rows="3">
                            </telerik:RadTextBox>
                
            </td>
            <td>
                <asp:RequiredFieldValidator ID="r4" runat="server" 
                    ControlToValidate="txtSummary" CssClass="requiredFeildValidators" 
                    ErrorMessage="*" 
                    ValidationGroup="i" Font-Bold="True" Font-Size="X-Large" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="style2">
                &nbsp;</td>
            <td>
                            <asp:Button ID="btnSubmit" runat="server" Text="SUBMIT GRIEVANCE" 
                                Width="174px" onclick="btnSubmit_Click" ValidationGroup="i" />
                
            </td>
            <td>
                &nbsp;</td>
        </tr>
        </table>
        </div>
             

 </div>

</asp:Content>
