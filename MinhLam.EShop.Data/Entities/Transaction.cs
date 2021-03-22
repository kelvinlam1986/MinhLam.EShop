using MinhLam.EShop.Data.Enums;
using System;

namespace MinhLam.EShop.Data.Entities
{
    public class Transaction
    {
        public int Id { set; get; }
        public DateTime TransactionDate { set; get; }
        public string ExternalTransactionId { set; get; }
        public decimal Amount { set; get; }
        public decimal Fee { set; get; }
        public string Result { set; get; }
        public string Message { set; get; }
        public TransactionStatusEnum Status { set; get; }
        public string Provider { set; get; }
    }
}
