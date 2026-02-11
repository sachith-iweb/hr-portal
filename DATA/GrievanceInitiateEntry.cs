using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DOMAIN;


namespace DATA
{
    public class GrievanceInitiateEntry
    {
        public DataTable InitiateGrievacne(GrievanceInitiate grievanceInitiate)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add("@CompanyId", grievanceInitiate.CompanyId);          
            spParameters.Add("@EmployeeId", grievanceInitiate.EmployeeId);
            spParameters.Add("@GrievanceCategoryId", grievanceInitiate.GrievanceCategoryId);
            spParameters.Add("@Description", grievanceInitiate.Description);
            spParameters.Add("@GrievanceSummary", grievanceInitiate.GrievanceSummary);
            spParameters.Add("@PreferredResolvingApprochId",grievanceInitiate.PreferredResolvingApprochId);
            spParameters.Add("@UserId", grievanceInitiate.UserId);
            return DataBaseUtilities.DataBaseUtilities.InsertWithSelect("InsertEmployeeWiseGrievanceDetails", spParameters);
        }

        public void InsertEmployeeWiseGrievanceIssues(int employeeWiseGrievanceId, int GrievanceCategoryId, int GrievanceIssueId)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add("@EmployeeWiseGrievanceId",employeeWiseGrievanceId);
            spParameters.Add("@GrievanceCategoryId", GrievanceCategoryId);
            spParameters.Add("@GrievanceIssueId", GrievanceIssueId); 
            DataBaseUtilities.DataBaseUtilities.Insert("InsertEmployeeWiseGrievanceIssues", spParameters);
        }

        public void InsertEmployeeWiseGrievanceIncidence(string employeeWiseGrievanceId, string DateTime, string Incident)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add("@EmployeeWiseGrievanceId", employeeWiseGrievanceId);
            spParameters.Add("@DateTime", Convert.ToDateTime(DateTime));
            spParameters.Add("@Incidence", Incident);
            DataBaseUtilities.DataBaseUtilities.Insert("InsertEmployeeWiseGrievanceIncidence", spParameters);
        }

        public void InsertEmployeeWiseGrievancePeopleInvolved(int employeeWiseGrievanceId, string DepartmentId, string DesignationId, string EmployeeId)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add("@EmployeeWiseGrievanceId", employeeWiseGrievanceId);
            spParameters.Add("@DepartmentId", DepartmentId);
            spParameters.Add("@DesignationId", DepartmentId);
            spParameters.Add("@EmployeeId", EmployeeId);
            DataBaseUtilities.DataBaseUtilities.Insert("InsertEmployeeWiseGrievanceWisePeopleInvolved", spParameters);
        }


    }
}
