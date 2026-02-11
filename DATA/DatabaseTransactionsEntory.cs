using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DATA
{
    public static class DatabaseTransactionsEntory
    {
        public static void CommitTranactions()
        {
            DataBaseUtilities.DataBaseUtilities.CommitTransactions(); 
        }

        public static void RollbackTranactions()
        {
            DataBaseUtilities.DataBaseUtilities.RollbackTransactions ();
        }

    }
}
