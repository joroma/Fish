using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace FishDAL
{
    public class FishDbMockInitializer : DropCreateDatabaseIfModelChanges<FishContext>
    {
        protected override void Seed(FishContext context)
        {
            base.Seed(context);
        }
    }
}
