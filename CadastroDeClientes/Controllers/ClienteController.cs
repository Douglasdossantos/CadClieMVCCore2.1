using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroDeClientes.Models;
using CadastroDeClientes.Models.Contexto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CadastroDeClientes.Controllers
{
    public class ClienteController : Controller
    {
        private readonly Contexto _contexto;

        public ClienteController(Contexto contexto)
        {
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            var lista = _contexto.Clientes.Include(c => c.EndCliente).ToList();
            return View(lista);
        }

        #region ações referente ao  cadastro de usuarios
        [HttpGet]
        public IActionResult Cadastro()
        {
            var cliente = new Cliente();
            return View(cliente);
        }

        [HttpPost]
        public IActionResult Cadastro(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _contexto.Clientes.Add(cliente);
                _contexto.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cliente);
        }
        #endregion

        [HttpGet]
        public IActionResult Visualizar(int id)
        {
            var cliente = _contexto.Clientes
                .Include(c => c.EndCliente)
                .Where(c => c.Id == id).
                FirstOrDefault();
            return View(cliente);
        }

        #region ações referente ao  editar do cliente
        [HttpGet]
        public IActionResult Editar(int id)
        {
            var cliente = _contexto.Clientes
                .Include(c => c.EndCliente)
                .Where(c => c.Id == id).
                FirstOrDefault();
            return View(cliente);
        }

        [HttpPost]
        public IActionResult Editar(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _contexto.Clientes.Update(cliente);
                _contexto.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cliente);
        }
        #endregion

        #region ações referente para excluir o cliente
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var cliente = _contexto.Clientes
                .Include(c => c.EndCliente)
                .Where(c => c.Id == id).
                FirstOrDefault();
            return View(cliente);
        }

        [HttpPost]
        public IActionResult Delete(Cliente _cliente)
        {
            var cliente = _contexto.Clientes
                .Include(c => c.EndCliente)
                .Where(c => c.Id == _cliente.Id).
                FirstOrDefault();
            if (cliente != null)
            {
                _contexto.Clientes.Remove(cliente);
                _contexto.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cliente);
        }
        #endregion
    }
}