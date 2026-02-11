using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DOMAIN;
using SERVICE;
using System.Data;
using Telerik.Web.UI;
using jQueryNotification.Helper;

namespace HRM_UserProfile
{
    public partial class grievance : System.Web.UI.Page
    {
        DesignationDetails designationDetails = new DesignationDetails();
        DesignationDetailsService designationDetailsService = new DesignationDetailsService();

        EmployeeDetails employeeDetails = new EmployeeDetails();
        EmployeeDetailsService employeeDetailsService = new EmployeeDetailsService();

        DepartmentDetails departmentDetails = new DepartmentDetails();
        DepartmentDetailsService departmentDetailsService = new DepartmentDetailsService();

            public void ResetInputs(bool p)
        {
            if (p)
            {
                //lblRelatedIssues.Visible = false;
                //lblRelatedIssuesColon.Visible = false;
                //chkLstIssues.Visible = false;

                DataTable dtCheckListDefault = new DataTable();
                dtCheckListDefault.Columns.Add("Id");
                dtCheckListDefault.Columns.Add("Name");
                dtCheckListDefault.Rows.Add("0", "Select Grievance Category First.");


                chkLstIssues.Items.Clear();
                chkLstIssues.DataSource = dtCheckListDefault;
                chkLstIssues.DataTextField = "Name";
                chkLstIssues.DataValueField = "Id";
                chkLstIssues.DataBind();

                cmbGrievanceCategory.SelectedIndex = 0;
                cmbEmployee.SelectedIndex = 0;
                cmbDesignation.SelectedIndex = 0;
                cmbDepartment.SelectedIndex = 0;

                dgPeopleInvolved.DataSource = new DataTable();
                dgPeopleInvolved.DataBind();

                dgRelatedIncidents.DataSource = new DataTable();
                dgRelatedIncidents.DataBind();

                dtpIncidentDateTime.SelectedDate = null;
                txtIncicentDescrioption.Text = "";
                txtSummary.Text = "";
                txtDescription.Text = "";
            }
        }

