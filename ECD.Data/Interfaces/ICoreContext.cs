using ECD.Core.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECD.Data.Interfaces
{
    public interface ICoreContext
    {
        DbSet<Teacher> Teachers { get; set; }
    }
}
