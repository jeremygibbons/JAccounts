using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using JAccounts.Models;

namespace JAccounts.Controllers
{
    public class AccountTypesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: AccountTypes
        public ActionResult Index()
        {
            return View(db.AccountTypes.ToList());
        }

        // GET: AccountTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AccountType accountType = db.AccountTypes.Find(id);
            if (accountType == null)
            {
                return HttpNotFound();
            }
            return View(accountType);
        }

        // GET: AccountTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AccountTypes/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name")] AccountType accountType)
        {
            if (ModelState.IsValid)
            {
                db.AccountTypes.Add(accountType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(accountType);
        }

        // GET: AccountTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AccountType accountType = db.AccountTypes.Find(id);
            if (accountType == null)
            {
                return HttpNotFound();
            }
            return View(accountType);
        }

        // POST: AccountTypes/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name")] AccountType accountType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(accountType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(accountType);
        }

        // GET: AccountTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AccountType accountType = db.AccountTypes.Find(id);
            if (accountType == null)
            {
                return HttpNotFound();
            }
            return View(accountType);
        }

        // POST: AccountTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AccountType accountType = db.AccountTypes.Find(id);
            db.AccountTypes.Remove(accountType);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
