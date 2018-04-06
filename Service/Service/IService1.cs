using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        long AddCustomer(Customer Customer);

        [OperationContract]
        bool UpdateCustomer(Customer Customer);

        [OperationContract]
        long DeleteCustomer(long id);

        [OperationContract]
        Customer GetCustomer(long id);

        [OperationContract]
        List<Customer> GetAllCustomers();

        [OperationContract]
        void Deposit(long accountId, int amount, string comments = "Deposit");

        [OperationContract]
        void Withdraw(long accountId, int amount, string comments = "Withdraw");

        [OperationContract]
        void Transfer(long src_accountId, long dest_accountId, int amount);


        [OperationContract]
        Account GetAccountDetails(long id);
        [OperationContract]
        List<Account> GetAccountDetailsBySSNID(long id);
        [OperationContract]
        List<Account> GetAccountDetailsByCustID(long id);
        [OperationContract]
        List<Account> GetActiveAccounts();
        [OperationContract]
        bool DeleteAccount(long id);
        [OperationContract]
        long CreateAccount(Account account);
        [OperationContract]
        List<Transaction> GetAccountStatement(long id, int n);
        [OperationContract]
        List<Transaction> GetAccountStatementByDate(long id, DateTime start, DateTime end);
        
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public partial class Customer
    {
        [DataMember]
        public long ID { get; set; }
        [DataMember]
        public long SSNID { get; set; }
        [DataMember]
        public DateTime DOB { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string AddressLine1  { get; set; }
        [DataMember]
        public string AddressLine2 { get; set; }
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public string State { get; set; }
        
     }

    [DataContract]
    public partial class Account
    {
        [DataMember]
        public long Id { get; set; }
        [DataMember]
        public long CustomerId { get; set; }
        [DataMember]
        public Customer Customer { get; set; }
        [DataMember]
        public long Balance { get; set; }
       
        [DataMember]
        public string Type { get; set; }

    }

    [DataContract]
    public partial class Transaction
    {
        public long ID { get; set; }
        public long AccountID { get; set; }
        public string TransactionType { get; set; }
        public int? Withdraw { get; set; }
        public int? Deposit { get; set; }
        public long Balance { get; set; }
        public string Comments { get; set; }
        public string Date { get ; set; } // automapeer

    }
}
