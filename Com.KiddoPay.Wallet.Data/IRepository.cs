using System;
using System.Collections.Generic;
using System.Text;

namespace Com.KiddoPay.Wallet.Data
{
    public interface IRepository<T, TKey> where T : class where TKey : struct
    {
        T Get(TKey key);
        TKey Create(T data);
        bool Update(TKey key, T data);
        bool Delete(TKey key);
    }
}
