using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Custom_Conventions
{
    public class DateTimeconvention : Convention
    {
        public DateTimeconvention()
        {
            Properties<DateTime>().Configure(d => d.HasColumnType("DateTime2"));
        }
    }
}
