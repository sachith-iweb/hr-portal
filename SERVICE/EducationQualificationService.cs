using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DATA;
using System.Data;

namespace SERVICE
{
    public class EducationQualificationService
    {
        public DataTable SelectAllActiveEducationLevels()
        {
            return new EducationLevelDetailsEntry().SelectAllActiveEducationLevels();
        }
    }
}