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

        public static MapperConfiguration Initialize()
        {
            MapperConfiguration config = new MapperConfiguration(cfg => {
                
                cfg.CreateMap<CustomerDTO, Customer>();
                cfg.CreateMap<Customer, CustomerDTO>();
            });

            return config;
        }


    }
}
