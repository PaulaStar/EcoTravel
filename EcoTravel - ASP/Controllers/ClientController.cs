using BLL.Entities;
using COMMON.Repositories;
using EcoTravel___ASP.Handlers;
using EcoTravel___ASP.Models.ClientModelView;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcoTravel___ASP.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientRepository<Client, int> _services;
        private readonly SessionManager _sessionManager;

        public ClientController(IClientRepository<Client, int> services, SessionManager sessionManager)
        {
            _services = services;
            _sessionManager = sessionManager;
        }

        // GET: ClientController
        public ActionResult Index()
        {
            IEnumerable<ClientListItem> model = _services.Get().Select(e => e.ToListItem());
            return View(model);
        }

        // GET: ClientController/Details/5
        public ActionResult Details(int id)
        {
            ClientDetails model = _services.Get(id).ToDetails();
            if (model is null)
            {
                TempData["Error"] = "Client inexistant...";
                return RedirectToAction("Index");
            }
            return View(model);
        }

        // GET: ClientController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClientCreateForm form)
        {
            if (!ModelState.IsValid)
            {
                form.password = null;
                form.confirmPass = null;
                return View(form);
            }
            else
            {
                int id = _services.Insert(form.ToBLL());
                return RedirectToAction("Details", "Client", new { id = id });
            }
        }

        // GET: ClientController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClientController/Edit/5
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

        // GET: ClientController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClientController/Delete/5
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
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginForm form)
        {
            if (!ModelState.IsValid) return View();
            int? id = _services.CheckPassword(form.email, form.password);
            if (id is null) return View();
            CurrentClient currentClient = new CurrentClient()
            {
                id_Client = (int)id,
                email = form.email,
                derniereConnection = DateTime.Now
            };
            _sessionManager.CurrentClient = currentClient;
            
        }
        public IActionResult Logout()
        {
            _sessionManager.CurrentClient = null;
            return RedirectToAction("Index", "Home");
        }
    }
}
