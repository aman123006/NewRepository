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
            CustomerDTO c = new CustomerDTO() { Name = "AmanDEEP",
                AddressLine1 = "aSdc",
                AddressLine2 = "dsdc"
            , State = "pb",
            City= "amksdcm",
            SSNID=444454444,
            Age=24};
            op.AddCustomer(c);
        }
    }
}
