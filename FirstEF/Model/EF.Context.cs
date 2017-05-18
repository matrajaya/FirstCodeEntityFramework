using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstEF.Model
{
    class EFContext : DbContext
    {
        public EFContext():base("EFContext")
        { }

        public DbSet<Product> Product { get; set; }
        
    }
}
