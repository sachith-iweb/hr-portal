using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DOMAIN;
using System.Data;

namespace DATA
{
    public class TalentCategoryDetailsEntry
    {
        public void Insert(TalentCategoryDetails talentCategoryDetails, string operation)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();

            spParameters.Add(WellKnownParameters.TalentCategoryDetails.IsActive, talentCategoryDetails.IsActive);
            spParameters.Add(WellKnownParameters.TalentCategoryDetails.Operation, operation);
            spParameters.Add(WellKnownParameters.TalentCategoryDetails.TalentCategoryId, talentCategoryDetails.TalentCategoryId);
            spParameters.Add(WellKnownParameters.TalentCategoryDetails.TalentCatName, talentCategoryDetails.TalentCatName);
            spParameters.Add(WellKnownParameters.TalentCategoryDetails.UserId, talentCategoryDetails.UserId);

            DataBaseUtilities.DataBaseUtilities.Insert("InsertTalentCategoryDetails", spParameters);
        }

        public DataTable SelectAll()
        {
            return DataBaseUtilities.DataBaseUtilities.Select("SelectAllTalentCategoryDetails");
        }

        public DataTable SelectAllIsActive(TalentCategoryDetails talentCategoryDetails)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add(WellKnownParameters.TalentCategoryDetails.IsActive, talentCategoryDetails.IsActive);
            return DataBaseUtilities.DataBaseUtilities.Select("SelectAllTalentCategoryDetails",spParameters);
        }

        public DataTable SelectAllByCatName(TalentCategoryDetails talentCategoryDetails)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add(WellKnownParameters.TalentCategoryDetails.TalentCatName, talentCategoryDetails.TalentCatName);
            return DataBaseUtilities.DataBaseUtilities.Select("SelectAllTalentCategoryDetails", spParameters);
        }

        public void Delete(TalentCategoryDetails talentCategoryDetails)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add(WellKnownParameters.TalentCategoryDetails.TalentCategoryId, talentCategoryDetails.TalentCategoryId);
            DataBaseUtilities.DataBaseUtilities.Delete("DeleteTalentCategoryDetails", spParameters);
        }
    }
}
