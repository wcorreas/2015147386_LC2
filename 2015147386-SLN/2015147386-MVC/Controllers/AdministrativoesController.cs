using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _2015147386_ENT.Entities;
using _2015147386_PER;

namespace _2015147386_MVC.Controllers
{
    public class AdministrativoesController : Controller
    {
        private TransporteDbContext db = new TransporteDbContext();

        // GET: Administrativoes
        public ActionResult Index()
        {
            return View(db.Empleadoes.ToList());
        }

        // GET: Administrativoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Administrativo administrativo = db.Empleadoes.Find(id);
            if (administrativo == null)
            {
                return HttpNotFound();
            }
            return View(administrativo);
        }

        // GET: Administrativoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Administrativoes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EmpleadoId,Classificaion")] Administrativo administrativo)
        {
            if (ModelState.IsValid)
            {
                db.Empleadoes.Add(administrativo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(administrativo);
        }

        // GET: Administrativoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Administrativo administrativo = db.Empleadoes.Find(id);
            if (administrativo == null)
            {
                return HttpNotFound();
            }
            return View(administrativo);
        }

        // POST: Administrativoes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EmpleadoId,Classificaion")] Administrativo administrativo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(administrativo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(administrativo);
        }

        // GET: Administrativoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Administrativo administrativo = db.Empleadoes.Find(id);
            if (administrativo == null)
            {
                return HttpNotFound();
            }
            return View(administrativo);
        }

        // POST: Administrativoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Administrativo administrativo = db.Empleadoes.Find(id);
            db.Empleadoes.Remove(administrativo);
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
