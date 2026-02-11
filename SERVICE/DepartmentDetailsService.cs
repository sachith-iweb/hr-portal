using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DOMAIN;
using System.Data;
using DATA;

namespace SERVICE
{
    public class DepartmentDetailsService
    {
        DepartmentDetailsEntry departmentDetailsEntry = new DepartmentDetailsEntry();
        
        public DataTable SelectAllActiveDepartment(DepartmentDetails departmentDetails)
        {
            return departmentDetailsEntry.SelectAllActiveDepartment(departmentDetails);
        }

        
    }
}
