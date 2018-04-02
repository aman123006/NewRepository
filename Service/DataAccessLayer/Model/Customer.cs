﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
    public class Customer
    {
        [Key]
        public  long ID { get; set; }
        [Index(IsUnique = true),Range(100000000,System.Int64.MaxValue)]
        public long SSNID { get; set; }
        
        public DateTime DOB { get; set; }
        
        public string Name { get; set; }
        
        public string AddressLine1 { get; set; }
        
        public string AddressLine2 { get; set; }
        
        public string City { get; set; }
        
        public string State { get; set; }
      // see default value decorator
       public bool Active { get; set; }

        //Update service and DTO Later
        public string Message { get; set; }

        //check if this serves the purpose  Update service and DTO Later
        [Timestamp]
        public byte[] LastUpdated { get; set; }
        //update service and DTO
       public List<Account> Accounts { get; set; }

    }
}
