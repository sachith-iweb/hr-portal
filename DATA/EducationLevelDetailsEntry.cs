using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DOMAIN;
using System.Data;

namespace DATA
{
    public class EducationLevelDetailsEntry
    {
        public DataTable SelectAllActiveEducationLevels()
        {
            return DataBaseUtilities.DataBaseUtilities.Select("SelectAllActiveEducationLevelDetails");
        }

       
    }
}
