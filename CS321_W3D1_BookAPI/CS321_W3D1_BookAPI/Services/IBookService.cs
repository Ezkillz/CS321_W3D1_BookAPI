using CS321_W3D1_BookAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS321_W3D1_BookAPI.Services
{
    interface IBookService
    {
        IEnumerable<Book> GetAll();
        Book Get(int id);
        Book Add(Book book);
        Book Update(Book book);
        void Remove(Book book);
    }
}
