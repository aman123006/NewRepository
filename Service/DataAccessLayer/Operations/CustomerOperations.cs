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
        MapperConfiguration config;
        IMapper mapper;
        public CustomerOperations()
        {
            config = MappingProfile.Initialize();
            mapper = config.CreateMapper();
        }
        public long AddCustomer(CustomerDTO customerDTO)
        {
            using (var db = new BankDbContext())
            {

                // or
                //  IMapper mapper = new Mapper(config);
             //   var customer = mapper.Map<customerDTO, Dest>(new Source());
                Customer customer = mapper.Map<CustomerDTO, Customer>(customerDTO); 

                db.Customer.Add(customer);
                db.SaveChanges();
                return db.Customer.FirstOrDefault(x => x.SSNID == customer.SSNID).SSNID;
            }
        }

        public CustomerDTO GetCustomer(int id)
        {
            using (var db = new BankDbContext())
            {
                return mapper.Map<Customer, CustomerDTO>(db.Customer.FirstOrDefault(x => x.ID == id));
                
            }


            }

        //need updation
        public void UpdateCustomer(CustomerDTO customerDTO)
        {
            using (var db = new BankDbContext())
            {
                //TODO : Use Automapper here;
                
                var customer = db.Customer.FirstOrDefault(x => x.ID == customerDTO.ID);
                //  customer =  Mapper.Map<CustomerDTO,Customer>(customerDTO, MappingProfile.ConfigureMap);
                customer.City = customerDTO.City;
                customer.AddressLine1 = customerDTO.AddressLine1;
                customer.AddressLine2 = customerDTO.AddressLine2;
                customer.State = customerDTO.State;
                customer.SSNID = customerDTO.SSNID;
                customer.Name = customerDTO.Name;
                customer.Age = customerDTO.Age;
                db.Entry(customer).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
