﻿using System;
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
            SSNID= 444984444,
            DOB=DateTime.Now,
            Active =true
            };
       //   op.AddCustomer(c);
            var a = op.GetActiveCustomers();

           //op.UpdateCustomer(c);
        }
    }
}
