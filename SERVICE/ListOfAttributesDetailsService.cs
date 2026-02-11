using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using DOMAIN;
using DATA;

namespace SERVICE
{
    public class ListOfAttributesDetailsService
    {
        ListOfAttributeEntry listOfAttributeEntry = new ListOfAttributeEntry();

        public void Insert(ListOfAttributes listOfAttributes)
        {
            listOfAttributeEntry.Insert(listOfAttributes,"I");
        }

        public int InsertHeader(ListOfAttributes listOfAttributes)
        {
            return listOfAttributeEntry.InsertHeader(listOfAttributes,"I");       
        }

        public DataTable SelectListOfAttributesHeader(ListOfAttributes listOfAttributes)
        {
            return listOfAttributeEntry.SelectListOfAttributesHeader(listOfAttributes);
        }

        public void Update(ListOfAttributes listOfAttributes)
        {
            listOfAttributeEntry.Insert(listOfAttributes, "U");
        }

        public void UpdateHeader(ListOfAttributes listOfAttributes)
        {
            listOfAttributeEntry.InsertHeader(listOfAttributes, "U");
        }

        public DataTable SelectAll(ListOfAttributes listOfAttributes)
        {
            return listOfAttributeEntry.Select(listOfAttributes);
        }

        public DataTable SelectForGrid()
        {
            return listOfAttributeEntry.SelectForGrid();
        }
        public DataTable SelectForItemCommand(ListOfAttributes listOfAttributes)
        {
            return listOfAttributeEntry.SelectForItemCommand(listOfAttributes);
        }

        public DataTable SelectForCombo(ListOfAttributes listOfAttributes)
        {
            listOfAttributes.IsActive = true;
            return listOfAttributeEntry.Select(listOfAttributes);
        }

        public void Delete(ListOfAttributes listOfAttributes)
        {
            listOfAttributeEntry.Delete(listOfAttributes);
        }

        public void DeleteHeader(ListOfAttributes listOfAttributes)
        {
            listOfAttributeEntry.DeleteHeader(listOfAttributes);
        }

        public DataTable SelectAllActiveHeaderListOfAttributes()
        {
            return listOfAttributeEntry.SelectAllActiveHeaderListOfAttributes();
        }

        public DataTable SelectAllHeaderListOfAttributes()
        {
            return listOfAttributeEntry.SelectAllHeaderListOfAttributes();
        }

        public DataTable SelectListOfAttributeHeaderDetailsFromListOfAttributeHeaderId(ListOfAttributes listOfAttributes)
        {
            return listOfAttributeEntry.SelectListOfAttributeHeaderDetailsFromListOfAttributeHeaderId(listOfAttributes);
        }
    }
}
