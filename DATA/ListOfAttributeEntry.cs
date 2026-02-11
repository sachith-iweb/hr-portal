using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DOMAIN;
using DATA.DataBaseUtilities;

namespace DATA
{
    public class ListOfAttributeEntry
    {
        public void Insert(ListOfAttributes listOfAttributes,string operation)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add(WellKnownParameters.ListOfAttributes.BoundValue, listOfAttributes.BoundValue);
            spParameters.Add(WellKnownParameters.ListOfAttributes.DetailId, listOfAttributes.DetailId);
            spParameters.Add(WellKnownParameters.ListOfAttributes.DisplayValue, listOfAttributes.DisplayValue);
            spParameters.Add(WellKnownParameters.ListOfAttributes.Id, listOfAttributes.Id);
            spParameters.Add(WellKnownParameters.ListOfAttributes.IsActive, listOfAttributes.IsActive);
            spParameters.Add(WellKnownParameters.ListOfAttributes.Name, listOfAttributes.Name);
            spParameters.Add(WellKnownParameters.ListOfAttributes.UserId, listOfAttributes.UserId);
            spParameters.Add(WellKnownParameters.ListOfAttributes.Operation, operation);
            DataBaseUtilities.DataBaseUtilities.Insert(WellKnownStoredProcedures.InsertSPs.InsertListOfAttributes, spParameters);  //InsertListOfAttributesValueHeader 
            
       }

        public int InsertHeader(ListOfAttributes listOfAttributes, string operation)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add(WellKnownParameters.ListOfAttributes.BoundValue, listOfAttributes.BoundValue);
            spParameters.Add(WellKnownParameters.ListOfAttributes.DetailId, listOfAttributes.DetailId);
            spParameters.Add(WellKnownParameters.ListOfAttributes.DisplayValue, listOfAttributes.DisplayValue);
            spParameters.Add(WellKnownParameters.ListOfAttributes.Id, listOfAttributes.Id);
            spParameters.Add(WellKnownParameters.ListOfAttributes.IsActive, listOfAttributes.IsActive);
            spParameters.Add(WellKnownParameters.ListOfAttributes.Name, listOfAttributes.Name);
            spParameters.Add(WellKnownParameters.ListOfAttributes.UserId, listOfAttributes.UserId);
            spParameters.Add(WellKnownParameters.ListOfAttributes.Operation, operation);

            DataTable dt = new DataTable();
            int headerId = 0;

            if (operation != "U")
            {
                dt = DataBaseUtilities.DataBaseUtilities.InsertWithSelect(WellKnownStoredProcedures.InsertSPs.InsertListOfAttributesValueHeader, spParameters);

                headerId = Convert.ToInt32(dt.Rows[0]["HeaderId"].ToString());
            }
            else
            {
                DataBaseUtilities.DataBaseUtilities.Insert(WellKnownStoredProcedures.InsertSPs.InsertListOfAttributesValueHeader, spParameters);
            }

            return headerId;


             //InsertListOfAttributesValueHeader 

        }



        public DataTable Select(ListOfAttributes listOfAttributes)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add(WellKnownParameters.ListOfAttributes.IsActive, listOfAttributes.IsActive);
            return DataBaseUtilities.DataBaseUtilities.Select(WellKnownStoredProcedures.SelectSPs.SelectAllListOfAttributes,spParameters);
        }

        public DataTable SelectListOfAttributesHeader(ListOfAttributes listOfAttributes)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add(WellKnownParameters.ListOfAttributes.Name, listOfAttributes.Name);
            spParameters.Add(WellKnownParameters.ListOfAttributes.IsActive, listOfAttributes.IsActive);
            return DataBaseUtilities.DataBaseUtilities.Select(WellKnownStoredProcedures.SelectSPs.SelectAllListOfAttributesHeader, spParameters);
            
            //SelectAllListOfAttributesHeader
        }


        public DataTable SelectForGrid()
        {
            return DataBaseUtilities.DataBaseUtilities.Select(WellKnownStoredProcedures.SelectSPs.SelectAllListOfAttributes);
        }

        public DataTable SelectForItemCommand(ListOfAttributes listOfAttributes)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add(WellKnownParameters.ListOfAttributes.Id, listOfAttributes.Id);

            return DataBaseUtilities.DataBaseUtilities.Select(WellKnownStoredProcedures.SelectSPs.SelectAllListOfAttributes,spParameters);
        }

        public void Delete(ListOfAttributes listOfAttributes)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();          
            //spParameters.Add(WellKnownParameters.ListOfAttributes.DetailId, listOfAttributes.DetailId);          
            spParameters.Add(WellKnownParameters.ListOfAttributes.Id, listOfAttributes.Id);        
            DataBaseUtilities.DataBaseUtilities.Insert(WellKnownStoredProcedures.DeleteSPs.DeleteListOfAttributes, spParameters);
        }

        public void DeleteHeader(ListOfAttributes listOfAttributes)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();          
            spParameters.Add(WellKnownParameters.ListOfAttributes.DetailId, listOfAttributes.DetailId);          
            spParameters.Add(WellKnownParameters.ListOfAttributes.Id, listOfAttributes.Id);        
            DataBaseUtilities.DataBaseUtilities.Insert(WellKnownStoredProcedures.DeleteSPs.DeleteListOfAttributesHeader, spParameters);
        }

        public DataTable SelectAllActiveHeaderListOfAttributes()
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add(WellKnownParameters.ListOfAttributes.IsActive, 1); 
            return DataBaseUtilities.DataBaseUtilities.Select(WellKnownStoredProcedures.SelectSPs.SelectActiveListOfHeaderAttributes,spParameters);
        }

        public DataTable SelectAllHeaderListOfAttributes()
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            return DataBaseUtilities.DataBaseUtilities.Select(WellKnownStoredProcedures.SelectSPs.SelectActiveListOfHeaderAttributes,spParameters);
        }

        public DataTable SelectListOfAttributeHeaderDetailsFromListOfAttributeHeaderId(ListOfAttributes listOfAttributes)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add(WellKnownParameters.ListOfAttributes.HeaderId, listOfAttributes.HeaderId);
            return DataBaseUtilities.DataBaseUtilities.Select(WellKnownStoredProcedures.SelectSPs.SelectListOfAttributeHeaderDetailsFromListOfAttributeHeaderId,spParameters);
        }
    }
}
