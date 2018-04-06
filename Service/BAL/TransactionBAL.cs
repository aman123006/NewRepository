using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Operations;

namespace BAL
{
  public  class TransactionBAL
    {
        TransactionOperations op;
        public TransactionBAL()
        {
            op = new TransactionOperations();
        }

        public void Deposit(long accountId, int amount, string comments = "Deposit")
        {
            op.Deposit(accountId, amount, comments);
        }


        public void Withdraw(long accountId, int amount, string comments = "Withdraw")
        {
            op.Withdraw(accountId, amount, comments);
        }

        public void Transfer(long src_accountId, long dest_accountId, int amount)
        {
            op.Transfer(src_accountId,dest_accountId,amount);
        }
    }
}
