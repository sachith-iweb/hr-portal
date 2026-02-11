using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DOMAIN;
using System.Data;

namespace DATA
{
    public class EmployeeWiseAchievementDetailsEntry
    {
        public void Insert(EmployeeWiseAchievementDetails employeeWiseAchievementDetails, string operation) 
        {
            Dictionary<string, object> spParameter = new Dictionary<string, object>();

            spParameter.Add(WellKnownParameters.EmployeeWiseAchievementDetails.achievement, employeeWiseAchievementDetails.Achievement);
            spParameter.Add(WellKnownParameters.EmployeeWiseAchievementDetails.createdUserId, employeeWiseAchievementDetails.CreatedUserId);
            spParameter.Add(WellKnownParameters.EmployeeWiseAchievementDetails.employeeID, employeeWiseAchievementDetails.EmployeeID);
            spParameter.Add(WellKnownParameters.EmployeeWiseAchievementDetails.employeeWiseAchievementId, employeeWiseAchievementDetails.EmployeeWiseAchievementId);
            spParameter.Add(WellKnownParameters.EmployeeWiseAchievementDetails.isActive, employeeWiseAchievementDetails.IsActive);
            spParameter.Add(WellKnownParameters.EmployeeWiseAchievementDetails.modifiedUserId, employeeWiseAchievementDetails.ModifiedUserId);
            spParameter.Add(WellKnownParameters.EmployeeWiseAchievementDetails.Operation, operation);
            spParameter.Add(WellKnownParameters.EmployeeWiseAchievementDetails.remarks, employeeWiseAchievementDetails.Remarks);
            spParameter.Add(WellKnownParameters.EmployeeWiseAchievementDetails.yearDate, employeeWiseAchievementDetails.YearDate);

            DataBaseUtilities.DataBaseUtilities.Insert("EmployeeProfile_InsertEmployeeWiseAchievementDetails", spParameter);
        }

      
        public DataTable SelectThisByEmpId(EmployeeWiseAchievementDetails employeeWiseAchievementDetails)
        {
            Dictionary<string, object> spParameter = new Dictionary<string, object>();
            spParameter.Add(WellKnownParameters.EmployeeWiseAchievementDetails.employeeID, employeeWiseAchievementDetails.EmployeeID);
            return DataBaseUtilities.DataBaseUtilities.Select("SelectThisEmployeeWiseAchievementDetailByEmployeeId", spParameter);
        }

        public DataTable SelectEmployeeWiseAchievementDetailsNotApproved(EmployeeWiseAchievementDetails employeeWiseAchievementDetails)
        {
            Dictionary<string, object> spParameter = new Dictionary<string, object>();
            spParameter.Add(WellKnownParameters.EmployeeWiseAchievementDetails.employeeID, employeeWiseAchievementDetails.EmployeeID);
            spParameter.Add(WellKnownParameters.EmployeeWiseAchievementDetails.employeeWiseAchievementId, employeeWiseAchievementDetails.EmployeeWiseAchievementId);
            return DataBaseUtilities.DataBaseUtilities.Select("EmployeeProfile_SelectEmployeeWiseAchievementDetailsNotApproved", spParameter);
        }


    }
}
