using DACN_CarCare.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DACN_CarCare.Controllers
{
    public class BookingController : Controller
    {
        // GET: Booking
        public ActionResult Index()
        {

            return View(Book.GetAll1());
        }
        public ActionResult Create()
        {
            ViewBag.ListLoai = Loai.GetAll();
            return View(new Book());
        }
        [HttpPost]
        [Authorize]
        public ActionResult Create(Book newbook)
        {
              string a = User.Identity.GetUserName();
              Booking context = new Booking();
              newbook.email = a;
              context.Books.Add(newbook);
              context.SaveChanges();
              return View("classify", Book.GetAll1());  
        }

        public ActionResult Edit(int? id)
        {
            ViewBag.ListLoai = Loai.GetAll();
            if (id == null)
            {
                return HttpNotFound();
            }
            Book find = Book.FindBookById(id.Value);
            if (find == null)
            {
                return HttpNotFound();
            }
            return View(find);
        }
        [HttpPost]
        public ActionResult Edit(Book bookEdit)
        {
            if (ModelState.IsValid)
            {
                bookEdit.Update();

                return View("classify", Book.GetAll1());
            }
            else return View("Edit", bookEdit);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Book find = Book.FindBookById(id.Value);
            if (find == null)
            {
                return HttpNotFound();
            }
            return View(find);
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {

            Book.Removee(id);
            return View("classify", Book.GetAll1());
        }
        public ActionResult classify()
        {
            Booking context = new Booking();
            string a = User.Identity.GetUserName();
            var book = new List<Book>();
            var c = context.Books.Where(p => p.email == a).ToList();
            book.AddRange(c);
            return View(book);
        }


    }
}