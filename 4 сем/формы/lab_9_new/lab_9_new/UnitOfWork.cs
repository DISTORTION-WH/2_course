using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_9_new
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LibContext _context;
        private IRepository<Book> _books;
        private IRepository<Author> _authors;
        private IRepository<Publisher> _publishers;

        public UnitOfWork(LibContext context)
        {
            _context = context;
        }

        public IRepository<Book> Books
        {
            get
            {
                if (_books == null)
                {
                    _books = new Repository<Book>(_context);
                }
                return _books;
            }
        }

        public IRepository<Author> Authors
        {
            get
            {
                if (_authors == null)
                {
                    _authors = new Repository<Author>(_context);
                }
                return _authors;
            }
        }

        public IRepository<Publisher> Publishers
        {
            get
            {
                if (_publishers == null)
                {
                    _publishers = new Repository<Publisher>(_context);
                }
                return _publishers;
            }
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
