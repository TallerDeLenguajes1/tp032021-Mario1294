using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Entidades;

namespace WebApp.Controllers
{
    public class CadeteController : Controller
    {
        static int i = 0;
        
        private readonly ILogger<CadeteController> _logger;
        private readonly List<Cadete> cadetes;

        public CadeteController(ILogger<CadeteController> logger, List<Cadete> Cadetes)
        {
            _logger = logger;
            cadetes = Cadetes;
        }

        public IActionResult Index(string nombre, string telf, string direccion)
        {
            if (nombre != null)
            {
                Cadete MiCadete = new Cadete(nombre, i++, telf, direccion);
               
                cadetes.Add(MiCadete);

                return View(cadetes);
            }
            else
            {
                return View(cadetes);
            }
        }
            
        public IActionResult AltaCadete()
        {
            return View();
        }

    }
}
