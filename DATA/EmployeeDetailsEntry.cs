using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DOMAIN;
using System.Data;

namespace DATA
{
    public class EmployeeDetailsEntry
    {
        
        public DataTable Select(EmployeeDetails employeeDetails)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add(WellKnownParameters.EmployeeDetails.companyId, employeeDetails.CompanyID);
            spParameters.Add(WellKnownParameters.EmployeeDetails.departmentID, employeeDetails.DepartmentID);
            spParameters.Add(WellKnownParameters.EmployeeDetails.designationID, employeeDetails.DesignationID);
            spParameters.Add(WellKnownParameters.EmployeeDetails.employeeID, employeeDetails.EmployeeID);  
            return DataBaseUtilities.DataBaseUtilities.Select("SelectAllEmployeeDetails",spParameters);
        }

        public DataTable SelectAllActiveEmployeeDetails(EmployeeDetails employeeDetails, int processID = -999)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add(WellKnownParameters.EmployeeDetails.companyId, employeeDetails.CompanyID);
            spParameters.Add(WellKnownParameters.EmployeeDetails.departmentID, employeeDetails.DepartmentID);
            spParameters.Add(WellKnownParameters.EmployeeDetails.designationID, employeeDetails.DesignationID);
            spParameters.Add(WellKnownParameters.EmployeeDetails.processId, processID);
            //return DataBaseUtilities.DataBaseUtilities.Select(WellKnownStoredProcedures.SelectSPs.SelectAllActiveEmployeeDetails, spParameters);

            return DataBaseUtilities.DataBaseUtilities.Select("SelectAllEmployeeWiseStatusForProcess", spParameters);
        }

        public DataTable SelectAllActiveTerminationInitiatedEmployeeDetails(EmployeeDetails employeeDetails)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add(WellKnownParameters.EmployeeDetails.companyId, employeeDetails.CompanyID);
            spParameters.Add(WellKnownParameters.EmployeeDetails.departmentID, employeeDetails.DepartmentID);
            spParameters.Add(WellKnownParameters.EmployeeDetails.designationID, employeeDetails.DesignationID);
            return DataBaseUtilities.DataBaseUtilities.Select("SelectAllActiveTerminationInitiatedEmployeeDetails", spParameters);
        }

        public DataTable SelectAllowDesignationEmployees(EmployeeDetails employeeDetails)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add(WellKnownParameters.EmployeeDetails.companyId, employeeDetails.CompanyID);
            spParameters.Add(WellKnownParameters.EmployeeDetails.departmentID, employeeDetails.DepartmentID);
            spParameters.Add(WellKnownParameters.EmployeeDetails.designationID, employeeDetails.DesignationID);          
            return DataBaseUtilities.DataBaseUtilities.Select("SelectEmployeesWhoHasPromotionAllowPermissions", spParameters);
        }

        public DataTable SelectThis(EmployeeDetails employeeDetails)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add(WellKnownParameters.EmployeeDetails.employeeCode, employeeDetails.EmployeeCode);

            return DataBaseUtilities.DataBaseUtilities.Select("SelectThisEmployeeDetails", spParameters);
        }

        public DataTable SelectThisEmployeeDetailsByEmployeeId(EmployeeDetails employeeDetails) 
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add(WellKnownParameters.EmployeeDetails.employeeID, employeeDetails.EmployeeID);

            return DataBaseUtilities.DataBaseUtilities.Select("SelectThisEmployeeDetailsByEmployeeId", spParameters);
        }

        public DataTable SelectAllCurrentDesignation(EmployeeDetails employeeDetails) 
        {
            Dictionary<string, object> spParameter = new Dictionary<string, object>();

            spParameter.Add(WellKnownParameters.EmployeeDetails.employeeID, employeeDetails.EmployeeID);
            spParameter.Add(WellKnownParameters.EmployeeDetails.companyId, employeeDetails.CompanyID);

            return DataBaseUtilities.DataBaseUtilities.Select("SelectAllCurrentDesignationFromEmployee", spParameter);


        }

        public void Delete(EmployeeDetails employeeDetails)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add(WellKnownParameters.EmployeeDetails.employeeID, employeeDetails.EmployeeID);
            spParameters.Add(WellKnownParameters.EmployeeDetails.companyId, employeeDetails.CompanyID);

            DataBaseUtilities.DataBaseUtilities.Delete("DeleteEmployeeDetails", spParameters);
        }

        public DataTable SelectThisEmployeeByCmpAndDesigDepartment(EmployeeDetails employeeDetails)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add(WellKnownParameters.EmployeeDetails.companyId, employeeDetails.CompanyID);
            spParameters.Add(WellKnownParameters.EmployeeDetails.departmentID, employeeDetails.DepartmentID);
            spParameters.Add(WellKnownParameters.EmployeeDetails.designationID, employeeDetails.DesignationID);

            return DataBaseUtilities.DataBaseUtilities.Select("rpt_SelectThisEmployeeDetails", spParameters);
        }

        public DataTable SelectThisEmployeeDetailsIdForReportUserProfile(EmployeeDetails employeeDetails)
        {
            Dictionary<string, object> spParameter = new Dictionary<string, object>();
            spParameter.Add(WellKnownParameters.EmployeeDetails.employeeID, employeeDetails.EmployeeID);

            return DataBaseUtilities.DataBaseUtilities.Select("SelectThisEmployeeDetailsByEmployeeIdForReport", spParameter);
        }
        public DataTable SelectAllEmployeeWiseStatusForProcess(EmployeeDetails employeeDetails,int UserId = -999, int processId = -999)
        {
            Dictionary<string, object> spParameter = new Dictionary<string, object>();
            spParameter.Add(WellKnownParameters.EmployeeDetails.companyId, employeeDetails.CompanyID);
            spParameter.Add(WellKnownParameters.EmployeeDetails.UserId, UserId);
            spParameter.Add(WellKnownParameters.EmployeeDetails.processId, processId);

            return DataBaseUtilities.DataBaseUtilities.Select("SelectAllEmployeeWiseStatusForProcess", spParameter);
        }

    }
}
