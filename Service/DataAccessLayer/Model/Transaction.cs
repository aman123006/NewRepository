using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
   public class Transaction
    {
        [Key]
        public long ID { get; set; }
        public long AccountID { get; set; }
        public string TransactionType { get; set; }
        public int Amount { get; set; }
        public long PreviousBalnce { get; set; }
        public long CurrentBalance { get; set; }
        public string Comments { get; set; }
        public DateTime TransactionDTTM { get; set; }
            

    }
}
