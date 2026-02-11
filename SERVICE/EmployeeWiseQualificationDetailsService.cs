using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DOMAIN;
using DATA;

namespace SERVICE
{
    public class EmployeeWiseQualificationDetailsService
    {
        EmployeeWiseQualificationDetailsEntry employeeWiseQualificationDetailsEntry = new EmployeeWiseQualificationDetailsEntry();

        public void Insert(EmployeeWiseQualificationDetails employeeWiseQualificationDetails) 
        {
            employeeWiseQualificationDetailsEntry.Insert(employeeWiseQualificationDetails, "I");
        }

               
        public DataTable SelectThisEmployeeId(EmployeeWiseQualificationDetails employeeWiseQualificationDetails)
        {
            return employeeWiseQualificationDetailsEntry.SelectThisEmployeeId(employeeWiseQualificationDetails);
        }

        public DataTable SelectEmployeeWiseQualificationsDetailNotApproved(EmployeeWiseQualificationDetails employeeWiseQualificationDetails)
        {
            return employeeWiseQualificationDetailsEntry.SelectEmployeeWiseQualificationsDetailNotApproved(employeeWiseQualificationDetails);
        }

       
    }
}
