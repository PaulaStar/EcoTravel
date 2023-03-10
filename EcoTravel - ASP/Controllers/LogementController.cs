using BLL.Entities;
using COMMON.Repositories;
using EcoTravel___ASP.Handlers;
using EcoTravel___ASP.Models.LogementModelView;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcoTravel___ASP.Controllers
{
    public class LogementController : Controller
    {
        private readonly ILogementRepository<Logement, int> _services;
        private readonly SessionManager _sessionManager;

        public LogementController(ILogementRepository<Logement, int> services, SessionManager sessionManager)
        {
            _services = services;
            _sessionManager = sessionManager;
        }

        // GET: LogementController
        public ActionResult Index()
        {
            IEnumerable<LogementListItem> model = _services.Get().Select(e => e.ToListItem());
            return View(model);
        }

        // GET: LogementController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LogementController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LogementController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(LogementCreateForm form)
        {
            if (!ModelState.IsValid) return View(form);
            else
            {
                form.id_Proprietaire = 1; //remplacer par le user session
                int id = _services.Insert(form.ToBLL());
                return RedirectToAction("Details", new { id = id });

            }
        }

        // GET: LogementController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LogementController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LogementController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LogementController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
