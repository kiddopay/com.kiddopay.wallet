using Com.KiddoPay.Data;
using Com.KiddoPay.Wallet.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.KiddoPay.Wallet.Data
{
    public abstract class WalletEFRepository<T, TKey> : EFRepository<WalletDbContext, T, TKey>
        where T : BaseEntity<TKey>
        where TKey : struct
    {
        public WalletEFRepository(WalletDbContext dbContext)
            : base(dbContext)
        {

        }
    }
}
