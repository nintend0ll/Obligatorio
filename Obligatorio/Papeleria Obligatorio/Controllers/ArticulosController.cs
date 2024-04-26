using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Papeleria.AccesoDatos.EF.Repositorios;
using Papeleria.LogicaAplicacion.Data_Transfer_Objects.Dtos.Articulos;
using Papeleria.LogicaAplicacion.ImplementacionCasosUso.Articulos;
using Papeleria.LogicaAplicacion.InterfacesCasosUso.Articulos;
using Papeleria.LogicaNegocio.InterfacesAccesoDatos;

namespace Papeleria_Obligatorio.Controllers
{
    public class ArticulosController : Controller
    {

        //repositorios 
        private IRepositorioArticulos _repositorioArticulos = new RepositorioArticulosEF(new PapeleriaContext());
        //casos de uso
        private IAltaArticulos _altaArticulos;
        private IGetAllArticulos _getAllArticulos;

        public ArticulosController() 
        {
            _altaArticulos = new AltaArticulos(_repositorioArticulos);
            _getAllArticulos = new GetAllArticulos(_repositorioArticulos);
        }


        // GET: ArticulosController
        public ActionResult Index()
        {
            return View(_getAllArticulos.Ejecutar());
        }

        // GET: ArticulosController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ArticulosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ArticulosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ArticulosDto art)
        {
            try
            {
                _altaArticulos.Ejecutar(art);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ArticulosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ArticulosController/Edit/5
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

        // GET: ArticulosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ArticulosController/Delete/5
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
