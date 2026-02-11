using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using DOMAIN;
using DATA;

namespace DATA
{
    public class CompanyWiseLeaveCalanderEntry
    {
        public void Insert(CompanyWiseLeaveCalander companyWiseLeaveCalander, string opertation)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, Object>();
            spParameters.Add("@Id", companyWiseLeaveCalander.Id);   
            spParameters.Add("@CompanyId", companyWiseLeaveCalander.CompanyId);
            spParameters.Add("@FinancialYear", companyWiseLeaveCalander.FinancialYear);
            spParameters.Add("@LeaveTypeId", companyWiseLeaveCalander.LeaveTypeId);
            spParameters.Add("@LeaveUnitId", companyWiseLeaveCalander.LeaveUnitId);
            spParameters.Add("@Date", companyWiseLeaveCalander.Date);
            spParameters.Add("@Remark", companyWiseLeaveCalander.Remark);
            spParameters.Add("@IsActive", companyWiseLeaveCalander.IsActive);
            spParameters.Add("@UserId", companyWiseLeaveCalander.UserId);
            spParameters.Add("@Operation", opertation);
            DataBaseUtilities.DataBaseUtilities.Insert("InsertCompanyLeaveCalander", spParameters); 

        }       

        public DataTable Select(CompanyWiseLeaveCalander companyWiseLeaveCalander)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, Object>();
            spParameters.Add("@Id", companyWiseLeaveCalander.Id);
            spParameters.Add("@CompanyId", companyWiseLeaveCalander.CompanyId);
            spParameters.Add("@FinancialYear", companyWiseLeaveCalander.FinancialYear);
            spParameters.Add("@LeaveTypeId", companyWiseLeaveCalander.LeaveTypeId);
            spParameters.Add("@LeaveUnitId", companyWiseLeaveCalander.LeaveUnitId);             
            spParameters.Add("@IsActive", companyWiseLeaveCalander.IsActive);

            return DataBaseUtilities.DataBaseUtilities.Select("SelectCompanyLeaveCalander", spParameters);
        }

        public DataTable SelectNoOfCompanyLeaveDatesInReqestedDateRange(DateTime fromDate , DateTime toDate, int companyId)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, Object>();
            spParameters.Add("@FromDate", fromDate);
            spParameters.Add("@ToDate", toDate);
            spParameters.Add("@CompanyId", companyId);
            return DataBaseUtilities.DataBaseUtilities.Select("SelectNoOfCompanyLeaveDatesInReqestedDateRange", spParameters);
        }



        public void Delete(CompanyWiseLeaveCalander companyWiseLeaveCalander)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, Object>();
            spParameters.Add("@Id", companyWiseLeaveCalander.Id);
            DataBaseUtilities.DataBaseUtilities.Delete("DeleteCompanyLeaveCalander", spParameters);

        }
    }
}
