using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DATA.DataBaseUtilities;
using DOMAIN;

namespace DATA
{
    public class TerminationFeedbackDetailsEntry
    {

        #region Termination Feedback Template
        public void Insert(TerminationFeedbackDetails terminationFeedbackDetails, string operation)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add(WellKnownParameters.TerminationFeedback.IsActive, terminationFeedbackDetails.IsActive);
            spParameters.Add(WellKnownParameters.TerminationFeedback.ListValueHeaderId, terminationFeedbackDetails.ListValueHeaderId);
            spParameters.Add(WellKnownParameters.TerminationFeedback.Operation, operation);
            spParameters.Add(WellKnownParameters.TerminationFeedback.Question, terminationFeedbackDetails.Question);
            spParameters.Add(WellKnownParameters.TerminationFeedback.TerminationFeedBackQId, terminationFeedbackDetails.TerminationFeedBackQId);
            spParameters.Add(WellKnownParameters.TerminationFeedback.User, terminationFeedbackDetails.User);


            DataBaseUtilities.DataBaseUtilities.Insert(WellKnownStoredProcedures.InsertSPs.InsertTerminationFeedbackQuestionaire, spParameters);

        }

        public DataTable SelectAll()
        {
            return DataBaseUtilities.DataBaseUtilities.Select(WellKnownStoredProcedures.SelectSPs.SelectAllTerminationFeedbackQuestionaire);
        }

        public DataTable SelectAllQuestionsIsActive()
        {
            Dictionary<string, object> spParameter = new Dictionary<string, object>();
            spParameter.Add(WellKnownParameters.TerminationFeedback.IsActive, true);

            return DataBaseUtilities.DataBaseUtilities.Select(WellKnownStoredProcedures.SelectSPs.SelectAllTerminationFeedbackQuestionaire,spParameter);
        }

        public DataTable SelectThisByTerminationQuestion(TerminationFeedbackDetails terminationFeedbackDetails)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add(WellKnownParameters.TerminationFeedback.Question, terminationFeedbackDetails.Question);

            return DataBaseUtilities.DataBaseUtilities.Select(WellKnownStoredProcedures.SelectSPs.SelectAllTerminationFeedbackQuestionaire,spParameters);
        }

        public void Delete(TerminationFeedbackDetails terminationFeedbackDetails)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add(WellKnownParameters.TerminationFeedback.TerminationFeedBackQId, terminationFeedbackDetails.TerminationFeedBackQId);

            DataBaseUtilities.DataBaseUtilities.Delete(WellKnownStoredProcedures.DeleteSPs.DeleteTerminationFeedbackQuestionaire, spParameters);
        }
        #endregion

        #region Termination Feedback Answers

        public void Insert_ANS(TerminationFeedbackDetails terminationFeedbackDetails, string operation)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add(WellKnownParameters.TerminationFeedbackAnswers.BoundValue, terminationFeedbackDetails.BoundValue_ANS);
            spParameters.Add(WellKnownParameters.TerminationFeedbackAnswers.DisplayValue, terminationFeedbackDetails.DisplayValue_ANS);
            spParameters.Add(WellKnownParameters.TerminationFeedbackAnswers.ListOfValueHeaderId, terminationFeedbackDetails.ListOfValueHeaderId_ANS);
            spParameters.Add(WellKnownParameters.TerminationFeedbackAnswers.Operation, operation);
            spParameters.Add(WellKnownParameters.TerminationFeedbackAnswers.QuestionId, terminationFeedbackDetails.QuestionId_ANS);
            spParameters.Add(WellKnownParameters.TerminationFeedbackAnswers.Remark, terminationFeedbackDetails.Remark_ANS);
            spParameters.Add(WellKnownParameters.TerminationFeedbackAnswers.TerminationFeedbackQuestionWiseAnswersId,terminationFeedbackDetails.TerminationFeedbackQuestionWiseAnswersId);
            spParameters.Add(WellKnownParameters.TerminationFeedbackAnswers.User, terminationFeedbackDetails.User);

            DataBaseUtilities.DataBaseUtilities.Insert(WellKnownStoredProcedures.InsertSPs.InsertTerminationFeedbackQuestionWiseAnswers, spParameters);
  
        }

        public DataTable SelectAll_ANS()
        {
            return DataBaseUtilities.DataBaseUtilities.Select(WellKnownStoredProcedures.SelectSPs.SelectAllTerminationFeedbackQuestionWiseAnswers);
        }

        public DataTable SelectAll_ANSByUser(TerminationFeedbackDetails terminationFeedbackDetails)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add(WellKnownParameters.TerminationFeedbackAnswers.User, terminationFeedbackDetails.User);
            return DataBaseUtilities.DataBaseUtilities.Select(WellKnownStoredProcedures.SelectSPs.SelectAllTerminationFeedbackQuestionWiseAnswers,spParameters);
        }



        public void Delete_ANS(TerminationFeedbackDetails terminationFeedbackDetails)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add(WellKnownParameters.TerminationFeedbackAnswers.TerminationFeedbackQuestionWiseAnswersId, terminationFeedbackDetails.TerminationFeedbackQuestionWiseAnswersId);

            DataBaseUtilities.DataBaseUtilities.Delete(WellKnownStoredProcedures.DeleteSPs.DeleteTerminationFeedbackQuestionWiseAnswers, spParameters);
        }

        
        
        #endregion

        public DataTable SelectThisTerminationInitiationByUser(int user)
        {
            Dictionary<string, object> spParameter = new Dictionary<string, object>();
            spParameter.Add("@UserId", user);

            return DataBaseUtilities.DataBaseUtilities.Select(WellKnownStoredProcedures.SelectSPs.SelectThisTerminationInitiationByUser, spParameter);
        }
    }
}
