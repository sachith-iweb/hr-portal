using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DATA;
using DOMAIN;
using System.Data;

namespace SERVICE
{
    public class TalentCategoryDetailsService
    {
        TalentCategoryDetailsEntry talentCategoryDetailsEntry = new TalentCategoryDetailsEntry();

        public void Insert(TalentCategoryDetails talentCategoryDetails)
        {
            talentCategoryDetailsEntry.Insert(talentCategoryDetails, "I");
        }

        public void Update(TalentCategoryDetails talentCategoryDetails)
        {
            talentCategoryDetailsEntry.Insert(talentCategoryDetails, "U");
        }

        public DataTable SelectAll()
        {
            return talentCategoryDetailsEntry.SelectAll();
        }

        public DataTable SelectAllIsActive(TalentCategoryDetails talentCategoryDetails)
        {
            return talentCategoryDetailsEntry.SelectAllIsActive(talentCategoryDetails);
        }

        public DataTable SelectAllByCatName(TalentCategoryDetails talentCategoryDetails)
        {
            return talentCategoryDetailsEntry.SelectAllByCatName(talentCategoryDetails);
        }
        public void Delete(TalentCategoryDetails talentCategoryDetails)
        {
            talentCategoryDetailsEntry.Delete(talentCategoryDetails);
        }



    }
}
