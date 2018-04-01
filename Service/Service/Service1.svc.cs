using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using AutoMapper;
using Service.AutoMapper;

namespace Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public Service1()
        {
            mapper = config.CreateMapper();
        }
        MapperConfiguration config = MappingProfile.Initialize();
        IMapper mapper;

        public long AddCustomer(Customer Customer)
        {
            //return mapper.Map<Customer, CustomerDTO>(db.Customer.FirstOrDefault(x => x.ID == id));
            return 0;
        }

        public long DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public long GetCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public long UpdateCustomer(Customer Customer)
        {
            throw new NotImplementedException();
        }
    }
}
