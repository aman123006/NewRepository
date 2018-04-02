using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class AccountDTO
    {
        public long Id { get; set; }
        public long CustomerId { get; set; }
        public CustomerDTO Customer { get; set; }
        public long Balance { get; set; }
        public bool Active { get; set; }

        public string Type { get; set; }

    }
}
