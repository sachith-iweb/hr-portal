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
    public partial class interests : System.Web.UI.Page
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

        private void FillGrid()
        {
            try
            {
                    EmployeeWiseInterestDetails employeeWiseInterestDetails= new EmployeeWiseInterestDetails();
                    employeeWiseInterestDetails.EmployeeId = Convert.ToInt32(Session["EmployeeId"].ToString());
                    dgEmployeeWiseInterestDetails.DataSource = null;
                    dgEmployeeWiseInterestDetails.DataSource = new EmployeeWiseInterestDetailsService().SelectThisByEmpId(employeeWiseInterestDetails);
                    dgEmployeeWiseInterestDetails.DataBind();
                
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx",false);
            }
        }

        protected void dgEmployeeWiseInterestDetails_NeedDataSource(object sender, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
        {
            try
            {
                EmployeeWiseInterestDetails employeeWiseInterestDetails = new EmployeeWiseInterestDetails();
                employeeWiseInterestDetails.EmployeeId = Convert.ToInt32(Session["EmployeeId"].ToString());
                dgEmployeeWiseInterestDetails.DataSource = null;
                dgEmployeeWiseInterestDetails.DataSource = new EmployeeWiseInterestDetailsService().SelectThisByEmpId(employeeWiseInterestDetails);
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx",false);
            }
        }

        protected void dgEmployeeWiseInterestDetails_PageIndexChanged(object sender, Telerik.Web.UI.GridPageChangedEventArgs e)
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

        protected void dgEmployeeWiseInterestDetails_PageSizeChanged(object sender, Telerik.Web.UI.GridPageSizeChangedEventArgs e)
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

        protected void dgEmployeeWiseInterestDetails_SortCommand(object sender, Telerik.Web.UI.GridSortCommandEventArgs e)
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

        protected void dgEmployeeWiseInterestDetails_ItemCommand(object sender, Telerik.Web.UI.GridCommandEventArgs e)
        {
            try
            {                
                if (e.CommandName == "Select")
                {
                    GridDataItem item = (GridDataItem)e.Item;
                    txtInterest.Text = item[CommonParameterNames.CommonTableColumnNames.EmployeeWiseInterestDetails.Interest].Text;
                    txtRemarks.Text = item[CommonParameterNames.CommonTableColumnNames.EmployeeWiseInterestDetails.Remarks].Text;

                    chkActive.Checked = Convert.ToBoolean(item[CommonParameterNames.CommonTableColumnNames.EmployeeWiseInterestDetails.IsActive].Text);
                    hdnEmployeeWiseInterestId.Value = item[CommonParameterNames.CommonTableColumnNames.EmployeeWiseInterestDetails.EmployeeWiseInterestId].Text;

                }
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx",false);
            }

            System.Threading.Thread.Sleep(1000);
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
                    System.Threading.Thread.Sleep(1000);
                    EmployeeWiseInterestDetails employeeWiseInterestDetails = new EmployeeWiseInterestDetails();
                    employeeWiseInterestDetails.EmployeeId = Convert.ToInt32(Session["EmployeeId"]);
                    employeeWiseInterestDetails.EmployeeWiseInterestId = Convert.ToInt32(hdnEmployeeWiseInterestId.Value);

                    if (new EmployeeWiseInterestDetailsService().SelectEmployeeWiseInterestDetailsNotApproved(employeeWiseInterestDetails).Rows.Count == 0)
                    {

                        employeeWiseInterestDetails.EmployeeId = Convert.ToInt32(Session["EmployeeId"]);
                        employeeWiseInterestDetails.EmployeeWiseInterestId = Convert.ToInt32(hdnEmployeeWiseInterestId.Value);
                        employeeWiseInterestDetails.Interest = txtInterest.Text;
                        employeeWiseInterestDetails.IsActive = chkActive.Checked;
                        employeeWiseInterestDetails.Remarks = txtRemarks.Text;
                        employeeWiseInterestDetails.UserId = Convert.ToInt32(Session["UserId"]);

                        new EmployeeWiseInterestDetailsService().Insert(employeeWiseInterestDetails);
                        DataBaseTransactions.CommitTransactions();
                        this.ShowSuccessfulNotification("Request submited successfully ...!");
                        FillGrid();
                        ResetInputs(true);
                    }
                    else
                    {
                        this.ShowErrorNotification("Request submition fail. There is a pending change request on this interest ...!");
                    } 
                }
                else
                {
                    this.ShowWarningNotification("You have missed some required fields.");
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
                System.Threading.Thread.Sleep(1000);
                txtInterest.Text = "";
                txtRemarks.Text = "";
                chkActive.Checked = true;
                hdnEmployeeWiseInterestId.Value = "0";
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
                System.Threading.Thread.Sleep(1000);
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