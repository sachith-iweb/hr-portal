using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DATA;
using DOMAIN; 

namespace SERVICE
{
    public class BasicInformationService
    {

        #region Selects
        public DataTable SelectTitle()
        {
            try
            {
                return new BasicInformationEntry().SelectTitle();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable SelectNationality()
        {
            try
            {
                return new BasicInformationEntry().SelectNationality();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable SelectRace()
        {
            try
            {
                return new BasicInformationEntry().SelectRace();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable SelectReligion()
        {
            try
            {
                return new BasicInformationEntry().SelectReligion();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable SelectCivilStatus()
        {
            try
            {
                return new BasicInformationEntry().SelectCivilStatus();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable SelectBasicDetails(int employeeId)
        {
            try
            {
                return new BasicInformationEntry().SelectBasicDetails(employeeId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion


        public void InsertEmployeeBasicInformation(EmployeeBasicInformation employeeBasicInformation)
        {
            try
            {
                new BasicInformationEntry().InsertEmployeeBasicInformation(employeeBasicInformation);
            }
            catch (Exception ex)
            {                
                throw ex;
            }
        }

        public DataTable SelectEmployeeBasicInformationNotApproved(EmployeeBasicInformation employeeBasicInformation)
        {
            try
            {
               return new BasicInformationEntry().SelectEmployeeBasicInformationNotApproved(employeeBasicInformation);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}