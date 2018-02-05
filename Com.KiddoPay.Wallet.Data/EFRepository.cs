using Com.KiddoPay.Wallet.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.KiddoPay.Wallet.Data
{
    public abstract class EFRepository<T, TKey> : IRepository<T, TKey> where T : BaseEntity<TKey> where TKey : struct
    {
        public abstract Func<TKey, Func<T, bool>> FindStrategy { get; }
        WalletDbContext DbContext { get; }
        public EFRepository(WalletDbContext dbContext)
        {
            this.DbContext = dbContext;
        }

        public TKey Create(T data)
        {
            this.DbContext.Set<T>().Add(data);
            this.DbContext.SaveChanges();
            return data.Id;
        }

        public bool Delete(TKey key)
        {
            throw new NotImplementedException();
        }

        public T Get(TKey key)
        {
            throw new NotImplementedException();
        }

        public bool Update(TKey key, T data)
        {
            throw new NotImplementedException();
        }
    }
}
