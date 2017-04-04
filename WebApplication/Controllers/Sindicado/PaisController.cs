using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GrmWebAppAdmSiSv01.Models.Sindicato;
using System.Collections;

namespace GrmWebAppAdmSiSv01.Controllers.Sindicado
{
    public class PaisController : Controller
    {
        private GrmAdmSiSModelContext db = new GrmAdmSiSModelContext();

        // GET: Pais
        public ActionResult Index()
        {
            return View(db.dbPais.ToList());
        }

        // GET: Pais/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pais pais = db.dbPais.Find(id);
            if (pais == null)
            {
                return HttpNotFound();
            }
            return View(pais);
        }

        // GET: Pais/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pais/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdPais,CodIbge,SiglaPais,NomePais")] Pais pais)
        {
            if (ModelState.IsValid)
            {
                //db.dbPais.Add(pais);
                //db.SaveChanges();
                ViewBag.acao = "C";
                ViewBag.ControllerMsg = "Indisponível";

                return RedirectToAction("Index");
            }

            return View(pais);
        }

        // GET: Pais/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pais pais = db.dbPais.Find(id);
            if (pais == null)
            {
                return HttpNotFound();
            }
            return View(pais);
        }

        // POST: Pais/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdPais,CodIbge,SiglaPais,NomePais")] Pais pais)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(pais).State = EntityState.Modified;
                //db.SaveChanges();
                ViewBag.acao = "E";
                ViewBag.ControllerMsg = "Indisponível";

                return RedirectToAction("Index");
            }
            return View(pais);
        }

        // GET: Pais/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pais pais = db.dbPais.Find(id);
            if (pais == null)
            {
                return HttpNotFound();
            }
            return View(pais);
        }

        // POST: Pais/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pais pais = db.dbPais.Find(id);
            //db.dbPais.Remove(pais);
            //db.SaveChanges();
            ViewBag.acao = "D";
            ViewBag.ControllerMsg = "Indisponível";

            return RedirectToAction("Index");
        }

        //-- Chamadas Json -------------------------------------------------------------------------------// 

        /// <summary>
        /// GetPaizes - Json
        /// </summary>
        public ActionResult GetPaizesJson()
        {
            var dbResult = db.dbPais.ToList();
            var paizes = (
                from pais in dbResult
                select new
                {
                    pais.IdPais,
                    pais.CodIbge,
                    pais.SiglaPais,
                    pais.NomePais
            });

            return Json(paizes, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="disposing"></param>
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
