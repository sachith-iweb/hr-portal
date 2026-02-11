using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DATA;
using DOMAIN;
using System.Data;

namespace SERVICE
{
    public class EmployeeDetailsService
    {
        EmployeeDetailsEntry employeeDetailsEntry = new EmployeeDetailsEntry();
        
        public DataTable Select(EmployeeDetails employeeDetails) 
        {
            return employeeDetailsEntry.Select(employeeDetails);
        }

        public DataTable SelectAllActiveTerminationInitiatedEmployeeDetails(EmployeeDetails employeeDetails) 
        {
            return employeeDetailsEntry.SelectAllActiveTerminationInitiatedEmployeeDetails(employeeDetails);
        }

        public DataTable SelectAllActiveEmployeeDetails(EmployeeDetails employeeDetails, int processID = -999) 
        {
            return employeeDetailsEntry.SelectAllActiveEmployeeDetails(employeeDetails,processID);
        }

        public DataTable SelectAllowDesignationEmployees(EmployeeDetails employeeDetails)
        {
            return employeeDetailsEntry.SelectAllowDesignationEmployees(employeeDetails);
        }

        public DataTable SelectThis(EmployeeDetails employeeDetails) 
        {
            return employeeDetailsEntry.SelectThis(employeeDetails);
        }

        public DataTable SelectThisEmployeeDetailsByEmployeeId(EmployeeDetails employeeDetails)
        {
            return employeeDetailsEntry.SelectThisEmployeeDetailsByEmployeeId(employeeDetails);
        }

        public DataTable SelectAllCurrentDesignation(EmployeeDetails employeeDetails) 
        {
            return employeeDetailsEntry.SelectAllCurrentDesignation(employeeDetails);
        }

        public void Delete(EmployeeDetails employeeDetails) 
        {
            employeeDetailsEntry.Delete(employeeDetails);
        }

        public DataTable SelectThisEmployeeByCmpAndDesigDepartment(EmployeeDetails employeeDetails)
        {
            return employeeDetailsEntry.SelectThisEmployeeByCmpAndDesigDepartment(employeeDetails);
        }

        public DataTable SelectThisEmployeeDetailsIdForReportUserProfile(EmployeeDetails employeeDetails)
        {
            return employeeDetailsEntry.SelectThisEmployeeDetailsIdForReportUserProfile(employeeDetails);
        }
        public DataTable SelectAllEmployeeWiseStatusForProcess(EmployeeDetails employeeDetails, int UserId = -999, int processId = -999)
        {
            return employeeDetailsEntry.SelectAllEmployeeWiseStatusForProcess(employeeDetails, UserId,processId);
        }
    }
}
