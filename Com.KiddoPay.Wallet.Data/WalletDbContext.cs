using Com.KiddoPay.Wallet.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.KiddoPay.Wallet.Data
{
    public class WalletDbContext : DbContext
    {

        public WalletDbContext(DbContextOptions<WalletDbContext> options) : base(options)
        {

        }
        public DbSet<TopUpOrder> TopUpOrders { get; set; }
    }
}
