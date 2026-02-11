using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DOMAIN;

using System.Data;
namespace DATA
{
    public class UserDetailsEntry
    {
        public void InsertUserDetails(UserDetails userDetails,string operation) 
        {
            Dictionary<string, object> spParameter = new Dictionary<string, object>();

            spParameter.Add(WellKnownParameters.Userdetails.Id, userDetails.Id);
            spParameter.Add(WellKnownParameters.Userdetails.userId, userDetails.UserId);
            spParameter.Add(WellKnownParameters.Userdetails.UserName , userDetails.UserName);
            spParameter.Add(WellKnownParameters.Userdetails.UserPass , userDetails.UserPassword);
            spParameter.Add(WellKnownParameters.Userdetails.EmployeeId, userDetails.EmployeeId);
            spParameter.Add(WellKnownParameters.Userdetails.isActive, userDetails.IsActive);
            spParameter.Add(WellKnownParameters.Userdetails.Operation , operation);

            DataBaseUtilities.DataBaseUtilities.Insert("InsertUserDetails", spParameter);
        }

        public DataTable SelectThis(UserDetails userDetails) 
        {
            Dictionary<string, object> spParameter = new Dictionary<string, object>();
            spParameter.Add(WellKnownParameters.Userdetails.UserName, userDetails.UserName);

            return DataBaseUtilities.DataBaseUtilities.Select("SelectThisUserDetails", spParameter);
        }

        public DataTable SelectThisToVerifyUser(UserDetails userDetails)
        {
            Dictionary<string, object> spParameter = new Dictionary<string, object>();
            spParameter.Add(WellKnownParameters.Userdetails.UserName, userDetails.UserName);
            spParameter.Add(WellKnownParameters.Userdetails.EmployeeId, userDetails.EmployeeId);

            return DataBaseUtilities.DataBaseUtilities.Select("SelectThisUserDetails", spParameter);
        }

        public DataTable Select()
        {

            return DataBaseUtilities.DataBaseUtilities.Select("SelectAllUserDetails");
        }

        public DataTable SelectEmployeeFromUserID(UserDetails userDetails) 
        {

            Dictionary<string, object> spParameter = new Dictionary<string, object>();
            spParameter.Add(WellKnownParameters.Userdetails.Id, userDetails.UserId);

            return DataBaseUtilities.DataBaseUtilities.Select("SelectEmployeeFromUserId", spParameter);
        }
        //public DataTable selectUserDetails(string userId, string sysType)
        //{
        //    Dictionary<string, object> spParameter = new Dictionary<string, object>();
        //    spParameter.Add(WellKnownParameters.Userdetails.userId, userId);
        //    spParameter.Add(WellKnownParameters.Userdetails.sysType, sysType);
        //    return DataBaseUtilities.DataBaseUtilities.Select(WellKnownStoredProcedures.SelectSPs.selectThisUserDetails ,spParameter);
        //}

        //public DataTable selectWebAccessDetails(string userId)
        //{
        //    Dictionary<string, object> spParameter = new Dictionary<string, object>();
        //    spParameter.Add(WellKnownParameters.Userdetails.userId, userId);
        //    return DataBaseUtilities.DataBaseUtilities.Select(WellKnownStoredProcedures.SelectSPs.selectThisWebUser, spParameter);
        //}

        
        //public DataTable selectALLUserDetails(string sysType)
        //{
        //    Dictionary<string, object> spParameter = new Dictionary<string, object>();
        //    spParameter.Add(WellKnownParameters.Userdetails.sysType, sysType);
        //    return DataBaseUtilities.DataBaseUtilities.Select(WellKnownStoredProcedures.SelectSPs.SelectAllUserDetails,spParameter);
        //}


        //public void deleteUserDetails(string userId, string sysType)
        //{
        //    Dictionary<string, object> spParameter = new Dictionary<string, object>();
        //    spParameter.Add(WellKnownParameters.Userdetails.userId, userId);
        //    spParameter.Add(WellKnownParameters.Userdetails.sysType, sysType);
        //    DataBaseUtilities.DataBaseUtilities.Delete(WellKnownStoredProcedures.DeleteSPs.deleteUserDetails, spParameter);
        //}

        public DataTable UserWiseCompanyAccsessDetails(UserDetails userDetails)
        {
            Dictionary<string, object> spParameter = new Dictionary<string, object>();
            spParameter.Add(WellKnownParameters.Userdetails.userId, userDetails.UserId);
            return DataBaseUtilities.DataBaseUtilities.Select("SelectThisUserWiseCompanyAccessDetails", spParameter);
        }

        public DataTable SelectAllUserWiseEmployees(UserDetails userDetails) 
        {
            Dictionary<string, object> spParameter = new Dictionary<string, object>();
            spParameter.Add(WellKnownParameters.Userdetails.userId, userDetails.UserId);
            return DataBaseUtilities.DataBaseUtilities.Select("SelectAllUserWiseEmployees", spParameter);
        }

    }
}
