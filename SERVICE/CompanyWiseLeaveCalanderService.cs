using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DOMAIN;
using DATA;
using System.Data;


namespace SERVICE
{
    public class CompanyWiseLeaveCalanderService
    {
        CompanyWiseLeaveCalanderEntry companyWiseLeaveCalanderEntry = new CompanyWiseLeaveCalanderEntry();

        public void Insert(CompanyWiseLeaveCalander companyWiseLeaveCalander)
        {
            companyWiseLeaveCalanderEntry.Insert(companyWiseLeaveCalander, "I");
        }

        public void Update(CompanyWiseLeaveCalander companyWiseLeaveCalander)
        {
            companyWiseLeaveCalanderEntry.Insert(companyWiseLeaveCalander, "U");
        }

        public DataTable Select(CompanyWiseLeaveCalander companyWiseLeaveCalander)        
        {
            return companyWiseLeaveCalanderEntry.Select(companyWiseLeaveCalander);
        }

        public DataTable SelectNoOfCompanyLeaveDatesInReqestedDateRange(DateTime fromDate, DateTime toDate, int companyId, int requestLeaveUnit)
        {
            return companyWiseLeaveCalanderEntry.SelectNoOfCompanyLeaveDatesInReqestedDateRange(fromDate, toDate, companyId, requestLeaveUnit);
        }

        public void Delete(CompanyWiseLeaveCalander companyWiseLeaveCalander)
        {
            companyWiseLeaveCalanderEntry.Delete(companyWiseLeaveCalander);
        }

        
    }
}
