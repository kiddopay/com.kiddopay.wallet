using System;

namespace Com.KiddoPay.Wallet.Data.Models
{
    public class BaseEntity<TKey> where TKey : struct
    {
        public virtual TKey Id { get; set; }
    }
}
