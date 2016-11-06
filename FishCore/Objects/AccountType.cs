using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishCore.Objects
{
    public class AccountType
    {
        public int ID { get; set; }
        public string Description { get; set; }

        public ICollection<Account> Accounts { get; set; }
    }
}
