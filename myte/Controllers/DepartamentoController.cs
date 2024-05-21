using Microsoft.AspNetCore.Mvc;
using Microsoft.Win32;
using myte.Models;
using System.Data;

namespace myte.Controllers
{
    public class DepartamentoController : Controller
    {
        public IActionResult Index() 
        {
            return View(Repositorio.TodosOsDepartamentos);
        }

        public IActionResult Create() 
        { 
            return View();
        }

        [HttpPost]
        public IActionResult Create(Departamento registroDepartamento)
        {
            if (ModelState.IsValid)
            {
                Repositorio.Inserir(registroDepartamento);
               return Redirect("Index");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Update(string Identificador)
        {
            Departamento consulta = Repositorio.TodosOsDepartamentos.Where((r) => r.Nome == Identificador).First();
            return View(consulta);
        }

        [HttpPost]
        public IActionResult Update(string Identificador, Departamento registroAlterado) 
        { 
            if (ModelState.IsValid)
            {
                var consulta = Repositorio.TodosOsDepartamentos.Where((r) => r.Nome == Identificador).First();

                consulta.Nome = registroAlterado.Nome;

                return Redirect("Index");

            }

            return View();

        }


        [HttpPost]
        public IActionResult Delete(string Identificador)
        {
            Departamento Consulta = Repositorio.TodosOsDepartamentos.Where((r) => r.Nome == Identificador).First();

            Repositorio.Excluir(Consulta);

            return RedirectToAction("Index");

        }

    }
}
