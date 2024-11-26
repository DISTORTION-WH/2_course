using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMVVM
{
    public class StudentContext : DbContext
    {
        public StudentContext()
            : base("DbConnection")
        { }

        public DbSet<Models.Student> Students { get; set; }
    }
}
