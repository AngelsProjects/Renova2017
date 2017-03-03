using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Renova.Models;

namespace Renova.Controllers
{
    public class asistenciasController : Controller
    {
        private RenoContext db = new RenoContext();

        // GET: asistencias
        public ActionResult Index()
        {
            var asistencias = db.asistencias.Include(a => a.alumno);
            return View(asistencias.ToList());
        }

        // GET: asistencias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            asistencia asistencia = db.asistencias.Find(id);
            if (asistencia == null)
            {
                return HttpNotFound();
            }
            return View(asistencia);
        }

        // GET: asistencias/Create
        public ActionResult Create()
        {
            ViewBag.IDAlumno = new SelectList(db.alumnos, "IDAlumno", "nombre");
            return View();
        }

        // POST: asistencias/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDAsistencia,IDAlumno,A1,A2,A3,A4,A5,A6,A7,A8,A9,A10,estado")] asistencia asistencia)
        {
            if (ModelState.IsValid)
            {
                db.asistencias.Add(asistencia);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IDAlumno = new SelectList(db.alumnos, "IDAlumno", "nombre", asistencia.IDAlumno);
            return View(asistencia);
        }

        // GET: asistencias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            asistencia asistencia = db.asistencias.Find(id);
            if (asistencia == null)
            {
                return HttpNotFound();
            }
            ViewBag.IDAlumno = new SelectList(db.alumnos, "IDAlumno", "nombre", asistencia.IDAlumno);
            return View(asistencia);
        }

        // POST: asistencias/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDAsistencia,IDAlumno,A1,A2,A3,A4,A5,A6,A7,A8,A9,A10,estado")] asistencia asistencia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(asistencia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IDAlumno = new SelectList(db.alumnos, "IDAlumno", "nombre", asistencia.IDAlumno);
            return View(asistencia);
        }

        // GET: asistencias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            asistencia asistencia = db.asistencias.Find(id);
            if (asistencia == null)
            {
                return HttpNotFound();
            }
            return View(asistencia);
        }

        // POST: asistencias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            asistencia asistencia = db.asistencias.Find(id);
            db.asistencias.Remove(asistencia);
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
