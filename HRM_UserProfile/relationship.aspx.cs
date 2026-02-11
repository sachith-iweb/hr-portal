using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;
using DOMAIN;
using SERVICE;
using System.Data;
using jQueryNotification.Helper;

namespace HRM_UserProfile
{
    public partial class relationship : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    FillCmbCivilStatus();
                    FillcmbRelationship();
                    FillGrid();

                    Reset();
                }
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx",false);
            }

        }

      

        private void FillcmbRelationship()
        {
            try
            {
                cmbRelationship.DataSource = null;
                cmbRelationship.DataSource = new RelationshipService().SelectRelationships();
                cmbRelationship.DataValueField = "RelationshipId";
                cmbRelationship.DataTextField = "Name";
                cmbRelationship.DataBind();
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx",false);
            }
        }
        private void FillCmbCivilStatus()
        {
            try
            {
                cmbCivilStatus.DataSource = null;
                cmbCivilStatus.DataSource = new RelationshipService().SelectCivilStatus();
                cmbCivilStatus.DataValueField = "CivilStatusId";
                cmbCivilStatus.DataTextField = "Name";
                cmbCivilStatus.DataBind();
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
                    dgEmployeeWiseRelationshipDetails.DataSource = null;
                    dgEmployeeWiseRelationshipDetails.DataSource = new RelationshipService().SelectEmployeeWiseRelationshipDetails(Convert.ToInt32(Session["EmployeeId"]));
                    dgEmployeeWiseRelationshipDetails.DataBind();
                
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx",false);
            }
        }

        protected void dgEmployeeWiseRelationshipDetails_ItemCommand(object sender, Telerik.Web.UI.GridCommandEventArgs e)
        {
            try
            {               

                if (e.CommandName == CommonParameterNames.ItemCommand.Select)
                {                    
                    GridDataItem item = (GridDataItem)e.Item;

                    Session[CommonParameterNames.CommonTableColumnNames.EmployeeWiseRelationshipDetails.EmployeeWiseRelationshipId] = item[CommonParameterNames.CommonTableColumnNames.EmployeeWiseRelationshipDetails.EmployeeWiseRelationshipId].Text;
                    cmbCivilStatus.SelectedValue = item[CommonParameterNames.CommonTableColumnNames.EmployeeWiseRelationshipDetails.CivilStatusId].Text;
                    cmbRelationship.SelectedValue = item[CommonParameterNames.CommonTableColumnNames.EmployeeWiseRelationshipDetails.RelationshipId].Text;
                    txtAddress.Text = item[CommonParameterNames.CommonTableColumnNames.EmployeeWiseRelationshipDetails.Address].Text;
                    txtEmail.Text = item[CommonParameterNames.CommonTableColumnNames.EmployeeWiseRelationshipDetails.Email].Text;
                    txtName.Text = item[CommonParameterNames.CommonTableColumnNames.EmployeeWiseRelationshipDetails.Name].Text;
                    cmbPriority.SelectedValue = item[CommonParameterNames.CommonTableColumnNames.EmployeeWiseRelationshipDetails.PriorityId].Text;
                    txtRemarks.Text = item[CommonParameterNames.CommonTableColumnNames.EmployeeWiseRelationshipDetails.Remarks].Text;
                    txtTelephone.Text = item[CommonParameterNames.CommonTableColumnNames.EmployeeWiseRelationshipDetails.Telephone].Text;
                    txtWorkPlace.Text = item[CommonParameterNames.CommonTableColumnNames.EmployeeWiseRelationshipDetails.WorkPlace].Text;
                    txtWorkPlaceAddress.Text = item[CommonParameterNames.CommonTableColumnNames.EmployeeWiseRelationshipDetails.WorkPlaceAddress].Text;
                    txtWorkPlaceTelephone.Text = item[CommonParameterNames.CommonTableColumnNames.EmployeeWiseRelationshipDetails.WorkPlaceTelephoneNumber].Text;
                    dtpDateOfBirth.SelectedDate = Convert.ToDateTime(item[CommonParameterNames.CommonTableColumnNames.EmployeeWiseRelationshipDetails.DateOfBirth].Text);
                    chkActive.Checked = Convert.ToBoolean(item[CommonParameterNames.CommonTableColumnNames.EmployeeWiseRelationshipDetails.IsActive].Text);
                     
                }
                
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx",false);
            }
        }



        protected void dgEmployeeWiseRelationshipDetails_PageIndexChanged(object sender, GridPageChangedEventArgs e)
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

        protected void dgEmployeeWiseRelationshipDetails_PageSizeChanged(object sender, GridPageSizeChangedEventArgs e)
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

        protected void dgEmployeeWiseRelationshipDetails_SortCommand(object sender, GridSortCommandEventArgs e)
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

        protected void dgEmployeeWiseRelationshipDetails_NeedDataSource(object sender, GridNeedDataSourceEventArgs e)
        {
            try
            {
                dgEmployeeWiseRelationshipDetails.DataSource = new RelationshipService().SelectEmployeeWiseRelationshipDetails(Convert.ToInt32(Session["EmployeeId"]));
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
            System.Threading.Thread.Sleep(1000);           
           
            try
            {
                if (r1.IsValid && r2.IsValid && r4.IsValid && r6.IsValid)
                {
                    EmployeeWiseRelationshipDetails employeeWiseRelationshipDetails = new EmployeeWiseRelationshipDetails();


                    //if (new RelationshipService().SelectEmployeeWiseRelationshipDetailsNotApproved(Convert.ToInt32(Session["EmployeeId"]), Convert.ToInt32(Session[CommonParameterNames.CommonTableColumnNames.EmployeeWiseRelationshipDetails.EmployeeWiseRelationshipId])).Rows.Count <= 0)
                    //{
                        if (txtEmail.Text.Trim().Length > 0)
                        {
                            if (System.Text.RegularExpressions.Regex.IsMatch(txtEmail.Text, Validations.CommonRegularExpressions.email))
                            {
                                employeeWiseRelationshipDetails.Email = txtEmail.Text;
                            }
                            else
                            {
                                this.ShowWarningNotification("Email is not in correct format.");
                                return;
                            }
                        }
                        else
                        {
                            employeeWiseRelationshipDetails.Email = "";
                        }


                        if (txtTelephone.Text.Length > 0)
                        {
                            if (System.Text.RegularExpressions.Regex.IsMatch(txtTelephone.Text, Validations.CommonRegularExpressions.Telephone))
                            {
                                employeeWiseRelationshipDetails.Telephone = txtTelephone.Text;
                            }
                            else
                            {
                                this.ShowWarningNotification("Personal telephone number not in correct format.");
                                return;
                            }
                        }
                        else
                        {
                            employeeWiseRelationshipDetails.Telephone = "";
                        }


                        if (txtWorkPlaceTelephone.Text.Trim().Length > 0)
                        {
                            if (System.Text.RegularExpressions.Regex.IsMatch(txtWorkPlaceTelephone.Text.Trim(), Validations.CommonRegularExpressions.Telephone))
                            {
                                employeeWiseRelationshipDetails.WorkPlaceTelephoneNumber = txtWorkPlaceTelephone.Text.Trim();
                            }
                            else
                            {
                                this.ShowWarningNotification("Work place telephone number not in correct format.");
                                return;
                            }
                        }
                        else
                        {
                            employeeWiseRelationshipDetails.WorkPlaceTelephoneNumber = "";
                        }

                        employeeWiseRelationshipDetails.Address = txtAddress.Text;
                        employeeWiseRelationshipDetails.CivilStatusId = Convert.ToInt32(cmbCivilStatus.SelectedValue);
                        employeeWiseRelationshipDetails.DateOfBirth = dtpDateOfBirth.SelectedDate == null ? Convert.ToDateTime("1900-01-01") : dtpDateOfBirth.SelectedDate.Value;
                        employeeWiseRelationshipDetails.EmployeeId = Convert.ToInt32(Session["EmployeeId"]);
                        employeeWiseRelationshipDetails.EmployeeWiseRelationshipId = Convert.ToInt32(Session[CommonParameterNames.CommonTableColumnNames.EmployeeWiseRelationshipDetails.EmployeeWiseRelationshipId]);
                        employeeWiseRelationshipDetails.IsActive = chkActive.Checked;
                        employeeWiseRelationshipDetails.Name = txtName.Text;
                        employeeWiseRelationshipDetails.PriorityId = Convert.ToInt32(cmbPriority.SelectedValue);
                        employeeWiseRelationshipDetails.RelationshipId = Convert.ToInt32(cmbRelationship.SelectedValue);
                        employeeWiseRelationshipDetails.Remarks = txtRemarks.Text;
                        employeeWiseRelationshipDetails.UserId = Convert.ToInt32(Session["UserId"]);
                        employeeWiseRelationshipDetails.WorkPlace = txtWorkPlace.Text;
                        employeeWiseRelationshipDetails.WorkPlaceAddress = txtWorkPlaceAddress.Text;

                        new RelationshipService().Insert(employeeWiseRelationshipDetails);
                        DataBaseTransactions.CommitTransactions();
                        FillGrid();

                        Reset();

                        this.ShowSuccessfulNotification("Request Successfully Submited ... !");
                    //}
                    //else
                    //{
                    //    this.ShowWarningNotification("Request submission fail. There is a pending change update request on this relationship type.");
                    //} 
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
                Reset();
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx",false);
            }
        }

        private void Reset()
        {
            try
            {               

                Session[CommonParameterNames.CommonTableColumnNames.EmployeeWiseRelationshipDetails.EmployeeWiseRelationshipId] = -1;
                txtAddress.Text = "";
                txtEmail.Text = "";
                txtName.Text = "";
                
                txtRemarks.Text = "";
                txtTelephone.Text = "";
                txtWorkPlace.Text = "";
                txtWorkPlaceAddress.Text = "";
                txtWorkPlaceTelephone.Text = "";
                cmbCivilStatus.SelectedIndex = 0;
                cmbRelationship.SelectedIndex = 0;
                cmbPriority.SelectedIndex = 0;
                chkActive.Checked = true;

                hdnAddress.Value = "";
                hdnCivilStatus.Value = "";
                hdnDateOfBirth.Value = "";
                hdnEmail.Value = "";
                hdnIsActive.Value = "";
                hdnName.Value = "";
                hdnPersonalTelephone.Value = "";
                hdnPriority.Value = "";
                hdnRelationship.Value = "";
                hdnRemark.Value = "";
                hdnWorkPlace.Value = "";
                hdnWorkPlaceTelephone.Value = "";
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.Message;
                Session["StackTrace"] = ex.StackTrace;
                Response.Redirect("error.aspx",false);
            }     
       }
        



        //private string CheckForChanges()
        //{
        //    string changes = "";

        //    try
        //    {
        //        DataTable dtEmployeeWiseRelationshipsFoForCheck = new BasicInformationService().new RelationshipService().SelectEmployeeWiseRelationshipDetails(Convert.ToInt32(Session["EmployeeId"].ToString()));

        //        if (cmbTitle.SelectedValue != dtBasicInfoForCheck.Rows[0]["TitleID"].ToString())
        //        {
        //            if (changes.Length > 0)
        //                changes += ", <br> Title : " + dtBasicInfoForCheck.Rows[0]["Title"].ToString() + " to <b>" + cmbTitle.Text + "</b>";
        //            else
        //                changes += "<br>Title : " + dtBasicInfoForCheck.Rows[0]["Title"].ToString() + " to <b>" + cmbTitle.Text + "</b>";
        //        }

        //        if (cmbReligion.SelectedValue != dtBasicInfoForCheck.Rows[0]["ReligionID"].ToString())
        //        {
        //            if (changes.Length > 0)
        //                changes += ", <br>Religion : " + dtBasicInfoForCheck.Rows[0]["Religion"].ToString() + " to <b>" + cmbReligion.Text + "</b>";
        //            else
        //                changes += "<br>Religion : " + dtBasicInfoForCheck.Rows[0]["Religion"].ToString() + " to <b>" + cmbReligion.Text + "</b>";
        //        }

        //        if (cmbRace.SelectedValue != dtBasicInfoForCheck.Rows[0]["RaceID"].ToString())
        //        {
        //            if (changes.Length > 0)
        //                changes += ", <br>Race : " + dtBasicInfoForCheck.Rows[0]["Race"].ToString() + " to <b>" + cmbRace.Text + "</b>";
        //            else
        //                changes += "<br>Race : " + dtBasicInfoForCheck.Rows[0]["Race"].ToString() + " to <b>" + cmbRace.Text + "</b>";
        //        }

        //        if (cmbNationality.SelectedValue != dtBasicInfoForCheck.Rows[0]["NationalityID"].ToString())
        //        {
        //            if (changes.Length > 0)
        //                changes += ", <br>Nationality : " + dtBasicInfoForCheck.Rows[0]["Nationality"].ToString() + " to <b>" + cmbNationality.Text + "</b>";
        //            else
        //                changes += "<br>Nationality : " + dtBasicInfoForCheck.Rows[0]["Nationality"].ToString() + " to <b>" + cmbNationality.Text + "</b>";
        //        }

        //        if (cmbGender.SelectedValue != dtBasicInfoForCheck.Rows[0]["Sex"].ToString())
        //        {
        //            if (changes.Length > 0)
        //                changes += ", <br>Gender : " + dtBasicInfoForCheck.Rows[0]["SexDescription"].ToString() + " to <b>" + cmbGender.Text + "</b>";
        //            else
        //                changes += "<br>Gender : " + dtBasicInfoForCheck.Rows[0]["SexDescription"].ToString() + " to <b>" + cmbGender.Text + "</b>";
        //        }

        //        if (cmbCivilStatus.SelectedValue != dtBasicInfoForCheck.Rows[0]["CivilStatusID"].ToString())
        //        {
        //            if (changes.Length > 0)
        //                changes += ", <br>Civil Status : " + dtBasicInfoForCheck.Rows[0]["CivilStatus"].ToString() + " to <b>" + cmbCivilStatus.Text + "</b>";
        //            else
        //                changes += "<br>Civil Status : " + dtBasicInfoForCheck.Rows[0]["CivilStatus"].ToString() + " to <b>" + cmbCivilStatus.Text + "</b>";
        //        }

        //        if (txtFirstName.Text.Trim() != dtBasicInfoForCheck.Rows[0]["FirstName"].ToString().Trim())
        //        {
        //            if (changes.Length > 0)
        //                changes += ", <br>First Name : " + dtBasicInfoForCheck.Rows[0]["FirstName"].ToString() + " to <b>" + txtFirstName.Text + "</b>";
        //            else
        //                changes += "<br>First Name : " + dtBasicInfoForCheck.Rows[0]["FirstName"].ToString() + " to <b>" + txtFirstName.Text + "</b>";
        //        }

        //        if (txtLastName.Text.Trim() != dtBasicInfoForCheck.Rows[0]["LastName"].ToString().Trim())
        //        {
        //            if (changes.Length > 0)
        //                changes += ", <br>Last Name : " + dtBasicInfoForCheck.Rows[0]["LastName"].ToString() + " to <b>" + txtLastName.Text + "</b>";
        //            else
        //                changes += "<br>Last Name : " + dtBasicInfoForCheck.Rows[0]["LastName"].ToString() + " to <b>" + txtLastName.Text + "</b>";
        //        }

        //        if (txtMiddleName.Text.Trim() != dtBasicInfoForCheck.Rows[0]["MiddleName"].ToString().Trim())
        //        {
        //            if (changes.Length > 0)
        //                changes += ", <br>Middle Name : " + dtBasicInfoForCheck.Rows[0]["MiddleName"].ToString() + " to <b>" + txtMiddleName.Text + "</b>";
        //            else
        //                changes += "<br>Middle Name : " + dtBasicInfoForCheck.Rows[0]["MiddleName"].ToString() + " to <b>" + txtMiddleName.Text + "</b>";
        //        }

        //        if (txtNameWithInitials.Text.Trim() != dtBasicInfoForCheck.Rows[0]["NameWithInitials"].ToString().Trim())
        //        {
        //            if (changes.Length > 0)
        //                changes += ", <br>Name With Initials : " + dtBasicInfoForCheck.Rows[0]["NameWithInitials"].ToString() + " to <b>" + txtNameWithInitials.Text + "</b>";
        //            else
        //                changes += "<br>Name With Initials : " + dtBasicInfoForCheck.Rows[0]["NameWithInitials"].ToString() + " to <b>" + txtNameWithInitials.Text + "</b>";
        //        }

        //        if (rdpBdateOfBirth.SelectedDate != Convert.ToDateTime(dtBasicInfoForCheck.Rows[0]["DateOfBirth"].ToString()))
        //        {
        //            if (changes.Length > 0)
        //                changes += ", <br>Date Of Birth : " + Convert.ToDateTime(dtBasicInfoForCheck.Rows[0]["DateOfBirth"].ToString()).ToShortDateString() + " to <b>" + rdpBdateOfBirth.SelectedDate.Value.ToShortDateString() + "</b>";
        //            else
        //                changes += "<br>Date Of Birth : " + Convert.ToDateTime(dtBasicInfoForCheck.Rows[0]["DateOfBirth"].ToString()).ToShortDateString() + " to <b>" + rdpBdateOfBirth.SelectedDate.Value.ToShortDateString() + "</b>";
        //        }
        //    }
        //    catch (NullReferenceException)
        //    {
        //        Response.Redirect("default.aspx");
        //    }
        //    catch (Exception ex)
        //    {
        //        Response.Write(ex.Message);
        //    }

        //    return changes;
        //}


        protected void btnCheckForChanges_Click(object sender, EventArgs e)
        {
            //lblMessage.Text = "";
            //System.Threading.Thread.Sleep(1000);
            //if (CheckForChanges().Length <= 0)
            //{
            //    lblMessage.Text = "No changes to save.";
            //    lblMessage.ForeColor = System.Drawing.Color.Red;
            //    btnSave.Visible = false;

            //}
            //else
            //{
            //    lblMessage.Text = "<span style='color:#003300;  text-transform: uppercase;'>Following change(s) detected. Please check again and request to change.</span><hr class='line'>" + "<span style='color:#f00;'>" + CheckForChanges() + "</span>";
            //    btnSave.Visible = true;

            //}
        }

        protected void cmbRelationship_DataBound(object sender, EventArgs e)
        {
            cmbRelationship.Items.Insert(0, new RadComboBoxItem("---Select---", "0"));
        }

        protected void cmbCivilStatus_DataBound(object sender, EventArgs e)
        {
            cmbCivilStatus.Items.Insert(0, new RadComboBoxItem("---Select---", "0"));
        }
    }
}