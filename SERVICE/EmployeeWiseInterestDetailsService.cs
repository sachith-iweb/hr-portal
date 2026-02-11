using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DOMAIN;
using DATA;

namespace SERVICE
{
    public class EmployeeWiseInterestDetailsService
    {
        EmployeeWiseInterestDetailsEntry employeeWiseInterestDetailsEntry = new EmployeeWiseInterestDetailsEntry();

        public void Insert(EmployeeWiseInterestDetails employeeWiseInterestDetails)
        {
            employeeWiseInterestDetailsEntry.Insert(employeeWiseInterestDetails, "I");
        }
        
   
        public DataTable SelectThisByEmpId(EmployeeWiseInterestDetails employeeWiseInterestDetails)
        {
            return employeeWiseInterestDetailsEntry.SelectThisByEmpId(employeeWiseInterestDetails);
        }

        public DataTable SelectEmployeeWiseInterestDetailsNotApproved(EmployeeWiseInterestDetails employeeWiseInterestDetails)
        {
            return employeeWiseInterestDetailsEntry.SelectEmployeeWiseInterestDetailsNotApproved(employeeWiseInterestDetails);
        }
        
    }
}
