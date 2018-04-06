using System;
using System.Collections.Generic;
using AutoMapper;
using Service.AutoMapper;
using BAL;
using DTO;

namespace Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        AccountsBAL Abal;
        CustomerBAL Cbal;
        TransactionBAL Tbal;

        MapperConfiguration config = MappingProfile.Initialize();
        IMapper mapper;

        public Service1()
        {
            Abal = new AccountsBAL();
            Cbal = new CustomerBAL();
            Tbal = new TransactionBAL();

            mapper = config.CreateMapper();
        }
      

        public long AddCustomer(Customer Customer)
        {
            return Cbal.AddCustomer(mapper.Map<Customer,CustomerDTO>(Customer));
        }

        public bool UpdateCustomer(Customer Customer)
        {
            throw new NotImplementedException();
        }

        public long DeleteCustomer(long id)
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomer(long id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public void Deposit(long accountId, int amount, string comments = "Deposit")
        {
            throw new NotImplementedException();
        }

        public void Withdraw(long accountId, int amount, string comments = "Withdraw")
        {
            throw new NotImplementedException();
        }

        public void Transfer(long src_accountId, long dest_accountId, int amount)
        {
            throw new NotImplementedException();
        }

        public Account GetAccountDetails(long id)
        {
            throw new NotImplementedException();
        }

        public List<Account> GetAccountDetailsBySSNID(long id)
        {
            throw new NotImplementedException();
        }

        public List<Account> GetAccountDetailsByCustID(long id)
        {
            throw new NotImplementedException();
        }

        public List<Account> GetActiveAccounts()
        {
            throw new NotImplementedException();
        }

        public bool DeleteAccount(long id)
        {
            throw new NotImplementedException();
        }

        public long CreateAccount(Account account)
        {
            throw new NotImplementedException();
        }

        public List<Transaction> GetAccountStatement(long id, int n)
        {
            throw new NotImplementedException();
        }

        public List<Transaction> GetAccountStatementByDate(long id, DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }
    }
}
