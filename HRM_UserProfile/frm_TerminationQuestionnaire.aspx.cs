using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SERVICE;
using DOMAIN;
using System.Data;
using jQueryNotification.Helper;

using Telerik.Web.UI;

namespace HRM_UserProfile
{
    public partial class frm_TerminationQuestionnaire : System.Web.UI.Page
    {
        TerminationFeedbackDetailsService terminationFeedbackDetailsService = new TerminationFeedbackDetailsService();
        TerminationFeedbackDetails terminationFeedbackDetails = new TerminationFeedbackDetails();

        ListOfAttributes listOfAttributes = new ListOfAttributes();
        ListOfAttributesDetailsService listOfAttributesDetailsService = new ListOfAttributesDetailsService();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (ValidateUserHasInitiateaTermination()) // if user has a termination
                {
                    dgTerminationQuestionnaire.Visible = true;

                    terminationFeedbackDetails = new TerminationFeedbackDetails();
                    terminationFeedbackDetails.User = Convert.ToInt32(Session["UserId"]);

                    if (terminationFeedbackDetailsService.SelectAll_ANSByUser(terminationFeedbackDetails).Rows.Count == 0)
                    {
                        dgTerminationQuestionnaire.Visible = true;                        
                        GenerateGridForAnswers();
                    }
                    else
                    {
                       

                      
                        this.ShowWarningNotification("You have already completed your termination feedback....");
                       
                    }
                }
                else
                {                    

                   this.ShowWarningNotification("You don't have a termination feedback...");
                    dgTerminationQuestionnaire.Visible = false;
                    //GenerateGridForAnswers(); 
                }
            }
        }

        public void ResetInputs(bool resetInputs) 
        { 
            
        }

        public bool ValidateUserHasInitiateaTermination()
        {
            bool validation = false;
            try
            {
                int terminationInitiationUser = Convert.ToInt32(Session["UserId"]);
                DataTable dtTeminationInitiation = terminationFeedbackDetailsService.SelectThisTerminationInitiationByUser(terminationInitiationUser);

                if (dtTeminationInitiation.Rows.Count > 0)
                {
                    validation = true;
                    return validation;
                }
            }
            catch (Exception)
            {
               
            }
            return validation;
        }

        public void GenerateGridForAnswers()
        {
            try
            {
                dgTerminationQuestionnaire.DataSource = terminationFeedbackDetailsService.SelectAllQuestionsIsActive();
                dgTerminationQuestionnaire.DataBind();

                for (int i = 0; i < dgTerminationQuestionnaire.Items.Count; i++)
                {
                    listOfAttributes.HeaderId = Convert.ToInt32(dgTerminationQuestionnaire.Items[i]["ListValueHeaderId"].Text);

                    ((RadComboBox)dgTerminationQuestionnaire.MasterTableView.Items[i]["Rating"].FindControl("cmbListOfValueDetails")).DataSource = null;
                    ((RadComboBox)dgTerminationQuestionnaire.MasterTableView.Items[i]["Rating"].FindControl("cmbListOfValueDetails")).DataBind();

                    ((RadComboBox)dgTerminationQuestionnaire.MasterTableView.Items[i]["Rating"].FindControl("cmbListOfValueDetails")).DataSource = listOfAttributesDetailsService.SelectListOfAttributeHeaderDetailsFromListOfAttributeHeaderId(listOfAttributes);

                    ((RadComboBox)dgTerminationQuestionnaire.MasterTableView.Items[i]["Rating"].FindControl("cmbListOfValueDetails")).DataTextField = "DisplayValue";
                    ((RadComboBox)dgTerminationQuestionnaire.MasterTableView.Items[i]["Rating"].FindControl("cmbListOfValueDetails")).DataValueField = "BoundValue";
                    ((RadComboBox)dgTerminationQuestionnaire.MasterTableView.Items[i]["Rating"].FindControl("cmbListOfValueDetails")).DataBind();     
                }
            }
            catch (Exception)
            {
               // this.ShowErrorNotification(CommonUserMessage.CommonErrorMessages.GeneralException);
            }
        }

        public void Insert()
        {
            try
            {
                terminationFeedbackDetails = new TerminationFeedbackDetails();

                for (int i = 0; i < dgTerminationQuestionnaire.Items.Count; i++)
                {
                    terminationFeedbackDetails.DisplayValue_ANS = ((RadComboBox)dgTerminationQuestionnaire.MasterTableView.Items[i]["Rating"].FindControl("cmbListOfValueDetails")).Text;
                    terminationFeedbackDetails.BoundValue_ANS = ((RadComboBox)dgTerminationQuestionnaire.MasterTableView.Items[i]["Rating"].FindControl("cmbListOfValueDetails")).SelectedValue;
                    terminationFeedbackDetails.ListOfValueHeaderId_ANS = Convert.ToInt32(dgTerminationQuestionnaire.Items[i]["ListValueHeaderId"].Text);
                    terminationFeedbackDetails.QuestionId_ANS = Convert.ToInt32(dgTerminationQuestionnaire.Items[i]["TerminationFeedBackQId"].Text);
                    terminationFeedbackDetails.Remark_ANS = dgTerminationQuestionnaire.Items[i]["Remark"].Text;
                    terminationFeedbackDetails.TerminationFeedbackQuestionWiseAnswersId = 1;
                    terminationFeedbackDetails.User = Convert.ToInt32(Session["UserId"]);

                    terminationFeedbackDetailsService.Insert_ANS(terminationFeedbackDetails);
                    DataBaseTransactions.CommitTransactions();
                   
                    this.ShowSuccessfulNotification("Feedback inserted successfully.");
                    

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

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Insert();

            terminationFeedbackDetails = new TerminationFeedbackDetails();
            terminationFeedbackDetails.User = Convert.ToInt32(Session["UserId"]);

            if (terminationFeedbackDetailsService.SelectAll_ANSByUser(terminationFeedbackDetails).Rows.Count == 0)
            {
                dgTerminationQuestionnaire.Visible = true;
                GenerateGridForAnswers();
            }
            
        }
    }
}