using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DOMAIN;
using SERVICE;
using Telerik.Web.UI;
using jQueryNotification.Helper;

namespace HRM_UserProfile
{
    public partial class talents : System.Web.UI.Page
    {
        EmployeeDetails employeeDetails = new EmployeeDetails();
        EmployeeDetailsService employeeDetailsService = new EmployeeDetailsService();

        TalentCategoryDetails talentCategoryDetails = new TalentCategoryDetails();
        TalentCategoryDetailsService talentCategoryDetailsService = new TalentCategoryDetailsService();

        TalentSubCategoryDetails talentSubCategoryDetails = new TalentSubCategoryDetails();
        TalentSubCategoryDetailsService talentSubCategoryDetailsService = new TalentSubCategoryDetailsService();

        EmployeeWiseTalentDetails employeeWiseTalentDetails = new EmployeeWiseTalentDetails();
        EmployeeWiseTalentDetailsService employeeWiseTalentDetailsService = new EmployeeWiseTalentDetailsService();

           

        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                if (!IsPostBack)
                {
                    FillComboBoxes();
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

        #region Fill ComboBoxes
        public void FillComboBoxes()
        {
            try
            {
                FillCategory();
                FillSubCategory();
            }
            catch (Exception ex)
            {
                  Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx",false);
            }
        }
        public void FillSubCategory()
        {
            try
            {
                talentSubCategoryDetails = new TalentSubCategoryDetails();
                talentSubCategoryDetails.IsActive = true;

                cmbSubCategory.DataSource = null;
                cmbSubCategory.DataBind();

                cmbSubCategory.Items.Clear();

                if (cmbCategory.SelectedIndex > 0)
                {
                    talentSubCategoryDetails.TalentCategoryId = Convert.ToInt32(cmbCategory.SelectedValue);

                    //cmbSubCategory.DataSource = null;
                    //cmbSubCategory.DataBind();

                    cmbSubCategory.DataSource = talentSubCategoryDetailsService.SelectSubCatByNameAndCat(talentSubCategoryDetails);
                    cmbSubCategory.DataTextField = "TalentSubCatName";
                    cmbSubCategory.DataValueField = "TalentSubCategoryId";
                    cmbSubCategory.DataBind();
                }

            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx", false);       
            }
        }

        public void FillCategory()
        {
            try
            {

                talentCategoryDetails = new TalentCategoryDetails();

                talentCategoryDetails.IsActive = true;
                cmbCategory.DataSource = null;
                cmbCategory.DataBind();

                cmbCategory.Items.Clear();      

                cmbCategory.DataSource = talentCategoryDetailsService.SelectAllIsActive(talentCategoryDetails);
                cmbCategory.DataTextField = "TalentCatName";
                cmbCategory.DataValueField = "TalentCategoryId";
                cmbCategory.DataBind();
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx", false);
            }
        }
        #endregion

        public void ResetInputs(bool resetInputs)
        {
            try
            {
                if (resetInputs)
                {
                    txtRemark.Text = "";
                    cmbSubCategory.ClearSelection();
                    cmbCategory.ClearSelection();
                    chkIsActive.Checked = true;
                }
            }
            catch (Exception ex)
            {
                  Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx",false);
            }
        }

        #region Grid Filler
        public void FillGrid()
        {
            try
            {
                dgEmployeeWiseTalent.DataSource = employeeWiseTalentDetailsService.SelectAll(Session["EmployeeId"].ToString());
                dgEmployeeWiseTalent.DataBind();
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx", false);
            }
        }
        #endregion

        #region Data Feeder -> Insertion
        public void Insert()
        {
            try
            {
                if (cmbCategory.SelectedIndex > 0 && cmbSubCategory.SelectedIndex > 0)
                {
                    employeeWiseTalentDetails.EmployeeId = Convert.ToInt32(Session["EmployeeId"]);
                    employeeWiseTalentDetails.EmployeeWiseTalentId = 1;
                    employeeWiseTalentDetails.IsActive = chkIsActive.Checked; //chk
                    employeeWiseTalentDetails.Remarks = txtRemark.Text.Trim();
                    employeeWiseTalentDetails.TalentSubCatId = Convert.ToInt32(cmbSubCategory.SelectedValue);
                    employeeWiseTalentDetails.User = Convert.ToInt32(Session["UserId"]);

                    employeeWiseTalentDetailsService.Insert(employeeWiseTalentDetails);
                    this.ShowSuccessfulNotification("Request sumbited successfully. It will apply to you after approved.");
                    DataBaseTransactions.CommitTransactions();
                    ResetInputs(true);
                    FillGrid();
                }
                else
                {
                   this.ShowWarningNotification("Please complete required feilds.");
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

        #region Data Feeder -> Update
        public void Update()
        {
            try
            {
                if (cmbCategory.SelectedIndex > 0 && cmbSubCategory.SelectedIndex > 0)
                {
                    employeeWiseTalentDetails.EmployeeId = Convert.ToInt32(Session["EmployeeId"].ToString());
                    employeeWiseTalentDetails.EmployeeWiseTalentId = Convert.ToInt32(ViewState["EmployeeWiseTalentId"]);
                    employeeWiseTalentDetails.IsActive = chkIsActive.Checked; //chk
                    employeeWiseTalentDetails.Remarks = txtRemark.Text.Trim();
                    employeeWiseTalentDetails.TalentSubCatId = Convert.ToInt32(cmbSubCategory.SelectedValue);
                    employeeWiseTalentDetails.User = Convert.ToInt32(Session["UserId"]);

                    employeeWiseTalentDetailsService.Update(employeeWiseTalentDetails);
                    this.ShowSuccessfulNotification("Record updated successfully.");
                    DataBaseTransactions.CommitTransactions();
                    ResetInputs(true);
                    FillGrid();
                }
                else
                {
                    this.ShowSuccessfulNotification("Please complete required feilds");
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

        protected void cmbSubCategory_SelectedIndexChanged(object o, RadComboBoxSelectedIndexChangedEventArgs e)
        {

        }

        protected void cmbCategory_SelectedIndexChanged(object o, RadComboBoxSelectedIndexChangedEventArgs e)
        {
            try
            {
                FillSubCategory();
            }
            catch (Exception ex)
            {

                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx", false);
            }
        }

        protected void dgEmployeeWiseTalent_NeedDataSource(object source, GridNeedDataSourceEventArgs e)
        {
            try
            {
                dgEmployeeWiseTalent.DataSource = employeeWiseTalentDetailsService.SelectAll(Session["EmployeeId"].ToString());
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx", false);
            }
        }

        protected void dgEmployeeWiseTalent_PageIndexChanged(object source, GridPageChangedEventArgs e)
        {
            FillGrid();
        }

        protected void dgEmployeeWiseTalent_PageSizeChanged(object source, GridPageSizeChangedEventArgs e)
        {
            FillGrid();
        }

        protected void dgEmployeeWiseTalent_ItemCommand(object source, GridCommandEventArgs e)
        {
            if (e.CommandName == CommonParameterNames.ItemCommand.Select)
            {
                GridDataItem item = (GridDataItem)e.Item;
                txtRemark.Text = item["Remarks"].Text;
                cmbCategory.SelectedValue = item["TalentCategoryId"].Text;               
                ViewState["EmployeeWiseTalentId"] = item["EmployeeWiseTalentId"].Text;
                chkIsActive.Checked = Convert.ToBoolean(item["IsActive"].Text);
                FillSubCategory();
                cmbSubCategory.SelectedValue = item["TalentSubCatId"].Text;

                //master = (Master.MasterFile)this.Master;
                //master.Update();
            }
            else if (e.CommandName == CommonParameterNames.ItemCommand.Delete)
            {
                try
                {
                    GridDataItem item = (GridDataItem)e.Item;
                    employeeWiseTalentDetails.EmployeeWiseTalentId = Convert.ToInt32(item["EmployeeWiseTalentId"].Text);
                    employeeWiseTalentDetailsService.Delete(employeeWiseTalentDetails);
                    DataBaseTransactions.CommitTransactions();
                    this.ShowSuccessfulNotification("Record deleted successfully.");
                }
                catch (Exception ex)
                {
                    DataBaseTransactions.RollbackTransactions();
                    Session["ErrorMessage"] = ex.Message;
                    Session["StackTrace"] = ex.StackTrace;
                    Response.Redirect("error.aspx", false);
                }
            }


        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            ResetInputs(true);
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Insert();
        }

        protected void btnCheckForChanges_Click(object sender, EventArgs e)
        {

        }

        protected void cmbCategory_DataBound(object sender, EventArgs e)
        {
            cmbCategory.Items.Insert(0, new RadComboBoxItem("---Select---", "0"));
        }

        protected void cmbSubCategory_DataBound(object sender, EventArgs e)
        {
            cmbSubCategory.Items.Insert(0, new RadComboBoxItem("---Select---", "0"));
        }
    }
}