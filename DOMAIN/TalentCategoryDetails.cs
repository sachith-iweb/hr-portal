using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOMAIN
{
    public class TalentCategoryDetails
    {
        public int TalentCategoryId { get; set; }
        public string TalentCatName { get; set; }
        public bool IsActive { get; set; }
        public int UserId { get; set; }
    }
}
