using ECD.Core.Model;
using ECD.Data.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECD.Data
{
    public class ECDDatabase:DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new TeacherMap());
        }
        public DbSet<Teacher> Teachers { get; set; }
    }
}
