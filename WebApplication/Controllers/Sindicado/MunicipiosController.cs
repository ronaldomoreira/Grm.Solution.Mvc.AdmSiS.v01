using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GrmWebAppAdmSiSv01.Models.Sindicato;
using System.Diagnostics;

namespace GrmWebAppAdmSiSv01.Controllers.Sindicado
{
    public class MunicipiosController : Controller
    {
        private GrmAdmSiSModelContext db = new GrmAdmSiSModelContext();

        // GET: Municipios
        public ActionResult Index()
        {
            var municipios = db.dbMunicipios.Include(m => m.MunicipioUf);
            return View(municipios.ToList());
        }

        // GET: Municipios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Municipio municipio = db.dbMunicipios.Find(id);
            if (municipio == null)
            {
                return HttpNotFound();
            }
            return View(municipio);
        }

        // GET: Municipios/Create
        public ActionResult Create()
        {
            ViewBag.IdUf = new SelectList(db.dbUfs, "IdUf", "CodigoIbge");
            return View();
        }

        // POST: Municipios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdMunicipio,IdUf,CodIbge,NomeMunicipio")] Municipio municipio)
        {
            if (ModelState.IsValid)
            {
                //db.Municipios.Add(municipio);
                //db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdUf = new SelectList(db.dbUfs, "IdUf", "CodigoIbge", municipio.IdUf);
            return View(municipio);
        }

        // GET: Municipios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Municipio municipio = db.dbMunicipios.Find(id);
            if (municipio == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdUf = new SelectList(db.dbUfs, "IdUf", "CodigoIbge", municipio.IdUf);
            return View(municipio);
        }

        // POST: Municipios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdMunicipio,IdUf,CodIbge,NomeMunicipio")] Municipio municipio)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(municipio).State = EntityState.Modified;
                //db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdUf = new SelectList(db.dbUfs, "IdUf", "CodigoIbge", municipio.IdUf);
            return View(municipio);
        }

        // GET: Municipios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Municipio municipio = db.dbMunicipios.Find(id);
            if (municipio == null)
            {
                return HttpNotFound();
            }
            return View(municipio);
        }

        // POST: Municipios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Municipio municipio = db.dbMunicipios.Find(id);
            //db.Municipios.Remove(municipio);
            //db.SaveChanges();
            return RedirectToAction("Index");
        }

        //-- Chamadas Json -------------------------------------------------------------------------------// 

        /// <summary>
        /// GetUfsJson
        /// </summary>
        /// <param name="idUf">todo: describe idUf parameter on GetMunicipiosJson</param>
        public ActionResult GetMunicipiosJson(int idUf = 0)
        {
            //var dbResult = new List<Municipio>();

            //if (idUf == 0)
            //{
            //    dbResult = db.dbMunicipios.ToList();
            //}
            //else
            //{
            //    dbResult = db.dbMunicipios.Where(p => p.IdUf == idUf).ToList();
            //}

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
            //return View(portfolio


            var dbResult =
                from cidade in db.dbMunicipios
                join e in db.dbUfs on cidade.IdUf equals e.IdUf into c_e
                from uf in c_e.DefaultIfEmpty()
                join p in db.dbPais on uf.IdPais equals p.IdPais into p_ce
                from pais in p_ce.DefaultIfEmpty()

                select new
                {
                    cidade.IdMunicipio,
                    cidade.IdUf,
                    cidade.CodIbge,
                    cidade.NomeMunicipio,
                    CodIbgeUf = uf.CodIbge,
                    uf.NomeUf,
                    SiglaUf = uf.Sigla,
                    SiglaPais =  pais.SiglaPais,
                    pais.NomePais

                };

            //        .FirstName, PetName = (subpet == null ? String.Empty : subpet.Name) };

            //foreach (var v in query)
            //{
            //    Debug.WriteLine("v.IdMunicipio: ", v.IdMunicipio, v.NomeMunicipio);
            //    Console.WriteLine("{0,-15}{1}", v.IdMunicipio + ":", v.NomeMunicipio);
            //}

            //query.ToList();

            var municipios = (from municipio in dbResult
                       select new
                       {
                           municipio.NomeMunicipio,
                           municipio.IdUf,
                           municipio.CodIbge,
                           municipio.MunicipioUf,
                           municipio.NomeMunicipio
                       });

            return Json(municipios, JsonRequestBehavior.AllowGet);
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
