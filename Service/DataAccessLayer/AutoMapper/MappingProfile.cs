using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DataAccessLayer.Model;
using DTO;

namespace DataAccessLayer.AutoMapper
{
    public class MappingProfile
    {
        public MappingProfile()
        {
            
          
        }

        public static void ConfigureMap(IMappingOperationOptions<CustomerDTO, Customer> opt)
        {
            opt.ConfigureMap()
               .ForMember(dest => dest.ID, m => m.Ignore());
}

        public static MapperConfiguration Initialize()
        {
            MapperConfiguration config = new MapperConfiguration(cfg => {
                
                cfg.CreateMap<CustomerDTO, Customer>(); 
                cfg.CreateMap<Customer, CustomerDTO>();

                cfg.CreateMap<AccountDTO, Account>().ForMember(dest => dest.Customer, m => m.Ignore()); 
                cfg.CreateMap<Account, AccountDTO>();

                cfg.CreateMap<Transaction, TransactionDTO>();
                cfg.CreateMap<TransactionDTO, Transaction>();
            });

            return config;
        }


    }
}
