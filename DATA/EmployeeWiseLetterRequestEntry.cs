using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.SqlClient;
using System.Data;

namespace DATA
{
    public class EmployeeWiseLetterRequestEntry
    {
        public DataTable SelectEmployeeLetterRequestLetterTypes()
        {
            return DataBaseUtilities.DataBaseUtilities.Select("Select_EmployeeLetterRequestLetterTypes");
        }

        public void InsertEmployeeLetterRequest(int letterRequestId, int letterTypeId, int employeeId, int requestedUserId,string remark)
        {
            Dictionary<string, object> spParameter = new Dictionary<string, object>();
            spParameter.Add("@LetterRequestId", letterRequestId);
            spParameter.Add("@LetterTypeId", letterTypeId);
            spParameter.Add("@EmployeeId", employeeId);
            spParameter.Add("@RequestedUserId", requestedUserId);
            spParameter.Add("@Remark", remark);
            DataBaseUtilities.DataBaseUtilities.Insert("Insert_EmployeeLetterRequest",spParameter);
        }

      


        public DataTable SelectEmployeeWiseLetterReqest(int employeeId)
        {
            Dictionary<string, object> spParameter = new Dictionary<string, object>();
            spParameter.Add("@EmployeeId", employeeId);
            return DataBaseUtilities.DataBaseUtilities.Select("Select_EmployeeWiseLetterReqest",spParameter);
        }


    }
}