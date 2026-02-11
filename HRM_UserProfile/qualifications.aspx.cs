using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SERVICE;
using DOMAIN;
using Telerik.Web.UI;
using jQueryNotification.Helper;

namespace HRM_UserProfile
{
    public partial class qualifications : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    FillComboBox();
                    FillGrid();
                    ResetInputs(true);
                }
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx",false);
            }
        }

      public void FillComboBox()
        {
            try
            {
                cmbEducationLevel.DataSource = null;
                cmbEducationLevel.DataBind();
                cmbEducationLevel.DataSource = new EducationQualificationService().SelectAllActiveEducationLevels();
                cmbEducationLevel.DataTextField = CommonParameterNames.CommonTableColumnNames.EducationLevelDetails.EducationLevelName;
                cmbEducationLevel.DataValueField = CommonParameterNames.CommonTableColumnNames.EducationLevelDetails.EducationLevelID;
                cmbEducationLevel.DataBind();
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx",false);
            }
        }
        public void FillGrid()
        {
            try
            {
                    EmployeeWiseQualificationDetails employeeWiseQualificationDetails = new EmployeeWiseQualificationDetails();
                    employeeWiseQualificationDetails.EmployeeID = Convert.ToInt32(Session["EmployeeId"]);
                    dgEmployeeWiseQualificationDetails.DataSource =  new EmployeeWiseQualificationDetailsService().SelectThisEmployeeId(employeeWiseQualificationDetails);
                    dgEmployeeWiseQualificationDetails.DataBind();
               
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx",false);
            }
        }
        protected void dgEmployeeWiseQualificationDetails_ItemCommand(object sender, Telerik.Web.UI.GridCommandEventArgs e)
        {
            try
            {
                System.Threading.Thread.Sleep(1000);
                if (e.CommandName == "Select")
                {
                    GridDataItem item = (GridDataItem)e.Item;
                    hdnEmployeeWIseQualificationId.Value = item["EmployeeWiseQualificationsID"].Text;
                    txtCourseTitle.Text = item["CourseTitle"].Text;
                    cmbEducationLevel.SelectedValue = item["educationLevelID"].Text;
                    txtInstitute.Text = item["Institute"].Text;
                    cntrl_YearPicker1.GridYear(Convert.ToInt32(item["YearOfCompletion"].Text));
                    txtRemarks.Text = item["Remarks"].Text;
                    chkActive.Checked = Convert.ToBoolean(item["IsActive"].Text);
                    ResetInputs(false);
                }
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx",false);
            }
        }
        private void ResetInputs(bool p)
        {
            try
            {
                if (p)
                {
                    txtCourseTitle.Text = "";
                    txtInstitute.Text = "";
                    txtRemarks.Text = "";
                    chkActive.Checked = true;

                    cmbEducationLevel.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx",false);
            }
        }
        protected void dgEmployeeWiseQualificationDetails_NeedDataSource(object sender, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
        {
            try
            {
                EmployeeWiseQualificationDetails employeeWiseQualificationDetails = new EmployeeWiseQualificationDetails();
                employeeWiseQualificationDetails.EmployeeID = Convert.ToInt32(Session["EmployeeId"]);
                dgEmployeeWiseQualificationDetails.DataSource = new EmployeeWiseQualificationDetailsService().SelectThisEmployeeId(employeeWiseQualificationDetails);
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx",false);
            }
        }
        protected void dgEmployeeWiseQualificationDetails_PageIndexChanged(object sender, Telerik.Web.UI.GridPageChangedEventArgs e)
        {
            try
            {
                FillGrid();
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx",false);
            }
        }
        protected void dgEmployeeWiseQualificationDetails_PageSizeChanged(object sender, Telerik.Web.UI.GridPageSizeChangedEventArgs e)
        {
            try
            {
                FillGrid();
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx",false);
            }
        }
        protected void dgEmployeeWiseQualificationDetails_SortCommand(object sender, Telerik.Web.UI.GridSortCommandEventArgs e)
        {
            try
            {
                FillGrid();
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
                if (r1.IsValid && r2.IsValid && r3.IsValid && r4.IsValid)
                {
                    System.Threading.Thread.Sleep(1000);
                    EmployeeWiseQualificationDetails employeeWiseQualificationDetails = new EmployeeWiseQualificationDetails();
                    employeeWiseQualificationDetails.EmployeeID = Convert.ToInt32(Session["EmployeeId"]);
                    employeeWiseQualificationDetails.EmployeeWiseQualificationId = Convert.ToInt32(hdnEmployeeWIseQualificationId.Value);

                    if (new EmployeeWiseQualificationDetailsService().SelectEmployeeWiseQualificationsDetailNotApproved(employeeWiseQualificationDetails).Rows.Count == 0)
                    {

                        employeeWiseQualificationDetails.CourseTitle = txtCourseTitle.Text.Trim();
                        employeeWiseQualificationDetails.CreatedUserId = Convert.ToInt32(Session["UserId"]);
                        employeeWiseQualificationDetails.EducationLevelId = Convert.ToInt32(cmbEducationLevel.SelectedValue);
                        employeeWiseQualificationDetails.EmployeeWiseQualificationId = Convert.ToInt32(hdnEmployeeWIseQualificationId.Value);
                        employeeWiseQualificationDetails.Institute = txtInstitute.Text.Trim();
                        employeeWiseQualificationDetails.IsActive = chkActive.Checked;
                        employeeWiseQualificationDetails.ModifiedUserId = Convert.ToInt32(Session["UserId"]);
                        employeeWiseQualificationDetails.Remarks = txtRemarks.Text.Trim();
                        employeeWiseQualificationDetails.YearOfCompletion = cntrl_YearPicker1.SelectedYear();

                        new EmployeeWiseQualificationDetailsService().Insert(employeeWiseQualificationDetails);
                        DataBaseTransactions.CommitTransactions();

                        ResetInputs(true);
                        FillGrid();
                        this.ShowSuccessfulNotification("Request submitted successfully...!");
                    }
                    else
                    {
                        this.ShowWarningNotification("Request submission fail. There is a pending change request on this qualification.");
                    } 
                }
                else
                {
                    this.ShowWarningNotification("You have missed some requierd fields.");
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

        protected void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                System.Threading.Thread.Sleep(1000);
                FillGrid();
                ResetInputs(true);
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx",false);
            }
        }

        protected void btnCheckForChanges_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx",false);
            }
        }

        protected void cmbEducationLevel_DataBound(object sender, EventArgs e)
        {
            cmbEducationLevel.Items.Insert(0, new RadComboBoxItem("---Select---", "0"));
        }
    }
}