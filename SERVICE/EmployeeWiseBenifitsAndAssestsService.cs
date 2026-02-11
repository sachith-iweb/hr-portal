using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DATA;
using System.Data;

namespace SERVICE
{
    public class EmployeeWiseBenifitsAndAssestsService
    {
        public DataTable SelectBenifitHeader(string employeeId)
        {
            return new EmployeeWiseBenifitsAndAssestsEntry().SelectBenifitHeader(employeeId);
        }
    }
}