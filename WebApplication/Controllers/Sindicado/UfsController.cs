using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GrmWebAppAdmSiSv01.Models.Sindicato;

namespace GrmWebAppAdmSiSv01.Controllers.Sindicado
{
    public class UfsController : Controller
    {
        private GrmAdmSiSModelContext db = new GrmAdmSiSModelContext();

        // GET: Ufs
        public ActionResult Index()
        {
            return View(db.dbUfs.ToList());
        }

        // GET: Ufs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Uf uf = db.dbUfs.Find(id);
            if (uf == null)
            {
                return HttpNotFound();
            }
            return View(uf);
        }

        // GET: Ufs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ufs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdUf,IdPais,CodigoIbge,Sigla,NomeUf")] Uf uf)
        {
            if (ModelState.IsValid)
            {
                //db.dbUfs.Add(uf);
                //db.SaveChanges();
                ViewBag.acao = "C";
                ViewBag.ControllerMsg = "Indisponível";

                return RedirectToAction("Index");
            }

            return View(uf);
        }

        // GET: Ufs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Uf uf = db.dbUfs.Find(id);
            if (uf == null)
            {
                return HttpNotFound();
            }
            return View(uf);
        }

        // POST: Ufs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdUf,IdPais,CodigoIbge,Sigla,NomeUf")] Uf uf)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(uf).State = EntityState.Modified;
                //db.SaveChanges();
                ViewBag.acao = "E";
                ViewBag.ControllerMsg = "Indisponível";

                return RedirectToAction("Index");
            }
            return View(uf);
        }

        // GET: Ufs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Uf uf = db.dbUfs.Find(id);
            if (uf == null)
            {
                return HttpNotFound();
            }
            return View(uf);
        }

        // POST: Ufs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //Uf uf = db.dbUfs.Find(id);
            //db.dbUfs.Remove(uf);
            //db.SaveChanges();
            ViewBag.acao = "D";
            ViewBag.ControllerMsg = "Indisponível";
            return RedirectToAction("Index");
        }

        //-- Chamadas Json -------------------------------------------------------------------------------// 

        /// <summary>
        /// GetUfsJson
        /// </summary>
        /// <param name="idPais">todo: describe idPais parameter on GetUfsJson</param>
        public ActionResult GetUfsJson(int idPais = 0)
        {
            var dbResult = new List<Uf>();

            if (idPais == 0)
            {
                dbResult = db.dbUfs.ToList();
            }
            else
            {
                dbResult = db.dbUfs.Where(p => p.IdPais == idPais).ToList();
            }

            //var user = _db.Users
            //      .Where(u => u.UserName == userName)
            //      .Select(u => new User
            //      {
            //          Id = u.Id,
            //          UserName = u.UserName,
            //          FirstName = u.FirstName,
            //          LastName = u.LastName,
            //          Email = u.Email,
            //          Portfolio = u.Portfolio
            //      });
            ////find the users portfolio id
            //var portfolioId = user.Select(u => u.Portfolio.Id);

            ////find their portfolio
            //var portfolio = _db.Portfolios.Find(portfolioId);
            //if (portfolio == null)
            //{
            //    return HttpNotFound();
            //}//end of if
            //return View(portfolio);


            var ufs = (from uf in dbResult
                       select new
                       {
                           uf.IdUf,
                           uf.IdPais,
                           uf.CodIbge,
                           uf.NomeUf,
                           uf.Sigla
                       });

            return Json(ufs, JsonRequestBehavior.AllowGet);
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
