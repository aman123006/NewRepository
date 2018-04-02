using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataAccessLayer.Operations;
using DTO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var op = new CustomerOperations();
            CustomerDTO c = new CustomerDTO() {ID =4, Name = "XYZ",
                AddressLine1 = "0000",
                AddressLine2 = "0000"
            , State = "000000",
            City= "00000",
            SSNID= 444989444,
            DOB=DateTime.Now,
            Active =true
            };
            //op.AddCustomer(c);
            //var a = op.DeleteCustomer(7);
            AccountDTO acc = new AccountDTO() { Active = true, CustomerId = 8, Type = "Savimngs" };
            var Aop = new AccountOperations();

            var a = Aop.GetActiveAccounts();
            //op.UpdateCustomer(c);

            //var Top = new TransactionOperations();
            //Top.Deposit(3, 500,"Dep");

            //Top.Withdraw(2, 500, "W");

            //Top.Transfer(2,3,1000);

            var x = Aop.GetAccountStatement(2,1);

        }
    }
}
