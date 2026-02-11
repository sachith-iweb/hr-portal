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
    public partial class outstation_allowance : System.Web.UI.Page
    {
        OutstationAllowance outstationAllowanceObj = new OutstationAllowance();
        OutstationAllowanceService outstationAllowanceService = new OutstationAllowanceService();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    ResetInputs(true);
                    dptToDate.Enabled = false;
                    FillGrid();
                }

            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx", false);
            }
        }

        #region Data Feeder -> Insert
        public void Insert()
        {
            try
            {

                if (r1.IsValid && r2.IsValid && r3.IsValid && r4.IsValid)
                {
                    outstationAllowanceObj.CreatedUserId = Convert.ToInt32(Session["UserId"]);
                    outstationAllowanceObj.EmployeeId = Convert.ToInt32(Session["EmployeeId"]);
                    outstationAllowanceObj.Customer = txtCustomer.Text;
                    outstationAllowanceObj.Reason = txtReason.Text;
                    outstationAllowanceObj.FromDate = dptFromDate.SelectedDate.Value;
                    outstationAllowanceObj.ToDate = dptToDate.SelectedDate.Value;
                    outstationAllowanceObj.OverstayNights = txtOverstayNights.Value.HasValue ? Convert.ToInt32(txtOverstayNights.Value) : 0;
                    outstationAllowanceObj.HolidayNights = txtHolidayNights.Value.HasValue ? Convert.ToInt32(txtHolidayNights.Value) : 0;
                    outstationAllowanceObj.Other = txtOther.Value.HasValue ? Convert.ToInt32(txtOther.Value) : 0;
                    outstationAllowanceObj.IsActive = true;
                    outstationAllowanceObj.OutstationAllowanceId = 1;
                    outstationAllowanceObj.ModifiedUserId = Convert.ToInt32(Session["UserId"]);
                    outstationAllowanceObj.RequestDate = DateTime.Now;
                    outstationAllowanceObj.Status = 'P';

                    outstationAllowanceService.Insert(outstationAllowanceObj);
                    this.ShowSuccessfulNotification("Outstation allowance request submitted successfully...!");
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
                Response.Redirect("error.aspx", false);
            }
        }
        #endregion

        #region Grid Filler
        public void FillGrid()
        {
            try
            {
                outstationAllowanceObj.EmployeeId = Convert.ToInt32(Session["EmployeeId"]);
                dgOutstationAllowance.DataSource = outstationAllowanceService.Select(outstationAllowanceObj);
                dgOutstationAllowance.DataBind();

                for (int i = 0; i < dgOutstationAllowance.Items.Count; i++)
                {
                    if (dgOutstationAllowance.Items[i]["Status"].Text != "A")
                    {
                        dgOutstationAllowance.Items[i]["Delete"].Visible = true;
                    }
                    else
                    {
                        dgOutstationAllowance.Items[i]["Delete"].Visible = false;
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
        #endregion

        #region Reset Inputs
        public void ResetInputs(bool resetInputs)
        {
            try
            {
                if (resetInputs == true)
                {
                    txtCustomer.Text = "";
                    txtReason.Text = "";
                    txtOverstayNights.Value = 0;
                    txtHolidayNights.Value = 0;
                    txtOther.Value = 0;

                    dptFromDate.SelectedDate = null;
                    dptToDate.SelectedDate = null;
                }
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx", false);
            }
        }
        #endregion

        protected void dptFromDate_SelectedDateChanged(object sender, Telerik.Web.UI.Calendar.SelectedDateChangedEventArgs e)
        {
            try
            {
                dptToDate.MinDate = dptFromDate.SelectedDate.Value;
                dptToDate.Enabled = true;
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
                // No specific calculation needed for outstation allowance on date change
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx", false);
            }
        }

        protected void dgOutstationAllowance_NeedDataSource(object source, GridNeedDataSourceEventArgs e)
        {
            try
            {
                outstationAllowanceObj.EmployeeId = Convert.ToInt32(Session["EmployeeId"]);
                dgOutstationAllowance.DataSource = outstationAllowanceService.Select(outstationAllowanceObj);
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx", false);
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
                Response.Redirect("error.aspx", false);
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
                Response.Redirect("error.aspx", false);
            }
        }

        protected void dgOutstationAllowance_ItemCommand(object sender, GridCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "Delete")
                {
                    GridDataItem item = (GridDataItem)e.Item;

                    if (item["Status"].Text == "P")
                    {

                        OutstationAllowance outstationAllowance = new OutstationAllowance();
                        outstationAllowance.OutstationAllowanceId = Convert.ToInt32(item["OutstationAllowanceId"].Text);
                        new OutstationAllowanceService().Delete(outstationAllowance);
                        DataBaseTransactions.CommitTransactions();
                        this.ShowSuccessfulNotification("Outstation Allowance Request Cancelled / Deleted Successfully.");

                    }
                    else
                    {
                        this.ShowSuccessfulNotification("Request Already Approved / Cancelled. Please Contact Administration to Cancel this Request.");
                    }
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

        protected void dgOutstationAllowance_DetailTableDataBind(object sender, GridDetailTableDataBindEventArgs e)
        {
            try
            {
                GridDataItem dataItem = (GridDataItem)e.DetailTableView.ParentItem;
                string outstationAllowanceId = dataItem.GetDataKeyValue("OutstationAllowanceId").ToString();
                e.DetailTableView.DataSource = new SERVICE.OutstationAllowanceService().SelectOutstationAllowanceFlowWiseStatus(Convert.ToInt32(outstationAllowanceId));
            }
            catch (Exception ex)
            {
                this.ShowErrorNotification(ex.Message);
            }
        }
    }
}
