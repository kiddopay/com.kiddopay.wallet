using Com.KiddoPay.Data;
using System;

namespace Com.KiddoPay.Wallet.Data.Models
{
    public class TopUpOrder : BaseEntity<int>
    {
        public string Username { get; set; }
        public decimal Nominal { get; set; }
        public string Status { get; set; }
    }
}
