using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DOMAIN;
using DATA;
using System.Data;


namespace SERVICE
{
    public class CompanyDetailsService
    {
        CompanyDetailsEntry companyDetailsentry = new CompanyDetailsEntry();   

        public void Insert(CompanyDetails companyDetails)
        {
            companyDetailsentry.Insert(companyDetails, "I");
        }

        public void Update(CompanyDetails companyDetails)
        {
            companyDetailsentry.Insert(companyDetails, "U");
        }

        public DataTable Select()        
        {            
            return companyDetailsentry.Select();
        }

        public DataTable Select(CompanyDetails companyDetails)
        {
            return companyDetailsentry.Select(companyDetails);
        }

        public DataTable SelectThis(CompanyDetails companyDetails)
        {
            return companyDetailsentry.SelectThisByCommpanyName(companyDetails);
        }

        public DataTable SelectThisByCompanyId(CompanyDetails companyDetails)
        {
            return companyDetailsentry.SelectThisByCommpanyId(companyDetails);
        }

        public void Delete(CompanyDetails companyDetails)
        {
            companyDetailsentry.Delete(companyDetails);
        }

        
    }
}
