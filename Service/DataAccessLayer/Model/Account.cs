using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
    public class Account
    {
        [Key]
       // [Range(100000000, System.Int64.MaxValue)]
        public long Id { get; set; }
        public long CustomerId { get; set; }
        
        public Customer Customer { get; set; }
        public long Balance { get; set; }
        public bool Active { get; set; }

       public string Type { get; set; }

        //check if this serves the purpose  Update service and DTO Later
        [Timestamp]
        public byte[] LastUpdated { get; set; }

        public List<Transaction> Transactions { get; set; }


    }
}
