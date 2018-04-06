using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Operations;
using DTO;

namespace BAL
{
   public class CustomerBAL
    {
        CustomerOperations op;
        public CustomerBAL()
        {
            op = new CustomerOperations();

        }
        public List<CustomerDTO> GetActiveCustomers()
        {

          return  op.GetActiveCustomers();

        }
        public long AddCustomer(CustomerDTO customerDTO)
        {
           return op.AddCustomer(customerDTO);
        }

        public CustomerDTO GetCustomer(long id)
        {
            return op.GetCustomer(id);
        }

             public void UpdateCustomer(CustomerDTO customerDTO)
        {
            op.UpdateCustomer(customerDTO);
        }

        public bool DeleteCustomer(long id)
        {
           return op.DeleteCustomer(id);
        }
    }
}
