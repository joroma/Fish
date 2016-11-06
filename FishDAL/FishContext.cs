using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using FishCore.Objects;

namespace FishDAL
{
    public class FishContext : DbContext
    {
        public DbSet<Account> Accounts {get; set;}
        public DbSet<ExpenseType> ExpenseTypes { get; set; }

    }
}
