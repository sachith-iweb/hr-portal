using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DOMAIN;
using DATA;
using System.Data;
namespace SERVICE
{
    public class TalentSubCategoryDetailsService
    {
        TalentSubCategoryDetailsEntry talentSubCategoryDetailsEntry = new TalentSubCategoryDetailsEntry();

        public void Insert(TalentSubCategoryDetails talentSubCategoryDetails)
        {
            talentSubCategoryDetailsEntry.Insert(talentSubCategoryDetails,"I");
        }

        public void Update(TalentSubCategoryDetails talentSubCategoryDetails)
        {
            talentSubCategoryDetailsEntry.Insert(talentSubCategoryDetails,"I");
        }

        public DataTable SelectAll()
        {
            return talentSubCategoryDetailsEntry.SelectAll();
        }

        public DataTable SelectAllIsActives(TalentSubCategoryDetails talentSubCategoryDetails)
        {
            return talentSubCategoryDetailsEntry.SelectAllIsActives(talentSubCategoryDetails);
        }
        
        public DataTable SelectAllIsActivesAndCatId(TalentSubCategoryDetails talentSubCategoryDetails)
        {
            return talentSubCategoryDetailsEntry.SelectAllIsActivesAndCatId(talentSubCategoryDetails);
        }

        public DataTable SelectSubCatByNameAndCat(TalentSubCategoryDetails talentSubCategoryDetails)
        {
            return talentSubCategoryDetailsEntry.SelectSubCatByNameAndCat(talentSubCategoryDetails);
        }

        public void Delete(TalentSubCategoryDetails talentSubCategoryDetails)
        {
            talentSubCategoryDetailsEntry.Delete(talentSubCategoryDetails);
        }
    }
}
