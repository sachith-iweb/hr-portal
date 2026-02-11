using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;
using DOMAIN;
using SERVICE;
using jQueryNotification.Helper;

namespace HRM_UserProfile
{
    public partial class achivements : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
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
               
        public void FillGrid()
        {
            try
            {
                EmployeeWiseAchievementDetails employeeWiseAchievementDetails = new EmployeeWiseAchievementDetails();
                employeeWiseAchievementDetails.EmployeeID = Convert.ToInt32(Session["EmployeeId"]);
                dgEmployeeWiseAchievement.DataSource = new EmployeeWiseAchievementDetailsService().SelectThisByEmpId(employeeWiseAchievementDetails);
                dgEmployeeWiseAchievement.DataBind();

            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx",false);
            }
        }

        protected void dgEmployeeWiseAchievement_ItemCommand(object sender, Telerik.Web.UI.GridCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "Select")
                {
                    GridDataItem item = (GridDataItem)e.Item;
                    hdnEmployeeWiseAchivementId.Value = item["EmployeeWiseAchievementID"].Text;
                    txtAchievement.Text = item["Achievement"].Text;
                    cntrl_YearPicker1.GridYear(Convert.ToInt32(item["YearDate"].Text));
                    txtRemarks.Text = item["Remarks"].Text;
                    chkActive.Checked = Convert.ToBoolean(item["IsActive"].Text);
                }
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx",false);
            }
        }

        protected void dgEmployeeWiseAchievement_NeedDataSource(object sender, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
        {
            try
            {
                EmployeeWiseAchievementDetails employeeWiseAchievementDetails = new EmployeeWiseAchievementDetails();
                employeeWiseAchievementDetails.EmployeeID = Convert.ToInt32(Session["EmployeeId"]);
                dgEmployeeWiseAchievement.DataSource = new EmployeeWiseAchievementDetailsService().SelectThisByEmpId(employeeWiseAchievementDetails);

            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx",false);
            } 
        }

        protected void dgEmployeeWiseAchievement_PageSizeChanged(object sender, Telerik.Web.UI.GridPageSizeChangedEventArgs e)
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

        protected void dgEmployeeWiseAchievement_PageIndexChanged(object sender, Telerik.Web.UI.GridPageChangedEventArgs e)
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

        protected void dgEmployeeWiseAchievement_SelectedIndexChanged(object sender, EventArgs e)
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

        protected void dgEmployeeWiseAchievement_SortCommand(object sender, Telerik.Web.UI.GridSortCommandEventArgs e)
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

        protected void btnCheckForChanges_Click(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (r1.IsValid && r2.IsValid)
                {
                    EmployeeWiseAchievementDetails employeeWiseAchievementDetails = new EmployeeWiseAchievementDetails();
                    employeeWiseAchievementDetails.EmployeeWiseAchievementId = Convert.ToInt32(hdnEmployeeWiseAchivementId.Value);
                    employeeWiseAchievementDetails.EmployeeID = Convert.ToInt32(Session["EmployeeId"]);

                    if (new EmployeeWiseAchievementDetailsService().SelectEmployeeWiseAchievementDetailsNotApproved(employeeWiseAchievementDetails).Rows.Count == 0)
                    {
                        employeeWiseAchievementDetails.Achievement = txtAchievement.Text.Trim();
                        employeeWiseAchievementDetails.CreatedUserId = Convert.ToInt32(Session["UserId"]);
                        employeeWiseAchievementDetails.EmployeeID = Convert.ToInt32(Session["EmployeeId"]);
                        employeeWiseAchievementDetails.EmployeeWiseAchievementId = Convert.ToInt32(hdnEmployeeWiseAchivementId.Value);
                        employeeWiseAchievementDetails.IsActive = chkActive.Checked;
                        employeeWiseAchievementDetails.ModifiedUserId = Convert.ToInt32(Session["UserId"]);
                        employeeWiseAchievementDetails.Remarks = txtRemarks.Text.Trim();
                        employeeWiseAchievementDetails.YearDate = cntrl_YearPicker1.SelectedYear();

                        new EmployeeWiseAchievementDetailsService().Insert(employeeWiseAchievementDetails);
                        DataBaseTransactions.CommitTransactions();
                        ResetInputs(true);
                        FillGrid();

                        this.ShowSuccessfulNotification("Achivement submitted successfully, It will apply to after approval.");
                    }
                    else
                    {
                        this.ShowWarningNotification("Request submission fail. There is a pending change request on this achivement.");
                    } 
                }
                else
                {
                    this.ShowWarningNotification("You have missed some required fields");
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

        private void ResetInputs(bool p)
        {
            try
            {
                if (p)
                {
                    txtAchievement.Text = "";
                    txtRemarks.Text = "";
                    chkActive.Checked = true;
                    hdnEmployeeWiseAchivementId.Value = "0";
                }
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

       
    }
}