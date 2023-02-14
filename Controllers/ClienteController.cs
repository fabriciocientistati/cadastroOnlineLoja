using CadastroPrimoMoveis.Date;
using CadastroPrimoMoveis.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CadastroPrimoMoveis.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ClienteController(ApplicationDbContext db)
        {
            _db = db;
          
        }
        public IActionResult Index()
        {
            IEnumerable<ClienteModel> Cliente = _db.Clientes;

            return View(Cliente);
        }

        public IActionResult Cadastrar() 
        { 
            return View(); 
        }

        public IActionResult Detalhes(int? id)
        {
            ClienteModel Cliente = _db.Clientes.FirstOrDefault(x => x.Id == id);

            return View(Cliente);
        }

        public IActionResult Excluir(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            ClienteModel Cliente = _db.Clientes.FirstOrDefault(x => x.Id == id);

            if (Cliente == null)
            {
                return NotFound();
            }


            return View(Cliente);

        }

        public IActionResult Editar(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }

            ClienteModel Cliente = _db.Clientes.FirstOrDefault(x => x.Id == id);

            if(Cliente == null)
            {
                return NotFound();
            }

            return View(Cliente);
        }

        [HttpPost]
        public IActionResult Cadastrar(ClienteModel Cliente) 
        {
            if (ModelState.IsValid)
            {
                _db.Clientes.Add(Cliente);
                _db.SaveChanges();
                TempData["MensagemSucesso"] = "Cadastro realizado com sucesso!";

                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Editar(ClienteModel Cliente)
        {
            if (ModelState.IsValid)
            {
                _db.Clientes.Update(Cliente);
                _db.SaveChanges();
                TempData["MensagemSucesso"] = "Edição realizada com sucesso!";

                return RedirectToAction("Index");
            }
            TempData["MensagemErro"] = "Ocorreu algum erro no momento da edição;";
                return View(Cliente);
        }

        [HttpPost]
        public IActionResult Excluir(ClienteModel cliente)
        {
            if (cliente == null)
            {
                return NotFound();
            }

            _db.Clientes.Remove(cliente);
            _db.SaveChanges();
            TempData["MensagemSucesso"] = "Remoção realizada com sucesso!";
            return RedirectToAction("Index");

        }
    }
}
