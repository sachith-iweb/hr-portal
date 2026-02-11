using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DATA; 
namespace SERVICE
{
    public static class DataBaseTransactions
    {
        public static void CommitTransactions()
        {
            DatabaseTransactionsEntory.CommitTranactions();
        }

        public static void RollbackTransactions()
        {
            DatabaseTransactionsEntory.RollbackTranactions();
        }

    }
}
