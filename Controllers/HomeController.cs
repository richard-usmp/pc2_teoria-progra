using Microsoft.AspNetCore.Mvc;
using Liga_Pokemon.Models;
using System;
namespace Liga_Pokemon.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(){
            Console.WriteLine("Index");
            return View();
        }

        [HttpPost]
        public IActionResult Formulario(Entrenador e){
            if(ModelState.IsValid){
                //TO_DO:Guardar en BD
                Console.WriteLine(ModelState.IsValid+"Formulario22222222222222222222222222222222222222222");
                return RedirectToAction("Confirmacion");
            }else{
                Console.WriteLine("probandoooooooooo............."+e);
                return View(e);
            } 
        }

        public IActionResult Formulario(){
            Console.WriteLine("Formularioooooooooooooo");
            return View();
        }

        public IActionResult Confirmacion(){
            Console.WriteLine("confirmacion");
                return View();
        }
    }
}