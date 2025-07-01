using GestionComex.Data.Repository.Interfaces;
using GestionComex.Models;
using GestionComex.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestionComex.Controllers
{
    public class ClientesController : Controller
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IClienteService _clienteService;
        public ClientesController(IClienteRepository clienteRepository,
            IClienteService clienteService)
        {
            _clienteRepository = clienteRepository;
            _clienteService = clienteService;   
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var clientes = await _clienteRepository.GetAll();
            return View(clientes);
        }

        [HttpGet]        
        public ActionResult Create()
        {
            var cliente = new Clientes
            {
                Activo = true ,
                RazonSocial = string.Empty  

            };
            return View(cliente);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Clientes cliente)
        {
            if (!ModelState.IsValid)
            {
                return View(cliente);
            }

            try
            {
                await _clienteService.Add(cliente);
                return RedirectToAction(nameof(Index)); 
            }
            catch (InvalidOperationException ex)
            {
                ModelState.AddModelError(nameof(cliente.CUIT), ex.Message);
                return View(cliente);   
            }
        }



        [HttpGet]
        public async Task<IActionResult> ObtenerRazonSocial(string cuit)
        {
            try
            {
                var razon = await _clienteService.GetRazonSocialPorCUIT(cuit);
                return Json(razon);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // GET: ClientesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }


        // GET: ClientesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClientesController/Edit/5
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

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var cliente = await _clienteService.getById(id);

            if(cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cliente = await _clienteService.getById(id);

            if(cliente == null)
            {
                return NotFound();
            }

            await _clienteService.Delete(id);
            return RedirectToAction(nameof(Index));

        }
    }
}
