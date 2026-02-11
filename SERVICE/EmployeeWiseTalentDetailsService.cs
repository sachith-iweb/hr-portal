using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DOMAIN;
using DATA;
using System.Data;

namespace SERVICE
{
    public class EmployeeWiseTalentDetailsService
    {
        EmployeeWiseTalentDetailsEntry employeeWiseTalentDetailsEntry = new EmployeeWiseTalentDetailsEntry();

        public void Insert(EmployeeWiseTalentDetails employeeWiseTalentDetails)
        {
            employeeWiseTalentDetailsEntry.Insert(employeeWiseTalentDetails,"I");
        }

        public void Update(EmployeeWiseTalentDetails employeeWiseTalentDetails)
        {
            employeeWiseTalentDetailsEntry.Insert(employeeWiseTalentDetails, "U");
        }

        public DataTable SelectAll(string employeeId)
        {
            return employeeWiseTalentDetailsEntry.SelectAll(employeeId);
        }

        public void Delete(EmployeeWiseTalentDetails employeeWiseTalentDetails)
        {
            employeeWiseTalentDetailsEntry.Delete(employeeWiseTalentDetails);
        }
    }
}
