using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Custom_Conventions
{
    class PrimaryKeyConvention : Convention
    {
        public PrimaryKeyConvention()
        {
            Properties<int>()
                .Where(p => p.Name.EndsWith("Key"))
                .Configure(p => p.IsKey());
        }
    }
}
