using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DOMAIN;
using DATA;

namespace SERVICE
{
    public class GrievanceResolvingMethodsService
    {
        public DataTable Select()
        {
            return new GrievanceResolvingMethodsEntry().Select();
        }
    }
}
