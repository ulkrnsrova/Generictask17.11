using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Repostory<T>
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
    }
}
