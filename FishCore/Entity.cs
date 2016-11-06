using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishCore
{
    public interface Entity
    {
        int ID { get; set; }
        string Description { get; set; }
        DateTime CreationDate { get; set; }
        string CreationOperator { get; set; }
        DateTime UpdateDate { get; set; }
        string UpdateOperator { get; set; }

        void AssignCreateDate();

    }
}
