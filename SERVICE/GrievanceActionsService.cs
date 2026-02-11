using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DOMAIN;
using DATA;
using System.Data;

namespace SERVICE
{
    public class GrievanceActionsService
    {
        public DataTable Select(GrievanceActions grievanceActions)
        {
            return new GrievanceActionsEntry().Select(grievanceActions);
        }
    }
}
