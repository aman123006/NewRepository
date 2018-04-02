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
               var debug = db.Account.Where(x => x.Id == id).FirstOrDefault();
                var x1 = debug.Customer;
                return mapper.Map<Account, AccountDTO>(db.Account.FirstOrDefault(x => x.Id == id));

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


        public bool CreateAccount(AccountDTO acc)
        {
            using (var db = new BankDbContext())
            {
                Account a = mapper.Map<AccountDTO, Account>(acc);
                db.Account.Add(a);
                db.SaveChanges();
                return true; // TODO Return ID??
            }
        }
    }
}
