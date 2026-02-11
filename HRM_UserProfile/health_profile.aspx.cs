using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DOMAIN;
using SERVICE;
using jQueryNotification.Helper;

namespace HRM_UserProfile
{
    public partial class health_profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    FillBloodGroupDetails();
                    FillEmployeeHealthProfileDetails();
                }
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx",false);
            }
        }
        private void FillBloodGroupDetails()
        {
            try
            {
                cmbBloodGroup.DataSource = null;
                cmbBloodGroup.DataBind();

                cmbBloodGroup.DataSource = new HealthProfileService().SelectBloodGroupDetails();
                cmbBloodGroup.DataTextField = "Name";
                cmbBloodGroup.DataValueField = "BloodGroupId";
                cmbBloodGroup.DataBind();
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx",false);
            }
        }
        private void FillEmployeeHealthProfileDetails()
        {
            try
            {
                chkActive.Checked = true;
                DataTable dtEmployeeHeathProfile = new HealthProfileService().SelectEmployeeWiseHealthProfile(Convert.ToInt32(Session["EmployeeId"]));

                if (dtEmployeeHeathProfile.Rows.Count > 0)
                {
                    txtAddress.Text = dtEmployeeHeathProfile.Rows[0]["FamilyDoctorAddress"].ToString();
                    txtAlergies.Text = dtEmployeeHeathProfile.Rows[0]["Alergies"].ToString();
                    txtContactNo.Text = dtEmployeeHeathProfile.Rows[0]["FamilyDoctorContactNo"].ToString();
                    txtEmail.Text = dtEmployeeHeathProfile.Rows[0]["FamilyDoctorEmail"].ToString();
                    txtHospital.Text = dtEmployeeHeathProfile.Rows[0]["FamilyDoctorHospital"].ToString();
                    txtIllness.Text = dtEmployeeHeathProfile.Rows[0]["Illness"].ToString();
                    txtName.Text = dtEmployeeHeathProfile.Rows[0]["FamilyDoctorName"].ToString();

                    cmbBloodGroup.SelectedValue = dtEmployeeHeathProfile.Rows[0]["BloodGroupID"].ToString();                   
                    chkActive.Checked = Convert.ToBoolean(dtEmployeeHeathProfile.Rows[0]["IsActive"].ToString());

                    hdnEmployeeWiseHelthProfileID.Value = dtEmployeeHeathProfile.Rows[0]["EmployeeWiseHelthProfileID"].ToString();

                }
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
            System.Threading.Thread.Sleep(1000);
        }
      
        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //if (r1.IsValid && r2.IsValid  && r3.IsValid && r4.IsValid && r5.IsValid && r6.IsValid && r7.IsValid && r8.IsValid)
                if (r1.IsValid)
                {
                    HealthProfile employeeWiseHelthProfileDetails = new HealthProfile();
                    System.Threading.Thread.Sleep(1000);

                    if (new HealthProfileService().SelectEmployeeHealthProfileNotApproved(Convert.ToInt32(Session["EmployeeId"])).Rows.Count == 0)
                    {
                        if (txtEmail.Text.Trim().Length > 0)
                        {
                            if (System.Text.RegularExpressions.Regex.IsMatch(txtEmail.Text.Trim(), Validations.CommonRegularExpressions.email))
                            {
                                this.ShowWarningNotification("Doctor's email is not in correct format");
                                return;
                            }
                        }

                        if (txtContactNo.Text.Trim().Length > 0)
                        {
                            if (!System.Text.RegularExpressions.Regex.IsMatch(txtContactNo.Text.Trim(), Validations.CommonRegularExpressions.Telephone))
                            {
                                this.ShowWarningNotification("Doctor's telephone is not in correct format");
                                return;
                            }
                        }

                        if (hdnEmployeeWiseHelthProfileID.Value.Length <= 0)
                            hdnEmployeeWiseHelthProfileID.Value = "0";

                        employeeWiseHelthProfileDetails.EmployeeWiseHelthProfileID = Convert.ToInt32(hdnEmployeeWiseHelthProfileID.Value);
                        employeeWiseHelthProfileDetails.IsActive = chkActive.Checked;
                        employeeWiseHelthProfileDetails.UserId = Convert.ToInt32(Session["UserId"]);
                        employeeWiseHelthProfileDetails.EmployeeID = Convert.ToInt32(Session["EmployeeId"]);
                        employeeWiseHelthProfileDetails.BloodGroupID = Convert.ToInt32(cmbBloodGroup.SelectedValue);
                        employeeWiseHelthProfileDetails.FamilyDoctorName = txtName.Text.Trim();
                        employeeWiseHelthProfileDetails.FamilyDoctorAddress = txtAddress.Text.Trim();
                        employeeWiseHelthProfileDetails.FamilyDoctorContactNo = txtContactNo.Text.Trim();
                        employeeWiseHelthProfileDetails.FamilyDoctorEmail = txtEmail.Text.Trim();
                        employeeWiseHelthProfileDetails.FamilyDoctorHospital = txtHospital.Text.Trim();
                        employeeWiseHelthProfileDetails.Alergies = txtAlergies.Text.Trim();
                        employeeWiseHelthProfileDetails.Illness = txtIllness.Text.Trim();

                        new HealthProfileService().Insert(employeeWiseHelthProfileDetails);
                        DataBaseTransactions.CommitTransactions();

                        FillEmployeeHealthProfileDetails();

                        this.ShowSuccessfulNotification("Request Successfully Submited ... !");


                    }
                    else
                    {
                        this.ShowWarningNotification("Request submission fail. There is a pending change request.");
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
        protected void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                System.Threading.Thread.Sleep(1000);
                FillEmployeeHealthProfileDetails();
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx",false);
            }
        }

        protected void cmbBloodGroup_DataBound(object sender, EventArgs e)
        {
            cmbBloodGroup.Items.Insert(0, new Telerik.Web.UI.RadComboBoxItem("---Select---", "0"));
        }
    }
}