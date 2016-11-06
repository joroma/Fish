using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishCore.Objects
{
    public class Transaction
    {
        public int ID { get; set; } 
        public string Descriptio { get; set; }
        public decimal Amount { get; set; }
        public DateTime Trandate { get; set; }

        public  ExpenseType expenseType { get; set; }


    }
}
