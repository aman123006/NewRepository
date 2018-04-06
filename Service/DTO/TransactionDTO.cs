using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TransactionDTO
    {
        public long ID { get; set; }
        public long AccountID { get; set; }
        public string TransactionType { get; set; }
        public int? Withdraw { get; set; }
        public int Deposit { get; set; }
        public long Balance { get; set; }
        public string Comments { get; set; }
        public DateTime TransactionDTTM { get; set; }
    }
}
