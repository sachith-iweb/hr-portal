using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DOMAIN;
using DATA;


namespace SERVICE
{
    public class GrievanceInitiateService
    {
        public DataTable InitiateGrievacne(GrievanceInitiate grievanceInitiate)
        {
            return new GrievanceInitiateEntry().InitiateGrievacne(grievanceInitiate);
        }

        public void InsertEmployeeWiseGrievanceIssues(int employeeWiseGrievanceId, int GrievanceCategoryId, int GrievanceIssueId)
        {
            new GrievanceInitiateEntry().InsertEmployeeWiseGrievanceIssues(employeeWiseGrievanceId,GrievanceCategoryId,GrievanceIssueId);
        }

        public void InsertEmployeeWiseGrievanceIncidence(string employeeWiseGrievanceId, string DateTime, string Incident)
        {
            new GrievanceInitiateEntry().InsertEmployeeWiseGrievanceIncidence(employeeWiseGrievanceId, DateTime, Incident);
        }

        public void InsertEmployeeWiseGrievancePeopleInvolved(int employeeWiseGrievanceId, string DepartmentId, string DesignationId, string EmployeeId)
        {
            new GrievanceInitiateEntry().InsertEmployeeWiseGrievancePeopleInvolved(employeeWiseGrievanceId, DepartmentId, DesignationId,EmployeeId);
        }
    }
}
