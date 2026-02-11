using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOMAIN
{
    public class TalentSubCategoryDetails
    {
        public int TalentSubCategoryId { get; set; }
        public int TalentCategoryId { get; set; }
        public string TalentSubCatName { get; set; }
        public bool IsActive { get; set; }
        public int UserId { get; set; }
    }
}
