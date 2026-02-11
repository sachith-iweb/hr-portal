using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DOMAIN;
using DATA;
using System.Data;

namespace SERVICE
{
    public class CompanyWiseLeaveUnitsService
    {
        CompanyWiseLeaveUnitsEntry companyWiseLeaveUnitsEntry = new CompanyWiseLeaveUnitsEntry();

        public void Insert(CompanyWiseLeaveUnitsDetails companyWiseLeaveUnitsDetails)
        {
            companyWiseLeaveUnitsEntry.Insert(companyWiseLeaveUnitsDetails, "I");
        }

        public void Update(CompanyWiseLeaveUnitsDetails companyWiseLeaveUnitsDetails)
        {
            companyWiseLeaveUnitsEntry.Insert(companyWiseLeaveUnitsDetails, "U");
        }

        public DataTable Select(CompanyWiseLeaveUnitsDetails companyWiseLeaveUnitsDetails)
        {
            return companyWiseLeaveUnitsEntry.Select(companyWiseLeaveUnitsDetails);
        }

        public DataTable SelectThis(CompanyWiseLeaveUnitsDetails companyWiseLeaveUnitsDetails)
        {
            return companyWiseLeaveUnitsEntry.SelectThis(companyWiseLeaveUnitsDetails);
        }

        public DataTable SelectThisCompanyWiseLeaveUnitsByLeaveUnit(CompanyWiseLeaveUnitsDetails companyWiseLeaveUnitsDetails)
        {
            return companyWiseLeaveUnitsEntry.SelectThisCompanyWiseLeaveUnitsByLeaveUnit(companyWiseLeaveUnitsDetails);
        }

        public void Delete(CompanyWiseLeaveUnitsDetails companyWiseLeaveUnitsDetails)
        {
            companyWiseLeaveUnitsEntry.Delete(companyWiseLeaveUnitsDetails);
        }
    }
}
