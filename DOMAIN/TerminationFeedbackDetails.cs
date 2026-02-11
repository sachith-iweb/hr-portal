using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOMAIN
{
    public class TerminationFeedbackDetails
    {
        #region Termination Feedback Templates

        public int TerminationFeedBackQId {get;set;} 
	    public string Question {get;set;}	   
        public int ListValueHeaderId {get;set;} 
	    public bool IsActive {get;set;}
	    public string Operation {get;set;}
        public int User { get; set; }
        
        #endregion

        #region Termination Feedback Answers

        public int TerminationFeedbackQuestionWiseAnswersId {get;set;}
	    public int QuestionId_ANS {get;set;} 
	    public int ListOfValueHeaderId_ANS {get;set;} 
	    public string BoundValue_ANS {get;set;}
        public string DisplayValue_ANS { get; set; }
        public string Remark_ANS {get;set;}  
	    //use user in termination feedback Template
        #endregion
    }
}
