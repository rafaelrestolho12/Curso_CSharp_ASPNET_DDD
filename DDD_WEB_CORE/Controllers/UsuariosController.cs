using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DDD_WEB_CORE.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly IAppUsuario _appUsuario;

        public UsuariosController(IAppUsuario appUsuario)
        {
            _appUsuario = appUsuario;
        }

        public ActionResult Index()
        {
            return View(_appUsuario.List());
        }

        public ActionResult Details(int id)
        {
            return View(_appUsuario.GetEntity(id));
        }

        public ActionResult Create()
        {
            return View(new Usuario());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Usuario usuario)
        {
            try
            {
                _appUsuario.Add(usuario);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            return View(_appUsuario.GetEntity(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Usuario usuario)
        {
            try
            {
                _appUsuario.Update(usuario);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            return View(_appUsuario.GetEntity(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Usuario usuario)
        {
            try
            {
                _appUsuario.Delete(usuario);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
