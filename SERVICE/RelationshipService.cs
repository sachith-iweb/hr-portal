using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DATA;
using DOMAIN;

namespace SERVICE
{
    public class RelationshipService
    {
        public DataTable SelectCivilStatus()
        {
            return new RelationshipEntry().SelectCivilStatus();
        }

        public DataTable SelectRelationships()
        {
            return new RelationshipEntry().SelectRelationships();
        }

        public DataTable SelectEmployeeWiseRelationshipDetails(int employeeId)
        {
            return new RelationshipEntry().SelectEmployeeWiseRelationshipDetails(employeeId);
        }

        public DataTable SelectEmployeeWiseRelationshipDetailsNotApproved(int employeeId, int employeeWiseRelationshipId)
        {
            return new RelationshipEntry().SelectEmployeeWiseRelationshipDetailsNotApproved(employeeId, employeeWiseRelationshipId);
        }

        public void Insert(EmployeeWiseRelationshipDetails employeeWiseRelationshipDetails)
        {
            new RelationshipEntry().Insert(employeeWiseRelationshipDetails);
        }
    }
}