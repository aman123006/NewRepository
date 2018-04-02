using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.DatabaseContext;
using DataAccessLayer.Model;

namespace DataAccessLayer.Operations
{
   public class TransactionOperations
    {
        public void Deposit(long accountId, int amount, string comments)
        {// use transactions
            using (var db = new BankDbContext())
            {
                var account = db.Account.FirstOrDefault(x => x.Id == accountId);

                account.Balance += amount;
                var transaction = new Transaction() {
                    Balance = account.Balance,
                    Deposit = amount,
                    TransactionType = "Cr",
                    Comments = comments,
                    AccountID = accountId,
                    TransactionDTTM = DateTime.Now
                };
                
                db.Entry(account).State = System.Data.Entity.EntityState.Modified;
                db.Transaction.Add(transaction);
                db.SaveChanges();
            }
        }


        public void Withdraw(long accountId, int amount, string comments)
        {// use transactions
            using (var db = new BankDbContext())
            {
                var account = db.Account.FirstOrDefault(x => x.Id == accountId);

                account.Balance -= amount;
                var transaction = new Transaction()
                {
                    Balance = account.Balance,
                    Withdraw = amount,
                    TransactionType = "Cr",
                    Comments = comments,
                    AccountID = accountId,
                    TransactionDTTM = DateTime.Now
                };
             
                db.Entry(account).State = System.Data.Entity.EntityState.Modified;
                db.Transaction.Add(transaction);
                db.SaveChanges();
            }
        }

        public void Transfer(long src_accountId,long dest_accountId, int amount)
        {// use transactions, Update, See return Things

            Withdraw(src_accountId, amount, "Transfered to" + dest_accountId);
            Deposit(dest_accountId, amount, "Transfered from "+ src_accountId);

        }


        }
}
