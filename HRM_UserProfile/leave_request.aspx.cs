using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DOMAIN;
using SERVICE;
using Telerik.Web.UI;
using System.Data;
using jQueryNotification.Helper;

namespace HRM_UserProfile
{
    public partial class leave_request : System.Web.UI.Page
    {
        LeaveRequest leaveRequest = new LeaveRequest();
        LeaveRequestService leaveRequestService = new LeaveRequestService();

        EmployeeDetails employeeDetails = new EmployeeDetails();
        EmployeeDetailsService employeeDetailsService = new EmployeeDetailsService();

        DesignationWiseLeaveTypeDetails designationWiseLeaveTypeDetails = new DesignationWiseLeaveTypeDetails();
        DesignationWiseLeaveTypeDetailsService designationWiseLeaveTypeDetailsService = new DesignationWiseLeaveTypeDetailsService();

        CompanyWiseLeaveUnitsDetails companyWiseLeaveUnitsDetails = new CompanyWiseLeaveUnitsDetails();
        CompanyWiseLeaveUnitsService companyWiseLeaveUnitsService = new CompanyWiseLeaveUnitsService();

        UserDetails userDetails = new UserDetails();
        UserDetailsService userDetailsService = new UserDetailsService();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                ControllerSizesAndValidationMessagesSet();

