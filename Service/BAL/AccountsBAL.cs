using System;
using System.Collections.Generic;

using DTO;
using DataAccessLayer;
using DataAccessLayer.Operations;

namespace BAL
{
    public class AccountsBAL
    {
        AccountOperations op;

        public AccountsBAL()
        {
            op = new AccountOperations();

        }
        public AccountDTO GetAccountDetails(long id)
        {
            return op.GetAccountDetails(id);
        }

        public List<AccountDTO> GetAccountDetailsBySSNID(long id)
        {
            return op.GetAccountDetailsBySSNID(id);
        }

        public List<AccountDTO> GetAccountDetailsByCustID(long id)
        {
            return op.GetAccountDetailsByCustID(id);
        }

        public List<AccountDTO> GetActiveAccounts()
        {
            return op.GetActiveAccounts();
        }

        public bool DeleteAccount(long id)
        {
            return op.DeleteAccount(id);
        }
    }
}
