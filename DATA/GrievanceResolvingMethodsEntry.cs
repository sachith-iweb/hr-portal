using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DOMAIN;
using System.Data;

namespace DATA
{
    public class GrievanceResolvingMethodsEntry
    {
        public DataTable Select()
        {
            return DataBaseUtilities.DataBaseUtilities.Select("SelectGrievanceResolvingMethods");
        }
    }
}
