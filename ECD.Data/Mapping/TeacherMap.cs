using ECD.Core.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECD.Data.Mapping
{
    public class TeacherMap:EntityTypeConfiguration<Teacher>
    {
        public TeacherMap()
        {
            Ignore(t => t.test);
        }
    }
}
