using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DOMAIN;

using System.Data;

namespace DATA
{
    public class TalentSubCategoryDetailsEntry
    {
        public void Insert(TalentSubCategoryDetails talentSubCategoryDetails, string operation)
        {
            Dictionary<string, object> spParamter = new Dictionary<string, object>();
            spParamter.Add(WellKnownParameters.TalentSubCategoryDetails.IsActive, talentSubCategoryDetails.IsActive);
            spParamter.Add(WellKnownParameters.TalentSubCategoryDetails.Operation, operation);
            spParamter.Add(WellKnownParameters.TalentSubCategoryDetails.TalentCategoryId, talentSubCategoryDetails.TalentCategoryId);
            spParamter.Add(WellKnownParameters.TalentSubCategoryDetails.TalentSubCategoryId, talentSubCategoryDetails.TalentSubCategoryId);
            spParamter.Add(WellKnownParameters.TalentSubCategoryDetails.TalentSubCatName, talentSubCategoryDetails.TalentSubCatName);
            spParamter.Add(WellKnownParameters.TalentSubCategoryDetails.UserId, talentSubCategoryDetails.UserId);

            DataBaseUtilities.DataBaseUtilities.Insert("InsertTalentSubCategory", spParamter);
        }

        public DataTable SelectAll() 
        {
            // Gets All Subcategories Which have active category
            return DataBaseUtilities.DataBaseUtilities.Select("SelectAllTalentSubCategory");
            }

        public DataTable SelectAllIsActives(TalentSubCategoryDetails talentSubCategoryDetails)
        {
            Dictionary<string, object> spParamter = new Dictionary<string, object>();
            spParamter.Add(WellKnownParameters.TalentSubCategoryDetails.IsActive, talentSubCategoryDetails.IsActive);

            return DataBaseUtilities.DataBaseUtilities.Select("SelectAllTalentSubCategory", spParamter);
        }

        public DataTable SelectAllIsActivesAndCatId(TalentSubCategoryDetails talentSubCategoryDetails)
        {
            Dictionary<string, object> spParamter = new Dictionary<string, object>();
            spParamter.Add(WellKnownParameters.TalentSubCategoryDetails.TalentCategoryId, talentSubCategoryDetails.TalentCategoryId);
            spParamter.Add(WellKnownParameters.TalentSubCategoryDetails.IsActive, talentSubCategoryDetails.IsActive);

            return DataBaseUtilities.DataBaseUtilities.Select("SelectAllTalentSubCategory", spParamter);
        }

        public DataTable SelectSubCatByNameAndCat(TalentSubCategoryDetails talentSubCategoryDetails)
        {
            Dictionary<string, object> spParamter = new Dictionary<string, object>();
            spParamter.Add(WellKnownParameters.TalentSubCategoryDetails.TalentSubCatName, talentSubCategoryDetails.TalentSubCatName);
            spParamter.Add(WellKnownParameters.TalentSubCategoryDetails.TalentCategoryId, talentSubCategoryDetails.TalentCategoryId);

            return DataBaseUtilities.DataBaseUtilities.Select("SelectAllTalentSubCategory", spParamter);
        }

        public void Delete(TalentSubCategoryDetails talentSubCategoryDetails)
        {
            Dictionary<string, object> spParamter = new Dictionary<string, object>();
            spParamter.Add(WellKnownParameters.TalentSubCategoryDetails.TalentSubCategoryId, talentSubCategoryDetails.TalentSubCategoryId);

            DataBaseUtilities.DataBaseUtilities.Delete("DeleteTalentSubCategory", spParamter);
        }

    }
}