        private void FillGrievanceResolvingMethods()
        {
            try
            {
                DataTable dtGrievanceResolvingMethods = new GrievanceResolvingMethodsService().Select();
                cmbPreferredResolvingMethod.DataSource = null;
                cmbPreferredResolvingMethod.DataSource = dtGrievanceResolvingMethods;
                cmbPreferredResolvingMethod.DataTextField = "Name";
                cmbPreferredResolvingMethod.DataValueField = "Id";
                cmbPreferredResolvingMethod.DataBind();

                if (dtGrievanceResolvingMethods.Rows.Count > 0)
                {
                    cmbPreferredResolvingMethod.SelectedValue = dtGrievanceResolvingMethods.Rows[0]["IsDefaultValue"].ToString();
                }

            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx", false);
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            { 
                Session.Timeout = 60;
           
                FillGrievanceCategory();
                FillGrievanceIssues();
                FillComboBox();

                ResetInputs(true);

                CreateTable();
                dgPeopleInvolved.DataSource = ((DataTable)Session["PeopleInvolved"]);
                dgPeopleInvolved.DataBind();

                CreateTableRelatedIncedents();
                dgRelatedIncidents.DataSource = ((DataTable)Session["RelatedIncident"]);
                dgRelatedIncidents.DataBind();

                FillGrievanceResolvingMethods();

                if (Request.QueryString.Count > 0)
                {
                    if (Request.QueryString["m"].ToString()=="1")
                    {
                        this.ShowSuccessfulNotification("Grievance submited successfully.");
                    }
                }
            }
        }

        private void CreateTable()
        {
            DataTable dtPeopleInvolved = new DataTable();
            dtPeopleInvolved.Columns.Add("DepartmentId");
            dtPeopleInvolved.Columns.Add("DesignationId");
            dtPeopleInvolved.Columns.Add("EmployeeId");
            dtPeopleInvolved.Columns.Add("Department");
            dtPeopleInvolved.Columns.Add("Designation");
            dtPeopleInvolved.Columns.Add("Employee");
            Session["PeopleInvolved"] = dtPeopleInvolved;
        }

        private void CreateTableRelatedIncedents()
        {
            DataTable dtPeopleInvolved = new DataTable();
            dtPeopleInvolved.Columns.Add("DateTime");
            dtPeopleInvolved.Columns.Add("Incident");
            Session["RelatedIncident"] = dtPeopleInvolved;
        }

        private void FillGrievanceCategory()
        {
            try
            {
                GrievanceCategories grievanceCategories = new DOMAIN.GrievanceCategories();
                grievanceCategories.IsActive = 1;
                cmbGrievanceCategory.DataSource = null;
                cmbGrievanceCategory.DataSource = new GrievanceCategoriesService().Select(grievanceCategories);
                cmbGrievanceCategory.DataTextField = "Name";
                cmbGrievanceCategory.DataValueField = "Id";
                cmbGrievanceCategory.DataBind();
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx", false);
            }
        }

        private void FillGrievanceIssues()
        {
            try
            {
                if (cmbGrievanceCategory.SelectedIndex != 0)
                {
                    GrievanceCategoryWiseIssues grievanceCategoryWiseIssues = new DOMAIN.GrievanceCategoryWiseIssues();
                    grievanceCategoryWiseIssues.IsActive = 2;
                    grievanceCategoryWiseIssues.GrievanceCategoryId = Convert.ToInt32(cmbGrievanceCategory.SelectedValue.Trim());

                    chkLstIssues.DataSource = null;
                    chkLstIssues.DataSource = new GrievanceCategoryWiseIssuesService().Select(grievanceCategoryWiseIssues);
                    chkLstIssues.DataTextField = "Name";
                    chkLstIssues.DataValueField = "Id";
                    chkLstIssues.DataBind();

                    chkLstIssues.SelectedValue = "0";
                }
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx", false);
            }
        }

        #region Combobox Filler
        public void FillComboBox()
        {
            try
            {
                FillDepartmentComboBox();

                cmbDesignation.DataSource = new DataTable();
                cmbDesignation.DataBind();

                cmbEmployee.DataSource = new DataTable();
                cmbEmployee.DataBind();
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx", false);
            }
        }
        #endregion

        #region Combo Box Filler-> Designation
        public void FillDesignationComboBox()
        {
            if (cmbDepartment.SelectedIndex != 0)
            {
                cmbDesignation.Items.Clear();
                cmbDesignation.DataSource = null;

                designationDetails.CompanyId = Convert.ToInt32(Session["CompanyId"]);
                designationDetails.DepartmentId = Convert.ToInt32(cmbDepartment.SelectedValue);

                cmbDesignation.DataSource = designationDetailsService.SelectDesigntionsByUsingDepartment(designationDetails);
                cmbDesignation.DataValueField = CommonParameterNames.CommonTableColumnNames.DesignationDetails.DesignationId;
                cmbDesignation.DataTextField = CommonParameterNames.CommonTableColumnNames.DesignationDetails.DesignationName;
                cmbDesignation.DataBind();
            }
        }
        #endregion

        #region Combo Box Filler -> Employee

        public void FillEmployeeComboBox()
        {
            if (cmbDesignation.SelectedIndex != 0)
            {
                cmbEmployee.Items.Clear();            
                employeeDetails.CompanyID = Convert.ToInt32(Session["CompanyId"]);
                employeeDetails.DepartmentID = Convert.ToInt32(cmbDepartment.SelectedValue);
                employeeDetails.DesignationID = Convert.ToInt32(cmbDesignation.SelectedValue);

                cmbEmployee.DataSource = null;
                cmbEmployee.DataSource = employeeDetailsService.SelectAllActiveEmployeeDetails(employeeDetails, 2);
                cmbEmployee.DataTextField = CommonParameterNames.CommonTableColumnNames.EmployeeDetails.EmployeeName;
                cmbEmployee.DataValueField = CommonParameterNames.CommonTableColumnNames.EmployeeDetails.EmployeeId;
                cmbEmployee.DataBind();
            }
        }
        #endregion

        #region Combo Box Filler -> Department
        public void FillDepartmentComboBox()
        {
            cmbDepartment.DataSource = null;      
            departmentDetails.CompanyId = Convert.ToInt32(Session["CompanyId"]);
            cmbDepartment.DataSource = departmentDetailsService.SelectAllActiveDepartment(departmentDetails);
            cmbDepartment.DataTextField = CommonParameterNames.CommonTableColumnNames.DepartmentDetails.DepartmentName;
            cmbDepartment.DataValueField = CommonParameterNames.CommonTableColumnNames.DepartmentDetails.DepartmentId;
            cmbDepartment.DataBind();
            lblAddEmployeeMessage.Text = "";
        }
        #endregion

        protected void cmbDesignation_SelectedIndexChanged(object o, RadComboBoxSelectedIndexChangedEventArgs e)
        {
            FillEmployeeComboBox();
            lblAddEmployeeMessage.Text = "";
        }

        protected void cmbDepartment_SelectedIndexChanged(object o, RadComboBoxSelectedIndexChangedEventArgs e)
        {
            FillDesignationComboBox();
            FillEmployeeComboBox();
            lblAddEmployeeMessage.Text = "";
        }

        protected void cmbGrievanceCategory_DataBound(object sender, EventArgs e)
        {
            cmbGrievanceCategory.Items.Insert(0, new RadComboBoxItem("---Select---", "0"));
        }

        protected void cmbGrievanceCategory_SelectedIndexChanged(object o, RadComboBoxSelectedIndexChangedEventArgs e)
        {
            FillGrievanceIssues();

            if (cmbGrievanceCategory.SelectedIndex != 0)
            {
                lblRelatedIssues.Visible = true;
                lblRelatedIssuesColon.Visible = true;
                chkLstIssues.Visible = true;
            }
            else
            {
                lblRelatedIssues.Visible = false;
                lblRelatedIssuesColon.Visible = false;
                chkLstIssues.Visible = false;
                chkLstIssues.Items.Clear();
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (ri3.IsValid)
            {
                bool isOK = true;

                lblAddEmployeeMessage.Text = "";

                for (int i = 0; i < dgPeopleInvolved.Items.Count; i++)
                {
                    if (dgPeopleInvolved.Items[i]["EmployeeId"].Text == cmbEmployee.SelectedValue)
                    {
                        isOK = false;
                        break;
                    }
                }

                if (isOK)
                {
                    if (Session["PeopleInvolved"] == null)
                    {
                        CreateTable();
                    }

                    if (Session["PeopleInvolved"] != null)
                    {
                        ((DataTable)Session["PeopleInvolved"]).Rows.Add(
                            cmbDepartment.SelectedValue,
                            cmbDesignation.SelectedValue,
                            cmbEmployee.SelectedValue,
                            cmbDepartment.Text,
                            cmbDesignation.Text,
                            cmbEmployee.Text
                            );
                    }

                    dgPeopleInvolved.DataSource = ((DataTable)Session["PeopleInvolved"]);
                    dgPeopleInvolved.DataBind();
                }
                else
                {
                    this.ShowWarningNotification("This employee already added to involed list.");
                }
                
            }
            else
            {
                this.ShowWarningNotification("Select an employee to add.");
            }
        }

        protected void dgPeopleInvolved_NeedDataSource(object source, GridNeedDataSourceEventArgs e)
        {
            dgPeopleInvolved.DataSource = ((DataTable)Session["PeopleInvolved"]);
        }

        protected void dgPeopleInvolved_ItemCommand(object source, GridCommandEventArgs e)
        {
            lblAddEmployeeMessage.Text = "";
            if (e.CommandName == "Delete")
            {
                GridDataItem item = (GridDataItem)e.Item;
                int rowIndex = item.ItemIndex;

                ((DataTable)Session["PeopleInvolved"]).Rows.RemoveAt(rowIndex);
                dgPeopleInvolved.DataSource = ((DataTable)Session["PeopleInvolved"]);
                dgPeopleInvolved.DataBind();

            }
        }

        protected void cmbDepartment_DataBound(object sender, EventArgs e)
        {
            cmbDepartment.Items.Insert(0, new RadComboBoxItem("---Select---", "0"));
        }

        protected void cmbDesignation_DataBound(object sender, EventArgs e)
        {
            cmbDesignation.Items.Insert(0, new RadComboBoxItem("---Select---", "0"));
        }

        protected void cmbEmployee_DataBound(object sender, EventArgs e)
        {
            cmbEmployee.Items.Insert(0, new RadComboBoxItem("---Select---", "0"));
        }

       

        protected void cmbPreferredResolvingMethod_DataBound(object sender, EventArgs e)
        {
            cmbPreferredResolvingMethod.Items.Insert(0, new RadComboBoxItem("---Select---", "0"));
        }

        protected void btnAddIncident_Click(object sender, EventArgs e)
        {
            if (rri.IsValid && rri1.IsValid)
            {
                if (Session["RelatedIncident"] == null)
                {
                    CreateTableRelatedIncedents();
                }

                if (Session["RelatedIncident"] != null)
                {
                    ((DataTable)Session["RelatedIncident"]).Rows.Add(
                       dtpIncidentDateTime.SelectedDate,
                       txtIncicentDescrioption.Text.Trim()
                        );

                    dtpIncidentDateTime.SelectedDate = null;
                    txtIncicentDescrioption.Text = "";
                }

                dgRelatedIncidents.DataSource = ((DataTable)Session["RelatedIncident"]);
                dgRelatedIncidents.DataBind(); 
            }
            else
            {
                this.ShowWarningNotification("You have missed some required fields.");
            }
        }

        protected void dgRelatedIncidents_ItemCommand(object source, GridCommandEventArgs e)
        {
           
            if (e.CommandName == "Delete")
            {
                GridDataItem item = (GridDataItem)e.Item;
                int rowIndex = item.ItemIndex;

                ((DataTable)Session["RelatedIncident"]).Rows.RemoveAt(rowIndex);
                dgPeopleInvolved.DataSource = ((DataTable)Session["RelatedIncident"]);
                dgPeopleInvolved.DataBind();

            }
        }

        protected void dgRelatedIncidents_NeedDataSource(object source, GridNeedDataSourceEventArgs e)
        {
            dgRelatedIncidents.DataSource = ((DataTable)Session["RelatedIncident"]);
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (r1.IsValid && r2.IsValid && r3.IsValid && r4.IsValid)
                {
                    bool isOneIssueSelected = false;

                    for (int i = 0; i < chkLstIssues.Items.Count; i++)
                    {
                        if (chkLstIssues.Items[i].Selected)
                        {
                            isOneIssueSelected = true;
                            break;
                        }
                    }


                    if (isOneIssueSelected)
                    {
                        UserDetails userDetails = new UserDetails();
                        userDetails.UserId = Convert.ToInt32(Session["UserId"].ToString());
                        DataTable dtUserDetails = new UserDetailsService().SelectEmployeeFromUserID(userDetails);
                        if (dtUserDetails.Rows.Count > 0)
                        {

                            int grievanceCategoryId = Convert.ToInt32(cmbGrievanceCategory.SelectedValue);

                            GrievanceInitiate grievanceInitiate = new GrievanceInitiate();
                            grievanceInitiate.CompanyId = Convert.ToInt32(Session["CompanyId"]);
                            grievanceInitiate.Description = txtDescription.Text.Trim();
                            grievanceInitiate.EmployeeId = Convert.ToInt32(dtUserDetails.Rows[0]["EmployeeId"].ToString());
                            grievanceInitiate.GrievanceCategoryId = grievanceCategoryId;
                            grievanceInitiate.GrievanceSummary = txtSummary.Text.Trim();
                            grievanceInitiate.PreferredResolvingApprochId = Convert.ToInt32(cmbPreferredResolvingMethod.SelectedValue);
                            grievanceInitiate.UserId = Convert.ToInt32(Session["UserId"]);

                            DataTable dtGrievanceDetails = new GrievanceInitiateService().InitiateGrievacne(grievanceInitiate);
                            int newEmployeeWiseGrievanceId = Convert.ToInt32(dtGrievanceDetails.Rows[0]["EmployeeWiseGrievanceId"].ToString());

                            for (int i = 0; i < chkLstIssues.Items.Count; i++)
                            {
                                if (chkLstIssues.Items[i].Selected)
                                {
                                    new GrievanceInitiateService().InsertEmployeeWiseGrievanceIssues(newEmployeeWiseGrievanceId, Convert.ToInt32(cmbGrievanceCategory.SelectedValue), Convert.ToInt32(chkLstIssues.Items[i].Value));
                                }
                            }

                            for (int i = 0; i < dgRelatedIncidents.Items.Count; i++)
                            {
                                new GrievanceInitiateService().InsertEmployeeWiseGrievanceIncidence(newEmployeeWiseGrievanceId.ToString(), dgRelatedIncidents.Items[i]["DateTime"].Text, dgRelatedIncidents.Items[i]["Incident"].Text);
                            }

                            for (int i = 0; i < ((DataTable)Session["PeopleInvolved"]).Rows.Count; i++)
                            {
                                new GrievanceInitiateService().InsertEmployeeWiseGrievancePeopleInvolved(newEmployeeWiseGrievanceId, ((DataTable)Session["PeopleInvolved"]).Rows[i]["DepartmentId"].ToString(), ((DataTable)Session["PeopleInvolved"]).Rows[i]["DesignationId"].ToString(), ((DataTable)Session["PeopleInvolved"]).Rows[i]["EmployeeId"].ToString());
                            }

                            DataBaseTransactions.CommitTransactions();
                            this.ShowWarningNotification("Grievance submited succesfully, HR department will contact you.");
                            ResetInputs(true);
                        }
                        else
                        {
                            this.ShowErrorNotification("Error in selecting user details.");
                        }
                    }
                    else
                    {
                        this.ShowWarningNotification("Plaese select atleast 'I have my own description / Other' option.");
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
                Response.Redirect("error.aspx", false);
            }
        }

        protected void cmbPreferredResolvingMethod_DataBound1(object sender, EventArgs e)
        {
            cmbPreferredResolvingMethod.Items.Insert(0, new RadComboBoxItem("---Select---", "0"));
        }

        

    }
}