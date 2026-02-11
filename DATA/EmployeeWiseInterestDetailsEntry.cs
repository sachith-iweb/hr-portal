using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DOMAIN;


namespace DATA
{
    public class EmployeeWiseInterestDetailsEntry
    {
        public void Insert(EmployeeWiseInterestDetails employeeWiseInterestDetails,string operation)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add(WellKnownParameters.EmployeeWiseInterestDetails.EmployeeId, employeeWiseInterestDetails.EmployeeId);
            spParameters.Add(WellKnownParameters.EmployeeWiseInterestDetails.EmployeeWiseInterestId, employeeWiseInterestDetails.EmployeeWiseInterestId);
            spParameters.Add(WellKnownParameters.EmployeeWiseInterestDetails.Interest, employeeWiseInterestDetails.Interest);
            spParameters.Add(WellKnownParameters.EmployeeWiseInterestDetails.IsActive, employeeWiseInterestDetails.IsActive);
            spParameters.Add(WellKnownParameters.EmployeeWiseInterestDetails.Operation, operation);
            spParameters.Add(WellKnownParameters.EmployeeWiseInterestDetails.Remarks, employeeWiseInterestDetails.Remarks);
            spParameters.Add(WellKnownParameters.EmployeeWiseInterestDetails.UserId, employeeWiseInterestDetails.UserId);

            DataBaseUtilities.DataBaseUtilities.Insert("EmployeeProfile_InsertEmployeeWiseInterestDetails", spParameters);
        }

        public DataTable SelectThisByEmpId(EmployeeWiseInterestDetails employeeWiseInterestDetails)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add(WellKnownParameters.EmployeeWiseInterestDetails.EmployeeId, employeeWiseInterestDetails.EmployeeId);
            return DataBaseUtilities.DataBaseUtilities.Select("SelectThisEmployeeWiseInterestDetailsByEmployeeId", spParameters);
        }

        public DataTable SelectEmployeeWiseInterestDetailsNotApproved(EmployeeWiseInterestDetails employeeWiseInterestDetails)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add(WellKnownParameters.EmployeeWiseInterestDetails.EmployeeId, employeeWiseInterestDetails.EmployeeId);
            spParameters.Add(WellKnownParameters.EmployeeWiseInterestDetails.EmployeeWiseInterestId, employeeWiseInterestDetails.EmployeeWiseInterestId);
            return DataBaseUtilities.DataBaseUtilities.Select("EmployeeProfile_SelectEmployeeWiseInterestDetailsNotApproved", spParameters);
        }
     
    }
}
