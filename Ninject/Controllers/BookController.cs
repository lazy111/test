using IOCForMvc.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace IOCForMvc.Controllers
{
    public class BookController : Controller
    {
        //
        // GET: /Book/

        private IBookRepository bookRepository;


        public BookController(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }
        public ActionResult Index()
        {

            ViewData.Model = bookRepository.Books;
            return View();
        }

    }
}
