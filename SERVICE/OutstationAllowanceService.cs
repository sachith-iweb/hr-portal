using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DATA;
using System.Data;
using DOMAIN;

namespace SERVICE
{
    public class OutstationAllowanceService
    {
        OutstationAllowanceEntry outstationAllowanceEntry = new OutstationAllowanceEntry();

        public void Insert(OutstationAllowance outstationAllowance)
        {
            outstationAllowanceEntry.Insert(outstationAllowance, "I");
        }

        public void Update(OutstationAllowance outstationAllowance)
        {
            outstationAllowanceEntry.Insert(outstationAllowance, "U");
        }

        public DataTable Select(OutstationAllowance outstationAllowance)
        {
            return outstationAllowanceEntry.Select(outstationAllowance);
        }

        public void Delete(OutstationAllowance outstationAllowance)
        {
            outstationAllowanceEntry.Delete(outstationAllowance);
        }

        public DataTable SelectOutstationAllowanceFlowWiseStatus(int outstationAllowanceId)
        {
            return outstationAllowanceEntry.SelectOutstationAllowanceFlowWiseStatus(outstationAllowanceId);
        }
    }
}
