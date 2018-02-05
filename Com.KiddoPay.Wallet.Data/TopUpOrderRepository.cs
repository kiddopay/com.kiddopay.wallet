using Com.KiddoPay.Wallet.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.KiddoPay.Wallet.Data
{
    public class TopUpOrderRepository : WalletEFRepository<TopUpOrder, int>
    {
        public override Func<int, Func<TopUpOrder, bool>> FindStrategy => (key) => (entity) => entity.Id == key;

        public TopUpOrderRepository(WalletDbContext dbContext)
            : base(dbContext)
        {

        }
    }
}
