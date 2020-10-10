using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ASPCore.Models;

namespace ASPCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var a = new Peliculas();

                a.ID_1 = "100";
                a.Fecha_subida1 = DateTime.Now;
                a.Nombre_pelicula1 = "El padrino";
                a.Director1 = "Francis Ford Coppola";
                a.Comentarios1 = "Muy buena pelicula, fantastica";
                a.Clasificacion1 = "B";
                a.Duracion1 = "2hr89m";

                a.ID_2 = "200";
                a.Fecha_subida2 = DateTime.Now;
                a.Nombre_pelicula2 = "Bajo fuego";
                a.Director2 = "Antoine Fuqua";
                a.Comentarios2 = "Excelente largometraje";
                a.Clasificacion2 = "B";
                a.Duracion2 = "1hr58m";

                a.ID_3 = "300";
                a.Fecha_subida3 = DateTime.Now;
                a.Nombre_pelicula3 = "Mision Imposible";
                a.Director3 = "Brian de Palma";
                a.Comentarios3 = "Buena pelicula, excelente";
                a.Clasificacion3 = "C";
                a.Duracion3 = "1hr40m";

            return View(a);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
