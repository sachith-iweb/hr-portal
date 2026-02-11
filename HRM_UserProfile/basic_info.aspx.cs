using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SERVICE;
using System.Data;
using DOMAIN;
using jQueryNotification.Helper;


namespace HRM_UserProfile
{
    public partial class basic_info : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {                    
                    FillCombo();
                    FillBasicDetails();
                }
                catch (Exception ex)
                {
                    Session["ErrorMessage"] = ex.Message;
                    Session["StackTrace"] = ex.StackTrace;
                    Response.Redirect("error.aspx",false);
                }
            }
        }

        
  
        private void FillCombo()
        {
            try
            {
                cmbTitle.DataSource = new BasicInformationService().SelectTitle();
                cmbTitle.DataTextField = "Name";
                cmbTitle.DataValueField = "TitleID";
                cmbTitle.DataBind();

                cmbNationality.DataSource = new BasicInformationService().SelectNationality();
                cmbNationality.DataTextField = "Name";
                cmbNationality.DataValueField = "NationalityId";
                cmbNationality.DataBind();

                cmbNationality.DataSource = new BasicInformationService().SelectRace();
                cmbNationality.DataTextField = "Name";
                cmbNationality.DataValueField = "RaceId";
                cmbNationality.DataBind();

                cmbRace.DataSource = new BasicInformationService().SelectRace();
                cmbRace.DataTextField = "Name";
                cmbRace.DataValueField = "RaceId";
                cmbRace.DataBind();

                cmbReligion.DataSource = new BasicInformationService().SelectReligion();
                cmbReligion.DataTextField = "Name";
                cmbReligion.DataValueField = "ReligionId";
                cmbReligion.DataBind();

                cmbCivilStatus.DataSource = new BasicInformationService().SelectCivilStatus();
                cmbCivilStatus.DataTextField = "Name";
                cmbCivilStatus.DataValueField = "CivilStatusId";
                cmbCivilStatus.DataBind();
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx",false);
            }
        }
        private void FillBasicDetails()
        {
            try
            {
                btnSave.Visible = false;             

                DataTable dtBasicInfo = new BasicInformationService().SelectBasicDetails(Convert.ToInt32(Session["UserId"].ToString()));

                if (dtBasicInfo.Rows.Count > 0)
                {
                    cmbTitle.SelectedValue = dtBasicInfo.Rows[0]["TitleID"].ToString();
                    cmbReligion.SelectedValue = dtBasicInfo.Rows[0]["ReligionID"].ToString();
                    cmbRace.SelectedValue = dtBasicInfo.Rows[0]["RaceID"].ToString();
                    cmbNationality.SelectedValue = dtBasicInfo.Rows[0]["NationalityID"].ToString();
                    cmbGender.SelectedValue = dtBasicInfo.Rows[0]["Sex"].ToString();
                    cmbCivilStatus.SelectedValue = dtBasicInfo.Rows[0]["CivilStatusID"].ToString();

                    txtFirstName.Text = dtBasicInfo.Rows[0]["FirstName"].ToString();
                    txtLastName.Text = dtBasicInfo.Rows[0]["LastName"].ToString();
                    txtMiddleName.Text = dtBasicInfo.Rows[0]["MiddleName"].ToString();
                    txtNameWithInitials.Text = dtBasicInfo.Rows[0]["NameWithInitials"].ToString();
                    rdpBdateOfBirth.SelectedDate = Convert.ToDateTime(dtBasicInfo.Rows[0]["DateOfBirth"].ToString());


                    lblCurrentValueTitle.Text = dtBasicInfo.Rows[0]["TitleID"].ToString();
                    lblCurrentValueReligion.Text = dtBasicInfo.Rows[0]["ReligionID"].ToString();
                    lblCurrentValueRace.Text = dtBasicInfo.Rows[0]["RaceID"].ToString();
                    lblCurrentValuenationality.Text = dtBasicInfo.Rows[0]["NationalityID"].ToString();
                    lblCurrentValueGender.Text = dtBasicInfo.Rows[0]["Sex"].ToString();
                    lblCurrentValueCivilStatus.Text = dtBasicInfo.Rows[0]["CivilStatusID"].ToString();

                    lblCurrentValueFname.Text = dtBasicInfo.Rows[0]["FirstName"].ToString();
                    lblCurrentValueLname.Text = dtBasicInfo.Rows[0]["LastName"].ToString();
                    lblCurrentValueMname.Text = dtBasicInfo.Rows[0]["MiddleName"].ToString();
                    lblCurrentValueNameWithInitials.Text = dtBasicInfo.Rows[0]["NameWithInitials"].ToString();
                    lblCurrentValueDateOfBirth.Text = dtBasicInfo.Rows[0]["DateOfBirth"].ToString();
             } 
        
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx",false);
            }
        }
        private string CheckForChanges()
        {   string changes = "";

        try
        {
            DataTable dtBasicInfoForCheck = new BasicInformationService().SelectBasicDetails(Convert.ToInt32(Session["UserId"].ToString()));

            if (cmbTitle.SelectedValue != dtBasicInfoForCheck.Rows[0]["TitleID"].ToString())
            {
                if (changes.Length > 0)
                    changes += ", <br> Title : " + dtBasicInfoForCheck.Rows[0]["Title"].ToString() + " to <b>" + cmbTitle.Text + "</b>";
                else
                    changes += "<br>Title : " + dtBasicInfoForCheck.Rows[0]["Title"].ToString() + " to <b>" + cmbTitle.Text + "</b>";
            }

            if (cmbReligion.SelectedValue != dtBasicInfoForCheck.Rows[0]["ReligionID"].ToString())
            {
                if (changes.Length > 0)
                    changes += ", <br>Religion : " + dtBasicInfoForCheck.Rows[0]["Religion"].ToString() + " to <b>" + cmbReligion.Text + "</b>";
                else
                    changes += "<br>Religion : " + dtBasicInfoForCheck.Rows[0]["Religion"].ToString() + " to <b>" + cmbReligion.Text + "</b>";
            }

            if (cmbRace.SelectedValue != dtBasicInfoForCheck.Rows[0]["RaceID"].ToString())
            {
                if (changes.Length > 0)
                    changes += ", <br>Race : " + dtBasicInfoForCheck.Rows[0]["Race"].ToString() + " to <b>" + cmbRace.Text + "</b>";
                else
                    changes += "<br>Race : " + dtBasicInfoForCheck.Rows[0]["Race"].ToString() + " to <b>" + cmbRace.Text + "</b>";
            }

            if (cmbNationality.SelectedValue != dtBasicInfoForCheck.Rows[0]["NationalityID"].ToString())
            {
                if (changes.Length > 0)
                    changes += ", <br>Nationality : " + dtBasicInfoForCheck.Rows[0]["Nationality"].ToString() + " to <b>" + cmbNationality.Text + "</b>";
                else
                    changes += "<br>Nationality : " + dtBasicInfoForCheck.Rows[0]["Nationality"].ToString() + " to <b>" + cmbNationality.Text + "</b>";
            }

            if (cmbGender.SelectedValue != dtBasicInfoForCheck.Rows[0]["Sex"].ToString())
            {
                if (changes.Length > 0)
                    changes += ", <br>Gender : " + dtBasicInfoForCheck.Rows[0]["SexDescription"].ToString() + " to <b>" + cmbGender.Text + "</b>";
                else
                    changes += "<br>Gender : " + dtBasicInfoForCheck.Rows[0]["SexDescription"].ToString() + " to <b>" + cmbGender.Text + "</b>";
            }

            if (cmbCivilStatus.SelectedValue != dtBasicInfoForCheck.Rows[0]["CivilStatusID"].ToString())
            {
                if (changes.Length > 0)
                    changes += ", <br>Civil Status : " + dtBasicInfoForCheck.Rows[0]["CivilStatus"].ToString() + " to <b>" + cmbCivilStatus.Text + "</b>";
                else
                    changes += "<br>Civil Status : " + dtBasicInfoForCheck.Rows[0]["CivilStatus"].ToString() + " to <b>" + cmbCivilStatus.Text + "</b>";
            }

            if (txtFirstName.Text.Trim() != dtBasicInfoForCheck.Rows[0]["FirstName"].ToString().Trim())
            {
                if (changes.Length > 0)
                    changes += ", <br>First Name : " + dtBasicInfoForCheck.Rows[0]["FirstName"].ToString() + " to <b>" + txtFirstName.Text + "</b>";
                else
                    changes += "<br>First Name : " + dtBasicInfoForCheck.Rows[0]["FirstName"].ToString() + " to <b>" + txtFirstName.Text + "</b>";
            }

            if (txtLastName.Text.Trim() != dtBasicInfoForCheck.Rows[0]["LastName"].ToString().Trim())
            {
                if (changes.Length > 0)
                    changes += ", <br>Last Name : " + dtBasicInfoForCheck.Rows[0]["LastName"].ToString() + " to <b>" + txtLastName.Text + "</b>";
                else
                    changes += "<br>Last Name : " + dtBasicInfoForCheck.Rows[0]["LastName"].ToString() + " to <b>" + txtLastName.Text + "</b>";
            }

            if (txtMiddleName.Text.Trim() != dtBasicInfoForCheck.Rows[0]["MiddleName"].ToString().Trim())
            {
                if (changes.Length > 0)
                    changes += ", <br>Middle Name : " + dtBasicInfoForCheck.Rows[0]["MiddleName"].ToString() + " to <b>" + txtMiddleName.Text + "</b>";
                else
                    changes += "<br>Middle Name : " + dtBasicInfoForCheck.Rows[0]["MiddleName"].ToString() + " to <b>" + txtMiddleName.Text + "</b>";
            }

            if (txtNameWithInitials.Text.Trim() != dtBasicInfoForCheck.Rows[0]["NameWithInitials"].ToString().Trim())
            {
                if (changes.Length > 0)
                    changes += ", <br>Name With Initials : " + dtBasicInfoForCheck.Rows[0]["NameWithInitials"].ToString() + " to <b>" + txtNameWithInitials.Text + "</b>";
                else
                    changes += "<br>Name With Initials : " + dtBasicInfoForCheck.Rows[0]["NameWithInitials"].ToString() + " to <b>" + txtNameWithInitials.Text + "</b>";
            }

            if (Convert.ToDateTime(rdpBdateOfBirth.SelectedDate.Value).Date != Convert.ToDateTime(dtBasicInfoForCheck.Rows[0]["DateOfBirth"].ToString()).Date)
            {
                if (changes.Length > 0)
                    changes += ", <br>Date Of Birth : " + Convert.ToDateTime(dtBasicInfoForCheck.Rows[0]["DateOfBirth"].ToString()).ToShortDateString() + " to <b>" + rdpBdateOfBirth.SelectedDate.Value.ToShortDateString() + "</b>";
                else
                    changes += "<br>Date Of Birth : " + Convert.ToDateTime(dtBasicInfoForCheck.Rows[0]["DateOfBirth"].ToString()).ToShortDateString() + " to <b>" + rdpBdateOfBirth.SelectedDate.Value.ToShortDateString() + "</b>";            
            }

           
        }        
        catch (Exception ex)
        {
            Session["ErrorMessage"] = ex.Message;
            Session["StackTrace"] = ex.StackTrace;
            Response.Redirect("error.aspx",false);
        }

            return changes;
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(1000);
            btnSave.Visible = false;

            try
            {
                if (r1.IsValid && r2.IsValid && r3.IsValid && r4.IsValid && r5.IsValid && r7.IsValid && r8.IsValid && r9.IsValid && r10.IsValid && r11.IsValid)
                {
                    EmployeeBasicInformation employeeBasicInformation = new DOMAIN.EmployeeBasicInformation();
                    employeeBasicInformation.RequestedUserId = Session["UserId"].ToString();


                    if (new BasicInformationService().SelectEmployeeBasicInformationNotApproved(employeeBasicInformation).Rows.Count <= 0)
                    {

                        System.Threading.Thread.Sleep(1000);

                        employeeBasicInformation.CivilStatusId = cmbCivilStatus.SelectedValue;
                        employeeBasicInformation.DateOfBirth = Convert.ToDateTime(rdpBdateOfBirth.SelectedDate);
                        employeeBasicInformation.FirstName = txtFirstName.Text;
                        employeeBasicInformation.Gender = cmbGender.SelectedValue;
                        employeeBasicInformation.Id = "1";
                        employeeBasicInformation.LastName = txtLastName.Text;
                        employeeBasicInformation.MiddleName = txtMiddleName.Text;
                        employeeBasicInformation.NameWithInitials = txtNameWithInitials.Text;
                        employeeBasicInformation.NationalityId = cmbNationality.SelectedValue;
                        //employeeBasicInformation.ProfilePicture = "";
                        employeeBasicInformation.RaceId = cmbRace.SelectedValue;
                        employeeBasicInformation.ReligionId = cmbReligion.SelectedValue;
                        employeeBasicInformation.TitleId = cmbTitle.SelectedValue;

                        new BasicInformationService().InsertEmployeeBasicInformation(employeeBasicInformation);
                        DataBaseTransactions.CommitTransactions();
                        //FillBasicDetails();

                        this.ShowSuccessfulNotification("Requested submited successfully, It will apply to your profile after appoval.");

                    }
                    else
                    {
                        this.ShowWarningNotification("You have not approved basic information updation. Request Rejected ... !");
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
                FillBasicDetails();
                btnSave.Visible = false;                
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
              
                System.Threading.Thread.Sleep(1000);
                if (CheckForChanges().Length <= 0)
                {
                    this.ShowWarningNotification("No changes to save.");                  
                    btnSave.Visible = false;

                }
                else
                {
                    this.ShowWarningNotification("Following change(s) detected. Please check again and request to change");
                    this.ShowInfomationNotification(CheckForChanges());
                    btnSave.Visible = true;
                }
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx",false);
            }

            
        }

        protected void cmbTitle_DataBound(object sender, EventArgs e)
        {
            cmbTitle.Items.Insert(0, new Telerik.Web.UI.RadComboBoxItem("---Select---", "0"));
        }

        protected void cmbNationality_DataBound(object sender, EventArgs e)
        {
            cmbNationality.Items.Insert(0, new Telerik.Web.UI.RadComboBoxItem("---Select---", "0"));
        }

        protected void cmbRace_DataBound(object sender, EventArgs e)
        {
            cmbRace.Items.Insert(0, new Telerik.Web.UI.RadComboBoxItem("---Select---", "0"));
        }

        protected void cmbReligion_DataBound(object sender, EventArgs e)
        {
            cmbReligion.Items.Insert(0, new Telerik.Web.UI.RadComboBoxItem("---Select---", "0"));
        }

        protected void cmbGender_DataBound(object sender, EventArgs e)
        {
           cmbGender.Items.Insert(0, new Telerik.Web.UI.RadComboBoxItem("---Select---", "0"));
        }

        protected void cmbCivilStatus_DataBound(object sender, EventArgs e)
        {
            cmbCivilStatus.Items.Insert(0, new Telerik.Web.UI.RadComboBoxItem("---Select---", "0"));
        }
            
    
    }
}