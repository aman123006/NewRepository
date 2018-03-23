using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Model;
using DataAccessLayer.DatabaseContext;
using DTO;
using AutoMapper;
using DataAccessLayer.AutoMapper;

namespace DataAccessLayer.Operations
{
   public class CustomerOperations
    {
        public void AddCustomer(CustomerDTO customerDTO)
        {
            using (var db = new BankDbContext())
            {
                var config = MappingProfile.Initialize();

                var mapper = config.CreateMapper();
                // or
                //  IMapper mapper = new Mapper(config);
             //   var customer = mapper.Map<customerDTO, Dest>(new Source());
                Customer customer = mapper.Map<CustomerDTO, Customer>(customerDTO); 

                db.Customer.Add(customer);
                db.SaveChanges();
            }
        }
    }
}
