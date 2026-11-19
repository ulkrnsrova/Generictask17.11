using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Repostory<T>where T: BaseEntity
    {
     public readonly new AppDbContext<T> _context;
        public Repostory()
        {
            _context = new AppDbContext<T>();
            
        }
       public void Add(T obj)
        {
            var res = _context.books.Append(obj);
        }
        public T[] GetAll()
        {
            return _context.books;
        }

        public T[] Delete(int id)
        {
            T[] newBooks = { };
            foreach (var item in _context.books)
            {
                if(item.Id==id)
                {
                    continue;
                }
                newBooks = newBooks.Append(item).ToArray();
            }
            return newBooks;
        }

        public T GetById(int id)
        {
            foreach (var item in _context.books)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }

        public T[] Search(Func<T,bool> func)
        {
            return _context.books.Where(func).ToArray();
        }
            
    }
}
