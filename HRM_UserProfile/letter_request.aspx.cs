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
    public partial class letter_request : System.Web.UI.Page
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
                if (!IsPostBack)
                {
                    FillLetterTypes();
                    FillGrid();
                    ResetInputs(true);
                }

            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx", false);
            }
        }


        private void FillGrid()
        {
            dgLetterRequest.DataSource = new EmployeeWiseLetterRequestService().SelectEmployeeWiseLetterReqest(Convert.ToInt32(Session["EmployeeId"]));
            dgLetterRequest.DataBind();
        }

        
        #region Letter Type Details Combo Box Filler
        public void FillLetterTypes()
        {
            try
            {
                cmbLetterType.DataSource = null;
                cmbLetterType.DataBind();

                cmbLetterType.Items.Clear();

                cmbLetterType.DataSource = new SERVICE.EmployeeWiseLetterRequestService().SelectEmployeeLetterRequestLetterTypes();
                cmbLetterType.DataTextField = "LetterTypeName";
                cmbLetterType.DataValueField = "LetterTypeId";
                cmbLetterType.DataBind();
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
                    cmbLetterType.SelectedIndex = 0;
                    txtRemarks.Text = "";
                    //lblMessage.Text = "";
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

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (RequiredFieldValidator2.IsValid && RequiredFieldValidator4.IsValid)
                {
                    int letterRequestId; int letterTypeId; int employeeId; int requestedUserId;

                    letterRequestId = 0;
                    letterTypeId = Convert.ToInt16(cmbLetterType.SelectedValue);
                    employeeId = Convert.ToInt16(Session["EmployeeId"]);
                    requestedUserId = Convert.ToInt16(Session["UserId"]);
                    new SERVICE.EmployeeWiseLetterRequestService().InsertEmployeeLetterRequest(letterRequestId, letterTypeId, employeeId, requestedUserId, txtRemarks.Text.Trim());
                    DataBaseTransactions.CommitTransactions();
                    this.ShowSuccessfulNotification("Letter request inserted successfully. HR department will inform you once letter is ready.");
                    FillGrid();
                } 
                else
                {
                    this.ShowWarningNotification("Please fill the mandatory fields.");
                }
            }
            catch (Exception ex)
            {
                 DataBaseTransactions.RollbackTransactions();
                 Session["ErrorMessage"] = ex.Message;
                 Session["StackTrace"] = ex.StackTrace;
                 Response.Redirect("error.aspx", false);
            }
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {

        }

        protected void cmbLetterType_DataBound(object sender, EventArgs e)
        {
            cmbLetterType.Items.Insert(0, new RadComboBoxItem("---Select---", "0"));
        }

      
     
    }
}