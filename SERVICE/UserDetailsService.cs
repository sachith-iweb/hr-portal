using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DOMAIN;
using DATA;
using System.Data;
using System.Security.Cryptography;

namespace SERVICE
{
    public class UserDetailsService
    {
        UserDetailsEntry userDetailsEntry = new UserDetailsEntry();

        public void Insert(UserDetails userDetails) 
        {
            userDetails.UserPassword = GetMd5Hash(userDetails.UserName + userDetails.UserPassword);

            userDetailsEntry.InsertUserDetails(userDetails, "I");            
        }

        public void Update(UserDetails userDetails)
        {
            userDetails.UserPassword = GetMd5Hash(userDetails.UserName + userDetails.UserPassword);

            userDetailsEntry.InsertUserDetails(userDetails, "U");         
        }       
       

        public DataTable SelectThisUserDetails(UserDetails userDetails)
        {
            return userDetailsEntry.SelectThis(userDetails);
        }
        
        public DataTable SelectThisToVerifyUser(UserDetails userDetails)
        {
            return userDetailsEntry.SelectThisToVerifyUser(userDetails);
        }

        public long ChekLogin(UserDetails userDetails)
        {
            DataTable dt = userDetailsEntry.SelectThis(userDetails);

            if (dt.Rows.Count == 0)
                return -999;
            string password = GetMd5Hash(userDetails.UserName + userDetails.UserPassword);
            if (!dt.Rows[0]["password"].ToString().Equals(password))
                return -999;

            return Convert.ToInt64(dt.Rows[0]["id"].ToString());
        }

        public DataTable GetEmployeeName(UserDetails userDetails)
        {
            DataTable dt = userDetailsEntry.SelectThis(userDetails);

            if (dt.Rows.Count == 0)
                return dt;
            string password = GetMd5Hash(userDetails.UserName + userDetails.UserPassword);
            if (!dt.Rows[0]["password"].ToString().Equals(password))
                return dt;

            return dt;
        }


        public long GetEmployeeId(UserDetails userDetails)
        {
            DataTable dt = userDetailsEntry.SelectThis(userDetails);

            if (dt.Rows.Count == 0)
                return -999;
            string password = GetMd5Hash(userDetails.UserName + userDetails.UserPassword);
            if (!dt.Rows[0]["password"].ToString().Equals(password))
                return -999;

            return Convert.ToInt64(dt.Rows[0]["EmployeeId"].ToString());
        }

        public DataTable UserWiseCompanyAccsessDetails(UserDetails userDetails)
        {
           return userDetailsEntry.UserWiseCompanyAccsessDetails(userDetails);
        }

        public DataTable Select() 
        {
            return userDetailsEntry.Select();
        }


        public DataTable SelectEmployeeFromUserID(UserDetails userDetails) 
        {
            return userDetailsEntry.SelectEmployeeFromUserID(userDetails);
        }

        static string GetMd5Hash(string input)
        {
            MD5 md5Hash = MD5.Create();

            // Convert the input string to a byte array and compute the hash. 
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes 
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data  
            // and format each one as a hexadecimal string. 
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string. 
            return sBuilder.ToString();
        }

        public DataTable SelectAllUserWiseEmployees(UserDetails userDetails)
        {
            return userDetailsEntry.SelectAllUserWiseEmployees(userDetails);
        }

    }
}
