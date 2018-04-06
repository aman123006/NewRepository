using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DataAccessLayer.AutoMapper;
using DataAccessLayer.DatabaseContext;
using DataAccessLayer.Model;
using DTO;

namespace DataAccessLayer.Operations
{
   public class AccountOperations
    {
        MapperConfiguration config;
        IMapper mapper;
        public AccountOperations()
        {
            config = MappingProfile.Initialize();
            mapper = config.CreateMapper();
        }
     
        public AccountDTO GetAccountDetails(long id)
        {
            using (var db = new BankDbContext())
            {
              return mapper.Map<Account, AccountDTO>(db.Account.FirstOrDefault(x => x.Id == id)); 

                }
        }

        public List<AccountDTO> GetAccountDetailsBySSNID(long id)
        {
            using (var db = new BankDbContext())
            {
               var Accounts = db.Account.Include(x=>x.Customer);
                var account = Accounts.Where(x => x.Customer.SSNID == id).ToList();
       
               return account.Select(y => mapper.Map<Account, AccountDTO>(y)).ToList();

            }
        }

        public List<AccountDTO> GetAccountDetailsByCustID(long id)
        {
            using (var db = new BankDbContext())
            {
                var Accounts = db.Account.Where(x => x.CustomerId == id).Include(x => x.Customer).ToList();
                

                return Accounts.Select(y => mapper.Map<Account, AccountDTO>(y)).ToList();

            }
        }

        public List<AccountDTO> GetActiveAccounts()
        {
            using (var db = new BankDbContext())
            {
                var Accounts = db.Account.Where(x => x.Active == true).Include(x => x.Customer).ToList();


                return Accounts.Select(y => mapper.Map<Account, AccountDTO>(y)).ToList();

            }
        }

        public bool DeleteAccount(long id)
        {
            using (var db = new BankDbContext())
            {
                Account account = db.Account.FirstOrDefault(x => x.Id == id);
                account.Active = false;
                db.Entry(account).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
        }

        

        public long CreateAccount(AccountDTO acc)
        {
            using (var db = new BankDbContext())
            {
                Account a = mapper.Map<AccountDTO, Account>(acc);
                db.Account.Add(a);
                db.SaveChanges();
                return a.Id;
            }
        }

        public List<TransactionDTO> GetAccountStatement(long id, int n)
        {
            using (var db = new BankDbContext())
            {
                var Account = db.Account.Where(x => x.Id == id).Include(y => y.Transactions).FirstOrDefault();
                return Account.Transactions.OrderByDescending(x => x.TransactionDTTM).Take(n).Select(y=>  mapper.Map<Transaction, TransactionDTO>(y)).ToList();
                
            }
        }

        public List<TransactionDTO> GetAccountStatement(long id, DateTime start, DateTime end)
        {
            using (var db = new BankDbContext())
            {
                var Account = db.Account.Include(y => y.Transactions).Where(x => x.Id == id).FirstOrDefault();
                return Account.Transactions.Where(y => y.TransactionDTTM >= start && y.TransactionDTTM<= end).OrderByDescending(x => x.TransactionDTTM).Select(y => mapper.Map<Transaction, TransactionDTO>(y)).ToList();

            }
        }

    }
}
