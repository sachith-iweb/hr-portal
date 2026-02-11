using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DATA;
using DOMAIN;
using System.Data;

namespace SERVICE
{
    public class DesignationWiseLeaveTypeDetailsService
    {
        DesignationWiseLeaveTypeDetailsEntry designationWiseLeaveTypeDetailsEntry = new DesignationWiseLeaveTypeDetailsEntry();

        public void Insert(DesignationWiseLeaveTypeDetails designationWiseLeaveTypeDetails) 
        {
            designationWiseLeaveTypeDetailsEntry.Insert(designationWiseLeaveTypeDetails,"I");
        }

        public void Update(DesignationWiseLeaveTypeDetails designationWiseLeaveTypeDetails) 
        {
            designationWiseLeaveTypeDetailsEntry.Insert(designationWiseLeaveTypeDetails, "U");
        }

        public DataTable Select(DesignationWiseLeaveTypeDetails designationWiseLeaveTypeDetails) 
        {
            return designationWiseLeaveTypeDetailsEntry.Select(designationWiseLeaveTypeDetails);
        }

        public DataTable SelectThis(DesignationWiseLeaveTypeDetails designationWiseLeaveTypeDetails)
        {
            return designationWiseLeaveTypeDetailsEntry.SelectThis(designationWiseLeaveTypeDetails);
        }

        public void Delete(DesignationWiseLeaveTypeDetails designationWiseLeaveTypeDetails) 
        {
            designationWiseLeaveTypeDetailsEntry.Delete(designationWiseLeaveTypeDetails);
        }
    }
}
