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
    public class CompanyDetailsEntry
    {
        public void Insert(CompanyDetails companyDetails, string opertation)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, Object>();
            spParameters.Add(WellKnownParameters.CompanyDetails.companyId, companyDetails.CompanyId);
            spParameters.Add(WellKnownParameters.CompanyDetails.name, companyDetails.Name);
            spParameters.Add(WellKnownParameters.CompanyDetails.userId, companyDetails.CreatedOrModifiedUserId);
            spParameters.Add(WellKnownParameters.CompanyDetails.isActive, companyDetails.IsActive);

            spParameters.Add(WellKnownParameters.CompanyDetails.operation, opertation);
            DataBaseUtilities.DataBaseUtilities.Insert("InsertCompanyDetails", spParameters);

        }

        public DataTable Select()
        {
            return DataBaseUtilities.DataBaseUtilities.Select("SelectAllCompanyDetails");
        }

        public DataTable Select(CompanyDetails companyDetails)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, Object>();
            spParameters.Add(WellKnownParameters.CompanyDetails.userId, companyDetails.CreatedOrModifiedUserId);
            return DataBaseUtilities.DataBaseUtilities.Select("SelectAllUserWiseCompanyAccessDetailsByUserId", spParameters);
        }

        public DataTable SelectThisByCommpanyId(CompanyDetails companyDetails)
        {
            Dictionary<string, object> spParameter = new Dictionary<string, object>();
            spParameter.Add(WellKnownParameters.CompanyDetails.companyId, companyDetails.CompanyId);
            return DataBaseUtilities.DataBaseUtilities.Select("SelectThisCompanyDetailsByCompanyId", spParameter);
        }

        public DataTable SelectThisByCommpanyName(CompanyDetails companyDetails)
        {
            Dictionary<string, object> spParameter = new Dictionary<string, object>();
            spParameter.Add(WellKnownParameters.CompanyDetails.name, companyDetails.Name);
            return DataBaseUtilities.DataBaseUtilities.Select("SelectThisCompanyDetails", spParameter);
        }

        public void Delete(CompanyDetails companyDetails)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add(WellKnownParameters.CompanyDetails.companyId, companyDetails.CompanyId);
            DataBaseUtilities.DataBaseUtilities.Delete("DeleteThisCompanyDetails", spParameters);

        }
    }
}
