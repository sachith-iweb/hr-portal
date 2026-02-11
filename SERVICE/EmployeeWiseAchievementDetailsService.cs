using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DOMAIN;
using DATA;
using System.Data;

namespace SERVICE
{
    public class EmployeeWiseAchievementDetailsService
    {
        EmployeeWiseAchievementDetailsEntry employeeWiseAchievementDetailsEntry = new EmployeeWiseAchievementDetailsEntry();

        public void Insert(EmployeeWiseAchievementDetails employeeWiseAchievementDetails) 
        {
            employeeWiseAchievementDetailsEntry.Insert(employeeWiseAchievementDetails, "I");
         
        }
        
        public DataTable SelectThisByEmpId(EmployeeWiseAchievementDetails employeeWiseAchievementDetails)
        {
            return employeeWiseAchievementDetailsEntry.SelectThisByEmpId(employeeWiseAchievementDetails);
        }

        public DataTable SelectEmployeeWiseAchievementDetailsNotApproved(EmployeeWiseAchievementDetails employeeWiseAchievementDetails)
        {
            return employeeWiseAchievementDetailsEntry.SelectEmployeeWiseAchievementDetailsNotApproved(employeeWiseAchievementDetails);
        }
               
    }
}
