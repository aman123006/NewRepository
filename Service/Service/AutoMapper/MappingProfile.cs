using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using DTO;

namespace Service.AutoMapper
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