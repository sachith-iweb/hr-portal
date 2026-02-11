using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DATA;
using System.Data;
using DOMAIN;

namespace SERVICE
{
    public class HealthProfileService
    {
        public DataTable SelectEmployeeWiseHealthProfile(int employeeId)
        {
            try
            {
                return new HealthProfileEntry().SelectEmployeeWiseHealthProfile(employeeId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable SelectBloodGroupDetails()
        {
            try
            {
                return new HealthProfileEntry().SelectBloodGroupDetails();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public void Insert(HealthProfile healthProfile)
        {
            new HealthProfileEntry().Insert(healthProfile);
        }

        public DataTable SelectEmployeeHealthProfileNotApproved(int employeeId)
        {
            try
            {
                return new HealthProfileEntry().SelectEmployeeHealthProfileNotApproved(employeeId);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}