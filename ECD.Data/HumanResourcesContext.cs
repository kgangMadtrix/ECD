using ECD.Data.Interfaces;
using ECD.HumanResources.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECD.Data.HR
{
    public class HumanResourcesContext : BaseContext<HumanResourcesContext>, IHumanResourcesContext
    {
        public DbSet<Teacher> Teachers { get; set; }
    }
}