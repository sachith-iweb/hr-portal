using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DOMAIN;
using DATA;

namespace SERVICE
{
    public class TerminationFeedbackDetailsService
    {

        #region Termination Feedback Template

        TerminationFeedbackDetailsEntry terminationFeedbackDetailsEntry = new TerminationFeedbackDetailsEntry();

        public void Insert(TerminationFeedbackDetails terminationFeedbackDetails)
        {
            terminationFeedbackDetailsEntry.Insert(terminationFeedbackDetails, "I");    
        }

        public void Update(TerminationFeedbackDetails terminationFeedbackDetails)
        {
            terminationFeedbackDetailsEntry.Insert(terminationFeedbackDetails,"U");
        }

        public DataTable SelectAll()
        {
            return terminationFeedbackDetailsEntry.SelectAll();
        }
        public DataTable SelectAllQuestionsIsActive()
        {
            return terminationFeedbackDetailsEntry.SelectAllQuestionsIsActive();
        }
        public DataTable SelectThisByTerminationQuestion(TerminationFeedbackDetails terminationFeedbackDetails)
        {
            return terminationFeedbackDetailsEntry.SelectThisByTerminationQuestion(terminationFeedbackDetails);
        }

        public void Delete(TerminationFeedbackDetails terminationFeedbackDetails)
        {
            terminationFeedbackDetailsEntry.Delete(terminationFeedbackDetails);
        }

        #endregion


        #region Termination Feedback Answers

        public void Insert_ANS(TerminationFeedbackDetails terminationFeedbackDetails)
        {
            terminationFeedbackDetailsEntry.Insert_ANS(terminationFeedbackDetails, "I");
        }

        public void Update_ANS(TerminationFeedbackDetails terminationFeedbackDetails)
        {
            terminationFeedbackDetailsEntry.Insert(terminationFeedbackDetails, "U");
        }

        public DataTable SelectAll_ANS()
        {
            return terminationFeedbackDetailsEntry.SelectAll_ANS();
        }

        public DataTable SelectAll_ANSByUser(TerminationFeedbackDetails terminationFeedbackDetails)
        {
            return terminationFeedbackDetailsEntry.SelectAll_ANSByUser(terminationFeedbackDetails);
        }

        public void Delete_ANS(TerminationFeedbackDetails terminationFeedbackDetails)
        {
            terminationFeedbackDetailsEntry.Delete_ANS(terminationFeedbackDetails);
        }

        #endregion

        public DataTable SelectThisTerminationInitiationByUser(int user)
        {
            return terminationFeedbackDetailsEntry.SelectThisTerminationInitiationByUser(user);
        }

    }
}
