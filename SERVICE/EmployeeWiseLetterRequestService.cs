using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace SERVICE
{
    public class EmployeeWiseLetterRequestService
    {
        public DataTable SelectEmployeeLetterRequestLetterTypes()
        {
            return new DATA.EmployeeWiseLetterRequestEntry().SelectEmployeeLetterRequestLetterTypes();
        }


        public void InsertEmployeeLetterRequest(int letterRequestId, int letterTypeId, int employeeId, int requestedUserId, string remark)
        {
            new DATA.EmployeeWiseLetterRequestEntry().InsertEmployeeLetterRequest(letterRequestId,letterTypeId,employeeId,requestedUserId, remark);
        }

        public DataTable SelectEmployeeWiseLetterReqest(int employeeId)
        {
            return new DATA.EmployeeWiseLetterRequestEntry().SelectEmployeeWiseLetterReqest(employeeId);
        }
    }
}