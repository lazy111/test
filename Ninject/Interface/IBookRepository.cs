using IOCForMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCForMvc.Interface
{
    public interface IBookRepository
    {
        IQueryable<Book> Books { get; }
    }
}
