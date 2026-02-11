using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DOMAIN;
using System.Data;

namespace DATA
{
    public class EmployeeWiseQualificationDetailsEntry
    {

        public void Insert(EmployeeWiseQualificationDetails employeeWiseQualificationDetails, string operation) 
        {
            Dictionary<string, object> spParameter = new Dictionary<string, object>();

            spParameter.Add(WellKnownParameters.EmployeeWiseQualificationDetails.courseTitle, employeeWiseQualificationDetails.CourseTitle);
            spParameter.Add(WellKnownParameters.EmployeeWiseQualificationDetails.createdUserId, employeeWiseQualificationDetails.CreatedUserId);
            spParameter.Add(WellKnownParameters.EmployeeWiseQualificationDetails.educationLevelId, employeeWiseQualificationDetails.EducationLevelId);
            spParameter.Add(WellKnownParameters.EmployeeWiseQualificationDetails.employeeID, employeeWiseQualificationDetails.EmployeeID);
            spParameter.Add(WellKnownParameters.EmployeeWiseQualificationDetails.employeeWiseQualificationId, employeeWiseQualificationDetails.EmployeeWiseQualificationId);
            spParameter.Add(WellKnownParameters.EmployeeWiseQualificationDetails.institute, employeeWiseQualificationDetails.Institute);
            spParameter.Add(WellKnownParameters.EmployeeWiseQualificationDetails.isActive, employeeWiseQualificationDetails.IsActive);
            spParameter.Add(WellKnownParameters.EmployeeWiseQualificationDetails.modifiedUserId, employeeWiseQualificationDetails.ModifiedUserId);
            spParameter.Add(WellKnownParameters.EmployeeWiseQualificationDetails.Operation, operation);
            spParameter.Add(WellKnownParameters.EmployeeWiseQualificationDetails.remarks, employeeWiseQualificationDetails.Remarks);
            spParameter.Add(WellKnownParameters.EmployeeWiseQualificationDetails.yearOfCompletion, employeeWiseQualificationDetails.YearOfCompletion);

            DataBaseUtilities.DataBaseUtilities.Insert("EmployeeProfile_InsertEmployeeWiseQualificationsDetail", spParameter);
        }

        public DataTable SelectThisEmployeeId(EmployeeWiseQualificationDetails employeeWiseQualificationDetails)
        {
            Dictionary<string, object> spParameter = new Dictionary<string, object>();
            spParameter.Add(WellKnownParameters.EmployeeWiseQualificationDetails.employeeID, employeeWiseQualificationDetails.EmployeeID);
            return DataBaseUtilities.DataBaseUtilities.Select("SelectThisEmployeeWiseQualificationsDetailByEmpId", spParameter);
        }

        public DataTable SelectEmployeeWiseQualificationsDetailNotApproved(EmployeeWiseQualificationDetails employeeWiseQualificationDetails)
        {
            Dictionary<string, object> spParameter = new Dictionary<string, object>();
            spParameter.Add(WellKnownParameters.EmployeeWiseQualificationDetails.employeeID, employeeWiseQualificationDetails.EmployeeID);
            spParameter.Add(WellKnownParameters.EmployeeWiseQualificationDetails.employeeWiseQualificationId, employeeWiseQualificationDetails.EmployeeWiseQualificationId);
            return DataBaseUtilities.DataBaseUtilities.Select("EmployeeProfile_SelectEmployeeWiseQualificationsDetailNotApproved", spParameter);

        }

        //
       
    }
}
