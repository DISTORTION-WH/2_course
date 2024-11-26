using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_9_new
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Book> Books { get; }
        IRepository<Author> Authors { get; }
        IRepository<Publisher> Publishers { get; }
        int Complete();
    }
}
