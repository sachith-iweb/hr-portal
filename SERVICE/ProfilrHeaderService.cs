using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DATA;
using System.Data;

namespace SERVICE
{
    public class ProfilrHeaderService
    {
        public DataTable SelectProfileHeader(int userId)
        {
            try
            {
                return new ProfileHeaderEntry().SelectProfileHeader(userId);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}