using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_9_new
{
    public class LibContext : DbContext
    {
        public LibContext() : base("DBConnection")
        {

        }
        public DbSet<Book> books { get; set; }
        public DbSet<Author> authors { get; set; }
        public DbSet<Publisher> publishers { get; set; }
    }
}
