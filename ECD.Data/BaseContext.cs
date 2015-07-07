using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECD.Data
{
    public class BaseContext<TContext>:DbContext where TContext:DbContext
    {
        static BaseContext()
        {
            Database.SetInitializer<DbContext>(null);
        }

        protected BaseContext()
            : base("name=ECDDatabase")
        {

        }
    }
}