                if (!IsPostBack)
                {
                   // dptFromDate.MinDate = DateTime.Today.Date;
                    FillComboBoxes();

                    ResetInputs(true);
                    dptToDate.Enabled = false;                   
                    ResetInputs(true);

                    userDetails.UserId = Convert.ToInt32(Session["UserId"]);                    
                    FillGrid();
                }

            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx",false);
            }
        }

        #region Combo Box Filler
        public void FillComboBoxes()
        {

            try
            {
                FillLeaveTypes();
                FillLeaveUnits();
                FillEmployeeCombo();
                ResetInputs(true);

            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx",false);
            }
        }
        #endregion

        
        private void FillEmployeeCombo()
        {
            try
            {
                EmployeeDetails employeeDetails = new EmployeeDetails();
                employeeDetails.CompanyID = Convert.ToInt32(Session["CompanyId"]);
                cmbActingEmployeeDetails.DataSource = null;
                cmbActingEmployeeDetails.DataSource = new EmployeeDetailsService().SelectAllActiveEmployeeDetails(employeeDetails, 1);
                cmbActingEmployeeDetails.DataTextField = "NameWithInitials";
                cmbActingEmployeeDetails.DataValueField = "EmployeeID";
                cmbActingEmployeeDetails.DataBind();
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx", false);
            }
        }

        #region Leave Type Details Combo Box Filler
        public void FillLeaveTypes()
        {
            try
            {
                cmbLeaveType.DataSource = null;
                cmbLeaveType.DataBind();

                cmbLeaveType.DataSource = new OverviewService().SelectLeaveAllocationAndBalace(Session["EmployeeId"].ToString());
                cmbLeaveType.DataTextField = "LeaveType";
                cmbLeaveType.DataValueField = "LeaveTypeID";

                cmbLeaveType.DataBind();
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx",false);
            }
        }
        #endregion

        #region Leave Units Details Combo Box Filler
        public void FillLeaveUnits()
        {
            try
            {
                companyWiseLeaveUnitsDetails.CompanyId = Convert.ToInt32(Session["CompanyId"]);

                cmbLeaveUnit.DataSource = companyWiseLeaveUnitsService.Select(companyWiseLeaveUnitsDetails);
                cmbLeaveUnit.DataTextField = "UnitName";
                cmbLeaveUnit.DataValueField = "LeaveUnitId";

                cmbLeaveUnit.DataBind();
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx",false);
            }

        }
        #endregion

        #region Set Controller Sizes And Validation Messages
        public void ControllerSizesAndValidationMessagesSet()
        {
            //cmbEmployee.Width = Convert.ToInt32(FromSpecificInformations.ComboBoxWidth);
            //cmbLeaveType.Width = Convert.ToInt32(FromSpecificInformations.ComboBoxWidth);
            //cmbLeaveUnit.Width = Convert.ToInt32(FromSpecificInformations.ComboBoxWidth);
            //dptFromDate.Width = Convert.ToInt32(FromSpecificInformations.DateTimePickerWidth);
            //dptToDate.Width = Convert.ToInt32(FromSpecificInformations.DateTimePickerWidth);

            //txtNumberOfUnits.Width = Convert.ToInt32(FromSpecificInformations.TextFeildWidth);
            //txtRemarks.Width = Convert.ToInt32(FromSpecificInformations.TextFeildWidth);

            //RequiredFieldValidator4.ErrorMessage = CommonUserMessage.CommonErrorMessages.RequiredFieldValidator;
            //RequiredFieldValidator5.ErrorMessage = CommonUserMessage.CommonErrorMessages.RequiredFieldValidator;
            //RequiredFieldValidator6.ErrorMessage = CommonUserMessage.CommonErrorMessages.RequiredFieldValidator;

            //RequiredFieldValidator1.ErrorMessage = CommonUserMessage.CommonErrorMessages.RequiredFieldValidator;
            //RequiredFieldValidator2.ErrorMessage = CommonUserMessage.CommonErrorMessages.RequiredFieldValidator;
            //RequiredFieldValidator3.ErrorMessage = CommonUserMessage.CommonErrorMessages.RequiredFieldValidator;
        }
        #endregion

        #region Data Feeder -> Insert
        public void Insert()
        {
            try
            {

                if (r1.IsValid && r2.IsValid && r3.IsValid && r4.IsValid && r5.IsValid && r6.IsValid && r7.IsValid)
                {
                    leaveRequest.CreatedUserId = Convert.ToInt32(Session["UserId"]);
                    leaveRequest.EmployeeId = Convert.ToInt32(Session["EmployeeId"]);
                    leaveRequest.FromDate = dptFromDate.SelectedDate.Value;
                    leaveRequest.IsActive = true;
                    leaveRequest.LeaveRequestId = 1;
                    leaveRequest.LeaveTypeId = Convert.ToInt32(cmbLeaveType.SelectedValue);
                    leaveRequest.LeaveUnitId = Convert.ToInt32(cmbLeaveUnit.SelectedValue);
                    leaveRequest.ModifiedUserId = Convert.ToInt32(Session["UserId"]);
                    leaveRequest.NoOfUnits = Convert.ToDouble(txtNumberOfUnits.Text);
                    leaveRequest.Remark = txtRemarks.Text;
                    leaveRequest.RequestDate = DateTime.Now;
                    leaveRequest.Status = 'P';
                    leaveRequest.ToDate = dptToDate.SelectedDate.Value;
                    leaveRequest.IsSendEmail = chkIsSendMail.Checked;
                    leaveRequest.ActingEmployee = Convert.ToInt32(cmbActingEmployeeDetails.SelectedValue);

                    leaveRequestService.Insert(leaveRequest);
                    this.ShowSuccessfulNotification("Leave request submited successfully...!");
                    DataBaseTransactions.CommitTransactions();
                    FillGrid();

                    ResetInputs(true); 
                }
                else
                {
                    this.ShowWarningNotification("You have missed some mandatory fields.");
                }
            }
            catch (Exception ex)
            {
                DataBaseTransactions.RollbackTransactions();
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx",false);
            }
        }
        #endregion

        #region Grid Filler
        public void FillGrid()
        {
            try
            {
                leaveRequest.EmployeeId = Convert.ToInt32(Session["EmployeeId"]);
                dgLeaveRequest.DataSource = leaveRequestService.Select(leaveRequest);
                dgLeaveRequest.DataBind();

                for (int i = 0; i < dgLeaveRequest.Items.Count; i++)
                {
                    if (dgLeaveRequest.Items[i]["Status"].Text != "A")
                    {
                        dgLeaveRequest.Items[i]["Delete"].Visible = true;
                    }
                    else
                    {
                        dgLeaveRequest.Items[i]["Delete"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx",false);
            }
        }
        #endregion

        #region Reset Inputs
        public void ResetInputs(bool resetInputs)
        {
            try
            {
                if (resetInputs == true)
                {
                    txtNumberOfUnits.Text = "";
                    txtRemarks.Text = "";

                    cmbActingEmployeeDetails.SelectedIndex = 0;
                    cmbLeaveType.SelectedIndex = 0;
                    cmbLeaveUnit.SelectedIndex = 0;

                    dptFromDate.SelectedDate = null;
                    dptToDate.SelectedDate = null;
                }
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx",false);
            }
        }
        #endregion
        protected void dptFromDate_SelectedDateChanged(object sender, Telerik.Web.UI.Calendar.SelectedDateChangedEventArgs e)
        {
            try
            {            

                dptToDate.MinDate = dptFromDate.SelectedDate.Value;
                dptToDate.Enabled = true;
                txtNumberOfUnits.Text = dptToDate.IsEmpty == false ? (((dptToDate.SelectedDate.Value.Subtract(dptFromDate.SelectedDate.Value)).Days) + 1).ToString() : "0";

                if (dptToDate.SelectedDate != null && dptFromDate.SelectedDate != null)
                {

                    DataTable dtCompanyLeaveDaysInThisDaterage = new SERVICE.CompanyWiseLeaveCalanderService().SelectNoOfCompanyLeaveDatesInReqestedDateRange(Convert.ToDateTime(dptFromDate.SelectedDate), Convert.ToDateTime(dptToDate.SelectedDate), Convert.ToInt32(Session["CompanyId"]));
                    txtNumberOfUnits.Text = (Convert.ToDecimal(txtNumberOfUnits.Text) - Convert.ToDecimal(dtCompanyLeaveDaysInThisDaterage.Rows[0]["NoOfCompanyLeave"].ToString())).ToString();

                }


                if (dptToDate.IsEmpty == false)
                {
                    leaveRequest.EmployeeId = Convert.ToInt32(Session["EmployeeId"]);
                    leaveRequest.FromDate = Convert.ToDateTime(dptToDate.SelectedDate.Value);
                    leaveRequest.ToDate = Convert.ToDateTime(dptFromDate.SelectedDate.Value);

                    DataTable leaveRequests = new DataTable();
                    leaveRequests = leaveRequestService.SelectThis(leaveRequest);

                    if (leaveRequests.Rows.Count > 0)
                    {
                        if (leaveRequests.Rows[0][0].ToString() == "1")
                        {
                            this.ShowInfomationNotification("Your Previous Leave Has Rejected... But you can request a new one again...");
                        }
                        else if (leaveRequests.Rows[0][0].ToString() == "0")
                        {
                            this.ShowWarningNotification("You have a Pending Leave In this Date Range. Cancel that leave first. ");
                            txtNumberOfUnits.Text = "";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx", false);
            }

        }
        protected void dptToDate_SelectedDateChanged(object sender, Telerik.Web.UI.Calendar.SelectedDateChangedEventArgs e)
        {
            try
            {
                txtNumberOfUnits.Text = (((dptToDate.SelectedDate.Value.Subtract(dptFromDate.SelectedDate.Value)).Days) + 1).ToString();

                if (dptToDate.SelectedDate != null && dptFromDate.SelectedDate != null)
                {

                    DataTable dtCompanyLeaveDaysInThisDaterage = new SERVICE.CompanyWiseLeaveCalanderService().SelectNoOfCompanyLeaveDatesInReqestedDateRange(Convert.ToDateTime(dptFromDate.SelectedDate), Convert.ToDateTime(dptToDate.SelectedDate), Convert.ToInt32(Session["CompanyId"]));
                    txtNumberOfUnits.Text = (Convert.ToDecimal(txtNumberOfUnits.Text) - Convert.ToDecimal(dtCompanyLeaveDaysInThisDaterage.Rows[0]["NoOfCompanyLeave"].ToString())).ToString();

                }

                leaveRequest.EmployeeId = Convert.ToInt32(Session["EmployeeId"]);
                leaveRequest.FromDate = Convert.ToDateTime(dptToDate.SelectedDate.Value);
                leaveRequest.ToDate = Convert.ToDateTime(dptFromDate.SelectedDate.Value);

                DataTable leaveRequests = new DataTable();
                leaveRequests = leaveRequestService.SelectThis(leaveRequest);

                if (leaveRequests.Rows.Count > 0)
                {
                    if (leaveRequests.Rows[0][0].ToString() == "1")
                    {
                        this.ShowInfomationNotification ("Your Previous Leave Has Rejected... But you can request a new one again...");
                    }
                    else if (leaveRequests.Rows[0][0].ToString() == "0")
                    {
                        this.ShowWarningNotification("You have a Pending Leave In this Date Range. Cancel that leave first. ");
                        txtNumberOfUnits.Text = "";

                    }

                }
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx",false);
            }
        }
        protected void dgLeaveRequest_NeedDataSource(object source, GridNeedDataSourceEventArgs e)
        {
            try
            {
                leaveRequest.EmployeeId = Convert.ToInt32(Session["EmployeeId"]);
                dgLeaveRequest.DataSource = leaveRequestService.Select(leaveRequest);
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx",false);
            }
        }
 
        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Insert();
                ResetInputs(true);
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx",false);
            }
        }
        protected void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                ResetInputs(true);
                FillGrid();
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx",false);
            }
        }

        protected void cmbEmployeeDetails_DataBound(object sender, EventArgs e)
        {
            cmbActingEmployeeDetails.Items.Insert(0, new RadComboBoxItem("------------ N/A ------------", "0"));
        }

        protected void dgLeaveRequest_ItemCommand(object sender, GridCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "Delete")
                {
                    GridDataItem item = (GridDataItem)e.Item;

                    if (item["Status"].Text == "P")
                    {

                        LeaveRequest leaveRequest = new LeaveRequest();
                        leaveRequest.LeaveRequestId = Convert.ToInt32(item["LeaveRequestId"].Text);
                        new LeaveRequestService().Delete(leaveRequest);
                        DataBaseTransactions.CommitTransactions();
                        this.ShowSuccessfulNotification("Leave Request Cancel / Deleted Succsessfully.");
                        
                    }
                    else
                    {
                        this.ShowSuccessfulNotification("Leave Already Approved / Cancelled. Please Contact Administration to Cancel this Leave.");                      
                    }
                }
            }
            catch (Exception ex)
            {
                DataBaseTransactions.RollbackTransactions();
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx",false);
            }
        }

        protected void dgLeaveRequest_DetailTableDataBind(object sender, GridDetailTableDataBindEventArgs e)
        {
            try
            {
                GridDataItem dataItem = (GridDataItem)e.DetailTableView.ParentItem;
                string leaveRequestId = dataItem.GetDataKeyValue("LeaveRequestId").ToString();
                e.DetailTableView.DataSource = new SERVICE.LeaveRequestService().SelectLeaveRequestFlowWiseStatus(Convert.ToInt32(leaveRequestId));
            }
            catch (Exception ex)
            {
                this.ShowErrorNotification(ex.Message);
            }
        }

        protected void cmbLeaveType_DataBound(object sender, EventArgs e)
        {
            cmbLeaveType.Items.Insert(0, new RadComboBoxItem("---Select---", "0"));

        }

        protected void cmbLeaveUnit_DataBound(object sender, EventArgs e)
        {
            cmbLeaveUnit.Items.Insert(0, new RadComboBoxItem("---Select---", "0"));
        }
    }
}