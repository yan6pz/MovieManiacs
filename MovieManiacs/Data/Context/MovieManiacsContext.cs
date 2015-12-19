using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public partial class MovieManiacsContext
    {
        public static MovieManiacsContext Create()
        {
            return new MovieManiacsContext();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        protected ObjectContext ObjectContext
        {
            get
            {
                return ((IObjectContextAdapter)this).ObjectContext;
            }
        }

        public override int SaveChanges()
        {
            
            int changesCount = base.SaveChanges();
          
            return changesCount;
        }
    }
}
