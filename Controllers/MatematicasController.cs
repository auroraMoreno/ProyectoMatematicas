using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoMatematicas.Controllers
{
    public class MatematicasController : Controller
    {
        public IActionResult SumarNumeros()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SumarNumeros(int numero1, int numero2)
        {
            int total = numero1 + numero2;
            ViewBag.Total = total;
            return View();
        }

        public IActionResult TablaMultiplicar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TablaMultiplicar(int numero)
        {
            List<int> numeros = new List<int>();
            ViewBag.Numero = numero;
            int resultado = 0;
            for (int i = 0; i <= 10; i++)
            {
                resultado = numero * i;
                numeros.Add(resultado);
            }
            //ViewBag.Numeros = numeros;
            return View(numeros);
        }

        public IActionResult ConjeturaCollazt()
        {
            List<Random> randoms = new List<Random>();
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}