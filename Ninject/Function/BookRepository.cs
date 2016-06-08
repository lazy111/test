using IOCForMvc.Interface;
using IOCForMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IOCForMvc.Function
{
    public class BookRepository : IBookRepository
    {
        public IQueryable<Models.Book> Books
        {
            get
            {
                return new List<Book>()
                {
                    new Book(){ ID=1, BookName="ASP.NET WebAPI入门到精通", Author="TOM", PageCount=200},
                    new Book(){ ID=2, BookName="CLR via C#", Author="Jeffrey", PageCount=700},
                }.AsQueryable();

            }
        }
    }
}